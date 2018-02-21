using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VideoGamesNeo
{
    public partial class AddPlatform : Form
    {
        public GraphClient client;
        public Platform P { get; set; }

        public AddPlatform()
        {
            InitializeComponent();
        }

        private void AddPlatform_Load(object sender, EventArgs e)
        {
            cbxType.SelectedIndex = 0;
            if (P != null)
            {
                txtName.Text = P.name;
                cbxType.Text = P.type;
            }
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            String qs;
            var query = (dynamic)null;
            if (P == null)
            {
                qs = "CREATE (n:Platform {name:'" + txtName.Text + "', type:'" + cbxType.Text.ToLower() + "'}) return n";
                query = new Neo4jClient.Cypher.CypherQuery(qs, queryDict, CypherResultMode.Set);
            }
            else
            {
                qs = "MATCH (n:Platform) WHERE n.name='" + P.name + "' SET n.name='" + txtName.Text + "',n.type='" + cbxType.Text.ToLower() + "' return n";
                query = new Neo4jClient.Cypher.CypherQuery(qs, queryDict, CypherResultMode.Set);
            }

            ((IRawGraphClient)client).ExecuteCypher(query);

            this.Close();
        }
    }
}