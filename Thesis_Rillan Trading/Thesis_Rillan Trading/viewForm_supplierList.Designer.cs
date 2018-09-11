namespace Thesis_Rillan_Trading
{
    partial class viewForm_supplierList
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_item = new System.Windows.Forms.TextBox();
            this.dgv_supplierList = new System.Windows.Forms.DataGridView();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.clmn_suppID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_suppName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_sellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplierList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Header.BackColor = System.Drawing.Color.Teal;
            this.pnl_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Header.Controls.Add(this.label2);
            this.pnl_Header.ForeColor = System.Drawing.Color.SteelBlue;
            this.pnl_Header.Location = new System.Drawing.Point(-2, 0);
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(607, 53);
            this.pnl_Header.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose a Supplier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Item:";
            // 
            // tbox_item
            // 
            this.tbox_item.Location = new System.Drawing.Point(61, 72);
            this.tbox_item.Name = "tbox_item";
            this.tbox_item.ReadOnly = true;
            this.tbox_item.Size = new System.Drawing.Size(288, 27);
            this.tbox_item.TabIndex = 26;
            // 
            // dgv_supplierList
            // 
            this.dgv_supplierList.AllowUserToAddRows = false;
            this.dgv_supplierList.AllowUserToDeleteRows = false;
            this.dgv_supplierList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_supplierList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_supplierList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmn_suppID,
            this.clmn_suppName,
            this.clmn_sellingPrice});
            this.dgv_supplierList.Location = new System.Drawing.Point(15, 117);
            this.dgv_supplierList.Name = "dgv_supplierList";
            this.dgv_supplierList.ReadOnly = true;
            this.dgv_supplierList.RowHeadersVisible = false;
            this.dgv_supplierList.RowTemplate.Height = 24;
            this.dgv_supplierList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_supplierList.Size = new System.Drawing.Size(577, 389);
            this.dgv_supplierList.TabIndex = 27;
            this.dgv_supplierList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_supplierList_CellClick);
            // 
            // btn_next
            // 
            this.btn_next.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.ForeColor = System.Drawing.Color.Teal;
            this.btn_next.Location = new System.Drawing.Point(466, 513);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(127, 37);
            this.btn_next.TabIndex = 28;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.ForeColor = System.Drawing.Color.Teal;
            this.btn_cancel.Location = new System.Drawing.Point(333, 513);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(127, 37);
            this.btn_cancel.TabIndex = 29;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // clmn_suppID
            // 
            this.clmn_suppID.HeaderText = "Supplier ID";
            this.clmn_suppID.Name = "clmn_suppID";
            this.clmn_suppID.ReadOnly = true;
            // 
            // clmn_suppName
            // 
            this.clmn_suppName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmn_suppName.HeaderText = "Supplier Name";
            this.clmn_suppName.Name = "clmn_suppName";
            this.clmn_suppName.ReadOnly = true;
            // 
            // clmn_sellingPrice
            // 
            this.clmn_sellingPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmn_sellingPrice.HeaderText = "Selling Price";
            this.clmn_sellingPrice.Name = "clmn_sellingPrice";
            this.clmn_sellingPrice.ReadOnly = true;
            this.clmn_sellingPrice.Width = 109;
            // 
            // viewForm_supplierList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(605, 562);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.dgv_supplierList);
            this.Controls.Add(this.tbox_item);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_Header);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "viewForm_supplierList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.viewForm_supplierList_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_supplierList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_item;
        private System.Windows.Forms.DataGridView dgv_supplierList;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_suppID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_suppName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_sellingPrice;
    }
}