using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VideoGamesNeo
{
    public partial class AddTag : Form
    {
        public GraphClient client;
        public Tag T { get; set; }

        public AddTag()
        {
            InitializeComponent();
        }

        private void AddTag_Load(object sender, EventArgs e)
        {
            if (T != null)
            {
                txtName.Text = T.name;
            }
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> queryDict = new Dictionary<string, object>();
            String qs;
            var query = (dynamic)null;
            if (T == null)
            {
                qs = "CREATE (n:Tag {name:'" + txtName.Text + "'}) return n";
                query = new Neo4jClient.Cypher.CypherQuery(qs, queryDict, CypherResultMode.Set);
            }
            else
            {
                qs = "MATCH (n:Tag) WHERE n.name='" + T.name + "' SET n.name='" + txtName.Text + "' return n";
                query = new Neo4jClient.Cypher.CypherQuery(qs, queryDict, CypherResultMode.Set);
            }

            ((IRawGraphClient)client).ExecuteCypher(query);

            this.Close();
        }
    }
}