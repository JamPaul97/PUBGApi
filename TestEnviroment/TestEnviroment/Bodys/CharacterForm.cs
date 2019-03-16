using System;
using PUBGApi.Tempates;
using System.Windows.Forms;

namespace TestEnviroment.Bodys
{
    public partial class CharacterForm : UserControl
    {
        public CharacterForm(TelemetryBases.Character character)
        {
            InitializeComponent();
            InitializeForm(character);
        }
        private void InitializeForm(TelemetryBases.Character character)
        {
            lblHealth.Text = character.health.ToString();
            lblIsInBlueZone.Text = character.isInBlueZone.ToString();
            lblisInRedZone.Text = character.isInRedZone.ToString();
            lblLocationX.Text = character.location.x.ToString();
            lblLocationY.Text = character.location.y.ToString();
            lblLocationZ.Text = character.location.z.ToString();
            lblName.Text = character.name;
            lblRanking.Text = character.ranking.ToString();
            lblTeamID.Text = character.teamId.ToString();
        }
        private void CharacterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
