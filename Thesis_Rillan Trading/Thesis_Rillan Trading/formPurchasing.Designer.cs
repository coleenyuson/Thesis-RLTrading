namespace Thesis_Rillan_Trading
{
    partial class formPurchasing
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
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.pnl_window = new System.Windows.Forms.Panel();
            this.pnl_sideMenu = new System.Windows.Forms.Panel();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.btn_itemMasterList = new System.Windows.Forms.Button();
            this.btn_stockTransfer = new System.Windows.Forms.Button();
            this.btn_inventoryData = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_itemInvStatus = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_grpo = new System.Windows.Forms.Button();
            this.btn_back_1 = new System.Windows.Forms.Button();
            this.pnl_Footer = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_DateTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userCon_itemsPurchasing1 = new Thesis_Rillan_Trading.userCon_itemsPurchasing();
            this.userCon_GRPO1 = new Thesis_Rillan_Trading.userCon_GRPO();
            this.pnl_Header.SuspendLayout();
            this.pnl_sideMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_Footer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Header.BackColor = System.Drawing.Color.Teal;
            this.pnl_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Header.Controls.Add(this.pnl_window);
            this.pnl_Header.Controls.Add(this.pnl_sideMenu);
            this.pnl_Header.Controls.Add(this.label2);
            this.pnl_Header.Controls.Add(this.btn_Settings);
            this.pnl_Header.Controls.Add(this.btn_Logout);
            this.pnl_Header.ForeColor = System.Drawing.Color.SteelBlue;
            this.pnl_Header.Location = new System.Drawing.Point(-4, -1);
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1290, 53);
            this.pnl_Header.TabIndex = 22;
            // 
            // pnl_window
            // 
            this.pnl_window.Location = new System.Drawing.Point(274, 56);
            this.pnl_window.Name = "pnl_window";
            this.pnl_window.Size = new System.Drawing.Size(1091, 612);
            this.pnl_window.TabIndex = 36;
            // 
            // pnl_sideMenu
            // 
            this.pnl_sideMenu.BackColor = System.Drawing.Color.CadetBlue;
            this.pnl_sideMenu.Controls.Add(this.btn_dashboard);
            this.pnl_sideMenu.Controls.Add(this.btn_itemMasterList);
            this.pnl_sideMenu.Controls.Add(this.btn_stockTransfer);
            this.pnl_sideMenu.Controls.Add(this.btn_inventoryData);
            this.pnl_sideMenu.Controls.Add(this.btn_Back);
            this.pnl_sideMenu.Location = new System.Drawing.Point(15, 50);
            this.pnl_sideMenu.Name = "pnl_sideMenu";
            this.pnl_sideMenu.Size = new System.Drawing.Size(267, 598);
            this.pnl_sideMenu.TabIndex = 23;
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_dashboard.ForeColor = System.Drawing.Color.Snow;
            this.btn_dashboard.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Dashboard_32px;
            this.btn_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.Location = new System.Drawing.Point(2, 118);
            this.btn_dashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(265, 43);
            this.btn_dashboard.TabIndex = 6;
            this.btn_dashboard.Text = "             Dashboard";
            this.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.UseVisualStyleBackColor = true;
            // 
            // btn_itemMasterList
            // 
            this.btn_itemMasterList.FlatAppearance.BorderSize = 0;
            this.btn_itemMasterList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_itemMasterList.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_itemMasterList.ForeColor = System.Drawing.Color.Snow;
            this.btn_itemMasterList.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Product_32px;
            this.btn_itemMasterList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_itemMasterList.Location = new System.Drawing.Point(2, 181);
            this.btn_itemMasterList.Margin = new System.Windows.Forms.Padding(2);
            this.btn_itemMasterList.Name = "btn_itemMasterList";
            this.btn_itemMasterList.Size = new System.Drawing.Size(265, 43);
            this.btn_itemMasterList.TabIndex = 5;
            this.btn_itemMasterList.Text = "             Item Master List";
            this.btn_itemMasterList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_itemMasterList.UseVisualStyleBackColor = true;
            // 
            // btn_stockTransfer
            // 
            this.btn_stockTransfer.FlatAppearance.BorderSize = 0;
            this.btn_stockTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stockTransfer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_stockTransfer.ForeColor = System.Drawing.Color.Snow;
            this.btn_stockTransfer.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Move_Stock_32px;
            this.btn_stockTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stockTransfer.Location = new System.Drawing.Point(2, 313);
            this.btn_stockTransfer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_stockTransfer.Name = "btn_stockTransfer";
            this.btn_stockTransfer.Size = new System.Drawing.Size(265, 43);
            this.btn_stockTransfer.TabIndex = 4;
            this.btn_stockTransfer.Text = "             Stock Transfer";
            this.btn_stockTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stockTransfer.UseVisualStyleBackColor = true;
            // 
            // btn_inventoryData
            // 
            this.btn_inventoryData.FlatAppearance.BorderSize = 0;
            this.btn_inventoryData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventoryData.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_inventoryData.ForeColor = System.Drawing.Color.Snow;
            this.btn_inventoryData.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Warehouse_32px;
            this.btn_inventoryData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inventoryData.Location = new System.Drawing.Point(2, 247);
            this.btn_inventoryData.Margin = new System.Windows.Forms.Padding(2);
            this.btn_inventoryData.Name = "btn_inventoryData";
            this.btn_inventoryData.Size = new System.Drawing.Size(265, 43);
            this.btn_inventoryData.TabIndex = 3;
            this.btn_inventoryData.Text = "             Inventory Data";
            this.btn_inventoryData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inventoryData.UseVisualStyleBackColor = true;
            // 
            // btn_Back
            // 
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_Back.ForeColor = System.Drawing.Color.Snow;
            this.btn_Back.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Home_32px_1;
            this.btn_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Back.Location = new System.Drawing.Point(2, 53);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(265, 43);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Text = "             Back to Home Menu";
            this.btn_Back.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Back.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LuloCleanW01-One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(570, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "PURCHASING";
            // 
            // btn_Settings
            // 
            this.btn_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Settings.FlatAppearance.BorderSize = 0;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Settings_32px;
            this.btn_Settings.Location = new System.Drawing.Point(1190, 7);
            this.btn_Settings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(40, 40);
            this.btn_Settings.TabIndex = 6;
            this.btn_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Settings.UseVisualStyleBackColor = true;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Sign_Out_32px;
            this.btn_Logout.Location = new System.Drawing.Point(1236, 5);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(40, 40);
            this.btn_Logout.TabIndex = 5;
            this.btn_Logout.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.btn_itemInvStatus);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btn_grpo);
            this.panel1.Controls.Add(this.btn_back_1);
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 598);
            this.panel1.TabIndex = 23;
            // 
            // btn_itemInvStatus
            // 
            this.btn_itemInvStatus.FlatAppearance.BorderSize = 0;
            this.btn_itemInvStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_itemInvStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_itemInvStatus.ForeColor = System.Drawing.Color.Snow;
            this.btn_itemInvStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_itemInvStatus.Location = new System.Drawing.Point(2, 118);
            this.btn_itemInvStatus.Margin = new System.Windows.Forms.Padding(2);
            this.btn_itemInvStatus.Name = "btn_itemInvStatus";
            this.btn_itemInvStatus.Size = new System.Drawing.Size(265, 43);
            this.btn_itemInvStatus.TabIndex = 6;
            this.btn_itemInvStatus.Text = "             Item Inventory Status";
            this.btn_itemInvStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_itemInvStatus.UseVisualStyleBackColor = true;
            this.btn_itemInvStatus.Click += new System.EventHandler(this.btn_itemInvStatus_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Purchase_Order_32px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(2, 181);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 43);
            this.button2.TabIndex = 5;
            this.button2.Text = "             Purchase Order";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Return_Purchase_32px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(2, 313);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(265, 43);
            this.button3.TabIndex = 4;
            this.button3.Text = "             Goods Issue";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_grpo
            // 
            this.btn_grpo.FlatAppearance.BorderSize = 0;
            this.btn_grpo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_grpo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_grpo.ForeColor = System.Drawing.Color.Snow;
            this.btn_grpo.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Receipt_32px;
            this.btn_grpo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_grpo.Location = new System.Drawing.Point(2, 247);
            this.btn_grpo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_grpo.Name = "btn_grpo";
            this.btn_grpo.Size = new System.Drawing.Size(265, 43);
            this.btn_grpo.TabIndex = 3;
            this.btn_grpo.Text = "             Goods Receipt PO";
            this.btn_grpo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_grpo.UseVisualStyleBackColor = true;
            this.btn_grpo.Click += new System.EventHandler(this.btn_grpo_Click);
            // 
            // btn_back_1
            // 
            this.btn_back_1.FlatAppearance.BorderSize = 0;
            this.btn_back_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back_1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_back_1.ForeColor = System.Drawing.Color.Snow;
            this.btn_back_1.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Back_32px;
            this.btn_back_1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back_1.Location = new System.Drawing.Point(2, 53);
            this.btn_back_1.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back_1.Name = "btn_back_1";
            this.btn_back_1.Size = new System.Drawing.Size(265, 43);
            this.btn_back_1.TabIndex = 2;
            this.btn_back_1.Text = "             Back ";
            this.btn_back_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_back_1.UseVisualStyleBackColor = true;
            this.btn_back_1.Click += new System.EventHandler(this.btn_back_1_Click);
            // 
            // pnl_Footer
            // 
            this.pnl_Footer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Footer.BackColor = System.Drawing.Color.Teal;
            this.pnl_Footer.Controls.Add(this.label3);
            this.pnl_Footer.Controls.Add(this.label1);
            this.pnl_Footer.Controls.Add(this.lbl_DateTime);
            this.pnl_Footer.Location = new System.Drawing.Point(-3, 649);
            this.pnl_Footer.Name = "pnl_Footer";
            this.pnl_Footer.Size = new System.Drawing.Size(1292, 32);
            this.pnl_Footer.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(73, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jane Doe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(20, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "User:";
            // 
            // lbl_DateTime
            // 
            this.lbl_DateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_DateTime.AutoSize = true;
            this.lbl_DateTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateTime.ForeColor = System.Drawing.Color.White;
            this.lbl_DateTime.Location = new System.Drawing.Point(1054, 7);
            this.lbl_DateTime.Name = "lbl_DateTime";
            this.lbl_DateTime.Size = new System.Drawing.Size(158, 20);
            this.lbl_DateTime.TabIndex = 3;
            this.lbl_DateTime.Text = "hh:mm January 1, 2018";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.userCon_GRPO1);
            this.panel2.Controls.Add(this.userCon_itemsPurchasing1);
            this.panel2.Location = new System.Drawing.Point(271, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1003, 594);
            this.panel2.TabIndex = 36;
            // 
            // userCon_itemsPurchasing1
            // 
            this.userCon_itemsPurchasing1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userCon_itemsPurchasing1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCon_itemsPurchasing1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userCon_itemsPurchasing1.Location = new System.Drawing.Point(0, 0);
            this.userCon_itemsPurchasing1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userCon_itemsPurchasing1.Name = "userCon_itemsPurchasing1";
            this.userCon_itemsPurchasing1.Size = new System.Drawing.Size(1003, 594);
            this.userCon_itemsPurchasing1.TabIndex = 0;
            this.userCon_itemsPurchasing1.Load += new System.EventHandler(this.userCon_itemsPurchasing1_Load);
            // 
            // userCon_GRPO1
            // 
            this.userCon_GRPO1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userCon_GRPO1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userCon_GRPO1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userCon_GRPO1.Location = new System.Drawing.Point(0, 0);
            this.userCon_GRPO1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userCon_GRPO1.Name = "userCon_GRPO1";
            this.userCon_GRPO1.Size = new System.Drawing.Size(1003, 594);
            this.userCon_GRPO1.TabIndex = 1;
            // 
            // formPurchasing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 680);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_Footer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Header);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formPurchasing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.formPurchasing_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.pnl_sideMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnl_Footer.ResumeLayout(false);
            this.pnl_Footer.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_sideMenu;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_itemMasterList;
        private System.Windows.Forms.Button btn_stockTransfer;
        private System.Windows.Forms.Button btn_inventoryData;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_grpo;
        private System.Windows.Forms.Button btn_back_1;
        private System.Windows.Forms.Panel pnl_Footer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_DateTime;
        private System.Windows.Forms.Panel pnl_window;
        private System.Windows.Forms.Panel panel2;
        private userCon_itemsPurchasing userCon_itemsPurchasing1;
        private System.Windows.Forms.Button btn_itemInvStatus;
        private userCon_GRPO userCon_GRPO1;
    }
}