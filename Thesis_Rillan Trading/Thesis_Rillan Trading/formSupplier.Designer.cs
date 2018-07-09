namespace Thesis_Rillan_Trading
{
    partial class formSupplier
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
            this.components = new System.ComponentModel.Container();
            this.tbox_supplierAddress = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.tbox_contactNum = new System.Windows.Forms.TextBox();
            this.lbl_contactNum = new System.Windows.Forms.Label();
            this.tbox_faxNum = new System.Windows.Forms.TextBox();
            this.lbl_faxNum = new System.Windows.Forms.Label();
            this.tbox_supplierName = new System.Windows.Forms.TextBox();
            this.panel_supplierForm = new System.Windows.Forms.Panel();
            this.lbl_supplierName = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGV_supplier = new System.Windows.Forms.DataGridView();
            this.pnl_Footer = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_DateTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btn_refresh = new System.Windows.Forms.Button();
            this.picBox_Search = new System.Windows.Forms.PictureBox();
            this.cmbBox_filter = new System.Windows.Forms.ComboBox();
            this.tbox_Search = new System.Windows.Forms.TextBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.panel_supplierForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_supplier)).BeginInit();
            this.pnl_Footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Search)).BeginInit();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbox_supplierAddress
            // 
            this.tbox_supplierAddress.Location = new System.Drawing.Point(18, 281);
            this.tbox_supplierAddress.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_supplierAddress.Multiline = true;
            this.tbox_supplierAddress.Name = "tbox_supplierAddress";
            this.tbox_supplierAddress.Size = new System.Drawing.Size(275, 88);
            this.tbox_supplierAddress.TabIndex = 9;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(13, 253);
            this.lbl_address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(62, 20);
            this.lbl_address.TabIndex = 8;
            this.lbl_address.Text = "Address";
            // 
            // tbox_contactNum
            // 
            this.tbox_contactNum.Location = new System.Drawing.Point(17, 202);
            this.tbox_contactNum.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_contactNum.Name = "tbox_contactNum";
            this.tbox_contactNum.Size = new System.Drawing.Size(276, 27);
            this.tbox_contactNum.TabIndex = 7;
            // 
            // lbl_contactNum
            // 
            this.lbl_contactNum.AutoSize = true;
            this.lbl_contactNum.Location = new System.Drawing.Point(14, 176);
            this.lbl_contactNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_contactNum.Name = "lbl_contactNum";
            this.lbl_contactNum.Size = new System.Drawing.Size(118, 20);
            this.lbl_contactNum.TabIndex = 6;
            this.lbl_contactNum.Text = "Contact Number";
            // 
            // tbox_faxNum
            // 
            this.tbox_faxNum.Location = new System.Drawing.Point(16, 123);
            this.tbox_faxNum.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_faxNum.Name = "tbox_faxNum";
            this.tbox_faxNum.Size = new System.Drawing.Size(276, 27);
            this.tbox_faxNum.TabIndex = 5;
            // 
            // lbl_faxNum
            // 
            this.lbl_faxNum.AutoSize = true;
            this.lbl_faxNum.Location = new System.Drawing.Point(13, 96);
            this.lbl_faxNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_faxNum.Name = "lbl_faxNum";
            this.lbl_faxNum.Size = new System.Drawing.Size(88, 20);
            this.lbl_faxNum.TabIndex = 4;
            this.lbl_faxNum.Text = "Fax Number";
            // 
            // tbox_supplierName
            // 
            this.tbox_supplierName.Location = new System.Drawing.Point(16, 47);
            this.tbox_supplierName.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_supplierName.Name = "tbox_supplierName";
            this.tbox_supplierName.Size = new System.Drawing.Size(276, 27);
            this.tbox_supplierName.TabIndex = 3;
            // 
            // panel_supplierForm
            // 
            this.panel_supplierForm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_supplierForm.Controls.Add(this.tbox_supplierAddress);
            this.panel_supplierForm.Controls.Add(this.lbl_address);
            this.panel_supplierForm.Controls.Add(this.tbox_contactNum);
            this.panel_supplierForm.Controls.Add(this.lbl_contactNum);
            this.panel_supplierForm.Controls.Add(this.tbox_faxNum);
            this.panel_supplierForm.Controls.Add(this.lbl_faxNum);
            this.panel_supplierForm.Controls.Add(this.tbox_supplierName);
            this.panel_supplierForm.Controls.Add(this.lbl_supplierName);
            this.panel_supplierForm.Location = new System.Drawing.Point(10, 113);
            this.panel_supplierForm.Margin = new System.Windows.Forms.Padding(2);
            this.panel_supplierForm.Name = "panel_supplierForm";
            this.panel_supplierForm.Size = new System.Drawing.Size(312, 408);
            this.panel_supplierForm.TabIndex = 21;
            // 
            // lbl_supplierName
            // 
            this.lbl_supplierName.AutoSize = true;
            this.lbl_supplierName.Location = new System.Drawing.Point(13, 19);
            this.lbl_supplierName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_supplierName.Name = "lbl_supplierName";
            this.lbl_supplierName.Size = new System.Drawing.Size(108, 20);
            this.lbl_supplierName.TabIndex = 2;
            this.lbl_supplierName.Text = "Supplier Name";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.IndianRed;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("LuloCleanW01-OneBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Snow;
            this.btn_delete.Location = new System.Drawing.Point(168, 525);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(154, 38);
            this.btn_delete.TabIndex = 29;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("LuloCleanW01-OneBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Snow;
            this.btn_Save.Location = new System.Drawing.Point(10, 525);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(154, 38);
            this.btn_Save.TabIndex = 28;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LuloCleanW01-OneBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 28);
            this.label2.TabIndex = 31;
            this.label2.Text = "SUPPLIER MASTER LIST";
            // 
            // dataGV_supplier
            // 
            this.dataGV_supplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGV_supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_supplier.Location = new System.Drawing.Point(327, 113);
            this.dataGV_supplier.Name = "dataGV_supplier";
            this.dataGV_supplier.RowTemplate.Height = 24;
            this.dataGV_supplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV_supplier.Size = new System.Drawing.Size(767, 450);
            this.dataGV_supplier.TabIndex = 32;
            // 
            // pnl_Footer
            // 
            this.pnl_Footer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Footer.BackColor = System.Drawing.Color.Teal;
            this.pnl_Footer.Controls.Add(this.label3);
            this.pnl_Footer.Controls.Add(this.label1);
            this.pnl_Footer.Controls.Add(this.lbl_DateTime);
            this.pnl_Footer.Location = new System.Drawing.Point(-3, 592);
            this.pnl_Footer.Name = "pnl_Footer";
            this.pnl_Footer.Size = new System.Drawing.Size(1112, 30);
            this.pnl_Footer.TabIndex = 33;
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
            this.lbl_DateTime.Location = new System.Drawing.Point(893, 7);
            this.lbl_DateTime.Name = "lbl_DateTime";
            this.lbl_DateTime.Size = new System.Drawing.Size(158, 20);
            this.lbl_DateTime.TabIndex = 3;
            this.lbl_DateTime.Text = "hh:mm January 1, 2018";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Refresh_32px;
            this.btn_refresh.Location = new System.Drawing.Point(603, 68);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(40, 40);
            this.btn_refresh.TabIndex = 30;
            this.btn_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_refresh.UseVisualStyleBackColor = false;
            // 
            // picBox_Search
            // 
            this.picBox_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox_Search.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Search_32px;
            this.picBox_Search.Location = new System.Drawing.Point(648, 74);
            this.picBox_Search.Name = "picBox_Search";
            this.picBox_Search.Size = new System.Drawing.Size(32, 32);
            this.picBox_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox_Search.TabIndex = 29;
            this.picBox_Search.TabStop = false;
            // 
            // cmbBox_filter
            // 
            this.cmbBox_filter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBox_filter.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.cmbBox_filter.FormattingEnabled = true;
            this.cmbBox_filter.Location = new System.Drawing.Point(929, 74);
            this.cmbBox_filter.Name = "cmbBox_filter";
            this.cmbBox_filter.Size = new System.Drawing.Size(165, 28);
            this.cmbBox_filter.TabIndex = 28;
            this.cmbBox_filter.Text = "Filter By";
            // 
            // tbox_Search
            // 
            this.tbox_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_Search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.tbox_Search.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.tbox_Search.Location = new System.Drawing.Point(685, 75);
            this.tbox_Search.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Search.Name = "tbox_Search";
            this.tbox_Search.Size = new System.Drawing.Size(239, 27);
            this.tbox_Search.TabIndex = 27;
            this.tbox_Search.Text = "Search";
            // 
            // btn_Back
            // 
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_Back.ForeColor = System.Drawing.Color.Snow;
            this.btn_Back.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Back_32px;
            this.btn_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Back.Location = new System.Drawing.Point(10, 5);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(78, 43);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Text = "BACK";
            this.btn_Back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Sign_Out_32px;
            this.btn_Logout.Location = new System.Drawing.Point(1054, 5);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(40, 40);
            this.btn_Logout.TabIndex = 5;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Settings.FlatAppearance.BorderSize = 0;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Settings_32px;
            this.btn_Settings.Location = new System.Drawing.Point(1008, 7);
            this.btn_Settings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(40, 40);
            this.btn_Settings.TabIndex = 6;
            this.btn_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // pnl_Header
            // 
            this.pnl_Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Header.BackColor = System.Drawing.Color.Teal;
            this.pnl_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Header.Controls.Add(this.btn_Settings);
            this.pnl_Header.Controls.Add(this.btn_Logout);
            this.pnl_Header.Controls.Add(this.btn_Back);
            this.pnl_Header.ForeColor = System.Drawing.Color.SteelBlue;
            this.pnl_Header.Location = new System.Drawing.Point(-1, -1);
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1108, 53);
            this.pnl_Header.TabIndex = 20;
            // 
            // formSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1106, 621);
            this.ControlBox = false;
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.picBox_Search);
            this.Controls.Add(this.pnl_Footer);
            this.Controls.Add(this.cmbBox_filter);
            this.Controls.Add(this.dataGV_supplier);
            this.Controls.Add(this.tbox_Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.panel_supplierForm);
            this.Controls.Add(this.pnl_Header);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formSupplier";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rillan Trading - Supplier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formSupplier_FormClosing);
            this.Load += new System.EventHandler(this.formSupplier_Load);
            this.panel_supplierForm.ResumeLayout(false);
            this.panel_supplierForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_supplier)).EndInit();
            this.pnl_Footer.ResumeLayout(false);
            this.pnl_Footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Search)).EndInit();
            this.pnl_Header.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbox_supplierAddress;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox tbox_contactNum;
        private System.Windows.Forms.Label lbl_contactNum;
        private System.Windows.Forms.TextBox tbox_faxNum;
        private System.Windows.Forms.Label lbl_faxNum;
        private System.Windows.Forms.TextBox tbox_supplierName;
        private System.Windows.Forms.Panel panel_supplierForm;
        private System.Windows.Forms.Label lbl_supplierName;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGV_supplier;
        private System.Windows.Forms.Panel pnl_Footer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_DateTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.PictureBox picBox_Search;
        private System.Windows.Forms.ComboBox cmbBox_filter;
        private System.Windows.Forms.TextBox tbox_Search;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Panel pnl_Header;
    }
}