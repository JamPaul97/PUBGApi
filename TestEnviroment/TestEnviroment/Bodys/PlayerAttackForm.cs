using PUBGApi.Tempates;
using System.Windows.Forms;

namespace TestEnviroment.Bodys
{
    public partial class PlayerAttackForm : UserControl
    {
        public PlayerAttackForm(TelemetryBases.PlayerAttack player)
        {
            InitializeComponent();
            InitializeForm(player);
        }
        void InitializeForm(TelemetryBases.PlayerAttack player)
        {
            //Attacker
            CharacterForm fr = new CharacterForm(player.attacker);
            chargb.Controls.Add(fr);
            //Weapon
            ItemForm it = new ItemForm(player.weapon);
            weapongb.Controls.Add(it);
            //Vehicle
            VehicleForm vr = new VehicleForm(player.vehicle);
            vehiclegb.Controls.Add(vr);
            //Other
            lblAttackID.Text = player.attackId.ToString();
            lblfireWeaponStackCount.Text = player.fireWeaponStackCount.ToString();
            lblAttackType.Text = player.attackType;

        }
    }
}
