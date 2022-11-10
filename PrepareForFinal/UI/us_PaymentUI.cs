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
    }
}
