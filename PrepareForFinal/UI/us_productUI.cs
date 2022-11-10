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
    public partial class us_productUI : UserControl
    {
        frm_typeList typeListForm;
        public us_productUI()
        {
            InitializeComponent();
        }

        private void btn_typeShowList_Click(object sender, EventArgs e)
        {
            this.typeListForm=new frm_typeList();
            this.typeListForm.Show();
        }

        private void us_productUI_Load(object sender, EventArgs e)
        {
            btn_productSave.Enabled=false;
            btn_productCancel.Enabled=false;
            btn_productDelete.Enabled=false;
        }

        private void btn_productAdd_Click(object sender, EventArgs e)
        {
            btn_productSave.Enabled = true;
            btn_productCancel.Enabled = true;
            btn_productAdd.Enabled = false;
            btn_productUpdate.Enabled = false;
        }

        private void btn_productUpdate_Click(object sender, EventArgs e)
        {
            btn_productSave.Enabled = true;
            btn_productCancel.Enabled = true;
            btn_productAdd.Enabled = false;
            btn_productUpdate.Enabled = false;
            txt_productID.Enabled = false;
        }

        private void btn_productSave_Click(object sender, EventArgs e)
        {
            btn_productSave.Enabled = false;
            btn_productCancel.Enabled = false;
            btn_productAdd.Enabled = true;
            btn_productUpdate.Enabled = true;
            txt_productID.Enabled = true;
        }

        private void btn_productCancel_Click(object sender, EventArgs e)
        {
            btn_productSave.Enabled = false;
            btn_productCancel.Enabled = false;
            btn_productAdd.Enabled = true;
            btn_productUpdate.Enabled = true;
            txt_productID.Enabled = true;
        }
    }
}
