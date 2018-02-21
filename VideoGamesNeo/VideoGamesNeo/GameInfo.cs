using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace VideoGamesNeo
{
    public partial class GameInfo : Form
    {
        public GraphClient client;
        public Game G { get; set; }

        public GameInfo()
        {
            InitializeComponent();
        }

        private void GameInfo_Load(object sender, EventArgs e)
        {
            txtName.Text = G.name;
            DateTime dt = DateTime.ParseExact(G.reldate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            dtp1.Value = dt;

            LoadCompanies();
            LoadTags();
            LoadPlatforms();
            LoadRating();
        }

        private void LoadPlatforms()
        {
            String qs = "MATCH (g:Game)-[:SUPPORTS]-(x:Platform) WHERE g.name='" + G.name + "' return x";
            var query = new Neo4jClient.Cypher.CypherQuery(qs, new Dictionary<string, object>(), CypherResultMode.Set);

            List<Platform> platforms = ((IRawGraphClient)client).ExecuteGetCypherResults<Platform>(query).ToList();
            dgvPlatform.DataSource = platforms;
        }

        private void LoadTags()
        {
            String qs = "MATCH (g:Game)-[:DESCRIBES]-(x:Tag) WHERE g.name='" + G.name + "' return x";
            var query = new Neo4jClient.Cypher.CypherQuery(qs, new Dictionary<string, object>(), CypherResultMode.Set);

            List<Tag> tags = ((IRawGraphClient)client).ExecuteGetCypherResults<Tag>(query).ToList();
            dgvTag.DataSource = tags;
        }

        private void LoadRating()
        {
            String qs = "MATCH (g:Game)-[v:ISRATED]-(x:Rating) WHERE g.name='" + G.name + "' return x";
            var query = new Neo4jClient.Cypher.CypherQuery(qs, new Dictionary<string, object>(), CypherResultMode.Set);
            try
            {
                Rating rt = ((IRawGraphClient)client).ExecuteGetCypherResults<Rating>(query).Single();
                cbxRate.SelectedItem = rt.value;
                lblrat.Text = rt.value + " (" + rt.desc + ")";

                qs = "MATCH (g:Game)-[v:ISRATED]-(x:Rating) WHERE g.name='" + G.name + "' return v";
                query = new Neo4jClient.Cypher.CypherQuery(qs, new Dictionary<string, object>(), CypherResultMode.Set);
                IsRated ir = ((IRawGraphClient)client).ExecuteGetCypherResults<IsRated>(query).Single();
                rtbDesc.Text = ir.comment;
            }
            catch (Exception ex)
            {
                lblrat.Text = "Not Rated";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String d = dtp1.Value.ToString("dd'/'MM'/'yyyy");

            //name and date
            String qs = "MATCH (g:Game) WHERE g.name='" + G.name + "' SET g.name='" + txtName.Text + "',g.reldate='" + d + "' return g";
            var query = new Neo4jClient.Cypher.CypherQuery(qs, new Dictionary<string, object>(), CypherResultMode.Set);
            ((IRawGraphClient)client).ExecuteCypher(query);

            //rating
            qs = "MATCH (g:Game)-[:ISRATED]-(c:Rating) WHERE g.name='" + G.name + "' return count(*)";
            query = new Neo4jClient.Cypher.CypherQuery(qs, new Dictionary<string, object>(), CypherResultMode.Set);
            Int32 p = ((IRawGraphClient)client).ExecuteGetCypherResults<Int32>(query).Single();

            if (p == 0)
            {
                qs = "MATCH (a:Game),(b:Rating) WHERE a.name = '" + G.name + "' AND b.value = " + cbxRate.Text +
                                                               " CREATE (a)-[r:ISRATED{comment:'" + rtbDesc.Text + "'}]->(b) RETURN r";
                query = new Neo4jClient.Cypher.CypherQuery(qs, new Dictionary<string, object>(), CypherResultMode.Set);
                ((IRawGraphClient)client).ExecuteCypher(query);
            }
            else
            {
                qs = "MATCH (g:Game)-[v:ISRATED]-(c:Rating) WHERE g.name='" + G.name + "' delete v";
                query = new Neo4jClient.Cypher.CypherQuery(qs, new Dictionary<string, object>(), CypherResultMode.Set);
                ((IRawGraphClient)client).ExecuteCypher(query);

                qs = "MATCH (a:Game),(b:Rating) WHERE a.name = '" + G.name + "' AND b.value = " + cbxRate.Text +
                                                              " CREATE (a)-[r:ISRATED{comment:'" + rtbDesc.Text + "'}]->(b) RETURN r";
                query = new Neo4jClient.Cypher.CypherQuery(qs, new Dictionary<string, object>(), CypherResultMode.Set);
                ((IRawGraphClient)client).ExecuteCypher(query);
            }
            LoadRating();
            MessageBox.Show("Succesfuly updated");
        }

        private void LoadCompanies()
        {
            String qs = "MATCH (g:Game)<-[:DEVELOPED]-(x:Company) WHERE g.name='" + G.name + "' return x";
            var query = new Neo4jClient.Cypher.CypherQuery(qs, new Dictionary<string, object>(), CypherResultMode.Set);

            List<Company> developers = ((IRawGraphClient)client).ExecuteGetCypherResults<Company>(query).ToList();
            foreach (Company k in developers)
            {
                k.type = "Developer";
            }

            qs = "MATCH (g:Game)<-[:PUBLISHED]-(x:Company) WHERE g.name='" + G.name + "' return x";
            query = new Neo4jClient.Cypher.CypherQuery(qs, new Dictionary<string, object>(), CypherResultMode.Set);

            List<Company> publishers = ((IRawGraphClient)client).ExecuteGetCypherResults<Company>(query).ToList();
            foreach (Company k in publishers)
            {
                k.type = "Publisher";
            }

            developers.AddRange(publishers);

            dgvCompany.DataSource = developers;
            dgvCompany.Columns["name"].HeaderText = "Name";
            dgvCompany.Columns["type"].HeaderText = "Type";
        }

        private void btnAddComp_Click(object sender, EventArgs e)
        {
            FormCompany agf = new FormCompany();
            agf.client = client;
            agf.G = G;
            agf.ShowDialog();
            LoadCompanies();
        }

        private void btnRemoveComp_Click(object sender, EventArgs e)
        {
            Company c = dgvCompany.CurrentRow.DataBoundItem as Company;

            String tip = "PUBLISHED";
            if (c.type == "Developer")
                tip = "DEVELOPED";

            String qs = "MATCH (a:Game),(b:Company),(b)-[r:" + tip + "]->(a) WHERE a.name = '" + G.name + "' AND b.name = '" + c.name + "'" +
                                                               "DELETE r";

            var query = new Neo4jClient.Cypher.CypherQuery(qs, new Dictionary<string, object>(), CypherResultMode.Set);

            ((IRawGraphClient)client).ExecuteCypher(query);
            LoadCompanies();
        }

        private void btnAddTag_Click(object sender, EventArgs e)
        {
            FormTag agf = new FormTag();
            agf.client = client;
            agf.G = G;
            agf.ShowDialog();
            LoadTags();
        }

        private void btnRemoveTag_Click(object sender, EventArgs e)
        {
            Tag c = dgvTag.CurrentRow.DataBoundItem as Tag;

            String qs = "MATCH (a:Game),(b:Tag),(b)-[r:DESCRIBES]->(a) WHERE a.name = '" + G.name + "' AND b.name = '" + c.name + "'" +
                                                               "DELETE r";

            var query = new Neo4jClient.Cypher.CypherQuery(qs, new Dictionary<string, object>(), CypherResultMode.Set);

            ((IRawGraphClient)client).ExecuteCypher(query);
            LoadTags();
        }

        private void btnAddPlat_Click(object sender, EventArgs e)
        {
            FormPlatform agf = new FormPlatform();
            agf.client = client;
            agf.G = G;
            agf.ShowDialog();
            LoadPlatforms();
        }

        private void btnRemovePlatform_Click(object sender, EventArgs e)
        {
            Platform c = dgvPlatform.CurrentRow.DataBoundItem as Platform;

            String qs = "MATCH (a:Game),(b:Platform),(b)-[r:SUPPORTS]->(a) WHERE a.name = '" + G.name + "' AND b.name = '" + c.name + "'" +
                                                               "DELETE r";

            var query = new Neo4jClient.Cypher.CypherQuery(qs, new Dictionary<string, object>(), CypherResultMode.Set);

            ((IRawGraphClient)client).ExecuteCypher(query);
            LoadPlatforms();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}