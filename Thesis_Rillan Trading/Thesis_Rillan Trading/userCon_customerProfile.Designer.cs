namespace Thesis_Rillan_Trading
{
    partial class userCon_customerProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userCon_customerProfile));
            this.cmbBox_filter = new System.Windows.Forms.ComboBox();
            this.tbox_Search = new System.Windows.Forms.TextBox();
            this.dataGV_custProfiles = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.pnl_prodDetails = new System.Windows.Forms.Panel();
            this.tbox_faxNum = new System.Windows.Forms.TextBox();
            this.tbox_contactNum = new System.Windows.Forms.TextBox();
            this.tbox_address = new System.Windows.Forms.TextBox();
            this.lbl_faxNumber = new System.Windows.Forms.Label();
            this.lbl_contactNum = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.tbox_contactPerson = new System.Windows.Forms.TextBox();
            this.lbl_contactPerson = new System.Windows.Forms.Label();
            this.tbox_custName = new System.Windows.Forms.TextBox();
            this.lbl_custName = new System.Windows.Forms.Label();
            this.lbl_custDetails = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.picBox_Search = new System.Windows.Forms.PictureBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_custProfiles)).BeginInit();
            this.pnl_prodDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBox_filter
            // 
            this.cmbBox_filter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBox_filter.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.cmbBox_filter.FormattingEnabled = true;
            this.cmbBox_filter.Location = new System.Drawing.Point(920, 52);
            this.cmbBox_filter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbBox_filter.Name = "cmbBox_filter";
            this.cmbBox_filter.Size = new System.Drawing.Size(165, 28);
            this.cmbBox_filter.TabIndex = 41;
            this.cmbBox_filter.Text = "Filter By";
            // 
            // tbox_Search
            // 
            this.tbox_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_Search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.tbox_Search.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.tbox_Search.Location = new System.Drawing.Point(676, 52);
            this.tbox_Search.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Search.Name = "tbox_Search";
            this.tbox_Search.Size = new System.Drawing.Size(239, 27);
            this.tbox_Search.TabIndex = 40;
            this.tbox_Search.Text = "Search";
            // 
            // dataGV_custProfiles
            // 
            this.dataGV_custProfiles.AllowUserToAddRows = false;
            this.dataGV_custProfiles.AllowUserToDeleteRows = false;
            this.dataGV_custProfiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGV_custProfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_custProfiles.Location = new System.Drawing.Point(383, 94);
            this.dataGV_custProfiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGV_custProfiles.MultiSelect = false;
            this.dataGV_custProfiles.Name = "dataGV_custProfiles";
            this.dataGV_custProfiles.ReadOnly = true;
            this.dataGV_custProfiles.RowTemplate.Height = 24;
            this.dataGV_custProfiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV_custProfiles.Size = new System.Drawing.Size(702, 490);
            this.dataGV_custProfiles.TabIndex = 39;
            this.dataGV_custProfiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_custProfiles_CellContentClick);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.IndianRed;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("LuloCleanW01-OneBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Snow;
            this.btn_delete.Location = new System.Drawing.Point(196, 536);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(181, 48);
            this.btn_delete.TabIndex = 38;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("LuloCleanW01-OneBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Snow;
            this.btn_Save.Location = new System.Drawing.Point(11, 536);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(181, 48);
            this.btn_Save.TabIndex = 37;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click_1);
            // 
            // pnl_prodDetails
            // 
            this.pnl_prodDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(234)))));
            this.pnl_prodDetails.Controls.Add(this.tbox_faxNum);
            this.pnl_prodDetails.Controls.Add(this.tbox_contactNum);
            this.pnl_prodDetails.Controls.Add(this.tbox_address);
            this.pnl_prodDetails.Controls.Add(this.lbl_faxNumber);
            this.pnl_prodDetails.Controls.Add(this.lbl_contactNum);
            this.pnl_prodDetails.Controls.Add(this.lbl_Address);
            this.pnl_prodDetails.Controls.Add(this.tbox_contactPerson);
            this.pnl_prodDetails.Controls.Add(this.lbl_contactPerson);
            this.pnl_prodDetails.Controls.Add(this.tbox_custName);
            this.pnl_prodDetails.Controls.Add(this.lbl_custName);
            this.pnl_prodDetails.Controls.Add(this.lbl_custDetails);
            this.pnl_prodDetails.Location = new System.Drawing.Point(11, 94);
            this.pnl_prodDetails.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnl_prodDetails.Name = "pnl_prodDetails";
            this.pnl_prodDetails.Size = new System.Drawing.Size(366, 435);
            this.pnl_prodDetails.TabIndex = 36;
            // 
            // tbox_faxNum
            // 
            this.tbox_faxNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_faxNum.Location = new System.Drawing.Point(140, 327);
            this.tbox_faxNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbox_faxNum.Name = "tbox_faxNum";
            this.tbox_faxNum.Size = new System.Drawing.Size(211, 27);
            this.tbox_faxNum.TabIndex = 17;
            // 
            // tbox_contactNum
            // 
            this.tbox_contactNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_contactNum.Location = new System.Drawing.Point(140, 278);
            this.tbox_contactNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbox_contactNum.Name = "tbox_contactNum";
            this.tbox_contactNum.Size = new System.Drawing.Size(211, 27);
            this.tbox_contactNum.TabIndex = 16;
            // 
            // tbox_address
            // 
            this.tbox_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_address.Location = new System.Drawing.Point(140, 176);
            this.tbox_address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbox_address.Multiline = true;
            this.tbox_address.Name = "tbox_address";
            this.tbox_address.Size = new System.Drawing.Size(211, 80);
            this.tbox_address.TabIndex = 15;
            // 
            // lbl_faxNumber
            // 
            this.lbl_faxNumber.AutoSize = true;
            this.lbl_faxNumber.Location = new System.Drawing.Point(8, 329);
            this.lbl_faxNumber.Name = "lbl_faxNumber";
            this.lbl_faxNumber.Size = new System.Drawing.Size(88, 20);
            this.lbl_faxNumber.TabIndex = 14;
            this.lbl_faxNumber.Text = "Fax Number";
            // 
            // lbl_contactNum
            // 
            this.lbl_contactNum.AutoSize = true;
            this.lbl_contactNum.Location = new System.Drawing.Point(8, 280);
            this.lbl_contactNum.Name = "lbl_contactNum";
            this.lbl_contactNum.Size = new System.Drawing.Size(118, 20);
            this.lbl_contactNum.TabIndex = 6;
            this.lbl_contactNum.Text = "Contact Number";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(8, 178);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(62, 20);
            this.lbl_Address.TabIndex = 4;
            this.lbl_Address.Text = "Address";
            // 
            // tbox_contactPerson
            // 
            this.tbox_contactPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_contactPerson.Location = new System.Drawing.Point(140, 130);
            this.tbox_contactPerson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbox_contactPerson.Name = "tbox_contactPerson";
            this.tbox_contactPerson.Size = new System.Drawing.Size(211, 27);
            this.tbox_contactPerson.TabIndex = 2;
            // 
            // lbl_contactPerson
            // 
            this.lbl_contactPerson.AutoSize = true;
            this.lbl_contactPerson.Location = new System.Drawing.Point(8, 132);
            this.lbl_contactPerson.Name = "lbl_contactPerson";
            this.lbl_contactPerson.Size = new System.Drawing.Size(107, 20);
            this.lbl_contactPerson.TabIndex = 3;
            this.lbl_contactPerson.Text = "Contact Person";
            // 
            // tbox_custName
            // 
            this.tbox_custName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_custName.Location = new System.Drawing.Point(140, 89);
            this.tbox_custName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbox_custName.Name = "tbox_custName";
            this.tbox_custName.Size = new System.Drawing.Size(211, 27);
            this.tbox_custName.TabIndex = 1;
            // 
            // lbl_custName
            // 
            this.lbl_custName.AutoSize = true;
            this.lbl_custName.Location = new System.Drawing.Point(7, 91);
            this.lbl_custName.Name = "lbl_custName";
            this.lbl_custName.Size = new System.Drawing.Size(49, 20);
            this.lbl_custName.TabIndex = 1;
            this.lbl_custName.Text = "Name";
            // 
            // lbl_custDetails
            // 
            this.lbl_custDetails.AutoSize = true;
            this.lbl_custDetails.Font = new System.Drawing.Font("LuloCleanW01-One", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_custDetails.Location = new System.Drawing.Point(56, 28);
            this.lbl_custDetails.Name = "lbl_custDetails";
            this.lbl_custDetails.Size = new System.Drawing.Size(257, 23);
            this.lbl_custDetails.TabIndex = 0;
            this.lbl_custDetails.Text = "Customer Details";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refresh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("LuloCleanW01-One", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Refresh_32px;
            this.btn_refresh.Location = new System.Drawing.Point(596, 46);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(35, 32);
            this.btn_refresh.TabIndex = 43;
            this.btn_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_refresh.UseVisualStyleBackColor = false;
            // 
            // picBox_Search
            // 
            this.picBox_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox_Search.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Search.Image")));
            this.picBox_Search.Location = new System.Drawing.Point(636, 46);
            this.picBox_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBox_Search.Name = "picBox_Search";
            this.picBox_Search.Size = new System.Drawing.Size(32, 32);
            this.picBox_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox_Search.TabIndex = 42;
            this.picBox_Search.TabStop = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("LuloCleanW01-OneBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.Snow;
            this.btn_Cancel.Location = new System.Drawing.Point(196, 536);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(181, 48);
            this.btn_Cancel.TabIndex = 45;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("LuloCleanW01-OneBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.Snow;
            this.btn_Update.Location = new System.Drawing.Point(11, 536);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(181, 48);
            this.btn_Update.TabIndex = 44;
            this.btn_Update.Text = "UPDATE";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 28);
            this.label1.TabIndex = 46;
            this.label1.Text = "Customer Profiles";
            // 
            // customerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.picBox_Search);
            this.Controls.Add(this.cmbBox_filter);
            this.Controls.Add(this.tbox_Search);
            this.Controls.Add(this.dataGV_custProfiles);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.pnl_prodDetails);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "customerProfile";
            this.Size = new System.Drawing.Size(1097, 624);
            this.Load += new System.EventHandler(this.customerProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_custProfiles)).EndInit();
            this.pnl_prodDetails.ResumeLayout(false);
            this.pnl_prodDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.PictureBox picBox_Search;
        private System.Windows.Forms.ComboBox cmbBox_filter;
        private System.Windows.Forms.TextBox tbox_Search;
        private System.Windows.Forms.DataGridView dataGV_custProfiles;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Panel pnl_prodDetails;
        private System.Windows.Forms.TextBox tbox_faxNum;
        private System.Windows.Forms.TextBox tbox_contactNum;
        private System.Windows.Forms.TextBox tbox_address;
        private System.Windows.Forms.Label lbl_faxNumber;
        private System.Windows.Forms.Label lbl_contactNum;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox tbox_contactPerson;
        private System.Windows.Forms.Label lbl_contactPerson;
        private System.Windows.Forms.TextBox tbox_custName;
        private System.Windows.Forms.Label lbl_custName;
        private System.Windows.Forms.Label lbl_custDetails;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label label1;
    }
}
