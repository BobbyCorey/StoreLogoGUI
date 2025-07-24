using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreLogo_P3_BC
{
    public partial class LogoStore : Form
    {
        public LogoStore()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool hasLogo = chkbxLogo.Checked;
            string text = txtbxEngravement.Text;
            int numColors = int.Parse(txtbxNumColors.Text);
            int numItems = int.Parse(txtbxNumItems.Text);

            string itemName = " ";

            if(rdbtnUsb.Checked)
            {
                itemName = "USB";
            }
            if (rdbtnMug.Checked)
            {
                itemName = "Mug";
            }
            if (rdbtnPen.Checked)
            {
                itemName = "Pen";
            }

            int count = 0;
            if (chkbxLogo.Checked)
            {
                count++;
            }

            LogoOrderItem itemOrder = new LogoOrderItem(hasLogo, itemName, numColors, numItems, text);

            txtbxResult.Text = itemOrder.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbxOrderNum.Clear();
            txtbxResult.Clear();
            txtbxNumColors.Clear();
            txtbxNumItems.Clear();
            txtbxEngravement.Clear();
            rdbtnMug.Checked = false;
            rdbtnPen.Checked = false;
            rdbtnUsb.Checked = false;
            chkbxLogo.Checked = false;

        }
    }
}
