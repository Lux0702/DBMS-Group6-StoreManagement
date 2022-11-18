using PrepareForFinal.BSLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrepareForFinal.UI
{
    public partial class us_supplyUI : UserControl
    {

        public us_supplyUI()
        {
            InitializeComponent();
        }

        private void us_supplyUI_Load(object sender, EventArgs e)
        {
            btn_supplySave.Enabled = false;
            btn_supplyCancel.Enabled = false;
            btn_supplyDelete.Enabled = false;
        }

        private void btn_supplyAdd_Click(object sender, EventArgs e)
        {
            btn_supplySave.Enabled = true;
            btn_supplyCancel.Enabled = true;
            btn_supplyAdd.Enabled = false;
            btn_supplyUpdate.Enabled = false;
        }

        private void btn_supplyUpdate_Click(object sender, EventArgs e)
        {
            btn_supplySave.Enabled = true;
            btn_supplyCancel.Enabled = true;
            btn_supplyAdd.Enabled = false;
            btn_supplyUpdate.Enabled = false;
            txt_supplyID.Enabled = false;
        }

        private void btn_supplySave_Click(object sender, EventArgs e)
        {
            btn_supplySave.Enabled = false;
            btn_supplyCancel.Enabled = false;
            btn_supplyAdd.Enabled = true;
            btn_supplyUpdate.Enabled = true;
            txt_supplyID.Enabled = true;
        }

        private void btn_supplyCancel_Click(object sender, EventArgs e)
        {
            btn_supplySave.Enabled = false;
            btn_supplyCancel.Enabled = false;
            btn_supplyAdd.Enabled = true;
            btn_supplyUpdate.Enabled = true;
            txt_supplyID.Enabled = true;
        }

        private void btn_findSupply_Click(object sender, EventArgs e)
        {

        }
    }
}
