using PUBGApi.Tempates;
using System.Windows.Forms;

namespace TestEnviroment.Bodys
{
    public partial class VehicleForm : UserControl
    {
        public VehicleForm(TelemetryBases.Vehicle veh)
        {
            InitializeComponent();
            InitializeForm(veh);
        }
        void InitializeForm(TelemetryBases.Vehicle veh)
        {
            lblType.Text = veh.vehicleType;
            lblId.Text = veh.vehicleId;
            lblVehicleHealth.Text = veh.healthPercent.ToString();
            lblFuel.Text = veh.feulPercent.ToString();
        }
    }
}
