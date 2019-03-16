using PUBGApi.Tempates;
using System.Windows.Forms;

namespace TestEnviroment.Bodys
{
    public partial class TelemetryForm : UserControl
    {
        Telemetry telemetryObject;
        public TelemetryForm(Telemetry telemetry)
        {
            InitializeComponent();
            telemetryObject = telemetry;
            InitializeForm(telemetry);
        }
        void InitializeForm(Telemetry tel)
        {
            ///Start
            lblMap.Text = tel.Start.mapName;
            lblWeather.Text = tel.Start.weatherId;
            foreach(TelemetryBases.Character x in tel.Start.characters)
            {
                startCharactersListBox.Items.Add(x.name);
            }
            lblCameraView.Text = tel.Start.cameraViewBehaviour;
            lblTeamSize.Text = tel.Start.teamSize.ToString();
            lblIsCustomGame.Text = tel.Start.isCustomGame.ToString();
            lblisEventMode.Text = tel.Start.isEventMode.ToString();
            lblBlueZoneCustomOptions.Text = tel.Start.blueZoneCustomOptions;
            ///Match Definition
            lblMatchID.Text = tel.Definition.MatchId;
            lblPingQuality.Text = tel.Definition.PingQuality;
            lblSeasonState.Text = tel.Definition.SeasonState;
            ///Players Logins
            foreach(TelemetryBases.PlayerLogin x in tel.PlayerLogins)
            {
                playersLogins.Items.Add(x.accountId);
            }
            ///Players Created
            foreach (TelemetryBases.PlayerCreate x in tel.PlayersCreated)
            {
                playersCreatedListbox.Items.Add(x.character.name);
            }
            ///Players logouts
            foreach (TelemetryBases.PlayerLogout x in tel.PlayersLogouts)
            {
                playersLogout.Items.Add(x.accountId);
            }
            ///Players possitions
            foreach(TelemetryBases.PlayerPosittion x in tel.PlayersPossitions)
            {
                playersPossitions.Items.Add(x.character.name);
            }


        }

        private void startCharactersListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if(startCharactersListBox.SelectedIndex >= 0)
            {
                foreach(TelemetryBases.Character x in telemetryObject.Start.characters)
                {
                    if(x.name == startCharactersListBox.SelectedItem.ToString())
                    {
                        startCharactersGroupBox.Controls.Clear();
                        CharacterForm fr = new CharacterForm(x);
                        startCharactersGroupBox.Controls.Add(fr);
                        startCharactersGroupBox.Text = "Current Player - " + x.name;
                    }
                }
            }
        }

        private void playersCreatedListbox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (playersCreatedListbox.SelectedIndex >= 0)
            {
                foreach (TelemetryBases.PlayerCreate x in telemetryObject.PlayersCreated)
                {
                    if (x.character.name == playersCreatedListbox.SelectedItem.ToString())
                    {
                        startCharactersGroupBox.Controls.Clear();
                        CharacterForm fr = new CharacterForm(x.character);
                        startCharactersGroupBox.Controls.Add(fr);
                        startCharactersGroupBox.Text = "Current Player - " + x.character.name; 
                    }
                }
            }
        }

        private void playersPossitions_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if(playersPossitions.SelectedIndex >= 0)
            {
                foreach(TelemetryBases.PlayerPosittion x in telemetryObject.PlayersPossitions)
                {
                    if(x.character.name == playersPossitions.SelectedItem.ToString())
                    {
                        currentPlayerPosittion.Controls.Clear();
                        PlayersPossitionForm fr = new PlayersPossitionForm(x);
                        currentPlayerPosittion.Controls.Add(fr);
                        currentPlayerPosittion.Text = "Current Player - " + x.character.name;
                    }
                }
            }
        }
    }
}
