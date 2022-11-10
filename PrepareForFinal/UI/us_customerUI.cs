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
    public partial class us_customerUI : UserControl
    {
        public us_customerUI()
        {
            InitializeComponent();
        }

        private void us_customerUI_Load(object sender, EventArgs e)
        {
            txt_customerPoint.Enabled = false;
            btn_customerSave.Enabled = false;
            btn_customerCancel.Enabled = false;
            btn_customerDelete.Enabled = false;
        }

        private void btn_customerAdd_Click(object sender, EventArgs e)
        {
            btn_customerAdd.Enabled = false;
            btn_customerSave.Enabled = true;
            btn_customerCancel.Enabled = true;
            btn_customerUpdate.Enabled =false;
        }

        private void btn_customerUpdate_Click(object sender, EventArgs e)
        {
            btn_customerAdd.Enabled = false;
            btn_customerSave.Enabled = true;
            btn_customerCancel.Enabled = true;
            btn_customerUpdate.Enabled = false;
            txt_customerID.Enabled = false;
        }

        private void btn_customerSave_Click(object sender, EventArgs e)
        {
            btn_customerAdd.Enabled = true;
            btn_customerSave.Enabled = false;
            btn_customerCancel.Enabled = false;
            btn_customerUpdate.Enabled=true;
            txt_customerID.Enabled = true;
        }

        private void btn_customerCancel_Click(object sender, EventArgs e)
        {
            btn_customerAdd.Enabled = true;
            btn_customerSave.Enabled = false;
            btn_customerCancel.Enabled = false;
            btn_customerUpdate.Enabled = true;
            txt_customerID.Enabled = true;
        }
    }
}
