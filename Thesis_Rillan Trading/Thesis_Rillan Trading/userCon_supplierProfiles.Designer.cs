namespace Thesis_Rillan_Trading
{
    partial class userCon_supplierProfiles
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
            this.btn_refresh = new System.Windows.Forms.Button();
            this.picBox_Search = new System.Windows.Forms.PictureBox();
            this.cmbBox_filter = new System.Windows.Forms.ComboBox();
            this.dataGV_supplier = new System.Windows.Forms.DataGridView();
            this.tbox_Search = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.panel_supplierForm = new System.Windows.Forms.Panel();
            this.lbl_custDetails = new System.Windows.Forms.Label();
            this.tbox_faxNum = new System.Windows.Forms.TextBox();
            this.lbl_faxNum = new System.Windows.Forms.Label();
            this.tbox_contactNum = new System.Windows.Forms.TextBox();
            this.lbl_contactNum = new System.Windows.Forms.Label();
            this.tbox_supplierAddress = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.tbox_emailAddr = new System.Windows.Forms.TextBox();
            this.lbl_emailAddr = new System.Windows.Forms.Label();
            this.tbox_contactPerson = new System.Windows.Forms.TextBox();
            this.lbl_contactPerson = new System.Windows.Forms.Label();
            this.tbox_supplierName = new System.Windows.Forms.TextBox();
            this.lbl_supplierName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_supplier)).BeginInit();
            this.panel_supplierForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Refresh_32px;
            this.btn_refresh.Location = new System.Drawing.Point(599, 21);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(40, 50);
            this.btn_refresh.TabIndex = 41;
            this.btn_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_refresh.UseVisualStyleBackColor = false;
            // 
            // picBox_Search
            // 
            this.picBox_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox_Search.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Search_32px;
            this.picBox_Search.Location = new System.Drawing.Point(644, 28);
            this.picBox_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBox_Search.Name = "picBox_Search";
            this.picBox_Search.Size = new System.Drawing.Size(32, 32);
            this.picBox_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox_Search.TabIndex = 39;
            this.picBox_Search.TabStop = false;
            // 
            // cmbBox_filter
            // 
            this.cmbBox_filter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBox_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbBox_filter.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.cmbBox_filter.FormattingEnabled = true;
            this.cmbBox_filter.Location = new System.Drawing.Point(925, 30);
            this.cmbBox_filter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbBox_filter.Name = "cmbBox_filter";
            this.cmbBox_filter.Size = new System.Drawing.Size(165, 26);
            this.cmbBox_filter.TabIndex = 37;
            this.cmbBox_filter.Text = "Filter By";
            // 
            // dataGV_supplier
            // 
            this.dataGV_supplier.AllowUserToAddRows = false;
            this.dataGV_supplier.AllowUserToDeleteRows = false;
            this.dataGV_supplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGV_supplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGV_supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_supplier.Location = new System.Drawing.Point(323, 76);
            this.dataGV_supplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGV_supplier.Name = "dataGV_supplier";
            this.dataGV_supplier.ReadOnly = true;
            this.dataGV_supplier.RowHeadersVisible = false;
            this.dataGV_supplier.RowTemplate.Height = 24;
            this.dataGV_supplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV_supplier.Size = new System.Drawing.Size(767, 536);
            this.dataGV_supplier.TabIndex = 43;
            this.dataGV_supplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_supplier_CellContentClick_1);
            // 
            // tbox_Search
            // 
            this.tbox_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_Search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.tbox_Search.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.tbox_Search.Location = new System.Drawing.Point(681, 29);
            this.tbox_Search.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Search.Name = "tbox_Search";
            this.tbox_Search.Size = new System.Drawing.Size(239, 27);
            this.tbox_Search.TabIndex = 36;
            this.tbox_Search.Text = "Search";
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
            this.btn_delete.Location = new System.Drawing.Point(164, 564);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(154, 48);
            this.btn_delete.TabIndex = 40;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
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
            this.btn_Save.Location = new System.Drawing.Point(6, 564);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(154, 48);
            this.btn_Save.TabIndex = 38;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // panel_supplierForm
            // 
            this.panel_supplierForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.panel_supplierForm.Controls.Add(this.lbl_custDetails);
            this.panel_supplierForm.Controls.Add(this.tbox_faxNum);
            this.panel_supplierForm.Controls.Add(this.lbl_faxNum);
            this.panel_supplierForm.Controls.Add(this.tbox_contactNum);
            this.panel_supplierForm.Controls.Add(this.lbl_contactNum);
            this.panel_supplierForm.Controls.Add(this.tbox_supplierAddress);
            this.panel_supplierForm.Controls.Add(this.lbl_address);
            this.panel_supplierForm.Controls.Add(this.tbox_emailAddr);
            this.panel_supplierForm.Controls.Add(this.lbl_emailAddr);
            this.panel_supplierForm.Controls.Add(this.tbox_contactPerson);
            this.panel_supplierForm.Controls.Add(this.lbl_contactPerson);
            this.panel_supplierForm.Controls.Add(this.tbox_supplierName);
            this.panel_supplierForm.Controls.Add(this.lbl_supplierName);
            this.panel_supplierForm.Location = new System.Drawing.Point(6, 76);
            this.panel_supplierForm.Margin = new System.Windows.Forms.Padding(2);
            this.panel_supplierForm.Name = "panel_supplierForm";
            this.panel_supplierForm.Size = new System.Drawing.Size(312, 484);
            this.panel_supplierForm.TabIndex = 35;
            // 
            // lbl_custDetails
            // 
            this.lbl_custDetails.AutoSize = true;
            this.lbl_custDetails.Font = new System.Drawing.Font("LuloCleanW01-One", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_custDetails.Location = new System.Drawing.Point(34, 14);
            this.lbl_custDetails.Name = "lbl_custDetails";
            this.lbl_custDetails.Size = new System.Drawing.Size(240, 23);
            this.lbl_custDetails.TabIndex = 48;
            this.lbl_custDetails.Text = "Supplier Details";
            // 
            // tbox_faxNum
            // 
            this.tbox_faxNum.Location = new System.Drawing.Point(19, 444);
            this.tbox_faxNum.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_faxNum.Name = "tbox_faxNum";
            this.tbox_faxNum.Size = new System.Drawing.Size(276, 27);
            this.tbox_faxNum.TabIndex = 13;
            // 
            // lbl_faxNum
            // 
            this.lbl_faxNum.AutoSize = true;
            this.lbl_faxNum.Location = new System.Drawing.Point(15, 422);
            this.lbl_faxNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_faxNum.Name = "lbl_faxNum";
            this.lbl_faxNum.Size = new System.Drawing.Size(88, 20);
            this.lbl_faxNum.TabIndex = 12;
            this.lbl_faxNum.Text = "Fax Number";
            // 
            // tbox_contactNum
            // 
            this.tbox_contactNum.Location = new System.Drawing.Point(19, 379);
            this.tbox_contactNum.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_contactNum.Name = "tbox_contactNum";
            this.tbox_contactNum.Size = new System.Drawing.Size(276, 27);
            this.tbox_contactNum.TabIndex = 11;
            // 
            // lbl_contactNum
            // 
            this.lbl_contactNum.AutoSize = true;
            this.lbl_contactNum.Location = new System.Drawing.Point(16, 357);
            this.lbl_contactNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_contactNum.Name = "lbl_contactNum";
            this.lbl_contactNum.Size = new System.Drawing.Size(118, 20);
            this.lbl_contactNum.TabIndex = 10;
            this.lbl_contactNum.Text = "Contact Number";
            // 
            // tbox_supplierAddress
            // 
            this.tbox_supplierAddress.Location = new System.Drawing.Point(20, 136);
            this.tbox_supplierAddress.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_supplierAddress.Multiline = true;
            this.tbox_supplierAddress.Name = "tbox_supplierAddress";
            this.tbox_supplierAddress.Size = new System.Drawing.Size(275, 69);
            this.tbox_supplierAddress.TabIndex = 9;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(14, 114);
            this.lbl_address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(62, 20);
            this.lbl_address.TabIndex = 8;
            this.lbl_address.Text = "Address";
            // 
            // tbox_emailAddr
            // 
            this.tbox_emailAddr.Location = new System.Drawing.Point(19, 317);
            this.tbox_emailAddr.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_emailAddr.Name = "tbox_emailAddr";
            this.tbox_emailAddr.Size = new System.Drawing.Size(276, 27);
            this.tbox_emailAddr.TabIndex = 7;
            // 
            // lbl_emailAddr
            // 
            this.lbl_emailAddr.AutoSize = true;
            this.lbl_emailAddr.Location = new System.Drawing.Point(17, 295);
            this.lbl_emailAddr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_emailAddr.Name = "lbl_emailAddr";
            this.lbl_emailAddr.Size = new System.Drawing.Size(103, 20);
            this.lbl_emailAddr.TabIndex = 6;
            this.lbl_emailAddr.Text = "Email Address";
            // 
            // tbox_contactPerson
            // 
            this.tbox_contactPerson.Location = new System.Drawing.Point(19, 248);
            this.tbox_contactPerson.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_contactPerson.Name = "tbox_contactPerson";
            this.tbox_contactPerson.Size = new System.Drawing.Size(276, 27);
            this.tbox_contactPerson.TabIndex = 5;
            // 
            // lbl_contactPerson
            // 
            this.lbl_contactPerson.AutoSize = true;
            this.lbl_contactPerson.Location = new System.Drawing.Point(16, 226);
            this.lbl_contactPerson.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_contactPerson.Name = "lbl_contactPerson";
            this.lbl_contactPerson.Size = new System.Drawing.Size(107, 20);
            this.lbl_contactPerson.TabIndex = 4;
            this.lbl_contactPerson.Text = "Contact Person";
            // 
            // tbox_supplierName
            // 
            this.tbox_supplierName.Location = new System.Drawing.Point(18, 74);
            this.tbox_supplierName.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_supplierName.Name = "tbox_supplierName";
            this.tbox_supplierName.Size = new System.Drawing.Size(276, 27);
            this.tbox_supplierName.TabIndex = 3;
            // 
            // lbl_supplierName
            // 
            this.lbl_supplierName.AutoSize = true;
            this.lbl_supplierName.Location = new System.Drawing.Point(15, 46);
            this.lbl_supplierName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_supplierName.Name = "lbl_supplierName";
            this.lbl_supplierName.Size = new System.Drawing.Size(108, 20);
            this.lbl_supplierName.TabIndex = 2;
            this.lbl_supplierName.Text = "Supplier Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 28);
            this.label2.TabIndex = 44;
            this.label2.Text = "Supplier Profiles";
            // 
            // userCon_supplierProfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.picBox_Search);
            this.Controls.Add(this.cmbBox_filter);
            this.Controls.Add(this.dataGV_supplier);
            this.Controls.Add(this.tbox_Search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.panel_supplierForm);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "userCon_supplierProfiles";
            this.Size = new System.Drawing.Size(1097, 627);
            this.Load += new System.EventHandler(this.supplierProfiles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_supplier)).EndInit();
            this.panel_supplierForm.ResumeLayout(false);
            this.panel_supplierForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.PictureBox picBox_Search;
        private System.Windows.Forms.ComboBox cmbBox_filter;
        private System.Windows.Forms.DataGridView dataGV_supplier;
        private System.Windows.Forms.TextBox tbox_Search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Panel panel_supplierForm;
        private System.Windows.Forms.TextBox tbox_faxNum;
        private System.Windows.Forms.Label lbl_faxNum;
        private System.Windows.Forms.TextBox tbox_contactNum;
        private System.Windows.Forms.Label lbl_contactNum;
        private System.Windows.Forms.TextBox tbox_supplierAddress;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox tbox_emailAddr;
        private System.Windows.Forms.Label lbl_emailAddr;
        private System.Windows.Forms.TextBox tbox_contactPerson;
        private System.Windows.Forms.Label lbl_contactPerson;
        private System.Windows.Forms.TextBox tbox_supplierName;
        private System.Windows.Forms.Label lbl_supplierName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_custDetails;
        private System.Windows.Forms.Label label2;
    }
}
