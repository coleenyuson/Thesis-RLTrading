﻿namespace Thesis_Rillan_Trading
{
    partial class userCon_customerAccounts
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_custName = new System.Windows.Forms.TextBox();
            this.dtp_dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dtp_dateTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DGView_customerAccts = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_custStatus = new System.Windows.Forms.Label();
            this.btn_Status = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGView_customerAccts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Accounts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date From";
            // 
            // tbox_custName
            // 
            this.tbox_custName.Location = new System.Drawing.Point(150, 72);
            this.tbox_custName.Name = "tbox_custName";
            this.tbox_custName.Size = new System.Drawing.Size(218, 27);
            this.tbox_custName.TabIndex = 3;
            // 
            // dtp_dateFrom
            // 
            this.dtp_dateFrom.Location = new System.Drawing.Point(497, 67);
            this.dtp_dateFrom.Name = "dtp_dateFrom";
            this.dtp_dateFrom.Size = new System.Drawing.Size(243, 27);
            this.dtp_dateFrom.TabIndex = 4;
            // 
            // dtp_dateTo
            // 
            this.dtp_dateTo.Location = new System.Drawing.Point(497, 107);
            this.dtp_dateTo.Name = "dtp_dateTo";
            this.dtp_dateTo.Size = new System.Drawing.Size(243, 27);
            this.dtp_dateTo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date To";
            // 
            // DGView_customerAccts
            // 
            this.DGView_customerAccts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGView_customerAccts.Location = new System.Drawing.Point(23, 144);
            this.DGView_customerAccts.Name = "DGView_customerAccts";
            this.DGView_customerAccts.RowTemplate.Height = 24;
            this.DGView_customerAccts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGView_customerAccts.Size = new System.Drawing.Size(1055, 442);
            this.DGView_customerAccts.TabIndex = 7;
            this.DGView_customerAccts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGView_customerAccts_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Status";
            // 
            // lbl_custStatus
            // 
            this.lbl_custStatus.AutoSize = true;
            this.lbl_custStatus.Font = new System.Drawing.Font("LuloCleanW01-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_custStatus.ForeColor = System.Drawing.Color.Red;
            this.lbl_custStatus.Location = new System.Drawing.Point(146, 112);
            this.lbl_custStatus.Name = "lbl_custStatus";
            this.lbl_custStatus.Size = new System.Drawing.Size(160, 21);
            this.lbl_custStatus.TabIndex = 9;
            this.lbl_custStatus.Text = "DEACTIVATED";
            this.lbl_custStatus.Click += new System.EventHandler(this.lbl_custStatus_Click);
            // 
            // btn_Status
            // 
            this.btn_Status.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Status.FlatAppearance.BorderSize = 0;
            this.btn_Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Status.ForeColor = System.Drawing.Color.Snow;
            this.btn_Status.Location = new System.Drawing.Point(852, 67);
            this.btn_Status.Name = "btn_Status";
            this.btn_Status.Size = new System.Drawing.Size(226, 32);
            this.btn_Status.TabIndex = 10;
            this.btn_Status.Text = "Activate";
            this.btn_Status.UseVisualStyleBackColor = false;
            this.btn_Status.Click += new System.EventHandler(this.btn_Status_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.ForeColor = System.Drawing.Color.Snow;
            this.btn_search.Location = new System.Drawing.Point(852, 106);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(226, 32);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // customerAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_Status);
            this.Controls.Add(this.lbl_custStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DGView_customerAccts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtp_dateTo);
            this.Controls.Add(this.dtp_dateFrom);
            this.Controls.Add(this.tbox_custName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "customerAccounts";
            this.Size = new System.Drawing.Size(1097, 624);
            this.Load += new System.EventHandler(this.customerAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGView_customerAccts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_custName;
        private System.Windows.Forms.DateTimePicker dtp_dateFrom;
        private System.Windows.Forms.DateTimePicker dtp_dateTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGView_customerAccts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_custStatus;
        private System.Windows.Forms.Button btn_Status;
        private System.Windows.Forms.Button btn_search;
    }
}
