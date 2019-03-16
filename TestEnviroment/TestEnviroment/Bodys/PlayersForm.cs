using System;
using PUBGApi;
using PUBGApi.Enumrations;
using PUBGApi.Tempates;
using System.Windows.Forms;

namespace TestEnviroment.Bodys
{
    public partial class PlayersForm : UserControl
    {
        public Players players;
        Action<string> md;
        Action<string> mt;
        public PlayersForm(Players pr,string message,Action<string> ma, Action<string> mb)
        {
            players = pr;
            md = ma;
            mt = mb;
            InitializeComponent();
            lbMessage.Text = message;
            InitializePlayers();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void InitializePlayers()
        {
            foreach(Players.Player x in players.data)
            {
                playerList.Items.Add(x.attributes.name);
            }
        }

        private void playerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Players.Player x in players.data)
            {
                if (x.attributes.name == playerList.SelectedItem.ToString())
                {
                    gbPlayer.Text = "Selected player - " + x.attributes.name;
                    lbName.Text = x.attributes.name;
                    lbID.Text = x.id;
                    listboxMatches.Items.Clear();
                    foreach (Players.SimpleMatch y  in x.relationships.matches.data)
                    {
                        listboxMatches.Items.Add(y.id);
                    }
                }
            }
            gbPlayer.Enabled = true;
        }

        private void btnCopyName_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbName.Text);
        }

        private void btnCopyAccountID_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbID.Text);
        }

        private void btnCopyMatchID_Click(object sender, EventArgs e)
        {
            if(listboxMatches.SelectedIndex >= 0)
            {
                Clipboard.SetText(listboxMatches.SelectedItem.ToString());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listboxMatches.SelectedIndex >= 0)
            {
                md(listboxMatches.SelectedItem.ToString());
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listboxMatches.SelectedIndex >= 0)
            {
                mt(listboxMatches.SelectedItem.ToString());
            }
        }
    }
}
