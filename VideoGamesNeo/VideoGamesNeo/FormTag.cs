using Neo4jClient;
using Neo4jClient.Cypher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VideoGamesNeo
{
    public partial class FormTag : Form
    {
        public GraphClient client;
        public Game G { get; set; }

        public FormTag()
        {
            InitializeComponent();
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            Tag c = dgvTag.CurrentRow.DataBoundItem as Tag;

            String qs = "MATCH (a:Game),(b:Tag) WHERE a.name = '" + G.name + "' AND b.name = '" + c.name + "'" +
                                                               "CREATE (b)-[r:DESCRIBES]->(a) RETURN r";

            var query = new Neo4jClient.Cypher.CypherQuery(qs, new Dictionary<string, object>(), CypherResultMode.Set);

            ((IRawGraphClient)client).ExecuteCypher(query);

            this.Close();
        }

        private void FormTag_Load(object sender, EventArgs e)
        {
            if (G != null)
            {
                
                panelEdit.Visible = false;
            }
            else
            {
                btnTrue.Visible = false;
            }
            LoadTags();
        }

        private void LoadTags()
        {
            var query = new Neo4jClient.Cypher.CypherQuery(" MATCH (n:Tag) RETURN n order by LOWER(n.name)",
                                                           new Dictionary<string, object>(), CypherResultMode.Set);

            List<Tag> tags = ((IRawGraphClient)client).ExecuteGetCypherResults<Tag>(query).ToList();
            dgvTag.DataSource = tags;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddTag agf = new AddTag();
            agf.client = client;
            agf.T = dgvTag.CurrentRow.DataBoundItem as Tag;
            agf.ShowDialog();
            LoadTags();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Tag g = dgvTag.CurrentRow.DataBoundItem as Tag;
            String qs = "MATCH (b:Tag) WHERE b.name = '" + g.name + "' detach delete b";
            var query = new Neo4jClient.Cypher.CypherQuery(qs, new Dictionary<string, object>(), CypherResultMode.Set);

            ((IRawGraphClient)client).ExecuteCypher(query);

            LoadTags();
        }
    }
}