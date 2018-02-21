using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VideoGamesNeo
{
    public partial class AddGame : Form
    {
        public GraphClient client;

        public AddGame()
        {
            InitializeComponent();
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            String dt = dtpRel.Value.ToString("dd'/'MM'/'yyyy");
            Dictionary<string, object> queryDict = new Dictionary<string, object>();

            String qs = "CREATE (n:Game {name:'" + txtName.Text + "', reldate:'" + dt + "'}) return n";
            var query = new Neo4jClient.Cypher.CypherQuery(qs, queryDict, CypherResultMode.Set);

            ((IRawGraphClient)client).ExecuteCypher(query);

            this.Close();
        }
    }
}