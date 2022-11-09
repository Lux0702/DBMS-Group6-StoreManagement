namespace PrepareForFinal.UI
{
    partial class frm_main
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
            this.pn_navigation = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_logout = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pn_groupButton = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_showAccountUI = new Guna.UI2.WinForms.Guna2Button();
            this.btn_showSupplyUI = new Guna.UI2.WinForms.Guna2Button();
            this.btn_showStatistic = new Guna.UI2.WinForms.Guna2Button();
            this.btn_showEmployeeUI = new Guna.UI2.WinForms.Guna2Button();
            this.btn_showCustomerUI = new Guna.UI2.WinForms.Guna2Button();
            this.btn_showPaymentUI = new Guna.UI2.WinForms.Guna2Button();
            this.btn_showProductUI = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lb_header = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lb_notify = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pn_notify = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.us_employeeUI = new PrepareForFinal.UI.us_employeeUI();
            this.us_productUI = new PrepareForFinal.UI.us_productUI();
            this.us_customerUI = new PrepareForFinal.UI.us_customerUI();
            this.us_accountUI = new PrepareForFinal.UI.us_accountUI();
            this.pn_navigation.SuspendLayout();
            this.pn_groupButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_navigation
            // 
            this.pn_navigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.pn_navigation.Controls.Add(this.btn_logout);
            this.pn_navigation.Controls.Add(this.guna2HtmlLabel1);
            this.pn_navigation.Controls.Add(this.guna2HtmlLabel2);
            this.pn_navigation.Controls.Add(this.pn_groupButton);
            this.pn_navigation.Location = new System.Drawing.Point(-2, 54);
            this.pn_navigation.Name = "pn_navigation";
            this.pn_navigation.ShadowDecoration.Parent = this.pn_navigation;
            this.pn_navigation.Size = new System.Drawing.Size(1181, 84);
            this.pn_navigation.TabIndex = 19;
            // 
            // btn_logout
            // 
            this.btn_logout.BorderRadius = 5;
            this.btn_logout.CheckedState.Parent = this.btn_logout;
            this.btn_logout.CustomImages.Parent = this.btn_logout;
            this.btn_logout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(65)))));
            this.btn_logout.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_logout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_logout.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_logout.HoverState.Parent = this.btn_logout;
            this.btn_logout.Location = new System.Drawing.Point(1085, 19);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.ShadowDecoration.Parent = this.btn_logout;
            this.btn_logout.Size = new System.Drawing.Size(82, 41);
            this.btn_logout.TabIndex = 7;
            this.btn_logout.Text = "Thoát";
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(1006, 37);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(97, 29);
            this.guna2HtmlLabel1.TabIndex = 8;
            this.guna2HtmlLabel1.Text = "Quản lý";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(1006, 19);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(97, 29);
            this.guna2HtmlLabel2.TabIndex = 8;
            this.guna2HtmlLabel2.Text = "Admin1";
            // 
            // pn_groupButton
            // 
            this.pn_groupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_groupButton.BackColor = System.Drawing.Color.Transparent;
            this.pn_groupButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.pn_groupButton.BorderRadius = 5;
            this.pn_groupButton.BorderThickness = 2;
            this.pn_groupButton.Controls.Add(this.btn_showAccountUI);
            this.pn_groupButton.Controls.Add(this.btn_showSupplyUI);
            this.pn_groupButton.Controls.Add(this.btn_showStatistic);
            this.pn_groupButton.Controls.Add(this.btn_showEmployeeUI);
            this.pn_groupButton.Controls.Add(this.btn_showCustomerUI);
            this.pn_groupButton.Controls.Add(this.btn_showPaymentUI);
            this.pn_groupButton.Controls.Add(this.btn_showProductUI);
            this.pn_groupButton.Location = new System.Drawing.Point(14, 19);
            this.pn_groupButton.Name = "pn_groupButton";
            this.pn_groupButton.ShadowDecoration.Parent = this.pn_groupButton;
            this.pn_groupButton.Size = new System.Drawing.Size(970, 50);
            this.pn_groupButton.TabIndex = 5;
            // 
            // btn_showAccountUI
            // 
            this.btn_showAccountUI.BorderRadius = 5;
            this.btn_showAccountUI.CheckedState.Parent = this.btn_showAccountUI;
            this.btn_showAccountUI.CustomImages.Parent = this.btn_showAccountUI;
            this.btn_showAccountUI.FillColor = System.Drawing.Color.Transparent;
            this.btn_showAccountUI.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showAccountUI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_showAccountUI.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_showAccountUI.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_showAccountUI.HoverState.Parent = this.btn_showAccountUI;
            this.btn_showAccountUI.Location = new System.Drawing.Point(809, 6);
            this.btn_showAccountUI.Name = "btn_showAccountUI";
            this.btn_showAccountUI.ShadowDecoration.Parent = this.btn_showAccountUI;
            this.btn_showAccountUI.Size = new System.Drawing.Size(146, 38);
            this.btn_showAccountUI.TabIndex = 0;
            this.btn_showAccountUI.Text = "Tài khoản";
            this.btn_showAccountUI.Click += new System.EventHandler(this.btn_showAccountUI_Click);
            // 
            // btn_showSupplyUI
            // 
            this.btn_showSupplyUI.BorderRadius = 5;
            this.btn_showSupplyUI.CheckedState.Parent = this.btn_showSupplyUI;
            this.btn_showSupplyUI.CustomImages.Parent = this.btn_showSupplyUI;
            this.btn_showSupplyUI.FillColor = System.Drawing.Color.Transparent;
            this.btn_showSupplyUI.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showSupplyUI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_showSupplyUI.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_showSupplyUI.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_showSupplyUI.HoverState.Parent = this.btn_showSupplyUI;
            this.btn_showSupplyUI.Location = new System.Drawing.Point(669, 6);
            this.btn_showSupplyUI.Name = "btn_showSupplyUI";
            this.btn_showSupplyUI.ShadowDecoration.Parent = this.btn_showSupplyUI;
            this.btn_showSupplyUI.Size = new System.Drawing.Size(143, 38);
            this.btn_showSupplyUI.TabIndex = 0;
            this.btn_showSupplyUI.Text = "Nhà cung cấp";
            // 
            // btn_showStatistic
            // 
            this.btn_showStatistic.BorderRadius = 5;
            this.btn_showStatistic.CheckedState.Parent = this.btn_showStatistic;
            this.btn_showStatistic.CustomImages.Parent = this.btn_showStatistic;
            this.btn_showStatistic.FillColor = System.Drawing.Color.Transparent;
            this.btn_showStatistic.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showStatistic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_showStatistic.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_showStatistic.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_showStatistic.HoverState.Parent = this.btn_showStatistic;
            this.btn_showStatistic.Location = new System.Drawing.Point(534, 6);
            this.btn_showStatistic.Name = "btn_showStatistic";
            this.btn_showStatistic.ShadowDecoration.Parent = this.btn_showStatistic;
            this.btn_showStatistic.Size = new System.Drawing.Size(138, 38);
            this.btn_showStatistic.TabIndex = 0;
            this.btn_showStatistic.Text = "Thống kê";
            // 
            // btn_showEmployeeUI
            // 
            this.btn_showEmployeeUI.BorderRadius = 5;
            this.btn_showEmployeeUI.CheckedState.Parent = this.btn_showEmployeeUI;
            this.btn_showEmployeeUI.CustomImages.Parent = this.btn_showEmployeeUI;
            this.btn_showEmployeeUI.FillColor = System.Drawing.Color.Transparent;
            this.btn_showEmployeeUI.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showEmployeeUI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_showEmployeeUI.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_showEmployeeUI.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_showEmployeeUI.HoverState.Parent = this.btn_showEmployeeUI;
            this.btn_showEmployeeUI.Location = new System.Drawing.Point(403, 6);
            this.btn_showEmployeeUI.Name = "btn_showEmployeeUI";
            this.btn_showEmployeeUI.ShadowDecoration.Parent = this.btn_showEmployeeUI;
            this.btn_showEmployeeUI.Size = new System.Drawing.Size(132, 38);
            this.btn_showEmployeeUI.TabIndex = 0;
            this.btn_showEmployeeUI.Text = "Nhân viên";
            this.btn_showEmployeeUI.Click += new System.EventHandler(this.btn_showEmployeeUI_Click);
            // 
            // btn_showCustomerUI
            // 
            this.btn_showCustomerUI.BorderRadius = 5;
            this.btn_showCustomerUI.CheckedState.Parent = this.btn_showCustomerUI;
            this.btn_showCustomerUI.CustomImages.Parent = this.btn_showCustomerUI;
            this.btn_showCustomerUI.FillColor = System.Drawing.Color.Transparent;
            this.btn_showCustomerUI.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showCustomerUI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_showCustomerUI.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_showCustomerUI.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_showCustomerUI.HoverState.Parent = this.btn_showCustomerUI;
            this.btn_showCustomerUI.Location = new System.Drawing.Point(268, 6);
            this.btn_showCustomerUI.Name = "btn_showCustomerUI";
            this.btn_showCustomerUI.ShadowDecoration.Parent = this.btn_showCustomerUI;
            this.btn_showCustomerUI.Size = new System.Drawing.Size(129, 38);
            this.btn_showCustomerUI.TabIndex = 0;
            this.btn_showCustomerUI.Text = "Khách hàng";
            this.btn_showCustomerUI.Click += new System.EventHandler(this.btn_showCustomerUI_Click);
            // 
            // btn_showPaymentUI
            // 
            this.btn_showPaymentUI.BackColor = System.Drawing.Color.Transparent;
            this.btn_showPaymentUI.BorderRadius = 5;
            this.btn_showPaymentUI.CheckedState.Parent = this.btn_showPaymentUI;
            this.btn_showPaymentUI.CustomImages.Parent = this.btn_showPaymentUI;
            this.btn_showPaymentUI.FillColor = System.Drawing.Color.Transparent;
            this.btn_showPaymentUI.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showPaymentUI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_showPaymentUI.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_showPaymentUI.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_showPaymentUI.HoverState.Parent = this.btn_showPaymentUI;
            this.btn_showPaymentUI.Location = new System.Drawing.Point(6, 6);
            this.btn_showPaymentUI.Name = "btn_showPaymentUI";
            this.btn_showPaymentUI.ShadowDecoration.Parent = this.btn_showPaymentUI;
            this.btn_showPaymentUI.Size = new System.Drawing.Size(140, 38);
            this.btn_showPaymentUI.TabIndex = 0;
            this.btn_showPaymentUI.Text = "Thanh toán";
            this.btn_showPaymentUI.Click += new System.EventHandler(this.btn_showPaymentUI_Click);
            // 
            // btn_showProductUI
            // 
            this.btn_showProductUI.BorderRadius = 5;
            this.btn_showProductUI.CheckedState.Parent = this.btn_showProductUI;
            this.btn_showProductUI.CustomImages.Parent = this.btn_showProductUI;
            this.btn_showProductUI.FillColor = System.Drawing.Color.Transparent;
            this.btn_showProductUI.Font = new System.Drawing.Font("DVN-Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showProductUI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(94)))), ((int)(((byte)(111)))));
            this.btn_showProductUI.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.btn_showProductUI.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.btn_showProductUI.HoverState.Parent = this.btn_showProductUI;
            this.btn_showProductUI.Location = new System.Drawing.Point(146, 6);
            this.btn_showProductUI.Name = "btn_showProductUI";
            this.btn_showProductUI.ShadowDecoration.Parent = this.btn_showProductUI;
            this.btn_showProductUI.Size = new System.Drawing.Size(116, 38);
            this.btn_showProductUI.TabIndex = 0;
            this.btn_showProductUI.Text = "Mặt hàng";
            this.btn_showProductUI.Click += new System.EventHandler(this.btn_showProductUI_Click);
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
            this.guna2ControlBox1.TabIndex = 18;
            // 
            // lb_header
            // 
            this.lb_header.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_header.AutoSize = false;
            this.lb_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.lb_header.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.lb_header.Location = new System.Drawing.Point(0, 0);
            this.lb_header.Name = "lb_header";
            this.lb_header.Size = new System.Drawing.Size(1179, 54);
            this.lb_header.TabIndex = 17;
            this.lb_header.Text = "-   Hệ thống quản lý cửa hàng";
            this.lb_header.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_notify
            // 
            this.lb_notify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_notify.AutoSize = false;
            this.lb_notify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.lb_notify.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_notify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.lb_notify.Location = new System.Drawing.Point(152, 7);
            this.lb_notify.Name = "lb_notify";
            this.lb_notify.Size = new System.Drawing.Size(1191, 531);
            this.lb_notify.TabIndex = 0;
            this.lb_notify.Text = "WELCOME";
            this.lb_notify.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn_notify
            // 
            this.pn_notify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_notify.AutoSize = false;
            this.pn_notify.BackColor = System.Drawing.Color.Transparent;
            this.pn_notify.Font = new System.Drawing.Font("DVN-Poppins ExtBd", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_notify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(239)))), ((int)(((byte)(214)))));
            this.pn_notify.Location = new System.Drawing.Point(0, 301);
            this.pn_notify.Name = "pn_notify";
            this.pn_notify.Size = new System.Drawing.Size(1177, 67);
            this.pn_notify.TabIndex = 20;
            this.pn_notify.Text = "WELCOME";
            this.pn_notify.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // us_employeeUI
            // 
            this.us_employeeUI.BackColor = System.Drawing.Color.Transparent;
            this.us_employeeUI.Location = new System.Drawing.Point(0, 139);
            this.us_employeeUI.Name = "us_employeeUI";
            this.us_employeeUI.Size = new System.Drawing.Size(1177, 531);
            this.us_employeeUI.TabIndex = 21;
            // 
            // us_productUI
            // 
            this.us_productUI.BackColor = System.Drawing.Color.Transparent;
            this.us_productUI.Location = new System.Drawing.Point(0, 140);
            this.us_productUI.Name = "us_productUI";
            this.us_productUI.Size = new System.Drawing.Size(1177, 531);
            this.us_productUI.TabIndex = 1;
            this.us_productUI.Load += new System.EventHandler(this.us_productUI1_Load);
            // 
            // us_customerUI
            // 
            this.us_customerUI.BackColor = System.Drawing.Color.Transparent;
            this.us_customerUI.Location = new System.Drawing.Point(3, 140);
            this.us_customerUI.Name = "us_customerUI";
            this.us_customerUI.Size = new System.Drawing.Size(1171, 525);
            this.us_customerUI.TabIndex = 22;
            // 
            // us_accountUI
            // 
            this.us_accountUI.Location = new System.Drawing.Point(3, 140);
            this.us_accountUI.Name = "us_accountUI";
            this.us_accountUI.Size = new System.Drawing.Size(1171, 525);
            this.us_accountUI.TabIndex = 1;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(1177, 668);
            this.Controls.Add(this.pn_navigation);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.lb_header);
            this.Controls.Add(this.us_productUI);
            this.Controls.Add(this.us_customerUI);
            this.Controls.Add(this.us_accountUI);
            this.Controls.Add(this.us_employeeUI);
            this.Controls.Add(this.pn_notify);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý cửa hàng";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.pn_navigation.ResumeLayout(false);
            this.pn_groupButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel pn_navigation;
        private Guna.UI2.WinForms.Guna2Button btn_logout;
        private Guna.UI2.WinForms.Guna2Panel pn_groupButton;
        private Guna.UI2.WinForms.Guna2Button btn_showSupplyUI;
        private Guna.UI2.WinForms.Guna2Button btn_showStatistic;
        private Guna.UI2.WinForms.Guna2Button btn_showEmployeeUI;
        private Guna.UI2.WinForms.Guna2Button btn_showCustomerUI;
        private Guna.UI2.WinForms.Guna2Button btn_showPaymentUI;
        private Guna.UI2.WinForms.Guna2Button btn_showProductUI;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_header;
        private us_productUI us_productUI;
        private Guna.UI2.WinForms.Guna2HtmlLabel lb_notify;
        private Guna.UI2.WinForms.Guna2HtmlLabel pn_notify;
        private Guna.UI2.WinForms.Guna2Button btn_showAccountUI;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private us_employeeUI us_employeeUI;
        private us_customerUI us_customerUI;
        private us_accountUI us_accountUI;
    }
}