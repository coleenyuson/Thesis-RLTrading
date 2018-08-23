namespace Thesis_Rillan_Trading
{
    partial class viewFormSOList
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
            this.btn_OK = new System.Windows.Forms.Button();
            this.dgv_SOList = new System.Windows.Forms.DataGridView();
            this.so_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PO_DocDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PO_OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.so_totalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PO_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SOList)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.BackColor = System.Drawing.Color.Teal;
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.FlatAppearance.BorderSize = 0;
            this.btn_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OK.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OK.ForeColor = System.Drawing.Color.White;
            this.btn_OK.Location = new System.Drawing.Point(694, 505);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(94, 30);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = false;
            // 
            // dgv_SOList
            // 
            this.dgv_SOList.AllowUserToAddRows = false;
            this.dgv_SOList.AllowUserToDeleteRows = false;
            this.dgv_SOList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_SOList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SOList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.so_ID,
            this.suppName,
            this.PO_DocDate,
            this.PO_OrderDate,
            this.so_totalAmount,
            this.PO_Status});
            this.dgv_SOList.Location = new System.Drawing.Point(12, 11);
            this.dgv_SOList.Name = "dgv_SOList";
            this.dgv_SOList.ReadOnly = true;
            this.dgv_SOList.RowHeadersVisible = false;
            this.dgv_SOList.RowTemplate.Height = 24;
            this.dgv_SOList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SOList.Size = new System.Drawing.Size(776, 487);
            this.dgv_SOList.TabIndex = 2;
            this.dgv_SOList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SOList_CellClick);
            // 
            // so_ID
            // 
            this.so_ID.HeaderText = "SO_ID";
            this.so_ID.Name = "so_ID";
            this.so_ID.ReadOnly = true;
            this.so_ID.Visible = false;
            // 
            // suppName
            // 
            this.suppName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.suppName.HeaderText = "Customer Name";
            this.suppName.Name = "suppName";
            this.suppName.ReadOnly = true;
            // 
            // PO_DocDate
            // 
            this.PO_DocDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PO_DocDate.HeaderText = "Document Date";
            this.PO_DocDate.Name = "PO_DocDate";
            this.PO_DocDate.ReadOnly = true;
            // 
            // PO_OrderDate
            // 
            this.PO_OrderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PO_OrderDate.HeaderText = "Order Date";
            this.PO_OrderDate.Name = "PO_OrderDate";
            this.PO_OrderDate.ReadOnly = true;
            // 
            // so_totalAmount
            // 
            this.so_totalAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.so_totalAmount.HeaderText = "Total Amount";
            this.so_totalAmount.Name = "so_totalAmount";
            this.so_totalAmount.ReadOnly = true;
            // 
            // PO_Status
            // 
            this.PO_Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PO_Status.HeaderText = "Status";
            this.PO_Status.Name = "PO_Status";
            this.PO_Status.ReadOnly = true;
            this.PO_Status.Width = 78;
            // 
            // viewFormSOList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.dgv_SOList);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "viewFormSOList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Order List";
            this.Load += new System.EventHandler(this.viewFormSOList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SOList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.DataGridView dgv_SOList;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PO_DocDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PO_OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn so_totalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PO_Status;
    }
}