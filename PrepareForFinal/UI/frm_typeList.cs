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
    public partial class frm_typeList : Form
    {
        DataTable dtType = new DataTable();
        TypeProduct dbType = new TypeProduct();

        bool addFlag;
        public frm_typeList()
        {
            InitializeComponent();
        }
        private void frm_typeList_Load(object sender, EventArgs e)
        {
           btn_typeCancel.Enabled = false;
           btn_typeSave.Enabled = false;

            loadData();
        }
        void loadData()
        {
            try
            {
                dtType = new DataTable();
                dtType.Clear();

                //Đưa dữ liệu vào Database
                DataSet ds = dbType.GetTypeProduct();
                dtType = ds.Tables[0];

                //Đưa dữ liệu lên DataGridView từ DataTable
                dtgv_typeList.DataSource = dtType;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);  
            }
            btn_typeDelete.Enabled = false;
        }
        private void btn_typeAdd_Click(object sender, EventArgs e)
        {
            addFlag = true;
            btn_typeDelete.Enabled = false;
            btn_typeCancel.Enabled = true;
            btn_typeSave.Enabled = true;
            btn_typeUpdate.Enabled = false;
            btn_typeAdd.Enabled = false;
        }

        private void btn_typeUpdate_Click(object sender, EventArgs e)
        {
            btn_typeDelete.Enabled = false;
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
            //Check dữ liệu từ 2 Checkbox
            if(addFlag == true)
            {
                try
                {
                    if(dbType.addType(txt_typeID.Text.Trim(), txt_typeName.Text.Trim()))
                    {
                        MessageBox.Show("Thêm Loại sản phẩm thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm Loại sản phẩm thất bại");
                    }
                    addFlag = false;
                    loadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    dbType.updateType(txt_typeID.Text.Trim(), txt_typeName.Text.Trim());

                    loadData();
                    MessageBox.Show("Cập nhật Loại sản phẩm thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            btn_typeCancel.Enabled = false;
            btn_typeSave.Enabled = false;
            btn_typeUpdate.Enabled = true;
            btn_typeAdd.Enabled = true;
            txt_typeID.Enabled = true;
        }

        private void btn_findType_Click(object sender, EventArgs e)
        {
            //Kiểm tra xem thông tin cần tìm đã được nhập chưa
            if (txt_findType.Text == null || txt_findType.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin");
                return;
            }

            try
            {
                DataTable dtType = new DataTable();
                dtType.Clear();
                dtType = dbType.findType(txt_findType.Text.Trim()).Tables[0];

                //Load lại dữ liệu
                dtgv_typeList.DataSource = dtType;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_typeDelete_Click(object sender, EventArgs e)
        {
            if(txt_typeID.Text == "" || txt_typeID.Text == null)
            {
                MessageBox.Show("Vui lòng chọn Loại sản phẩm cần xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Hỏi người dùng là có chắc chắn muốn xóa không
                DialogResult respone = MessageBox.Show("Bạn có chắc chắn muỗn Loại sản phẩm này không ?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //Nếu đồng ý
                if(respone == DialogResult.Yes)
                {
                    try
                    {
                        dbType.deleteType(txt_typeID.Text);

                        loadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void dtgv_typeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy vị trí hàng được chọn
            int index = dtgv_typeList.CurrentCell.RowIndex;

            //Load thông tin từ hàng được chọn lên textbox
            this.txt_typeID.Text = dtgv_typeList.Rows[index].Cells[0].Value.ToString();
            this.txt_typeName.Text = dtgv_typeList.Rows[index].Cells[1].Value.ToString();

            //Cho phép xóa Loại sản phẩm
            btn_typeDelete.Enabled = true;
        }
    }
}
