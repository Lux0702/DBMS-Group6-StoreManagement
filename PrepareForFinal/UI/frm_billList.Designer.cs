namespace PrepareForFinal.UI
{
    partial class frm_billList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_billImportDetail = new Guna.UI2.WinForms.Guna2Button();
            this.gb_billGeneralInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cb_billCustomerName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cb_billEmployeeName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtp_billDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_billID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_billCustomerName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_employeeName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_billDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_billID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_billTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.cb_billProductName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lb_billTotalPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_billPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_billQuantity = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_billProductName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.num_billQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.num_billPrice = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.gb_billDetailInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtgv_billDetailList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_billDeleteDetail = new Guna.UI2.WinForms.Guna2Button();
            this.btn_BillInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lb_header = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtgv_billList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_billDelete = new Guna.UI2.WinForms.Guna2Button();
            this.txt_findBill = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_findBill = new Guna.UI2.WinForms.Guna2Button();
            this.gb_billGeneralInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_billQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_billPrice)).BeginInit();
            this.gb_billDetailInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_billDetailList)).BeginInit();
            this.btn_BillInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_billList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_billImportDetail
            // 
            this.btn_billImportDetail.BackColor = System.Drawing.Color.Transparent;
            this.btn_billImportDetail.BorderRadius = 5;
            this.btn_billImportDetail.CheckedState.Parent = this.btn_billImportDetail;
            this.btn_billImportDetail.CustomImages.Parent = this.btn_billImportDetail;
            this.btn_billImportDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_billImportDetail.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_billImportDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_billImportDetail.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_billImportDetail.HoverState.Parent = this.btn_billImportDetail;
            this.btn_billImportDetail.Location = new System.Drawing.Point(881, 69);
            this.btn_billImportDetail.Name = "btn_billImportDetail";
            this.btn_billImportDetail.ShadowDecoration.Parent = this.btn_billImportDetail;
            this.btn_billImportDetail.Size = new System.Drawing.Size(108, 36);
            this.btn_billImportDetail.TabIndex = 24;
            this.btn_billImportDetail.Text = "Nhập";
            // 
            // gb_billGeneralInfo
            // 
            this.gb_billGeneralInfo.BackColor = System.Drawing.Color.Transparent;
            this.gb_billGeneralInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.gb_billGeneralInfo.BorderRadius = 5;
            this.gb_billGeneralInfo.BorderThickness = 2;
            this.gb_billGeneralInfo.Controls.Add(this.cb_billCustomerName);
            this.gb_billGeneralInfo.Controls.Add(this.cb_billEmployeeName);
            this.gb_billGeneralInfo.Controls.Add(this.dtp_billDate);
            this.gb_billGeneralInfo.Controls.Add(this.txt_billID);
            this.gb_billGeneralInfo.Controls.Add(this.lb_billCustomerName);
            this.gb_billGeneralInfo.Controls.Add(this.lb_employeeName);
            this.gb_billGeneralInfo.Controls.Add(this.lb_billDate);
            this.gb_billGeneralInfo.Controls.Add(this.lb_billID);
            this.gb_billGeneralInfo.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.gb_billGeneralInfo.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.gb_billGeneralInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.gb_billGeneralInfo.Font = new System.Drawing.Font("DVN-Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_billGeneralInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.gb_billGeneralInfo.Location = new System.Drawing.Point(16, 45);
            this.gb_billGeneralInfo.Name = "gb_billGeneralInfo";
            this.gb_billGeneralInfo.ShadowDecoration.Parent = this.gb_billGeneralInfo;
            this.gb_billGeneralInfo.Size = new System.Drawing.Size(1127, 123);
            this.gb_billGeneralInfo.TabIndex = 27;
            this.gb_billGeneralInfo.Text = "Thông tin chung";
            // 
            // cb_billCustomerName
            // 
            this.cb_billCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.cb_billCustomerName.BorderRadius = 5;
            this.cb_billCustomerName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_billCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_billCustomerName.FocusedColor = System.Drawing.Color.Empty;
            this.cb_billCustomerName.FocusedState.Parent = this.cb_billCustomerName;
            this.cb_billCustomerName.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_billCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.cb_billCustomerName.FormattingEnabled = true;
            this.cb_billCustomerName.HoverState.Parent = this.cb_billCustomerName;
            this.cb_billCustomerName.ItemHeight = 30;
            this.cb_billCustomerName.Items.AddRange(new object[] {
            "Using",
            "Deleted"});
            this.cb_billCustomerName.ItemsAppearance.Parent = this.cb_billCustomerName;
            this.cb_billCustomerName.Location = new System.Drawing.Point(651, 66);
            this.cb_billCustomerName.Name = "cb_billCustomerName";
            this.cb_billCustomerName.ShadowDecoration.Parent = this.cb_billCustomerName;
            this.cb_billCustomerName.Size = new System.Drawing.Size(205, 36);
            this.cb_billCustomerName.TabIndex = 24;
            // 
            // cb_billEmployeeName
            // 
            this.cb_billEmployeeName.BackColor = System.Drawing.Color.Transparent;
            this.cb_billEmployeeName.BorderRadius = 5;
            this.cb_billEmployeeName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_billEmployeeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_billEmployeeName.FocusedColor = System.Drawing.Color.Empty;
            this.cb_billEmployeeName.FocusedState.Parent = this.cb_billEmployeeName;
            this.cb_billEmployeeName.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_billEmployeeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.cb_billEmployeeName.FormattingEnabled = true;
            this.cb_billEmployeeName.HoverState.Parent = this.cb_billEmployeeName;
            this.cb_billEmployeeName.ItemHeight = 30;
            this.cb_billEmployeeName.Items.AddRange(new object[] {
            "Using",
            "Deleted"});
            this.cb_billEmployeeName.ItemsAppearance.Parent = this.cb_billEmployeeName;
            this.cb_billEmployeeName.Location = new System.Drawing.Point(430, 67);
            this.cb_billEmployeeName.Name = "cb_billEmployeeName";
            this.cb_billEmployeeName.ShadowDecoration.Parent = this.cb_billEmployeeName;
            this.cb_billEmployeeName.Size = new System.Drawing.Size(199, 36);
            this.cb_billEmployeeName.TabIndex = 24;
            // 
            // dtp_billDate
            // 
            this.dtp_billDate.BorderRadius = 5;
            this.dtp_billDate.CheckedState.Parent = this.dtp_billDate;
            this.dtp_billDate.CustomFormat = "dd/MM/yyyy";
            this.dtp_billDate.FillColor = System.Drawing.Color.White;
            this.dtp_billDate.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_billDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_billDate.HoverState.Parent = this.dtp_billDate;
            this.dtp_billDate.Location = new System.Drawing.Point(229, 67);
            this.dtp_billDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_billDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_billDate.Name = "dtp_billDate";
            this.dtp_billDate.ShadowDecoration.Parent = this.dtp_billDate;
            this.dtp_billDate.Size = new System.Drawing.Size(179, 36);
            this.dtp_billDate.TabIndex = 16;
            this.dtp_billDate.Value = new System.DateTime(2022, 11, 9, 11, 17, 6, 398);
            // 
            // txt_billID
            // 
            this.txt_billID.BackColor = System.Drawing.Color.Transparent;
            this.txt_billID.BorderRadius = 5;
            this.txt_billID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_billID.DefaultText = "";
            this.txt_billID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_billID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_billID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_billID.DisabledState.Parent = this.txt_billID;
            this.txt_billID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_billID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_billID.FocusedState.Parent = this.txt_billID;
            this.txt_billID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_billID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_billID.HoverState.Parent = this.txt_billID;
            this.txt_billID.Location = new System.Drawing.Point(15, 66);
            this.txt_billID.Margin = new System.Windows.Forms.Padding(8, 23, 8, 23);
            this.txt_billID.Name = "txt_billID";
            this.txt_billID.PasswordChar = '\0';
            this.txt_billID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.txt_billID.PlaceholderText = "";
            this.txt_billID.SelectedText = "";
            this.txt_billID.ShadowDecoration.Parent = this.txt_billID;
            this.txt_billID.Size = new System.Drawing.Size(192, 37);
            this.txt_billID.TabIndex = 15;
            // 
            // lb_billCustomerName
            // 
            this.lb_billCustomerName.AutoSize = false;
            this.lb_billCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lb_billCustomerName.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_billCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_billCustomerName.Location = new System.Drawing.Point(651, 36);
            this.lb_billCustomerName.Name = "lb_billCustomerName";
            this.lb_billCustomerName.Size = new System.Drawing.Size(228, 34);
            this.lb_billCustomerName.TabIndex = 18;
            this.lb_billCustomerName.Text = "Khách hàng";
            // 
            // lb_employeeName
            // 
            this.lb_employeeName.AutoSize = false;
            this.lb_employeeName.BackColor = System.Drawing.Color.Transparent;
            this.lb_employeeName.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_employeeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_employeeName.Location = new System.Drawing.Point(430, 38);
            this.lb_employeeName.Name = "lb_employeeName";
            this.lb_employeeName.Size = new System.Drawing.Size(243, 34);
            this.lb_employeeName.TabIndex = 18;
            this.lb_employeeName.Text = "Nhân viên";
            // 
            // lb_billDate
            // 
            this.lb_billDate.AutoSize = false;
            this.lb_billDate.BackColor = System.Drawing.Color.Transparent;
            this.lb_billDate.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_billDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_billDate.Location = new System.Drawing.Point(229, 36);
            this.lb_billDate.Name = "lb_billDate";
            this.lb_billDate.Size = new System.Drawing.Size(196, 37);
            this.lb_billDate.TabIndex = 17;
            this.lb_billDate.Text = "Ngày bán";
            // 
            // lb_billID
            // 
            this.lb_billID.AutoSize = false;
            this.lb_billID.BackColor = System.Drawing.Color.Transparent;
            this.lb_billID.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_billID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_billID.Location = new System.Drawing.Point(15, 38);
            this.lb_billID.Name = "lb_billID";
            this.lb_billID.Size = new System.Drawing.Size(206, 34);
            this.lb_billID.TabIndex = 14;
            this.lb_billID.Text = "Mã hóa đơn";
            // 
            // txt_billTotalPrice
            // 
            this.txt_billTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.txt_billTotalPrice.BorderRadius = 5;
            this.txt_billTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_billTotalPrice.DefaultText = "";
            this.txt_billTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_billTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_billTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_billTotalPrice.DisabledState.Parent = this.txt_billTotalPrice;
            this.txt_billTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_billTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_billTotalPrice.FocusedState.Parent = this.txt_billTotalPrice;
            this.txt_billTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_billTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_billTotalPrice.HoverState.Parent = this.txt_billTotalPrice;
            this.txt_billTotalPrice.Location = new System.Drawing.Point(702, 68);
            this.txt_billTotalPrice.Margin = new System.Windows.Forms.Padding(15, 87, 15, 87);
            this.txt_billTotalPrice.Name = "txt_billTotalPrice";
            this.txt_billTotalPrice.PasswordChar = '\0';
            this.txt_billTotalPrice.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.txt_billTotalPrice.PlaceholderText = "";
            this.txt_billTotalPrice.SelectedText = "";
            this.txt_billTotalPrice.ShadowDecoration.Parent = this.txt_billTotalPrice;
            this.txt_billTotalPrice.Size = new System.Drawing.Size(154, 37);
            this.txt_billTotalPrice.TabIndex = 15;
            // 
            // cb_billProductName
            // 
            this.cb_billProductName.BackColor = System.Drawing.Color.Transparent;
            this.cb_billProductName.BorderRadius = 5;
            this.cb_billProductName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_billProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_billProductName.FocusedColor = System.Drawing.Color.Empty;
            this.cb_billProductName.FocusedState.Parent = this.cb_billProductName;
            this.cb_billProductName.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_billProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.cb_billProductName.FormattingEnabled = true;
            this.cb_billProductName.HoverState.Parent = this.cb_billProductName;
            this.cb_billProductName.ItemHeight = 30;
            this.cb_billProductName.Items.AddRange(new object[] {
            "Using",
            "Deleted"});
            this.cb_billProductName.ItemsAppearance.Parent = this.cb_billProductName;
            this.cb_billProductName.Location = new System.Drawing.Point(15, 69);
            this.cb_billProductName.Name = "cb_billProductName";
            this.cb_billProductName.ShadowDecoration.Parent = this.cb_billProductName;
            this.cb_billProductName.Size = new System.Drawing.Size(381, 36);
            this.cb_billProductName.TabIndex = 24;
            // 
            // lb_billTotalPrice
            // 
            this.lb_billTotalPrice.AutoSize = false;
            this.lb_billTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lb_billTotalPrice.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_billTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_billTotalPrice.Location = new System.Drawing.Point(702, 37);
            this.lb_billTotalPrice.Name = "lb_billTotalPrice";
            this.lb_billTotalPrice.Size = new System.Drawing.Size(177, 40);
            this.lb_billTotalPrice.TabIndex = 18;
            this.lb_billTotalPrice.Text = "Thành tiền";
            // 
            // lb_billPrice
            // 
            this.lb_billPrice.AutoSize = false;
            this.lb_billPrice.BackColor = System.Drawing.Color.Transparent;
            this.lb_billPrice.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_billPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_billPrice.Location = new System.Drawing.Point(541, 38);
            this.lb_billPrice.Name = "lb_billPrice";
            this.lb_billPrice.Size = new System.Drawing.Size(139, 40);
            this.lb_billPrice.TabIndex = 18;
            this.lb_billPrice.Text = "Đơn giá";
            // 
            // lb_billQuantity
            // 
            this.lb_billQuantity.AutoSize = false;
            this.lb_billQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lb_billQuantity.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_billQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_billQuantity.Location = new System.Drawing.Point(417, 38);
            this.lb_billQuantity.Name = "lb_billQuantity";
            this.lb_billQuantity.Size = new System.Drawing.Size(139, 40);
            this.lb_billQuantity.TabIndex = 18;
            this.lb_billQuantity.Text = "Số lượng";
            // 
            // lb_billProductName
            // 
            this.lb_billProductName.AutoSize = false;
            this.lb_billProductName.BackColor = System.Drawing.Color.Transparent;
            this.lb_billProductName.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_billProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_billProductName.Location = new System.Drawing.Point(15, 38);
            this.lb_billProductName.Name = "lb_billProductName";
            this.lb_billProductName.Size = new System.Drawing.Size(206, 40);
            this.lb_billProductName.TabIndex = 14;
            this.lb_billProductName.Text = "Sản phẩm";
            // 
            // num_billQuantity
            // 
            this.num_billQuantity.BackColor = System.Drawing.Color.Transparent;
            this.num_billQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.num_billQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.num_billQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.num_billQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.num_billQuantity.DisabledState.Parent = this.num_billQuantity;
            this.num_billQuantity.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.num_billQuantity.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.num_billQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.num_billQuantity.FocusedState.Parent = this.num_billQuantity;
            this.num_billQuantity.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_billQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.num_billQuantity.Location = new System.Drawing.Point(419, 69);
            this.num_billQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.num_billQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_billQuantity.Name = "num_billQuantity";
            this.num_billQuantity.ShadowDecoration.Parent = this.num_billQuantity;
            this.num_billQuantity.Size = new System.Drawing.Size(106, 36);
            this.num_billQuantity.TabIndex = 25;
            this.num_billQuantity.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            // 
            // num_billPrice
            // 
            this.num_billPrice.BackColor = System.Drawing.Color.Transparent;
            this.num_billPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.num_billPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.num_billPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.num_billPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.num_billPrice.DisabledState.Parent = this.num_billPrice;
            this.num_billPrice.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.num_billPrice.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.num_billPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.num_billPrice.FocusedState.Parent = this.num_billPrice;
            this.num_billPrice.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_billPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.num_billPrice.Location = new System.Drawing.Point(541, 69);
            this.num_billPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.num_billPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.num_billPrice.Name = "num_billPrice";
            this.num_billPrice.ShadowDecoration.Parent = this.num_billPrice;
            this.num_billPrice.Size = new System.Drawing.Size(145, 36);
            this.num_billPrice.TabIndex = 25;
            this.num_billPrice.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            // 
            // gb_billDetailInfo
            // 
            this.gb_billDetailInfo.BackColor = System.Drawing.Color.Transparent;
            this.gb_billDetailInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.gb_billDetailInfo.BorderRadius = 5;
            this.gb_billDetailInfo.BorderThickness = 2;
            this.gb_billDetailInfo.Controls.Add(this.txt_billTotalPrice);
            this.gb_billDetailInfo.Controls.Add(this.num_billQuantity);
            this.gb_billDetailInfo.Controls.Add(this.num_billPrice);
            this.gb_billDetailInfo.Controls.Add(this.cb_billProductName);
            this.gb_billDetailInfo.Controls.Add(this.dtgv_billDetailList);
            this.gb_billDetailInfo.Controls.Add(this.btn_billImportDetail);
            this.gb_billDetailInfo.Controls.Add(this.btn_billDeleteDetail);
            this.gb_billDetailInfo.Controls.Add(this.lb_billTotalPrice);
            this.gb_billDetailInfo.Controls.Add(this.lb_billPrice);
            this.gb_billDetailInfo.Controls.Add(this.lb_billQuantity);
            this.gb_billDetailInfo.Controls.Add(this.lb_billProductName);
            this.gb_billDetailInfo.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.gb_billDetailInfo.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.gb_billDetailInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.gb_billDetailInfo.Font = new System.Drawing.Font("DVN-Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_billDetailInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.gb_billDetailInfo.Location = new System.Drawing.Point(16, 180);
            this.gb_billDetailInfo.Name = "gb_billDetailInfo";
            this.gb_billDetailInfo.ShadowDecoration.Parent = this.gb_billDetailInfo;
            this.gb_billDetailInfo.Size = new System.Drawing.Size(1127, 325);
            this.gb_billDetailInfo.TabIndex = 27;
            this.gb_billDetailInfo.Text = "Thông tin chi tiết";
            // 
            // dtgv_billDetailList
            // 
            this.dtgv_billDetailList.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgv_billDetailList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_billDetailList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_billDetailList.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_billDetailList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_billDetailList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_billDetailList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("DVN-Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_billDetailList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_billDetailList.ColumnHeadersHeight = 28;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("DVN-Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_billDetailList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_billDetailList.EnableHeadersVisualStyles = false;
            this.dtgv_billDetailList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_billDetailList.Location = new System.Drawing.Point(15, 121);
            this.dtgv_billDetailList.Name = "dtgv_billDetailList";
            this.dtgv_billDetailList.ReadOnly = true;
            this.dtgv_billDetailList.RowHeadersVisible = false;
            this.dtgv_billDetailList.RowHeadersWidth = 51;
            this.dtgv_billDetailList.RowTemplate.Height = 24;
            this.dtgv_billDetailList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_billDetailList.Size = new System.Drawing.Size(1091, 186);
            this.dtgv_billDetailList.TabIndex = 26;
            this.dtgv_billDetailList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgv_billDetailList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_billDetailList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgv_billDetailList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgv_billDetailList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgv_billDetailList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgv_billDetailList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_billDetailList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_billDetailList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.dtgv_billDetailList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgv_billDetailList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("DVN-Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_billDetailList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.dtgv_billDetailList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgv_billDetailList.ThemeStyle.HeaderStyle.Height = 28;
            this.dtgv_billDetailList.ThemeStyle.ReadOnly = true;
            this.dtgv_billDetailList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_billDetailList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_billDetailList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("DVN-Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_billDetailList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.dtgv_billDetailList.ThemeStyle.RowsStyle.Height = 24;
            this.dtgv_billDetailList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_billDetailList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btn_billDeleteDetail
            // 
            this.btn_billDeleteDetail.BackColor = System.Drawing.Color.Transparent;
            this.btn_billDeleteDetail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_billDeleteDetail.BorderRadius = 5;
            this.btn_billDeleteDetail.BorderThickness = 2;
            this.btn_billDeleteDetail.CheckedState.Parent = this.btn_billDeleteDetail;
            this.btn_billDeleteDetail.CustomImages.Parent = this.btn_billDeleteDetail;
            this.btn_billDeleteDetail.FillColor = System.Drawing.Color.Transparent;
            this.btn_billDeleteDetail.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_billDeleteDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_billDeleteDetail.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_billDeleteDetail.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_billDeleteDetail.HoverState.Parent = this.btn_billDeleteDetail;
            this.btn_billDeleteDetail.Location = new System.Drawing.Point(998, 69);
            this.btn_billDeleteDetail.Name = "btn_billDeleteDetail";
            this.btn_billDeleteDetail.ShadowDecoration.Parent = this.btn_billDeleteDetail;
            this.btn_billDeleteDetail.Size = new System.Drawing.Size(108, 36);
            this.btn_billDeleteDetail.TabIndex = 24;
            this.btn_billDeleteDetail.Text = "Xóa";
            // 
            // btn_BillInfo
            // 
            this.btn_BillInfo.BackColor = System.Drawing.Color.Transparent;
            this.btn_BillInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_BillInfo.BorderRadius = 5;
            this.btn_BillInfo.BorderThickness = 2;
            this.btn_BillInfo.Controls.Add(this.gb_billGeneralInfo);
            this.btn_BillInfo.Controls.Add(this.gb_billDetailInfo);
            this.btn_BillInfo.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_BillInfo.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.btn_BillInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_BillInfo.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BillInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_BillInfo.Location = new System.Drawing.Point(9, 214);
            this.btn_BillInfo.Margin = new System.Windows.Forms.Padding(10);
            this.btn_BillInfo.Name = "btn_BillInfo";
            this.btn_BillInfo.ShadowDecoration.Parent = this.btn_BillInfo;
            this.btn_BillInfo.Size = new System.Drawing.Size(1158, 516);
            this.btn_BillInfo.TabIndex = 15;
            this.btn_BillInfo.Text = "Thông tin hóa đơn";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(1134, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 20;
            // 
            // lb_header
            // 
            this.lb_header.AutoSize = false;
            this.lb_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_header.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.lb_header.Location = new System.Drawing.Point(0, 0);
            this.lb_header.Name = "lb_header";
            this.lb_header.Size = new System.Drawing.Size(1177, 54);
            this.lb_header.TabIndex = 19;
            this.lb_header.Text = "-   Danh sách hóa đơn";
            this.lb_header.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtgv_billList
            // 
            this.dtgv_billList.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtgv_billList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgv_billList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_billList.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_billList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_billList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_billList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("DVN-Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_billList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgv_billList.ColumnHeadersHeight = 28;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("DVN-Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_billList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgv_billList.EnableHeadersVisualStyles = false;
            this.dtgv_billList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_billList.Location = new System.Drawing.Point(19, 62);
            this.dtgv_billList.Name = "dtgv_billList";
            this.dtgv_billList.ReadOnly = true;
            this.dtgv_billList.RowHeadersVisible = false;
            this.dtgv_billList.RowHeadersWidth = 51;
            this.dtgv_billList.RowTemplate.Height = 24;
            this.dtgv_billList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_billList.Size = new System.Drawing.Size(807, 141);
            this.dtgv_billList.TabIndex = 27;
            this.dtgv_billList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgv_billList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_billList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgv_billList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgv_billList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgv_billList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgv_billList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_billList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_billList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.dtgv_billList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgv_billList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("DVN-Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_billList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.dtgv_billList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgv_billList.ThemeStyle.HeaderStyle.Height = 28;
            this.dtgv_billList.ThemeStyle.ReadOnly = true;
            this.dtgv_billList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_billList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_billList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("DVN-Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_billList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.dtgv_billList.ThemeStyle.RowsStyle.Height = 24;
            this.dtgv_billList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_billList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btn_billDelete
            // 
            this.btn_billDelete.BackColor = System.Drawing.Color.Transparent;
            this.btn_billDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_billDelete.BorderRadius = 5;
            this.btn_billDelete.BorderThickness = 2;
            this.btn_billDelete.CheckedState.Parent = this.btn_billDelete;
            this.btn_billDelete.CustomImages.Parent = this.btn_billDelete;
            this.btn_billDelete.FillColor = System.Drawing.Color.Transparent;
            this.btn_billDelete.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_billDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_billDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_billDelete.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_billDelete.HoverState.Parent = this.btn_billDelete;
            this.btn_billDelete.Location = new System.Drawing.Point(843, 165);
            this.btn_billDelete.Name = "btn_billDelete";
            this.btn_billDelete.ShadowDecoration.Parent = this.btn_billDelete;
            this.btn_billDelete.Size = new System.Drawing.Size(303, 36);
            this.btn_billDelete.TabIndex = 24;
            this.btn_billDelete.Text = "Xóa";
            // 
            // txt_findBill
            // 
            this.txt_findBill.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_findBill.DefaultText = "";
            this.txt_findBill.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_findBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_findBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_findBill.DisabledState.Parent = this.txt_findBill;
            this.txt_findBill.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_findBill.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_findBill.FocusedState.Parent = this.txt_findBill;
            this.txt_findBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_findBill.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_findBill.HoverState.Parent = this.txt_findBill;
            this.txt_findBill.Location = new System.Drawing.Point(843, 81);
            this.txt_findBill.Margin = new System.Windows.Forms.Padding(14, 72, 14, 72);
            this.txt_findBill.Name = "txt_findBill";
            this.txt_findBill.PasswordChar = '\0';
            this.txt_findBill.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.txt_findBill.PlaceholderText = "";
            this.txt_findBill.SelectedText = "";
            this.txt_findBill.ShadowDecoration.Parent = this.txt_findBill;
            this.txt_findBill.Size = new System.Drawing.Size(223, 36);
            this.txt_findBill.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_findBill.TabIndex = 29;
            // 
            // btn_findBill
            // 
            this.btn_findBill.BackColor = System.Drawing.Color.Transparent;
            this.btn_findBill.BorderRadius = 5;
            this.btn_findBill.CheckedState.Parent = this.btn_findBill;
            this.btn_findBill.CustomImages.Parent = this.btn_findBill;
            this.btn_findBill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_findBill.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_findBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_findBill.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_findBill.HoverState.Parent = this.btn_findBill;
            this.btn_findBill.Location = new System.Drawing.Point(1072, 81);
            this.btn_findBill.Name = "btn_findBill";
            this.btn_findBill.ShadowDecoration.Parent = this.btn_findBill;
            this.btn_findBill.Size = new System.Drawing.Size(74, 36);
            this.btn_findBill.TabIndex = 28;
            this.btn_findBill.Text = "Tìm";
            // 
            // frm_billList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(1177, 738);
            this.Controls.Add(this.txt_findBill);
            this.Controls.Add(this.btn_findBill);
            this.Controls.Add(this.dtgv_billList);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.lb_header);
            this.Controls.Add(this.btn_BillInfo);
            this.Controls.Add(this.btn_billDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_billList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách hóa đơn";
            this.gb_billGeneralInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_billQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_billPrice)).EndInit();
            this.gb_billDetailInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_billDetailList)).EndInit();
            this.btn_BillInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_billList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_billImportDetail;
        private Guna.UI2.WinForms.Guna2GroupBox gb_billGeneralInfo;
        private Guna.UI2.WinForms.Guna2ComboBox cb_billCustomerName;
        private Guna.UI2.WinForms.Guna2ComboBox cb_billEmployeeName;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_billDate;
        private Guna.UI2.WinForms.Guna2TextBox txt_billID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_billCustomerName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_employeeName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_billDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_billID;
        private Guna.UI2.WinForms.Guna2TextBox txt_billTotalPrice;
        private Guna.UI2.WinForms.Guna2ComboBox cb_billProductName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_billTotalPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_billPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_billQuantity;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_billProductName;
        private Guna.UI2.WinForms.Guna2NumericUpDown num_billQuantity;
        private Guna.UI2.WinForms.Guna2NumericUpDown num_billPrice;
        private Guna.UI2.WinForms.Guna2GroupBox gb_billDetailInfo;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_billDetailList;
        private Guna.UI2.WinForms.Guna2Button btn_billDeleteDetail;
        private Guna.UI2.WinForms.Guna2GroupBox btn_BillInfo;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_header;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_billList;
        private Guna.UI2.WinForms.Guna2Button btn_billDelete;
        private Guna.UI2.WinForms.Guna2TextBox txt_findBill;
        private Guna.UI2.WinForms.Guna2Button btn_findBill;
    }
}