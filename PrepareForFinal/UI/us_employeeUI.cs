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
    public partial class us_employeeUI : UserControl
    {
        public us_employeeUI()
        {
            InitializeComponent();
        }

        private void us_employeeUI_Load(object sender, EventArgs e)
        {
            btn_employeeSave.Enabled = false;
            btn_employeeCancel.Enabled = false;
            btn_employeeDelete.Enabled = false;
        }

        private void btn_employeeAdd_Click(object sender, EventArgs e)
        {
            btn_employeeSave.Enabled = true;
            btn_employeeCancel.Enabled = true;
            btn_employeeAdd.Enabled = false;
            btn_employeeUpdate.Enabled = false;
        }

        private void btn_employeeUpdate_Click(object sender, EventArgs e)
        {
            btn_employeeSave.Enabled = true;
            btn_employeeCancel.Enabled = true;
            btn_employeeAdd.Enabled = false;
            btn_employeeUpdate.Enabled = false;
            txt_employeeID.Enabled = false;
        }

        private void btn_employeeSave_Click(object sender, EventArgs e)
        {
            btn_employeeSave.Enabled = false;
            btn_employeeCancel.Enabled = false;
            btn_employeeAdd.Enabled = true;
            btn_employeeUpdate.Enabled = true;
            txt_employeeID.Enabled = true;
        }

        private void btn_employeeCancel_Click(object sender, EventArgs e)
        {
            btn_employeeSave.Enabled = false;
            btn_employeeCancel.Enabled = false;
            btn_employeeAdd.Enabled = true;
            btn_employeeUpdate.Enabled = true;
            txt_employeeID.Enabled = true;
        }
    }
}
