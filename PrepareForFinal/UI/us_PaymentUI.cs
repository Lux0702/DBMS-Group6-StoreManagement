using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrepareForFinal.BSLayer;

namespace PrepareForFinal.UI
{
    public partial class us_paymentUI : UserControl
    {
        public frm_billList billListForm;
        public Bill myBill;
        public Detail myDetail;
        public DataTable myDataTable;
        public DataSet myDataSet;
        public List<Control> InputcontrolList = new List<Control>();
        public us_paymentUI()
        {
            InitializeComponent();
            InputControlLoad();
        }
        private void InputControlLoad()
        {
            InputcontrolList.Add(txt_billID);
            InputcontrolList.Add(dtp_billDate);
            InputcontrolList.Add(cb_billEmployeeName);
            InputcontrolList.Add(cb_billCustomerName);
            InputcontrolList.Add(cb_billProductName);
            InputcontrolList.Add(num_billProductQuantity);
        }
        private void EnabledInputControl()
        {
            foreach (Control control in InputcontrolList)
            {
                control.Enabled = true;
            }
        }
        private void UnenabledInputControl()
        {
            foreach (Control control in InputcontrolList)
            {
                control.Enabled = false;
            }
        }

        private void ClearItems()
        {
            cb_billCustomerName.Items.Clear();
            cb_billEmployeeName.Items.Clear();
            cb_billProductName.Items.Clear();
            txt_billID.Clear();
            txt_billProductPrice.Clear();
            txt_billTotalPay.Clear();
            txt_billTotalPrice.Clear();
            num_billProductQuantity.Value = 1;
        }
        private void btn_billShowList_Click(object sender, EventArgs e)
        {
            this.billListForm = new frm_billList();
            this.billListForm.Show();
            this.billListForm.BringToFront();
        }

        private void us_paymentUI_Load(object sender, EventArgs e)
        {
            btn_billSave.Enabled = false;
            btn_billCancel.Enabled = false;
            btn_billDeleteDetail.Enabled = false;
            txt_billProductPrice.Enabled = false;
            txt_billTotalPay.Enabled = false;
            txt_billTotalPrice.Enabled = false;
            btn_billImportDetail.Enabled = false;
            dtp_billDate.Value = DateTime.Today;
            ClearItems();
            UnenabledInputControl();
        }

        private void btn_billSave_Click(object sender, EventArgs e)
        {
            btn_billAdd.Enabled = true;
            btn_billSave.Enabled = false;
            btn_billCancel.Enabled = false;
            try
            {
                String eid = myBill.getEmployeeID(cb_billEmployeeName.Text.ToString());
                String cid = myBill.getCustomerID(cb_billCustomerName.Text.ToString());
                if (txt_billID.Enabled == true)
                {
                    if (myBill.addBill(txt_billID.Text.Trim(), Convert.ToDateTime(dtp_billDate.Value), (float)0, eid, cid) == true)
                    {
                        MessageBox.Show("Thêm hóa đơn thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm hóa đơn không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Thêm hóa đơn thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể lưu, lỗi: " + ex.Message);
            }
            ClearItems();
            UnenabledInputControl();
            LoadData();
            btn_billDeleteDetail.Enabled = false;
        }

        private void btn_billCancel_Click(object sender, EventArgs e)
        {
            btn_billAdd.Enabled = true;
            btn_billSave.Enabled = false;
            btn_billCancel.Enabled = false;
            txt_billTotalPay.Enabled = false;
            ClearItems();
            UnenabledInputControl();
        }

        private void btn_billAdd_Click(object sender, EventArgs e)
        {
            btn_billAdd.Enabled = false;
            btn_billSave.Enabled = true;
            btn_billCancel.Enabled = true;
            btn_billImportDetail.Enabled = true;
            myBill = new Bill();
            myBill.getEmployeeName(cb_billEmployeeName);
            myBill.getCustomerName(cb_billCustomerName);
            myBill.getProductName(cb_billProductName);
            txt_billTotalPay.Text = "0";
            EnabledInputControl();
        }

        private void dtgv_billDetialList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_billDeleteDetail.Enabled = false;
            // Lấy dòng đang được ấy
            if (dtgv_billDetialList.Rows.Count < 1)
            {
                return;
            }
            int row = dtgv_billDetialList.CurrentCell.RowIndex;

            btn_billDeleteDetail.Enabled = true;


            CustomeDetailDataGridView();
        }

        private void btn_billImportDetail_Click(object sender, EventArgs e)
        {
            String eid = myBill.getEmployeeID(cb_billEmployeeName.Text.ToString());
            String cid = myBill.getCustomerID(cb_billCustomerName.Text.ToString());

            if (cb_billProductName.Text == "" || num_billProductQuantity.Value.ToString() == "" || txt_billProductPrice.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
            else
            {
                if (txt_billID.Enabled == true)
                {
                    if (myBill.addBill(txt_billID.Text.Trim(), Convert.ToDateTime(dtp_billDate.Value), (float)0, eid, cid) &&
                    myDetail.addDetail((float)num_billProductQuantity.Value, txt_billID.Text, myDetail.getProductID(cb_billProductName.Text)))
                    {
                        MessageBox.Show("Thêm hàng thành công");
                        txt_billID.Enabled = false;
                        dtp_billDate.Enabled = false;
                        cb_billEmployeeName.Enabled = false;
                        cb_billCustomerName.Enabled = false;

                        cb_billProductName.ResetText();
                        num_billProductQuantity.Value = 1;
                        txt_billProductPrice.ResetText();
                        txt_billTotalPrice.ResetText();
                        txt_billTotalPay.Text = myBill.getBillTotal(txt_billID.Text);
                    }
                    else
                    {
                        MessageBox.Show("Thêm hàng không thành công");
                    }
                }
                else
                {
                    if (myDetail.addDetail((float)num_billProductQuantity.Value, txt_billID.Text, myDetail.getProductID(cb_billProductName.Text)))
                    {
                        MessageBox.Show("Thêm hàng thành công");
                        txt_billID.Enabled = false;
                        dtp_billDate.Enabled = false;
                        cb_billEmployeeName.Enabled = false;
                        cb_billCustomerName.Enabled = false;

                        cb_billProductName.ResetText();
                        num_billProductQuantity.Value = 1;
                        txt_billProductPrice.ResetText();
                        txt_billTotalPrice.ResetText();
                        txt_billTotalPay.Text = myBill.getBillTotal(txt_billID.Text);
                    }
                    else
                    {
                        MessageBox.Show("Thêm hàng không thành công");
                    }
                }
                LoadData();
                CustomeDetailDataGridView();
            }
            
        }

        private void cb_billProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_billProductName.Text != "")
            {
                myDetail = new Detail();
                double price = Convert.ToDouble(myDetail.getProductPrice(cb_billProductName.Text)) * 1.15;
                txt_billProductPrice.Text = price.ToString();

                txt_billTotalPrice.Text = (price * (double)num_billProductQuantity.Value).ToString();
            }
        }

        private void num_billProductQuantity_ValueChanged(object sender, EventArgs e)
        {
            myDetail = new Detail();
            if (cb_billProductName.Text != "")
            {
                double price = Convert.ToDouble(myDetail.getProductPrice(cb_billProductName.Text)) * 1.15;
                txt_billTotalPrice.Text = (price * (double)num_billProductQuantity.Value).ToString();
            }
        }

        private void LoadData()
        {
            try
            {
                myDataTable = new DataTable();
                myDetail = new Detail();
                myDataSet = new DataSet();
                // Lấy data đưa vào dataset
                myDataSet = myDetail.GetData(txt_billID.Text);
                // Đưa dữ liệu từ dataset vào table
                myDataTable = myDataSet.Tables[0];
                // Đổ data vào datagridview
                dtgv_billDetialList.DataSource = myDataTable;
                // Tùy chỉnh giao diện cho cái list
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi", "Không hiển thị được thông tin, Lỗi: " + ex.Message);
            }

        }

        private void CustomeDetailDataGridView()
        {
            dtgv_billDetialList.AllowUserToAddRows = false;
            dtgv_billDetialList.Columns[0].HeaderText = "Sản phẩm";
            dtgv_billDetialList.Columns[1].HeaderText = "Số lượng";
            dtgv_billDetialList.Columns[2].HeaderText = "Đơn giá";
            dtgv_billDetialList.Columns[3].HeaderText = "Thành tiền";
            dtgv_billDetialList.Columns[4].Visible = false;
            dtgv_billDetialList.Columns[5].Visible = false;
        }
    }
}
