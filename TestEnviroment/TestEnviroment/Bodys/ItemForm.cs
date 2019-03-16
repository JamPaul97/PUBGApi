using System;
using PUBGApi.Tempates;
using System.Windows.Forms;

namespace TestEnviroment.Bodys
{
    public partial class ItemForm : UserControl
    {
        public ItemForm(TelemetryBases.Item item)
        {
            InitializeComponent();
            InitializeForm(item);
        }

        private void InitializeForm(TelemetryBases.Item item)
        {
            lblItemID.Text = item.ItemId;
            lblStackCount.Text = item.stackCount.ToString();
            lblCategory.Text = item.category;
            lblsubCategory.Text = item.subCategory;
            foreach(string x in item.attachedItems)
            {
                attachedItems.Items.Add(x);
            }
        }
    }
}
