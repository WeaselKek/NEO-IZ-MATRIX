using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VideoGamesNeo
{
    public partial class FormCompany : Form
    {
        public GraphClient client;
        public Game G { get; set; }

        public FormCompany()
        {
            InitializeComponent();
        }

        private void FormCompany_Load(object sender, EventArgs e)
        {
            if (G != null)
            {
                rdbPub.Checked = true;
                panelEdit.Visible = false;
            }
            else
            {
                panelAdd.Visible = false;
            }
            LoadCompanies();
        }

        private void LoadCompanies()
        {
            var query = new Neo4jClient.Cypher.CypherQuery(" MATCH (n:Company) RETURN n order by LOWER(n.name)",
                                                          new Dictionary<string, object>(), CypherResultMode.Set);

            List<Company> companies = ((IRawGraphClient)client).ExecuteGetCypherResults<Company>(query).ToList();
            dgvCompany.DataSource = companies;
            dgvCompany.Columns["type"].Visible = false;
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            String tip = "PUBLISHED";
            if (rdbDev.Checked)
                tip = "DEVELOPED";

            Company c = dgvCompany.CurrentRow.DataBoundItem as Company;

            String qs = "MATCH (a:Game),(b:Company) WHERE a.name = '" + G.name + "' AND b.name = '" + c.name + "'" +
                                                               "CREATE (b)-[r:" + tip + "]->(a) RETURN r";

            var query = new Neo4jClient.Cypher.CypherQuery(qs, new Dictionary<string, object>(), CypherResultMode.Set);

            ((IRawGraphClient)client).ExecuteCypher(query);

            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddCompany agf = new AddCompany();
            agf.client = client;
            agf.C = dgvCompany.CurrentRow.DataBoundItem as Company;
            agf.ShowDialog();
            LoadCompanies();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Company g = dgvCompany.CurrentRow.DataBoundItem as Company;
            String qs = "MATCH (b:Company) WHERE b.name = '" + g.name +"' detach delete b";
            var query = new Neo4jClient.Cypher.CypherQuery(qs, new Dictionary<string, object>(), CypherResultMode.Set);

            ((IRawGraphClient)client).ExecuteCypher(query);

            LoadCompanies();
        }
    }
}