using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VideoGamesNeo
{
    public partial class FormPlatform : Form
    {
        public GraphClient client;
        public Game G { get; set; }

        public FormPlatform()
        {
            InitializeComponent();
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            Platform c = dgvPlatform.CurrentRow.DataBoundItem as Platform;

            String qs = "MATCH (a:Game),(b:Platform) WHERE a.name = '" + G.name + "' AND b.name = '" + c.name + "'" +
                                                               "CREATE (b)-[r:SUPPORTS]->(a) RETURN r";

            var query = new Neo4jClient.Cypher.CypherQuery(qs, new Dictionary<string, object>(), CypherResultMode.Set);

            ((IRawGraphClient)client).ExecuteCypher(query);

            this.Close();
        }

        private void FormPlatform_Load(object sender, EventArgs e)
        {
            if (G != null)
            {
                
                panelEdit.Visible = false;
            }
            else
            {
                btnTrue.Visible = false;
            }
            LoadPlatforms();
        }

        private void LoadPlatforms()
        {
            var query = new Neo4jClient.Cypher.CypherQuery(" MATCH (n:Platform) RETURN n order by LOWER(n.name)",
                                                            new Dictionary<string, object>(), CypherResultMode.Set);

            List<Platform> plats = ((IRawGraphClient)client).ExecuteGetCypherResults<Platform>(query).ToList();
            dgvPlatform.DataSource = plats;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddPlatform agf = new AddPlatform();
            agf.client = client;
            agf.P = dgvPlatform.CurrentRow.DataBoundItem as Platform;
            agf.ShowDialog();
            LoadPlatforms();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Platform g = dgvPlatform.CurrentRow.DataBoundItem as Platform;
            String qs = "MATCH (b:Platform) WHERE b.name = '" + g.name + "' detach delete b";
            var query = new Neo4jClient.Cypher.CypherQuery(qs, new Dictionary<string, object>(), CypherResultMode.Set);

            ((IRawGraphClient)client).ExecuteCypher(query);

            LoadPlatforms();
        }
    }
}