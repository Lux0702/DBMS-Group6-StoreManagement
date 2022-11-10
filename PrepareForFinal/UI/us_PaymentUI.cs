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
    public partial class us_paymentUI : UserControl
    {
        public frm_billList billListForm;
        public us_paymentUI()
        {
            InitializeComponent();
        }

        private void btn_billShowList_Click(object sender, EventArgs e)
        {
            this.billListForm=new frm_billList();
            this.billListForm.Show();
            this.billListForm.BringToFront();
        }

        private void us_paymentUI_Load(object sender, EventArgs e)
        {
            btn_billSave.Enabled = false;
            btn_billCancel.Enabled = false;
            btn_billDeleteDetail.Enabled = false;
            txt_billProductPrice.Enabled = false;
            txt_billTotalPrice.Enabled = false;
        }

        private void btn_billSave_Click(object sender, EventArgs e)
        {
            btn_billAdd.Enabled = true;
            btn_billSave.Enabled = false;
            btn_billCancel.Enabled = false;
        }

        private void btn_billCancel_Click(object sender, EventArgs e)
        {
            btn_billAdd.Enabled = true;
            btn_billSave.Enabled = false;
            btn_billCancel.Enabled = false;
        }

        private void btn_billAdd_Click(object sender, EventArgs e)
        {
            btn_billAdd.Enabled = false;
            btn_billSave.Enabled = true;
            btn_billCancel.Enabled = true;
        }
    }
}
