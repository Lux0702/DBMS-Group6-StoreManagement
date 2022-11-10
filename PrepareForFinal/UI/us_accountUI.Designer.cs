namespace PrepareForFinal.UI
{
    partial class us_accountUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cb_customerStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lb_accountStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_findAccount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_customerID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_findAccount = new Guna.UI2.WinForms.Guna2Button();
            this.dtgv_customerList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lb_accountEmployeeID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_customerInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lb_accountRepassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_accountPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_accountUsername = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_productDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_productSave = new Guna.UI2.WinForms.Guna2Button();
            this.btn_productUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btn_productAdd = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_customerList)).BeginInit();
            this.btn_customerInfo.SuspendLayout();
            this.SuspendLayout();
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
            this.cb_customerStatus.Location = new System.Drawing.Point(960, 289);
            this.cb_customerStatus.Name = "cb_customerStatus";
            this.cb_customerStatus.ShadowDecoration.Parent = this.cb_customerStatus;
            this.cb_customerStatus.Size = new System.Drawing.Size(183, 36);
            this.cb_customerStatus.TabIndex = 22;
            // 
            // lb_accountStatus
            // 
            this.lb_accountStatus.AutoSize = false;
            this.lb_accountStatus.BackColor = System.Drawing.Color.Transparent;
            this.lb_accountStatus.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_accountStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_accountStatus.Location = new System.Drawing.Point(960, 261);
            this.lb_accountStatus.Name = "lb_accountStatus";
            this.lb_accountStatus.Size = new System.Drawing.Size(157, 28);
            this.lb_accountStatus.TabIndex = 21;
            this.lb_accountStatus.Text = "Tình trạng";
            // 
            // txt_findAccount
            // 
            this.txt_findAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_findAccount.DefaultText = "";
            this.txt_findAccount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_findAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_findAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_findAccount.DisabledState.Parent = this.txt_findAccount;
            this.txt_findAccount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_findAccount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_findAccount.FocusedState.Parent = this.txt_findAccount;
            this.txt_findAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_findAccount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_findAccount.HoverState.Parent = this.txt_findAccount;
            this.txt_findAccount.Location = new System.Drawing.Point(731, 373);
            this.txt_findAccount.Margin = new System.Windows.Forms.Padding(14, 72, 14, 72);
            this.txt_findAccount.Name = "txt_findAccount";
            this.txt_findAccount.PasswordChar = '\0';
            this.txt_findAccount.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.txt_findAccount.PlaceholderText = "";
            this.txt_findAccount.SelectedText = "";
            this.txt_findAccount.ShadowDecoration.Parent = this.txt_findAccount;
            this.txt_findAccount.Size = new System.Drawing.Size(267, 36);
            this.txt_findAccount.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_findAccount.TabIndex = 12;
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
            this.txt_customerID.Location = new System.Drawing.Point(731, 289);
            this.txt_customerID.Margin = new System.Windows.Forms.Padding(6, 12, 6, 12);
            this.txt_customerID.Name = "txt_customerID";
            this.txt_customerID.PasswordChar = '\0';
            this.txt_customerID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.txt_customerID.PlaceholderText = "";
            this.txt_customerID.SelectedText = "";
            this.txt_customerID.ShadowDecoration.Parent = this.txt_customerID;
            this.txt_customerID.Size = new System.Drawing.Size(186, 37);
            this.txt_customerID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_customerID.TabIndex = 13;
            // 
            // btn_findAccount
            // 
            this.btn_findAccount.BackColor = System.Drawing.Color.Transparent;
            this.btn_findAccount.BorderRadius = 5;
            this.btn_findAccount.CheckedState.Parent = this.btn_findAccount;
            this.btn_findAccount.CustomImages.Parent = this.btn_findAccount;
            this.btn_findAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_findAccount.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_findAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_findAccount.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_findAccount.HoverState.Parent = this.btn_findAccount;
            this.btn_findAccount.Location = new System.Drawing.Point(1006, 371);
            this.btn_findAccount.Name = "btn_findAccount";
            this.btn_findAccount.ShadowDecoration.Parent = this.btn_findAccount;
            this.btn_findAccount.Size = new System.Drawing.Size(138, 41);
            this.btn_findAccount.TabIndex = 5;
            this.btn_findAccount.Text = "Tìm kiếm";
            // 
            // dtgv_customerList
            // 
            this.dtgv_customerList.AllowUserToAddRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dtgv_customerList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dtgv_customerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_customerList.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_customerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_customerList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_customerList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_customerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dtgv_customerList.ColumnHeadersHeight = 28;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_customerList.DefaultCellStyle = dataGridViewCellStyle15;
            this.dtgv_customerList.EnableHeadersVisualStyles = false;
            this.dtgv_customerList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_customerList.Location = new System.Drawing.Point(20, 66);
            this.dtgv_customerList.Name = "dtgv_customerList";
            this.dtgv_customerList.ReadOnly = true;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_customerList.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dtgv_customerList.RowHeadersVisible = false;
            this.dtgv_customerList.RowHeadersWidth = 51;
            this.dtgv_customerList.RowTemplate.Height = 24;
            this.dtgv_customerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_customerList.Size = new System.Drawing.Size(689, 417);
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
            // lb_accountEmployeeID
            // 
            this.lb_accountEmployeeID.AutoSize = false;
            this.lb_accountEmployeeID.BackColor = System.Drawing.Color.Transparent;
            this.lb_accountEmployeeID.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_accountEmployeeID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_accountEmployeeID.Location = new System.Drawing.Point(731, 262);
            this.lb_accountEmployeeID.Name = "lb_accountEmployeeID";
            this.lb_accountEmployeeID.Size = new System.Drawing.Size(164, 25);
            this.lb_accountEmployeeID.TabIndex = 14;
            this.lb_accountEmployeeID.Text = "Mã nhân viên";
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
            this.btn_customerInfo.Controls.Add(this.lb_accountRepassword);
            this.btn_customerInfo.Controls.Add(this.lb_accountPassword);
            this.btn_customerInfo.Controls.Add(this.lb_accountUsername);
            this.btn_customerInfo.Controls.Add(this.lb_accountEmployeeID);
            this.btn_customerInfo.Controls.Add(this.cb_customerStatus);
            this.btn_customerInfo.Controls.Add(this.lb_accountStatus);
            this.btn_customerInfo.Controls.Add(this.txt_findAccount);
            this.btn_customerInfo.Controls.Add(this.guna2TextBox3);
            this.btn_customerInfo.Controls.Add(this.guna2TextBox2);
            this.btn_customerInfo.Controls.Add(this.guna2TextBox1);
            this.btn_customerInfo.Controls.Add(this.txt_customerID);
            this.btn_customerInfo.Controls.Add(this.btn_findAccount);
            this.btn_customerInfo.Controls.Add(this.dtgv_customerList);
            this.btn_customerInfo.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_customerInfo.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.btn_customerInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_customerInfo.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customerInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_customerInfo.Location = new System.Drawing.Point(0, 0);
            this.btn_customerInfo.Name = "btn_customerInfo";
            this.btn_customerInfo.ShadowDecoration.Parent = this.btn_customerInfo;
            this.btn_customerInfo.Size = new System.Drawing.Size(1171, 525);
            this.btn_customerInfo.TabIndex = 15;
            this.btn_customerInfo.Text = "Thông tin tài khoản";
            // 
            // lb_accountRepassword
            // 
            this.lb_accountRepassword.AutoSize = false;
            this.lb_accountRepassword.BackColor = System.Drawing.Color.Transparent;
            this.lb_accountRepassword.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_accountRepassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_accountRepassword.Location = new System.Drawing.Point(731, 184);
            this.lb_accountRepassword.Name = "lb_accountRepassword";
            this.lb_accountRepassword.Size = new System.Drawing.Size(139, 25);
            this.lb_accountRepassword.TabIndex = 14;
            this.lb_accountRepassword.Text = "Nhập lại mật khẩu";
            // 
            // lb_accountPassword
            // 
            this.lb_accountPassword.AutoSize = false;
            this.lb_accountPassword.BackColor = System.Drawing.Color.Transparent;
            this.lb_accountPassword.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_accountPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_accountPassword.Location = new System.Drawing.Point(731, 112);
            this.lb_accountPassword.Name = "lb_accountPassword";
            this.lb_accountPassword.Size = new System.Drawing.Size(139, 25);
            this.lb_accountPassword.TabIndex = 14;
            this.lb_accountPassword.Text = "Mật khẩu";
            // 
            // lb_accountUsername
            // 
            this.lb_accountUsername.AutoSize = false;
            this.lb_accountUsername.BackColor = System.Drawing.Color.Transparent;
            this.lb_accountUsername.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_accountUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_accountUsername.Location = new System.Drawing.Point(731, 42);
            this.lb_accountUsername.Name = "lb_accountUsername";
            this.lb_accountUsername.Size = new System.Drawing.Size(241, 25);
            this.lb_accountUsername.TabIndex = 14;
            this.lb_accountUsername.Text = "Tên đăng nhập";
            // 
            // guna2TextBox3
            // 
            this.guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox3.DefaultText = "";
            this.guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.DisabledState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.guna2TextBox3.FocusedState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.guna2TextBox3.HoverState.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Location = new System.Drawing.Point(731, 211);
            this.guna2TextBox3.Margin = new System.Windows.Forms.Padding(21, 87, 21, 87);
            this.guna2TextBox3.Name = "guna2TextBox3";
            this.guna2TextBox3.PasswordChar = '\0';
            this.guna2TextBox3.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.guna2TextBox3.PlaceholderText = "";
            this.guna2TextBox3.SelectedText = "";
            this.guna2TextBox3.ShadowDecoration.Parent = this.guna2TextBox3;
            this.guna2TextBox3.Size = new System.Drawing.Size(289, 37);
            this.guna2TextBox3.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2TextBox3.TabIndex = 13;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.guna2TextBox2.FocusedState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.guna2TextBox2.HoverState.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Location = new System.Drawing.Point(731, 139);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(14, 45, 14, 45);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.ShadowDecoration.Parent = this.guna2TextBox2;
            this.guna2TextBox2.Size = new System.Drawing.Size(289, 37);
            this.guna2TextBox2.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2TextBox2.TabIndex = 13;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(731, 69);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(9, 23, 9, 23);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(289, 37);
            this.guna2TextBox1.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.guna2TextBox1.TabIndex = 13;
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
            this.guna2Button2.Location = new System.Drawing.Point(983, 434);
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
            this.btn_productDelete.Location = new System.Drawing.Point(1067, 434);
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
            this.btn_productSave.Location = new System.Drawing.Point(899, 434);
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
            this.btn_productUpdate.Location = new System.Drawing.Point(815, 434);
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
            this.btn_productAdd.Location = new System.Drawing.Point(731, 434);
            this.btn_productAdd.Name = "btn_productAdd";
            this.btn_productAdd.ShadowDecoration.Parent = this.btn_productAdd;
            this.btn_productAdd.Size = new System.Drawing.Size(75, 49);
            this.btn_productAdd.TabIndex = 38;
            this.btn_productAdd.Text = "Thêm";
            // 
            // us_accountUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn_customerInfo);
            this.Name = "us_accountUI";
            this.Size = new System.Drawing.Size(1171, 525);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_customerList)).EndInit();
            this.btn_customerInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cb_customerStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_accountStatus;
        private Guna.UI2.WinForms.Guna2TextBox txt_findAccount;
        private Guna.UI2.WinForms.Guna2TextBox txt_customerID;
        private Guna.UI2.WinForms.Guna2Button btn_findAccount;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_customerList;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_accountEmployeeID;
        private Guna.UI2.WinForms.Guna2GroupBox btn_customerInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_accountRepassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_accountPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_accountUsername;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btn_productDelete;
        private Guna.UI2.WinForms.Guna2Button btn_productSave;
        private Guna.UI2.WinForms.Guna2Button btn_productUpdate;
        private Guna.UI2.WinForms.Guna2Button btn_productAdd;
    }
}
