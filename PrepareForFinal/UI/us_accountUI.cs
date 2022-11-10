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
    public partial class us_accountUI : UserControl
    {
        public us_accountUI()
        {
            InitializeComponent();
        }

        private void us_accountUI_Load(object sender, EventArgs e)
        {
            btn_accountCancel.Enabled = false;
            btn_accountDelete.Enabled = false;
            btn_accountSave.Enabled = false;
        }

        private void btn_accountAdd_Click(object sender, EventArgs e)
        {
            btn_accountAdd.Enabled = false;
            btn_accountUpdate.Enabled = false;
            btn_accountSave.Enabled = true;
            btn_accountCancel.Enabled = true;
        }

        private void btn_accountSave_Click(object sender, EventArgs e)
        {
            btn_accountAdd.Enabled = true;
            btn_accountUpdate.Enabled = true;
            btn_accountSave.Enabled = false;
            btn_accountCancel.Enabled = false;
            txt_accountUsername.Enabled = true;
        }

        private void btn_accountCancel_Click(object sender, EventArgs e)
        {
            btn_accountAdd.Enabled = true;
            btn_accountUpdate.Enabled = true;
            btn_accountSave.Enabled = false;
            btn_accountCancel.Enabled = false;
            txt_accountUsername.Enabled = true;
        }

        private void btn_accountUpdate_Click(object sender, EventArgs e)
        {
            btn_accountAdd.Enabled = false;
            btn_accountUpdate.Enabled = false;
            btn_accountSave.Enabled = true;
            btn_accountCancel.Enabled = true;
            txt_accountUsername.Enabled = false;
        }
    }
}
