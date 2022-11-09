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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cb_customerStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lb_accountStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_findAccount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_customerID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_accountDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_accountUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btn_findAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btn_accountAdd = new Guna.UI2.WinForms.Guna2Button();
            this.dtgv_customerList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lb_accountEmployeeID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_customerInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lb_accountRepassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_accountPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_accountUsername = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2TextBox3 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_accountSave = new Guna.UI2.WinForms.Guna2Button();
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
            this.cb_customerStatus.Location = new System.Drawing.Point(950, 286);
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
            this.lb_accountStatus.Location = new System.Drawing.Point(950, 258);
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
            this.txt_findAccount.Location = new System.Drawing.Point(721, 370);
            this.txt_findAccount.Margin = new System.Windows.Forms.Padding(14, 72, 14, 72);
            this.txt_findAccount.Name = "txt_findAccount";
            this.txt_findAccount.PasswordChar = '\0';
            this.txt_findAccount.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.txt_findAccount.PlaceholderText = "";
            this.txt_findAccount.SelectedText = "";
            this.txt_findAccount.ShadowDecoration.Parent = this.txt_findAccount;
            this.txt_findAccount.Size = new System.Drawing.Size(258, 36);
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
            this.txt_customerID.Location = new System.Drawing.Point(721, 286);
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
            // btn_accountDelete
            // 
            this.btn_accountDelete.BackColor = System.Drawing.Color.Transparent;
            this.btn_accountDelete.BorderRadius = 5;
            this.btn_accountDelete.CheckedState.Parent = this.btn_accountDelete;
            this.btn_accountDelete.CustomImages.Parent = this.btn_accountDelete;
            this.btn_accountDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(65)))));
            this.btn_accountDelete.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accountDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_accountDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_accountDelete.HoverState.Parent = this.btn_accountDelete;
            this.btn_accountDelete.Location = new System.Drawing.Point(1037, 432);
            this.btn_accountDelete.Name = "btn_accountDelete";
            this.btn_accountDelete.ShadowDecoration.Parent = this.btn_accountDelete;
            this.btn_accountDelete.Size = new System.Drawing.Size(94, 49);
            this.btn_accountDelete.TabIndex = 5;
            this.btn_accountDelete.Text = "Xóa";
            // 
            // btn_accountUpdate
            // 
            this.btn_accountUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btn_accountUpdate.BorderRadius = 5;
            this.btn_accountUpdate.CheckedState.Parent = this.btn_accountUpdate;
            this.btn_accountUpdate.CustomImages.Parent = this.btn_accountUpdate;
            this.btn_accountUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_accountUpdate.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accountUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_accountUpdate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_accountUpdate.HoverState.Parent = this.btn_accountUpdate;
            this.btn_accountUpdate.Location = new System.Drawing.Point(832, 432);
            this.btn_accountUpdate.Name = "btn_accountUpdate";
            this.btn_accountUpdate.ShadowDecoration.Parent = this.btn_accountUpdate;
            this.btn_accountUpdate.Size = new System.Drawing.Size(105, 49);
            this.btn_accountUpdate.TabIndex = 5;
            this.btn_accountUpdate.Text = "Sửa";
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
            this.btn_findAccount.Location = new System.Drawing.Point(996, 368);
            this.btn_findAccount.Name = "btn_findAccount";
            this.btn_findAccount.ShadowDecoration.Parent = this.btn_findAccount;
            this.btn_findAccount.Size = new System.Drawing.Size(138, 41);
            this.btn_findAccount.TabIndex = 5;
            this.btn_findAccount.Text = "Tìm kiếm";
            // 
            // btn_accountAdd
            // 
            this.btn_accountAdd.BackColor = System.Drawing.Color.Transparent;
            this.btn_accountAdd.BorderRadius = 5;
            this.btn_accountAdd.CheckedState.Parent = this.btn_accountAdd;
            this.btn_accountAdd.CustomImages.Parent = this.btn_accountAdd;
            this.btn_accountAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_accountAdd.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accountAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_accountAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_accountAdd.HoverState.Parent = this.btn_accountAdd;
            this.btn_accountAdd.Location = new System.Drawing.Point(721, 432);
            this.btn_accountAdd.Name = "btn_accountAdd";
            this.btn_accountAdd.ShadowDecoration.Parent = this.btn_accountAdd;
            this.btn_accountAdd.Size = new System.Drawing.Size(105, 49);
            this.btn_accountAdd.TabIndex = 5;
            this.btn_accountAdd.Text = "Thêm";
            // 
            // dtgv_customerList
            // 
            this.dtgv_customerList.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgv_customerList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_customerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_customerList.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_customerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_customerList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_customerList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_customerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_customerList.ColumnHeadersHeight = 28;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_customerList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_customerList.EnableHeadersVisualStyles = false;
            this.dtgv_customerList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_customerList.Location = new System.Drawing.Point(20, 66);
            this.dtgv_customerList.Name = "dtgv_customerList";
            this.dtgv_customerList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_customerList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            this.lb_accountEmployeeID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.lb_accountEmployeeID.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_accountEmployeeID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_accountEmployeeID.Location = new System.Drawing.Point(721, 259);
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
            this.btn_customerInfo.Controls.Add(this.btn_accountDelete);
            this.btn_customerInfo.Controls.Add(this.btn_accountSave);
            this.btn_customerInfo.Controls.Add(this.btn_accountUpdate);
            this.btn_customerInfo.Controls.Add(this.btn_findAccount);
            this.btn_customerInfo.Controls.Add(this.btn_accountAdd);
            this.btn_customerInfo.Controls.Add(this.dtgv_customerList);
            this.btn_customerInfo.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_customerInfo.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.btn_customerInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
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
            this.lb_accountRepassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.lb_accountRepassword.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_accountRepassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_accountRepassword.Location = new System.Drawing.Point(721, 181);
            this.lb_accountRepassword.Name = "lb_accountRepassword";
            this.lb_accountRepassword.Size = new System.Drawing.Size(139, 25);
            this.lb_accountRepassword.TabIndex = 14;
            this.lb_accountRepassword.Text = "Nhập lại mật khẩu";
            // 
            // lb_accountPassword
            // 
            this.lb_accountPassword.AutoSize = false;
            this.lb_accountPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.lb_accountPassword.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_accountPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_accountPassword.Location = new System.Drawing.Point(721, 109);
            this.lb_accountPassword.Name = "lb_accountPassword";
            this.lb_accountPassword.Size = new System.Drawing.Size(139, 25);
            this.lb_accountPassword.TabIndex = 14;
            this.lb_accountPassword.Text = "Mật khẩu";
            // 
            // lb_accountUsername
            // 
            this.lb_accountUsername.AutoSize = false;
            this.lb_accountUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.lb_accountUsername.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_accountUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_accountUsername.Location = new System.Drawing.Point(721, 39);
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
            this.guna2TextBox3.Location = new System.Drawing.Point(721, 208);
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
            this.guna2TextBox2.Location = new System.Drawing.Point(721, 136);
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
            this.guna2TextBox1.Location = new System.Drawing.Point(721, 66);
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
            // btn_accountSave
            // 
            this.btn_accountSave.BackColor = System.Drawing.Color.Transparent;
            this.btn_accountSave.BorderRadius = 5;
            this.btn_accountSave.CheckedState.Parent = this.btn_accountSave;
            this.btn_accountSave.CustomImages.Parent = this.btn_accountSave;
            this.btn_accountSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_accountSave.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accountSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_accountSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_accountSave.HoverState.Parent = this.btn_accountSave;
            this.btn_accountSave.Location = new System.Drawing.Point(943, 432);
            this.btn_accountSave.Name = "btn_accountSave";
            this.btn_accountSave.ShadowDecoration.Parent = this.btn_accountSave;
            this.btn_accountSave.Size = new System.Drawing.Size(88, 49);
            this.btn_accountSave.TabIndex = 5;
            this.btn_accountSave.Text = "Lưu";
            // 
            // us_accountUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private Guna.UI2.WinForms.Guna2Button btn_accountDelete;
        private Guna.UI2.WinForms.Guna2Button btn_accountUpdate;
        private Guna.UI2.WinForms.Guna2Button btn_findAccount;
        private Guna.UI2.WinForms.Guna2Button btn_accountAdd;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_customerList;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_accountEmployeeID;
        private Guna.UI2.WinForms.Guna2GroupBox btn_customerInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_accountRepassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_accountPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_accountUsername;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button btn_accountSave;
    }
}
