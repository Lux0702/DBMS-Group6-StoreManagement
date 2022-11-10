namespace PrepareForFinal.UI
{
    partial class us_customerUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_customerStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_customerPoint = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.num_customerPoint = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lb_customerPhone = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_customerAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_customerName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rb_customerFemale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rb_customerMale = new Guna.UI2.WinForms.Guna2RadioButton();
            this.txt_customerPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_findCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_customerAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_customerGender = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_customerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_customerID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_customerBirth = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_productID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtp_customerBirthdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_findCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.dtgv_customerList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txt_productName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_productID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_customerID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_customerInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cb_customerStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_productDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_productSave = new Guna.UI2.WinForms.Guna2Button();
            this.btn_productUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btn_productAdd = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_customerPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_customerList)).BeginInit();
            this.btn_customerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_customerStatus
            // 
            this.lb_customerStatus.AutoSize = false;
            this.lb_customerStatus.BackColor = System.Drawing.Color.Transparent;
            this.lb_customerStatus.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_customerStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_customerStatus.Location = new System.Drawing.Point(950, 151);
            this.lb_customerStatus.Name = "lb_customerStatus";
            this.lb_customerStatus.Size = new System.Drawing.Size(93, 28);
            this.lb_customerStatus.TabIndex = 21;
            this.lb_customerStatus.Text = "Tình trạng";
            // 
            // lb_customerPoint
            // 
            this.lb_customerPoint.AutoSize = false;
            this.lb_customerPoint.BackColor = System.Drawing.Color.Transparent;
            this.lb_customerPoint.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_customerPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_customerPoint.Location = new System.Drawing.Point(721, 151);
            this.lb_customerPoint.Name = "lb_customerPoint";
            this.lb_customerPoint.Size = new System.Drawing.Size(93, 28);
            this.lb_customerPoint.TabIndex = 21;
            this.lb_customerPoint.Text = "Điểm";
            // 
            // num_customerPoint
            // 
            this.num_customerPoint.BackColor = System.Drawing.Color.Transparent;
            this.num_customerPoint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.num_customerPoint.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.num_customerPoint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.num_customerPoint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.num_customerPoint.DisabledState.Parent = this.num_customerPoint;
            this.num_customerPoint.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.num_customerPoint.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.num_customerPoint.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.num_customerPoint.FocusedState.Parent = this.num_customerPoint;
            this.num_customerPoint.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_customerPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.num_customerPoint.Location = new System.Drawing.Point(721, 179);
            this.num_customerPoint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.num_customerPoint.Maximum = new decimal(new int[] {
            20000000,
            0,
            0,
            0});
            this.num_customerPoint.Name = "num_customerPoint";
            this.num_customerPoint.ShadowDecoration.Parent = this.num_customerPoint;
            this.num_customerPoint.Size = new System.Drawing.Size(155, 36);
            this.num_customerPoint.TabIndex = 20;
            this.num_customerPoint.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            // 
            // lb_customerPhone
            // 
            this.lb_customerPhone.AutoSize = false;
            this.lb_customerPhone.BackColor = System.Drawing.Color.Transparent;
            this.lb_customerPhone.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_customerPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_customerPhone.Location = new System.Drawing.Point(950, 55);
            this.lb_customerPhone.Name = "lb_customerPhone";
            this.lb_customerPhone.Size = new System.Drawing.Size(160, 25);
            this.lb_customerPhone.TabIndex = 8;
            this.lb_customerPhone.Text = "Số điện thoại";
            // 
            // lb_customerAddress
            // 
            this.lb_customerAddress.AutoSize = false;
            this.lb_customerAddress.BackColor = System.Drawing.Color.Transparent;
            this.lb_customerAddress.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_customerAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_customerAddress.Location = new System.Drawing.Point(721, 55);
            this.lb_customerAddress.Name = "lb_customerAddress";
            this.lb_customerAddress.Size = new System.Drawing.Size(160, 25);
            this.lb_customerAddress.TabIndex = 8;
            this.lb_customerAddress.Text = "Địa chỉ";
            // 
            // lb_customerName
            // 
            this.lb_customerName.AutoSize = false;
            this.lb_customerName.BackColor = System.Drawing.Color.Transparent;
            this.lb_customerName.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_customerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_customerName.Location = new System.Drawing.Point(154, 55);
            this.lb_customerName.Name = "lb_customerName";
            this.lb_customerName.Size = new System.Drawing.Size(206, 25);
            this.lb_customerName.TabIndex = 8;
            this.lb_customerName.Text = "Tên khách hàng";
            // 
            // rb_customerFemale
            // 
            this.rb_customerFemale.AutoSize = true;
            this.rb_customerFemale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rb_customerFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.rb_customerFemale.CheckedState.BorderThickness = 0;
            this.rb_customerFemale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.rb_customerFemale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rb_customerFemale.CheckedState.InnerOffset = -4;
            this.rb_customerFemale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_customerFemale.Font = new System.Drawing.Font("DVN-Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_customerFemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.rb_customerFemale.Location = new System.Drawing.Point(453, 88);
            this.rb_customerFemale.Name = "rb_customerFemale";
            this.rb_customerFemale.Size = new System.Drawing.Size(47, 27);
            this.rb_customerFemale.TabIndex = 16;
            this.rb_customerFemale.TabStop = true;
            this.rb_customerFemale.Text = "Nữ";
            this.rb_customerFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.rb_customerFemale.UncheckedState.BorderThickness = 2;
            this.rb_customerFemale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rb_customerFemale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rb_customerFemale.UseVisualStyleBackColor = true;
            // 
            // rb_customerMale
            // 
            this.rb_customerMale.AutoSize = true;
            this.rb_customerMale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rb_customerMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.rb_customerMale.CheckedState.BorderThickness = 0;
            this.rb_customerMale.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.rb_customerMale.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rb_customerMale.CheckedState.InnerOffset = -4;
            this.rb_customerMale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_customerMale.Font = new System.Drawing.Font("DVN-Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_customerMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.rb_customerMale.Location = new System.Drawing.Point(377, 88);
            this.rb_customerMale.Name = "rb_customerMale";
            this.rb_customerMale.Size = new System.Drawing.Size(61, 27);
            this.rb_customerMale.TabIndex = 15;
            this.rb_customerMale.TabStop = true;
            this.rb_customerMale.Text = "Nam";
            this.rb_customerMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.rb_customerMale.UncheckedState.BorderThickness = 2;
            this.rb_customerMale.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rb_customerMale.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.rb_customerMale.UseVisualStyleBackColor = true;
            // 
            // txt_customerPhone
            // 
            this.txt_customerPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_customerPhone.DefaultText = "";
            this.txt_customerPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_customerPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_customerPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_customerPhone.DisabledState.Parent = this.txt_customerPhone;
            this.txt_customerPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_customerPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_customerPhone.FocusedState.Parent = this.txt_customerPhone;
            this.txt_customerPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_customerPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_customerPhone.HoverState.Parent = this.txt_customerPhone;
            this.txt_customerPhone.Location = new System.Drawing.Point(950, 84);
            this.txt_customerPhone.Margin = new System.Windows.Forms.Padding(14, 72, 14, 72);
            this.txt_customerPhone.Name = "txt_customerPhone";
            this.txt_customerPhone.PasswordChar = '\0';
            this.txt_customerPhone.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.txt_customerPhone.PlaceholderText = "";
            this.txt_customerPhone.SelectedText = "";
            this.txt_customerPhone.ShadowDecoration.Parent = this.txt_customerPhone;
            this.txt_customerPhone.Size = new System.Drawing.Size(183, 36);
            this.txt_customerPhone.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_customerPhone.TabIndex = 12;
            // 
            // txt_findCustomer
            // 
            this.txt_findCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_findCustomer.DefaultText = "";
            this.txt_findCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_findCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_findCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_findCustomer.DisabledState.Parent = this.txt_findCustomer;
            this.txt_findCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_findCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_findCustomer.FocusedState.Parent = this.txt_findCustomer;
            this.txt_findCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_findCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_findCustomer.HoverState.Parent = this.txt_findCustomer;
            this.txt_findCustomer.Location = new System.Drawing.Point(721, 370);
            this.txt_findCustomer.Margin = new System.Windows.Forms.Padding(14, 72, 14, 72);
            this.txt_findCustomer.Name = "txt_findCustomer";
            this.txt_findCustomer.PasswordChar = '\0';
            this.txt_findCustomer.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.txt_findCustomer.PlaceholderText = "";
            this.txt_findCustomer.SelectedText = "";
            this.txt_findCustomer.ShadowDecoration.Parent = this.txt_findCustomer;
            this.txt_findCustomer.Size = new System.Drawing.Size(258, 36);
            this.txt_findCustomer.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_findCustomer.TabIndex = 12;
            // 
            // txt_customerAddress
            // 
            this.txt_customerAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_customerAddress.DefaultText = "";
            this.txt_customerAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_customerAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_customerAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_customerAddress.DisabledState.Parent = this.txt_customerAddress;
            this.txt_customerAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_customerAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_customerAddress.FocusedState.Parent = this.txt_customerAddress;
            this.txt_customerAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_customerAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_customerAddress.HoverState.Parent = this.txt_customerAddress;
            this.txt_customerAddress.Location = new System.Drawing.Point(721, 83);
            this.txt_customerAddress.Margin = new System.Windows.Forms.Padding(9, 37, 9, 37);
            this.txt_customerAddress.Name = "txt_customerAddress";
            this.txt_customerAddress.PasswordChar = '\0';
            this.txt_customerAddress.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.txt_customerAddress.PlaceholderText = "";
            this.txt_customerAddress.SelectedText = "";
            this.txt_customerAddress.ShadowDecoration.Parent = this.txt_customerAddress;
            this.txt_customerAddress.Size = new System.Drawing.Size(192, 36);
            this.txt_customerAddress.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_customerAddress.TabIndex = 12;
            // 
            // lb_customerGender
            // 
            this.lb_customerGender.AutoSize = false;
            this.lb_customerGender.BackColor = System.Drawing.Color.Transparent;
            this.lb_customerGender.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_customerGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_customerGender.Location = new System.Drawing.Point(377, 55);
            this.lb_customerGender.Name = "lb_customerGender";
            this.lb_customerGender.Size = new System.Drawing.Size(147, 24);
            this.lb_customerGender.TabIndex = 14;
            this.lb_customerGender.Text = "Giới tính";
            // 
            // txt_customerName
            // 
            this.txt_customerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_customerName.DefaultText = "";
            this.txt_customerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_customerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_customerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_customerName.DisabledState.Parent = this.txt_customerName;
            this.txt_customerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_customerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_customerName.FocusedState.Parent = this.txt_customerName;
            this.txt_customerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_customerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_customerName.HoverState.Parent = this.txt_customerName;
            this.txt_customerName.Location = new System.Drawing.Point(154, 83);
            this.txt_customerName.Margin = new System.Windows.Forms.Padding(6, 19, 6, 19);
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.PasswordChar = '\0';
            this.txt_customerName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.txt_customerName.PlaceholderText = "";
            this.txt_customerName.SelectedText = "";
            this.txt_customerName.ShadowDecoration.Parent = this.txt_customerName;
            this.txt_customerName.Size = new System.Drawing.Size(206, 37);
            this.txt_customerName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_customerName.TabIndex = 12;
            // 
            // txt_customerID
            // 
            this.txt_customerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_customerID.DefaultText = "";
            this.txt_customerID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_customerID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_customerID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_customerID.DisabledState.Parent = this.txt_customerID;
            this.txt_customerID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_customerID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_customerID.FocusedState.Parent = this.txt_customerID;
            this.txt_customerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_customerID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_customerID.HoverState.Parent = this.txt_customerID;
            this.txt_customerID.Location = new System.Drawing.Point(14, 84);
            this.txt_customerID.Margin = new System.Windows.Forms.Padding(6, 12, 6, 12);
            this.txt_customerID.Name = "txt_customerID";
            this.txt_customerID.PasswordChar = '\0';
            this.txt_customerID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.txt_customerID.PlaceholderText = "";
            this.txt_customerID.SelectedText = "";
            this.txt_customerID.ShadowDecoration.Parent = this.txt_customerID;
            this.txt_customerID.Size = new System.Drawing.Size(114, 37);
            this.txt_customerID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_customerID.TabIndex = 13;
            // 
            // lb_customerBirth
            // 
            this.lb_customerBirth.AutoSize = false;
            this.lb_customerBirth.BackColor = System.Drawing.Color.Transparent;
            this.lb_customerBirth.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_customerBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_customerBirth.Location = new System.Drawing.Point(523, 53);
            this.lb_customerBirth.Name = "lb_customerBirth";
            this.lb_customerBirth.Size = new System.Drawing.Size(128, 28);
            this.lb_customerBirth.TabIndex = 9;
            this.lb_customerBirth.Text = "Ngày sinh";
            // 
            // lb_productID
            // 
            this.lb_productID.AutoSize = false;
            this.lb_productID.BackColor = System.Drawing.Color.Transparent;
            this.lb_productID.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_productID.Location = new System.Drawing.Point(14, 55);
            this.lb_productID.Name = "lb_productID";
            this.lb_productID.Size = new System.Drawing.Size(90, 28);
            this.lb_productID.TabIndex = 9;
            this.lb_productID.Text = "Mã SP";
            // 
            // dtp_customerBirthdate
            // 
            this.dtp_customerBirthdate.CheckedState.Parent = this.dtp_customerBirthdate;
            this.dtp_customerBirthdate.CustomFormat = "dd/MM/yyyy";
            this.dtp_customerBirthdate.FillColor = System.Drawing.Color.White;
            this.dtp_customerBirthdate.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_customerBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_customerBirthdate.HoverState.Parent = this.dtp_customerBirthdate;
            this.dtp_customerBirthdate.Location = new System.Drawing.Point(523, 83);
            this.dtp_customerBirthdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_customerBirthdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_customerBirthdate.Name = "dtp_customerBirthdate";
            this.dtp_customerBirthdate.ShadowDecoration.Parent = this.dtp_customerBirthdate;
            this.dtp_customerBirthdate.Size = new System.Drawing.Size(179, 36);
            this.dtp_customerBirthdate.TabIndex = 7;
            this.dtp_customerBirthdate.Value = new System.DateTime(2022, 11, 9, 11, 17, 6, 398);
            // 
            // btn_findCustomer
            // 
            this.btn_findCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btn_findCustomer.BorderRadius = 5;
            this.btn_findCustomer.CheckedState.Parent = this.btn_findCustomer;
            this.btn_findCustomer.CustomImages.Parent = this.btn_findCustomer;
            this.btn_findCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_findCustomer.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_findCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_findCustomer.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_findCustomer.HoverState.Parent = this.btn_findCustomer;
            this.btn_findCustomer.Location = new System.Drawing.Point(996, 368);
            this.btn_findCustomer.Name = "btn_findCustomer";
            this.btn_findCustomer.ShadowDecoration.Parent = this.btn_findCustomer;
            this.btn_findCustomer.Size = new System.Drawing.Size(138, 41);
            this.btn_findCustomer.TabIndex = 5;
            this.btn_findCustomer.Text = "Tìm kiếm";
            // 
            // dtgv_customerList
            // 
            this.dtgv_customerList.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dtgv_customerList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgv_customerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_customerList.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_customerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_customerList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_customerList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_customerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgv_customerList.ColumnHeadersHeight = 28;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_customerList.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtgv_customerList.EnableHeadersVisualStyles = false;
            this.dtgv_customerList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_customerList.Location = new System.Drawing.Point(13, 147);
            this.dtgv_customerList.Name = "dtgv_customerList";
            this.dtgv_customerList.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_customerList.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgv_customerList.RowHeadersVisible = false;
            this.dtgv_customerList.RowHeadersWidth = 51;
            this.dtgv_customerList.RowTemplate.Height = 24;
            this.dtgv_customerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_customerList.Size = new System.Drawing.Size(689, 338);
            this.dtgv_customerList.TabIndex = 4;
            this.dtgv_customerList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgv_customerList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_customerList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgv_customerList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgv_customerList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgv_customerList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgv_customerList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_customerList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_customerList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.dtgv_customerList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgv_customerList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_customerList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.dtgv_customerList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgv_customerList.ThemeStyle.HeaderStyle.Height = 28;
            this.dtgv_customerList.ThemeStyle.ReadOnly = true;
            this.dtgv_customerList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_customerList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_customerList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_customerList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.dtgv_customerList.ThemeStyle.RowsStyle.Height = 24;
            this.dtgv_customerList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_customerList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // txt_productName
            // 
            this.txt_productName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_productName.DefaultText = "";
            this.txt_productName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_productName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_productName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_productName.DisabledState.Parent = this.txt_productName;
            this.txt_productName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_productName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_productName.FocusedState.Parent = this.txt_productName;
            this.txt_productName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_productName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_productName.HoverState.Parent = this.txt_productName;
            this.txt_productName.Location = new System.Drawing.Point(237, 161);
            this.txt_productName.Margin = new System.Windows.Forms.Padding(6, 19, 6, 19);
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.PasswordChar = '\0';
            this.txt_productName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.txt_productName.PlaceholderText = "";
            this.txt_productName.SelectedText = "";
            this.txt_productName.ShadowDecoration.Parent = this.txt_productName;
            this.txt_productName.Size = new System.Drawing.Size(309, 70);
            this.txt_productName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_productName.TabIndex = 1;
            // 
            // txt_productID
            // 
            this.txt_productID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_productID.DefaultText = "";
            this.txt_productID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_productID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_productID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_productID.DisabledState.Parent = this.txt_productID;
            this.txt_productID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_productID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_productID.FocusedState.Parent = this.txt_productID;
            this.txt_productID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_productID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_productID.HoverState.Parent = this.txt_productID;
            this.txt_productID.Location = new System.Drawing.Point(20, 161);
            this.txt_productID.Margin = new System.Windows.Forms.Padding(6, 12, 6, 12);
            this.txt_productID.Name = "txt_productID";
            this.txt_productID.PasswordChar = '\0';
            this.txt_productID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.txt_productID.PlaceholderText = "";
            this.txt_productID.SelectedText = "";
            this.txt_productID.ShadowDecoration.Parent = this.txt_productID;
            this.txt_productID.Size = new System.Drawing.Size(178, 70);
            this.txt_productID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_productID.TabIndex = 1;
            // 
            // lb_customerID
            // 
            this.lb_customerID.AutoSize = false;
            this.lb_customerID.BackColor = System.Drawing.Color.Transparent;
            this.lb_customerID.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_customerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_customerID.Location = new System.Drawing.Point(14, 53);
            this.lb_customerID.Name = "lb_customerID";
            this.lb_customerID.Size = new System.Drawing.Size(139, 25);
            this.lb_customerID.TabIndex = 12;
            this.lb_customerID.Text = "Mã khách hàng";
            // 
            // btn_customerInfo
            // 
            this.btn_customerInfo.BackColor = System.Drawing.Color.Transparent;
            this.btn_customerInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_customerInfo.BorderRadius = 5;
            this.btn_customerInfo.BorderThickness = 2;
            this.btn_customerInfo.Controls.Add(this.guna2Button2);
            this.btn_customerInfo.Controls.Add(this.btn_productDelete);
            this.btn_customerInfo.Controls.Add(this.btn_productSave);
            this.btn_customerInfo.Controls.Add(this.btn_productUpdate);
            this.btn_customerInfo.Controls.Add(this.btn_productAdd);
            this.btn_customerInfo.Controls.Add(this.lb_customerID);
            this.btn_customerInfo.Controls.Add(this.cb_customerStatus);
            this.btn_customerInfo.Controls.Add(this.lb_customerStatus);
            this.btn_customerInfo.Controls.Add(this.lb_customerPoint);
            this.btn_customerInfo.Controls.Add(this.num_customerPoint);
            this.btn_customerInfo.Controls.Add(this.lb_customerPhone);
            this.btn_customerInfo.Controls.Add(this.lb_customerAddress);
            this.btn_customerInfo.Controls.Add(this.lb_customerName);
            this.btn_customerInfo.Controls.Add(this.rb_customerFemale);
            this.btn_customerInfo.Controls.Add(this.rb_customerMale);
            this.btn_customerInfo.Controls.Add(this.txt_customerPhone);
            this.btn_customerInfo.Controls.Add(this.txt_findCustomer);
            this.btn_customerInfo.Controls.Add(this.txt_customerAddress);
            this.btn_customerInfo.Controls.Add(this.lb_customerGender);
            this.btn_customerInfo.Controls.Add(this.txt_customerName);
            this.btn_customerInfo.Controls.Add(this.txt_customerID);
            this.btn_customerInfo.Controls.Add(this.lb_customerBirth);
            this.btn_customerInfo.Controls.Add(this.lb_productID);
            this.btn_customerInfo.Controls.Add(this.dtp_customerBirthdate);
            this.btn_customerInfo.Controls.Add(this.btn_findCustomer);
            this.btn_customerInfo.Controls.Add(this.dtgv_customerList);
            this.btn_customerInfo.Controls.Add(this.txt_productName);
            this.btn_customerInfo.Controls.Add(this.txt_productID);
            this.btn_customerInfo.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_customerInfo.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.btn_customerInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_customerInfo.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customerInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_customerInfo.Location = new System.Drawing.Point(0, 0);
            this.btn_customerInfo.Name = "btn_customerInfo";
            this.btn_customerInfo.ShadowDecoration.Parent = this.btn_customerInfo;
            this.btn_customerInfo.Size = new System.Drawing.Size(1171, 525);
            this.btn_customerInfo.TabIndex = 13;
            this.btn_customerInfo.Text = "Thông tin khách hàng";
            // 
            // cb_customerStatus
            // 
            this.cb_customerStatus.BackColor = System.Drawing.Color.Transparent;
            this.cb_customerStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_customerStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_customerStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cb_customerStatus.FocusedState.Parent = this.cb_customerStatus;
            this.cb_customerStatus.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_customerStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.cb_customerStatus.FormattingEnabled = true;
            this.cb_customerStatus.HoverState.Parent = this.cb_customerStatus;
            this.cb_customerStatus.ItemHeight = 30;
            this.cb_customerStatus.Items.AddRange(new object[] {
            "Using",
            "Deleted"});
            this.cb_customerStatus.ItemsAppearance.Parent = this.cb_customerStatus;
            this.cb_customerStatus.Location = new System.Drawing.Point(950, 179);
            this.cb_customerStatus.Name = "cb_customerStatus";
            this.cb_customerStatus.ShadowDecoration.Parent = this.cb_customerStatus;
            this.cb_customerStatus.Size = new System.Drawing.Size(183, 36);
            this.cb_customerStatus.TabIndex = 22;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 5;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.guna2Button2.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(976, 436);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(75, 49);
            this.guna2Button2.TabIndex = 39;
            this.guna2Button2.Text = "Hủy";
            // 
            // btn_productDelete
            // 
            this.btn_productDelete.BackColor = System.Drawing.Color.Transparent;
            this.btn_productDelete.BorderRadius = 5;
            this.btn_productDelete.CheckedState.Parent = this.btn_productDelete;
            this.btn_productDelete.CustomImages.Parent = this.btn_productDelete;
            this.btn_productDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(65)))));
            this.btn_productDelete.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_productDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_productDelete.HoverState.Parent = this.btn_productDelete;
            this.btn_productDelete.Location = new System.Drawing.Point(1061, 436);
            this.btn_productDelete.Name = "btn_productDelete";
            this.btn_productDelete.ShadowDecoration.Parent = this.btn_productDelete;
            this.btn_productDelete.Size = new System.Drawing.Size(72, 49);
            this.btn_productDelete.TabIndex = 35;
            this.btn_productDelete.Text = "Xóa";
            // 
            // btn_productSave
            // 
            this.btn_productSave.BackColor = System.Drawing.Color.Transparent;
            this.btn_productSave.BorderRadius = 5;
            this.btn_productSave.CheckedState.Parent = this.btn_productSave;
            this.btn_productSave.CustomImages.Parent = this.btn_productSave;
            this.btn_productSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_productSave.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_productSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_productSave.HoverState.Parent = this.btn_productSave;
            this.btn_productSave.Location = new System.Drawing.Point(891, 436);
            this.btn_productSave.Name = "btn_productSave";
            this.btn_productSave.ShadowDecoration.Parent = this.btn_productSave;
            this.btn_productSave.Size = new System.Drawing.Size(75, 49);
            this.btn_productSave.TabIndex = 36;
            this.btn_productSave.Text = "Lưu";
            // 
            // btn_productUpdate
            // 
            this.btn_productUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btn_productUpdate.BorderRadius = 5;
            this.btn_productUpdate.CheckedState.Parent = this.btn_productUpdate;
            this.btn_productUpdate.CustomImages.Parent = this.btn_productUpdate;
            this.btn_productUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_productUpdate.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_productUpdate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_productUpdate.HoverState.Parent = this.btn_productUpdate;
            this.btn_productUpdate.Location = new System.Drawing.Point(806, 436);
            this.btn_productUpdate.Name = "btn_productUpdate";
            this.btn_productUpdate.ShadowDecoration.Parent = this.btn_productUpdate;
            this.btn_productUpdate.Size = new System.Drawing.Size(75, 49);
            this.btn_productUpdate.TabIndex = 37;
            this.btn_productUpdate.Text = "Sửa";
            // 
            // btn_productAdd
            // 
            this.btn_productAdd.BackColor = System.Drawing.Color.Transparent;
            this.btn_productAdd.BorderRadius = 5;
            this.btn_productAdd.CheckedState.Parent = this.btn_productAdd;
            this.btn_productAdd.CustomImages.Parent = this.btn_productAdd;
            this.btn_productAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_productAdd.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_productAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_productAdd.HoverState.Parent = this.btn_productAdd;
            this.btn_productAdd.Location = new System.Drawing.Point(721, 436);
            this.btn_productAdd.Name = "btn_productAdd";
            this.btn_productAdd.ShadowDecoration.Parent = this.btn_productAdd;
            this.btn_productAdd.Size = new System.Drawing.Size(75, 49);
            this.btn_productAdd.TabIndex = 38;
            this.btn_productAdd.Text = "Thêm";
            // 
            // us_customerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn_customerInfo);
            this.Name = "us_customerUI";
            this.Size = new System.Drawing.Size(1171, 525);
            ((System.ComponentModel.ISupportInitialize)(this.num_customerPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_customerList)).EndInit();
            this.btn_customerInfo.ResumeLayout(false);
            this.btn_customerInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lb_customerStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_customerPoint;
        private Guna.UI2.WinForms.Guna2NumericUpDown num_customerPoint;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_customerPhone;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_customerAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_customerName;
        private Guna.UI2.WinForms.Guna2RadioButton rb_customerFemale;
        private Guna.UI2.WinForms.Guna2RadioButton rb_customerMale;
        private Guna.UI2.WinForms.Guna2TextBox txt_customerPhone;
        private Guna.UI2.WinForms.Guna2TextBox txt_findCustomer;
        private Guna.UI2.WinForms.Guna2TextBox txt_customerAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_customerGender;
        private Guna.UI2.WinForms.Guna2TextBox txt_customerName;
        private Guna.UI2.WinForms.Guna2TextBox txt_customerID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_customerBirth;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_productID;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_customerBirthdate;
        private Guna.UI2.WinForms.Guna2Button btn_findCustomer;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_customerList;
        private Guna.UI2.WinForms.Guna2TextBox txt_productName;
        private Guna.UI2.WinForms.Guna2TextBox txt_productID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_customerID;
        private Guna.UI2.WinForms.Guna2GroupBox btn_customerInfo;
        private Guna.UI2.WinForms.Guna2ComboBox cb_customerStatus;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btn_productDelete;
        private Guna.UI2.WinForms.Guna2Button btn_productSave;
        private Guna.UI2.WinForms.Guna2Button btn_productUpdate;
        private Guna.UI2.WinForms.Guna2Button btn_productAdd;
    }
}
