namespace Thesis_Rillan_Trading
{
    partial class userCon_GRPO
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
            this.dgv_purchaseOrders = new System.Windows.Forms.DataGridView();
            this.clmn_poID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_suppName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_poDocDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_orderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.po_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_poNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_purchaseOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LuloCleanW01-One", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Purchase Orders";
            // 
            // dgv_purchaseOrders
            // 
            this.dgv_purchaseOrders.AllowUserToAddRows = false;
            this.dgv_purchaseOrders.AllowUserToDeleteRows = false;
            this.dgv_purchaseOrders.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_purchaseOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_purchaseOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmn_poID,
            this.clmn_suppName,
            this.clmn_poDocDate,
            this.clmn_orderDate,
            this.po_status,
            this.clmn_poNotes});
            this.dgv_purchaseOrders.Location = new System.Drawing.Point(15, 66);
            this.dgv_purchaseOrders.Name = "dgv_purchaseOrders";
            this.dgv_purchaseOrders.ReadOnly = true;
            this.dgv_purchaseOrders.RowHeadersVisible = false;
            this.dgv_purchaseOrders.RowTemplate.Height = 24;
            this.dgv_purchaseOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_purchaseOrders.Size = new System.Drawing.Size(893, 505);
            this.dgv_purchaseOrders.TabIndex = 27;
            this.dgv_purchaseOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_purchaseOrders_CellClick);
            this.dgv_purchaseOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_purchaseOrders_CellDoubleClick);
            // 
            // clmn_poID
            // 
            this.clmn_poID.HeaderText = "po_id";
            this.clmn_poID.Name = "clmn_poID";
            this.clmn_poID.ReadOnly = true;
            this.clmn_poID.Visible = false;
            // 
            // clmn_suppName
            // 
            this.clmn_suppName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmn_suppName.HeaderText = "Supplier";
            this.clmn_suppName.Name = "clmn_suppName";
            this.clmn_suppName.ReadOnly = true;
            // 
            // clmn_poDocDate
            // 
            this.clmn_poDocDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmn_poDocDate.HeaderText = "Document Date";
            this.clmn_poDocDate.Name = "clmn_poDocDate";
            this.clmn_poDocDate.ReadOnly = true;
            this.clmn_poDocDate.Width = 143;
            // 
            // clmn_orderDate
            // 
            this.clmn_orderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmn_orderDate.HeaderText = "Ordered Date";
            this.clmn_orderDate.Name = "clmn_orderDate";
            this.clmn_orderDate.ReadOnly = true;
            this.clmn_orderDate.Width = 129;
            // 
            // po_status
            // 
            this.po_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.po_status.HeaderText = "Status";
            this.po_status.Name = "po_status";
            this.po_status.ReadOnly = true;
            this.po_status.Width = 78;
            // 
            // clmn_poNotes
            // 
            this.clmn_poNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmn_poNotes.HeaderText = "Notes";
            this.clmn_poNotes.Name = "clmn_poNotes";
            this.clmn_poNotes.ReadOnly = true;
            // 
            // userCon_GRPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.dgv_purchaseOrders);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "userCon_GRPO";
            this.Size = new System.Drawing.Size(920, 583);
            this.Load += new System.EventHandler(this.userCon_GRPO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_purchaseOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_purchaseOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_poID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_suppName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_poDocDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_orderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn po_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_poNotes;
    }
}
