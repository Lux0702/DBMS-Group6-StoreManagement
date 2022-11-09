namespace PrepareForFinal.UI
{
    partial class us_supplyUI
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
            this.lb_productID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_supplyAddress = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_supplyID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cb_supplyStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lb_supplyStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_findSupply = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_productID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_supplyAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_supplyID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_findSupply = new Guna.UI2.WinForms.Guna2Button();
            this.btn_supplyInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txt_supplyName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_supplyName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_supplyPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_supplyPhone = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtgv_supplyList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_supplyDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_supplySave = new Guna.UI2.WinForms.Guna2Button();
            this.btn_supplyUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btn_supplyAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btn_supplyInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_supplyList)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_productID
            // 
            this.lb_productID.AutoSize = false;
            this.lb_productID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.lb_productID.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_productID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_productID.Location = new System.Drawing.Point(959, 39);
            this.lb_productID.Name = "lb_productID";
            this.lb_productID.Size = new System.Drawing.Size(255, 25);
            this.lb_productID.TabIndex = 14;
            this.lb_productID.Text = "Mã sản phẩm";
            // 
            // lb_supplyAddress
            // 
            this.lb_supplyAddress.AutoSize = false;
            this.lb_supplyAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.lb_supplyAddress.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_supplyAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_supplyAddress.Location = new System.Drawing.Point(721, 111);
            this.lb_supplyAddress.Name = "lb_supplyAddress";
            this.lb_supplyAddress.Size = new System.Drawing.Size(139, 25);
            this.lb_supplyAddress.TabIndex = 14;
            this.lb_supplyAddress.Text = "Địa chỉ";
            // 
            // lb_supplyID
            // 
            this.lb_supplyID.AutoSize = false;
            this.lb_supplyID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.lb_supplyID.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_supplyID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_supplyID.Location = new System.Drawing.Point(721, 39);
            this.lb_supplyID.Name = "lb_supplyID";
            this.lb_supplyID.Size = new System.Drawing.Size(191, 25);
            this.lb_supplyID.TabIndex = 14;
            this.lb_supplyID.Text = "Mã nhà sản xuất";
            // 
            // cb_supplyStatus
            // 
            this.cb_supplyStatus.BackColor = System.Drawing.Color.Transparent;
            this.cb_supplyStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_supplyStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_supplyStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cb_supplyStatus.FocusedState.Parent = this.cb_supplyStatus;
            this.cb_supplyStatus.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_supplyStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.cb_supplyStatus.FormattingEnabled = true;
            this.cb_supplyStatus.HoverState.Parent = this.cb_supplyStatus;
            this.cb_supplyStatus.ItemHeight = 30;
            this.cb_supplyStatus.Items.AddRange(new object[] {
            "Using",
            "Deleted"});
            this.cb_supplyStatus.ItemsAppearance.Parent = this.cb_supplyStatus;
            this.cb_supplyStatus.Location = new System.Drawing.Point(950, 285);
            this.cb_supplyStatus.Name = "cb_supplyStatus";
            this.cb_supplyStatus.ShadowDecoration.Parent = this.cb_supplyStatus;
            this.cb_supplyStatus.Size = new System.Drawing.Size(183, 36);
            this.cb_supplyStatus.TabIndex = 22;
            // 
            // lb_supplyStatus
            // 
            this.lb_supplyStatus.AutoSize = false;
            this.lb_supplyStatus.BackColor = System.Drawing.Color.Transparent;
            this.lb_supplyStatus.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_supplyStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_supplyStatus.Location = new System.Drawing.Point(950, 253);
            this.lb_supplyStatus.Name = "lb_supplyStatus";
            this.lb_supplyStatus.Size = new System.Drawing.Size(183, 28);
            this.lb_supplyStatus.TabIndex = 21;
            this.lb_supplyStatus.Text = "Tình trạng";
            // 
            // txt_findSupply
            // 
            this.txt_findSupply.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_findSupply.DefaultText = "";
            this.txt_findSupply.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_findSupply.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_findSupply.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_findSupply.DisabledState.Parent = this.txt_findSupply;
            this.txt_findSupply.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_findSupply.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_findSupply.FocusedState.Parent = this.txt_findSupply;
            this.txt_findSupply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_findSupply.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_findSupply.HoverState.Parent = this.txt_findSupply;
            this.txt_findSupply.Location = new System.Drawing.Point(721, 370);
            this.txt_findSupply.Margin = new System.Windows.Forms.Padding(14, 72, 14, 72);
            this.txt_findSupply.Name = "txt_findSupply";
            this.txt_findSupply.PasswordChar = '\0';
            this.txt_findSupply.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.txt_findSupply.PlaceholderText = "";
            this.txt_findSupply.SelectedText = "";
            this.txt_findSupply.ShadowDecoration.Parent = this.txt_findSupply;
            this.txt_findSupply.Size = new System.Drawing.Size(258, 36);
            this.txt_findSupply.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_findSupply.TabIndex = 12;
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
            this.txt_productID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_productID.FocusedState.Parent = this.txt_productID;
            this.txt_productID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_productID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_productID.HoverState.Parent = this.txt_productID;
            this.txt_productID.Location = new System.Drawing.Point(959, 66);
            this.txt_productID.Margin = new System.Windows.Forms.Padding(21, 87, 21, 87);
            this.txt_productID.Name = "txt_productID";
            this.txt_productID.PasswordChar = '\0';
            this.txt_productID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.txt_productID.PlaceholderText = "";
            this.txt_productID.SelectedText = "";
            this.txt_productID.ShadowDecoration.Parent = this.txt_productID;
            this.txt_productID.Size = new System.Drawing.Size(174, 37);
            this.txt_productID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_productID.TabIndex = 13;
            // 
            // txt_supplyAddress
            // 
            this.txt_supplyAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_supplyAddress.DefaultText = "";
            this.txt_supplyAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_supplyAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_supplyAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_supplyAddress.DisabledState.Parent = this.txt_supplyAddress;
            this.txt_supplyAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_supplyAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_supplyAddress.FocusedState.Parent = this.txt_supplyAddress;
            this.txt_supplyAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_supplyAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_supplyAddress.HoverState.Parent = this.txt_supplyAddress;
            this.txt_supplyAddress.Location = new System.Drawing.Point(721, 139);
            this.txt_supplyAddress.Margin = new System.Windows.Forms.Padding(14, 45, 14, 45);
            this.txt_supplyAddress.Name = "txt_supplyAddress";
            this.txt_supplyAddress.PasswordChar = '\0';
            this.txt_supplyAddress.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.txt_supplyAddress.PlaceholderText = "";
            this.txt_supplyAddress.SelectedText = "";
            this.txt_supplyAddress.ShadowDecoration.Parent = this.txt_supplyAddress;
            this.txt_supplyAddress.Size = new System.Drawing.Size(203, 37);
            this.txt_supplyAddress.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_supplyAddress.TabIndex = 13;
            // 
            // txt_supplyID
            // 
            this.txt_supplyID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_supplyID.DefaultText = "";
            this.txt_supplyID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_supplyID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_supplyID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_supplyID.DisabledState.Parent = this.txt_supplyID;
            this.txt_supplyID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_supplyID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_supplyID.FocusedState.Parent = this.txt_supplyID;
            this.txt_supplyID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_supplyID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_supplyID.HoverState.Parent = this.txt_supplyID;
            this.txt_supplyID.Location = new System.Drawing.Point(721, 66);
            this.txt_supplyID.Margin = new System.Windows.Forms.Padding(9, 23, 9, 23);
            this.txt_supplyID.Name = "txt_supplyID";
            this.txt_supplyID.PasswordChar = '\0';
            this.txt_supplyID.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.txt_supplyID.PlaceholderText = "";
            this.txt_supplyID.SelectedText = "";
            this.txt_supplyID.ShadowDecoration.Parent = this.txt_supplyID;
            this.txt_supplyID.Size = new System.Drawing.Size(203, 37);
            this.txt_supplyID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_supplyID.TabIndex = 13;
            // 
            // btn_findSupply
            // 
            this.btn_findSupply.BackColor = System.Drawing.Color.Transparent;
            this.btn_findSupply.BorderRadius = 5;
            this.btn_findSupply.CheckedState.Parent = this.btn_findSupply;
            this.btn_findSupply.CustomImages.Parent = this.btn_findSupply;
            this.btn_findSupply.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_findSupply.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_findSupply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_findSupply.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_findSupply.HoverState.Parent = this.btn_findSupply;
            this.btn_findSupply.Location = new System.Drawing.Point(996, 368);
            this.btn_findSupply.Name = "btn_findSupply";
            this.btn_findSupply.ShadowDecoration.Parent = this.btn_findSupply;
            this.btn_findSupply.Size = new System.Drawing.Size(138, 41);
            this.btn_findSupply.TabIndex = 5;
            this.btn_findSupply.Text = "Tìm kiếm";
            // 
            // btn_supplyInfo
            // 
            this.btn_supplyInfo.BackColor = System.Drawing.Color.Transparent;
            this.btn_supplyInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_supplyInfo.BorderRadius = 5;
            this.btn_supplyInfo.BorderThickness = 2;
            this.btn_supplyInfo.Controls.Add(this.btn_supplyDelete);
            this.btn_supplyInfo.Controls.Add(this.btn_supplySave);
            this.btn_supplyInfo.Controls.Add(this.btn_supplyUpdate);
            this.btn_supplyInfo.Controls.Add(this.btn_supplyAdd);
            this.btn_supplyInfo.Controls.Add(this.dtgv_supplyList);
            this.btn_supplyInfo.Controls.Add(this.lb_productID);
            this.btn_supplyInfo.Controls.Add(this.lb_supplyPhone);
            this.btn_supplyInfo.Controls.Add(this.lb_supplyAddress);
            this.btn_supplyInfo.Controls.Add(this.lb_supplyName);
            this.btn_supplyInfo.Controls.Add(this.lb_supplyID);
            this.btn_supplyInfo.Controls.Add(this.cb_supplyStatus);
            this.btn_supplyInfo.Controls.Add(this.lb_supplyStatus);
            this.btn_supplyInfo.Controls.Add(this.txt_findSupply);
            this.btn_supplyInfo.Controls.Add(this.txt_productID);
            this.btn_supplyInfo.Controls.Add(this.txt_supplyPhone);
            this.btn_supplyInfo.Controls.Add(this.txt_supplyAddress);
            this.btn_supplyInfo.Controls.Add(this.txt_supplyName);
            this.btn_supplyInfo.Controls.Add(this.txt_supplyID);
            this.btn_supplyInfo.Controls.Add(this.btn_findSupply);
            this.btn_supplyInfo.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_supplyInfo.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.btn_supplyInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.btn_supplyInfo.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supplyInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_supplyInfo.Location = new System.Drawing.Point(3, 3);
            this.btn_supplyInfo.Name = "btn_supplyInfo";
            this.btn_supplyInfo.ShadowDecoration.Parent = this.btn_supplyInfo;
            this.btn_supplyInfo.Size = new System.Drawing.Size(1171, 525);
            this.btn_supplyInfo.TabIndex = 16;
            this.btn_supplyInfo.Text = "Thông tin nhà sản xuất";
            // 
            // txt_supplyName
            // 
            this.txt_supplyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_supplyName.DefaultText = "";
            this.txt_supplyName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_supplyName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_supplyName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_supplyName.DisabledState.Parent = this.txt_supplyName;
            this.txt_supplyName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_supplyName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_supplyName.FocusedState.Parent = this.txt_supplyName;
            this.txt_supplyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_supplyName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_supplyName.HoverState.Parent = this.txt_supplyName;
            this.txt_supplyName.Location = new System.Drawing.Point(721, 212);
            this.txt_supplyName.Margin = new System.Windows.Forms.Padding(14, 45, 14, 45);
            this.txt_supplyName.Name = "txt_supplyName";
            this.txt_supplyName.PasswordChar = '\0';
            this.txt_supplyName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.txt_supplyName.PlaceholderText = "";
            this.txt_supplyName.SelectedText = "";
            this.txt_supplyName.ShadowDecoration.Parent = this.txt_supplyName;
            this.txt_supplyName.Size = new System.Drawing.Size(412, 37);
            this.txt_supplyName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_supplyName.TabIndex = 13;
            // 
            // lb_supplyName
            // 
            this.lb_supplyName.AutoSize = false;
            this.lb_supplyName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.lb_supplyName.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_supplyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_supplyName.Location = new System.Drawing.Point(721, 183);
            this.lb_supplyName.Name = "lb_supplyName";
            this.lb_supplyName.Size = new System.Drawing.Size(225, 25);
            this.lb_supplyName.TabIndex = 14;
            this.lb_supplyName.Text = "Tên nhà sản xuất";
            // 
            // txt_supplyPhone
            // 
            this.txt_supplyPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_supplyPhone.DefaultText = "";
            this.txt_supplyPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_supplyPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_supplyPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_supplyPhone.DisabledState.Parent = this.txt_supplyPhone;
            this.txt_supplyPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_supplyPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_supplyPhone.FocusedState.Parent = this.txt_supplyPhone;
            this.txt_supplyPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_supplyPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.txt_supplyPhone.HoverState.Parent = this.txt_supplyPhone;
            this.txt_supplyPhone.Location = new System.Drawing.Point(959, 139);
            this.txt_supplyPhone.Margin = new System.Windows.Forms.Padding(21, 87, 21, 87);
            this.txt_supplyPhone.Name = "txt_supplyPhone";
            this.txt_supplyPhone.PasswordChar = '\0';
            this.txt_supplyPhone.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.txt_supplyPhone.PlaceholderText = "";
            this.txt_supplyPhone.SelectedText = "";
            this.txt_supplyPhone.ShadowDecoration.Parent = this.txt_supplyPhone;
            this.txt_supplyPhone.Size = new System.Drawing.Size(174, 37);
            this.txt_supplyPhone.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_supplyPhone.TabIndex = 13;
            // 
            // lb_supplyPhone
            // 
            this.lb_supplyPhone.AutoSize = false;
            this.lb_supplyPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.lb_supplyPhone.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_supplyPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_supplyPhone.Location = new System.Drawing.Point(959, 111);
            this.lb_supplyPhone.Name = "lb_supplyPhone";
            this.lb_supplyPhone.Size = new System.Drawing.Size(139, 25);
            this.lb_supplyPhone.TabIndex = 14;
            this.lb_supplyPhone.Text = "Điện thoại";
            // 
            // dtgv_supplyList
            // 
            this.dtgv_supplyList.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgv_supplyList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_supplyList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv_supplyList.BackgroundColor = System.Drawing.Color.White;
            this.dtgv_supplyList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgv_supplyList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_supplyList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_supplyList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_supplyList.ColumnHeadersHeight = 28;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_supplyList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv_supplyList.EnableHeadersVisualStyles = false;
            this.dtgv_supplyList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_supplyList.Location = new System.Drawing.Point(15, 64);
            this.dtgv_supplyList.Name = "dtgv_supplyList";
            this.dtgv_supplyList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_supplyList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgv_supplyList.RowHeadersVisible = false;
            this.dtgv_supplyList.RowHeadersWidth = 51;
            this.dtgv_supplyList.RowTemplate.Height = 24;
            this.dtgv_supplyList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_supplyList.Size = new System.Drawing.Size(689, 417);
            this.dtgv_supplyList.TabIndex = 23;
            this.dtgv_supplyList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgv_supplyList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_supplyList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgv_supplyList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgv_supplyList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgv_supplyList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgv_supplyList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_supplyList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_supplyList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.dtgv_supplyList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgv_supplyList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_supplyList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.dtgv_supplyList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgv_supplyList.ThemeStyle.HeaderStyle.Height = 28;
            this.dtgv_supplyList.ThemeStyle.ReadOnly = true;
            this.dtgv_supplyList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv_supplyList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv_supplyList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_supplyList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.dtgv_supplyList.ThemeStyle.RowsStyle.Height = 24;
            this.dtgv_supplyList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv_supplyList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btn_supplyDelete
            // 
            this.btn_supplyDelete.BackColor = System.Drawing.Color.Transparent;
            this.btn_supplyDelete.BorderRadius = 5;
            this.btn_supplyDelete.CheckedState.Parent = this.btn_supplyDelete;
            this.btn_supplyDelete.CustomImages.Parent = this.btn_supplyDelete;
            this.btn_supplyDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(65)))));
            this.btn_supplyDelete.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supplyDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_supplyDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_supplyDelete.HoverState.Parent = this.btn_supplyDelete;
            this.btn_supplyDelete.Location = new System.Drawing.Point(1037, 432);
            this.btn_supplyDelete.Name = "btn_supplyDelete";
            this.btn_supplyDelete.ShadowDecoration.Parent = this.btn_supplyDelete;
            this.btn_supplyDelete.Size = new System.Drawing.Size(94, 49);
            this.btn_supplyDelete.TabIndex = 27;
            this.btn_supplyDelete.Text = "Xóa";
            // 
            // btn_supplySave
            // 
            this.btn_supplySave.BackColor = System.Drawing.Color.Transparent;
            this.btn_supplySave.BorderRadius = 5;
            this.btn_supplySave.CheckedState.Parent = this.btn_supplySave;
            this.btn_supplySave.CustomImages.Parent = this.btn_supplySave;
            this.btn_supplySave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_supplySave.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supplySave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_supplySave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_supplySave.HoverState.Parent = this.btn_supplySave;
            this.btn_supplySave.Location = new System.Drawing.Point(943, 432);
            this.btn_supplySave.Name = "btn_supplySave";
            this.btn_supplySave.ShadowDecoration.Parent = this.btn_supplySave;
            this.btn_supplySave.Size = new System.Drawing.Size(88, 49);
            this.btn_supplySave.TabIndex = 28;
            this.btn_supplySave.Text = "Lưu";
            // 
            // btn_supplyUpdate
            // 
            this.btn_supplyUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btn_supplyUpdate.BorderRadius = 5;
            this.btn_supplyUpdate.CheckedState.Parent = this.btn_supplyUpdate;
            this.btn_supplyUpdate.CustomImages.Parent = this.btn_supplyUpdate;
            this.btn_supplyUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_supplyUpdate.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supplyUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_supplyUpdate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_supplyUpdate.HoverState.Parent = this.btn_supplyUpdate;
            this.btn_supplyUpdate.Location = new System.Drawing.Point(832, 432);
            this.btn_supplyUpdate.Name = "btn_supplyUpdate";
            this.btn_supplyUpdate.ShadowDecoration.Parent = this.btn_supplyUpdate;
            this.btn_supplyUpdate.Size = new System.Drawing.Size(105, 49);
            this.btn_supplyUpdate.TabIndex = 29;
            this.btn_supplyUpdate.Text = "Sửa";
            // 
            // btn_supplyAdd
            // 
            this.btn_supplyAdd.BackColor = System.Drawing.Color.Transparent;
            this.btn_supplyAdd.BorderRadius = 5;
            this.btn_supplyAdd.CheckedState.Parent = this.btn_supplyAdd;
            this.btn_supplyAdd.CustomImages.Parent = this.btn_supplyAdd;
            this.btn_supplyAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_supplyAdd.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supplyAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_supplyAdd.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_supplyAdd.HoverState.Parent = this.btn_supplyAdd;
            this.btn_supplyAdd.Location = new System.Drawing.Point(721, 432);
            this.btn_supplyAdd.Name = "btn_supplyAdd";
            this.btn_supplyAdd.ShadowDecoration.Parent = this.btn_supplyAdd;
            this.btn_supplyAdd.Size = new System.Drawing.Size(105, 49);
            this.btn_supplyAdd.TabIndex = 30;
            this.btn_supplyAdd.Text = "Thêm";
            // 
            // us_supplyUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_supplyInfo);
            this.Name = "us_supplyUI";
            this.Size = new System.Drawing.Size(1177, 531);
            this.btn_supplyInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_supplyList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lb_productID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_supplyAddress;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_supplyID;
        private Guna.UI2.WinForms.Guna2ComboBox cb_supplyStatus;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_supplyStatus;
        private Guna.UI2.WinForms.Guna2TextBox txt_findSupply;
        private Guna.UI2.WinForms.Guna2TextBox txt_productID;
        private Guna.UI2.WinForms.Guna2TextBox txt_supplyAddress;
        private Guna.UI2.WinForms.Guna2TextBox txt_supplyID;
        private Guna.UI2.WinForms.Guna2Button btn_findSupply;
        private Guna.UI2.WinForms.Guna2GroupBox btn_supplyInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_supplyPhone;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_supplyName;
        private Guna.UI2.WinForms.Guna2TextBox txt_supplyPhone;
        private Guna.UI2.WinForms.Guna2TextBox txt_supplyName;
        private Guna.UI2.WinForms.Guna2DataGridView dtgv_supplyList;
        private Guna.UI2.WinForms.Guna2Button btn_supplyDelete;
        private Guna.UI2.WinForms.Guna2Button btn_supplySave;
        private Guna.UI2.WinForms.Guna2Button btn_supplyUpdate;
        private Guna.UI2.WinForms.Guna2Button btn_supplyAdd;
    }
}
