using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VideoGamesNeo
{
    public partial class AddCompany : Form
    {
        public GraphClient client;
        public Company C { get; set; }

        public AddCompany()
        {
            InitializeComponent();
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            String qs;
            var query = (dynamic)null;
            if (C == null)
            {
                qs = "CREATE (n:Company {name:'" + txtName.Text + "'}) return n";
                query = new Neo4jClient.Cypher.CypherQuery(qs, queryDict, CypherResultMode.Set);
            }
            else
            {
                qs = "MATCH (n:Company) WHERE n.name='" + C.name + "' SET n.name='" + txtName.Text + "' return n";
                query = new Neo4jClient.Cypher.CypherQuery(qs, queryDict, CypherResultMode.Set);
            }

            ((IRawGraphClient)client).ExecuteCypher(query);

            this.Close();
        }

        private void AddCompany_Load(object sender, EventArgs e)
        {
            if (C != null)
            {
                txtName.Text = C.name;
            }
        }
    }
}