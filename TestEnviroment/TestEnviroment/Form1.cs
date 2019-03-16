using System;
using System.Diagnostics;
using PUBGApi;
using System.Text.RegularExpressions;
using PUBGApi.Tempates;
using TestEnviroment.Bodys;
using System.Windows.Forms;
using Newtonsoft.Json;
using PUBGApi.Enumrations;

namespace TestEnviroment
{
    public partial class Form1 : Form
    {
        Connector cn = new Connector("eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJqdGkiOiI4NGFjNDgwMC1kZDU4LTAxMzYtOTRmZi0xZDg1OGQxMzk3ZGMiLCJpc3MiOiJnYW1lbG9ja2VyIiwiaWF0IjoxNTQ0MzAyMDk5LCJwdWIiOiJibHVlaG9sZSIsInRpdGxlIjoicHViZyIsImFwcCI6InB1Z2ItbmV0In0.xIdyJslEYHq_WLL_TjrjfQJ177GcDD9BoPM9SoNntcw",Shards.steam, Regions.eu);
        TreeView sharedTree;
        public Form1()
        {
            InitializeComponent();
            //cn.UpdateProgress += updateProgress;
        }
        public void getMatchDetails(string matchID)
        {
            result2.Controls.Clear();
            sharedTree = null;
            PUBGApi.Tempates.Match ma = cn.GetMatchDetailsById(matchID);

            TreeView tv = new TreeView();
            TreeNode rosters = new TreeNode();
            rosters.Text = "Rosters";
            TreeNode participants = new TreeNode();
            participants.Text = "Participants";
            foreach (PUBGApi.Tempates.Match.Data x in ma.included)
            {
                TreeNode temp = new TreeNode();
                temp.Text = x.id;
                if(x.type == "roster")
                {
                    dynamic obj = JsonConvert.DeserializeObject<dynamic>(JsonConvert.SerializeObject(x.attributes.stats));
                    if (obj != null)
                    {
                        foreach (dynamic te in obj)
                        {
                            TreeNode temp2 = new TreeNode();
                            temp2.Text = Convert.ToString(te);
                            temp.Nodes.Add(temp2);
                        }
                    }
                    rosters.Nodes.Add(temp);
                }
                else
                {
                    dynamic obj = JsonConvert.DeserializeObject<dynamic>(JsonConvert.SerializeObject(x.attributes.stats));
                    if (obj != null)
                    {
                        foreach (dynamic te in obj)
                        {
                            TreeNode temp2 = new TreeNode();
                            temp2.Text = Convert.ToString(te);
                            temp.Nodes.Add(temp2);
                        }
                    }
                    participants.Nodes.Add(temp);
                }

            }
            tv.Nodes.Add(participants);
            tv.Nodes.Add(rosters);
            tv.Size = result2.Size;
            tv.AfterSelect += onNodeMouseClick;
            tv.ContextMenuStrip = contextMenuStrip1;
            result2.Controls.Add(tv);
            sharedTree = tv;
        }
        public void handleTelemetry(string matchID)
        {
            result2.Controls.Clear();
        }
        public void onNodeMouseClick(object sender, TreeViewEventArgs e)
        {
            Debug.WriteLine(e.Node.Text);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            backgroundWorker1.RunWorkerAsync();
            
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            int x = this.Width;
            int y = this.Height;
            result1.Size = new System.Drawing.Size(((x - 190) / 2), y);
            result2.Size = new System.Drawing.Size(((x - 190) / 2) - 25, y);
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchPlayer("fcbergi");
        }
        public void searchPlayer(string name)
        {
            string[] names = { name };
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Players pr = cn.GetPlayersByName(names);
            sw.Stop();
            PlayersForm fr = new PlayersForm(pr, string.Format("It took {0}ms to make the search", sw.ElapsedMilliseconds), getMatchDetails, handleTelemetry);
            result1.Controls.Add(fr);
        }
        public void searchPlayerID(string id)
        {
            string[] names = { id };
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Players pr = cn.GetPlayerByAccountID(names);
            sw.Stop();
            PlayersForm fr = new PlayersForm(pr, string.Format("It took {0}ms to make the search", sw.ElapsedMilliseconds), getMatchDetails, handleTelemetry);
            result1.Controls.Add(fr);

        }
        private void searchPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(sharedTree != null && sharedTree.SelectedNode != null)
            {
                string b = sharedTree.SelectedNode.Text;
                if(b.Contains("playerId"))
                {
                    Regex regex = new Regex(@"(account.+[^\\""])");
                    System.Text.RegularExpressions.Match match = regex.Match(b);
                    if (match.Success)
                    {
                        string account = match.Value;
                        result1.Controls.Clear();
                        searchPlayerID(account);
                    }
                }
                else
                {
                    MessageBox.Show(this,"Select a valid player to search for", "No valid players selected",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
           
        }
    }
}
