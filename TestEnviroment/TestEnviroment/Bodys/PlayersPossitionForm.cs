using System;
using PUBGApi;
using PUBGApi.Tempates;
using System.Windows.Forms;

namespace TestEnviroment.Bodys
{
    public partial class PlayersPossitionForm : UserControl
    {
        public PlayersPossitionForm(TelemetryBases.PlayerPosittion pr)
        {
            InitializeComponent();
            InitializeForm(pr);
        }
        void InitializeForm(TelemetryBases.PlayerPosittion pr)
        {
            if (pr.character != null)
            {
                CharacterForm fr = new CharacterForm(pr.character);
                chargb.Controls.Add(fr);
            }
            if (pr.vehicle != null)
            {
                VehicleForm fr = new VehicleForm(pr.vehicle);
                vehiclegb.Controls.Add(fr);
            }
            lblEllapseTime.Text = pr.elapsedTime.ToString();
            lblalivePlayers.Text = pr.numAlivePlayers.ToString();
            lblTimestamp.Text = pr.TimeStamp.TimeStamp;
        }

    }
}
