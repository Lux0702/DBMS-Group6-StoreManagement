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
    public partial class frm_billList : Form
    {
        public frm_billList()
        {
            InitializeComponent();
        }

        private void frm_billList_Load(object sender, EventArgs e)
        {
            btn_billDelete.Enabled = false;
            txt_billProductPrice.Enabled = false; 
            txt_billCName.Enabled = false;
            txt_billEName.Enabled = false; 
            txt_billID.Enabled = false;
            txt_billProductName.Enabled = false;
            txt_billProductPrice.Enabled=false;
            txt_billQuantity.Enabled = false;
            txt_billTotalPrice.Enabled = false;
            dtp_billDate.Enabled = false;
        }
    }
}
