namespace Thesis_Rillan_Trading
{
    partial class userCon_itemsPurchasing
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
            this.dgv_itemMasterList = new System.Windows.Forms.DataGridView();
            this.clmn_itemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_itemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_itemDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_minWhseLvl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_inStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itemMasterList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_itemMasterList
            // 
            this.dgv_itemMasterList.AllowUserToAddRows = false;
            this.dgv_itemMasterList.AllowUserToDeleteRows = false;
            this.dgv_itemMasterList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_itemMasterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_itemMasterList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmn_itemID,
            this.clmn_itemCode,
            this.clmn_itemDesc,
            this.clmn_minWhseLvl,
            this.clmn_inStock});
            this.dgv_itemMasterList.Location = new System.Drawing.Point(3, 49);
            this.dgv_itemMasterList.Name = "dgv_itemMasterList";
            this.dgv_itemMasterList.ReadOnly = true;
            this.dgv_itemMasterList.RowHeadersVisible = false;
            this.dgv_itemMasterList.RowTemplate.Height = 24;
            this.dgv_itemMasterList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_itemMasterList.Size = new System.Drawing.Size(968, 526);
            this.dgv_itemMasterList.TabIndex = 24;
            this.dgv_itemMasterList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_itemMasterList_CellClick);
            this.dgv_itemMasterList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_itemMasterList_CellDoubleClick);
            // 
            // clmn_itemID
            // 
            this.clmn_itemID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmn_itemID.HeaderText = "Item ID";
            this.clmn_itemID.Name = "clmn_itemID";
            this.clmn_itemID.ReadOnly = true;
            this.clmn_itemID.Visible = false;
            // 
            // clmn_itemCode
            // 
            this.clmn_itemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.clmn_itemCode.HeaderText = "Item Code";
            this.clmn_itemCode.Name = "clmn_itemCode";
            this.clmn_itemCode.ReadOnly = true;
            this.clmn_itemCode.Width = 107;
            // 
            // clmn_itemDesc
            // 
            this.clmn_itemDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmn_itemDesc.HeaderText = "Item Description";
            this.clmn_itemDesc.Name = "clmn_itemDesc";
            this.clmn_itemDesc.ReadOnly = true;
            // 
            // clmn_minWhseLvl
            // 
            this.clmn_minWhseLvl.HeaderText = "minWhseLvl";
            this.clmn_minWhseLvl.Name = "clmn_minWhseLvl";
            this.clmn_minWhseLvl.ReadOnly = true;
            this.clmn_minWhseLvl.Visible = false;
            // 
            // clmn_inStock
            // 
            this.clmn_inStock.HeaderText = "In Stock";
            this.clmn_inStock.Name = "clmn_inStock";
            this.clmn_inStock.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LuloCleanW01-One", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Item Inventory Status";
            // 
            // userCon_itemsPurchasing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_itemMasterList);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "userCon_itemsPurchasing";
            this.Size = new System.Drawing.Size(974, 578);
            this.Load += new System.EventHandler(this.userCon_itemsPurchasing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_itemMasterList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_itemMasterList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_itemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_itemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_itemDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_minWhseLvl;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_inStock;
        private System.Windows.Forms.Label label1;
    }
}
