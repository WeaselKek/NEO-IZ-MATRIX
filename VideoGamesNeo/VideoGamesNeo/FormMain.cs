using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VideoGamesNeo
{
    public partial class FormMain : Form
    {
        private GraphClient client;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "neoneo");
            client = new GraphClient(new Uri("http://217.16.142.190:7474/db/data"), "neo4j", "neoneo");
            try
            {
                client.Connect();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            LoadGames();
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            var query = new Neo4jClient.Cypher.CypherQuery(" MATCH (n:Tag) RETURN n order by LOWER(n.name)",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            List<Tag> tags = ((IRawGraphClient)client).ExecuteGetCypherResults<Tag>(query).ToList();
            foreach (Tag t in tags)
            {
                cbxTags.Items.Add(t.name);
            }
            cbxTags.SelectedIndex = 0;

            query = new Neo4jClient.Cypher.CypherQuery(" MATCH (n:Platform) RETURN n order by LOWER(n.name)",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            List<Platform> plats = ((IRawGraphClient)client).ExecuteGetCypherResults<Platform>(query).ToList();
            foreach (Platform t in plats)
            {
                cbxPlatforms.Items.Add(t.name);
            }
            cbxPlatforms.SelectedIndex = 0;

            query = new Neo4jClient.Cypher.CypherQuery(" MATCH (n:Company) RETURN n order by LOWER(n.name)",
                                                          new Dictionary<string, object>(), CypherResultMode.Set);

            List<Company> companies = ((IRawGraphClient)client).ExecuteGetCypherResults<Company>(query).ToList();
            foreach (Company t in companies)
            {
                cbxCompanies.Items.Add(t.name);
            }
            cbxCompanies.SelectedIndex = 0;
            cbxRate.SelectedIndex = 4;
        }

        private void LoadGames()
        {
            var query = new Neo4jClient.Cypher.CypherQuery(" MATCH (n:Game) RETURN n order by LOWER(n.name)",
                                                           new Dictionary<string, object>(), CypherResultMode.Set);
            List<Game> games = ((IRawGraphClient)client).ExecuteGetCypherResults<Game>(query).ToList();
            dgv1.DataSource = games;
            dgv1.Columns["rat"].Visible = false;
            dgv1.Columns["name"].HeaderText = "Name";
            dgv1.Columns["reldate"].HeaderText = "Release Date"; ;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            GameInfo agf = new GameInfo();
            Game gm = dgv1.CurrentRow.DataBoundItem as Game;
            agf.client = client;
            agf.G = gm;
            agf.ShowDialog();
            LoadGames();
        }

        private void tsmAddGame_Click(object sender, EventArgs e)
        {
            AddGame agf = new AddGame();
            agf.client = client;
            agf.ShowDialog();
            LoadGames();
        }

        private void tsmAddCompany_Click(object sender, EventArgs e)
        {
            AddCompany agf = new AddCompany();
            agf.client = client;
            agf.ShowDialog();
        }

        private void tsmEditCompany_Click(object sender, EventArgs e)
        {
            FormCompany agf = new FormCompany();
            agf.client = client;
            agf.ShowDialog();
        }

        private void btnDelGame_Click(object sender, EventArgs e)
        {
            Game gm = dgv1.CurrentRow.DataBoundItem as Game;

            String qs = "MATCH (b:Game) WHERE b.name = '" + gm.name + "' detach delete b";
            var query = new Neo4jClient.Cypher.CypherQuery(qs, new Dictionary<string, object>(), CypherResultMode.Set);

            ((IRawGraphClient)client).ExecuteCypher(query);

            LoadGames();
        }

        private void tsmAddPlatform_Click(object sender, EventArgs e)
        {
            AddPlatform agf = new AddPlatform();
            agf.client = client;
            agf.ShowDialog();
        }

        private void tsmEditPlatform_Click(object sender, EventArgs e)
        {
            FormPlatform agf = new FormPlatform();
            agf.client = client;
            agf.ShowDialog();
        }

        private void tsmAddTag_Click(object sender, EventArgs e)
        {
            AddTag agf = new AddTag();
            agf.client = client;
            agf.ShowDialog();
        }

        private void tsmEditTag_Click(object sender, EventArgs e)
        {
            FormTag agf = new FormTag();
            agf.client = client;
            agf.ShowDialog();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            String tag, plat, comp;
            if (cbxTags.Text == "None")
                tag = ".*";
            else
                tag = cbxTags.Text;

            if (cbxPlatforms.Text == "None")
                plat = ".*";
            else
                plat = cbxPlatforms.Text;

            if (cbxCompanies.Text == "None")
                comp = ".*";
            else
                comp = cbxCompanies.Text;

            //ime
            String qs = "MATCH (n:Game)-[]-(t:Tag),(n)-[]-(p:Platform),(n)-[]-(c:Company),(n)-[]-(r:Rating)" +
                                " WHERE tolower(n.name)=~'.*" + txtSearch.Text + ".*' " +
                                "and t.name=~'" + tag + "' and p.name=~'" + plat + "' and c.name=~'" + comp + "' and r.value>=" + cbxRate.Text +
                                " RETURN DISTINCT n order by tolower(n.name)";
            var query = new Neo4jClient.Cypher.CypherQuery(qs, new Dictionary<string, object>(), CypherResultMode.Set);
            List<Game> games = ((IRawGraphClient)client).ExecuteGetCypherResults<Game>(query).ToList();

            dgv1.DataSource = games;
            dgv1.Columns["rat"].Visible = false;
            dgv1.Columns["name"].HeaderText = "Name";
            dgv1.Columns["reldate"].HeaderText = "Release Date"; ;
        }
    }
}