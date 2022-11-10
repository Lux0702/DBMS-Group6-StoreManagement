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
    public partial class frm_typeList : Form
    {
        public frm_typeList()
        {
            InitializeComponent();
        }

        private void frm_typeList_Load(object sender, EventArgs e)
        {
           btn_typeCancel.Enabled = false;
           btn_typeDelete.Enabled = false;
           btn_typeSave.Enabled = false;
        }

        private void btn_typeAdd_Click(object sender, EventArgs e)
        {
            btn_typeCancel.Enabled = true;
            btn_typeSave.Enabled = true;
            btn_typeUpdate.Enabled = false;
            btn_typeAdd.Enabled = false;
        }

        private void btn_typeUpdate_Click(object sender, EventArgs e)
        {
            btn_typeCancel.Enabled = true;
            btn_typeSave.Enabled = true;
            btn_typeAdd.Enabled = false;
            btn_typeUpdate.Enabled = false;
            txt_typeID.Enabled = false;
        }

        private void btn_typeCancel_Click(object sender, EventArgs e)
        {
            btn_typeCancel.Enabled = false;
            btn_typeSave.Enabled = false;
            btn_typeUpdate.Enabled = true;
            btn_typeAdd.Enabled = true;
            txt_typeID.Enabled = true;
        }

        private void btn_typeSave_Click(object sender, EventArgs e)
        {
            btn_typeCancel.Enabled = false;
            btn_typeSave.Enabled = false;
            btn_typeUpdate.Enabled = true;
            btn_typeAdd.Enabled = true;
            txt_typeID.Enabled = true;
        }
    }
}
