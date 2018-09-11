namespace Thesis_Rillan_Trading
{
    partial class addForm_Item
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
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_addNewItem = new System.Windows.Forms.Button();
            this.tbox_minStoreLvl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_minWhseLvl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbox_itemUnit = new System.Windows.Forms.ComboBox();
            this.lbl_itemUnit = new System.Windows.Forms.Label();
            this.cmbox_itemCategory = new System.Windows.Forms.ComboBox();
            this.lbl_category = new System.Windows.Forms.Label();
            this.cmbox_itemBrand = new System.Windows.Forms.ComboBox();
            this.lbl_brand = new System.Windows.Forms.Label();
            this.tbox_itemDesc = new System.Windows.Forms.TextBox();
            this.tbox_itemCode = new System.Windows.Forms.TextBox();
            this.lbl_itemDesc = new System.Windows.Forms.Label();
            this.lbl_itemCode = new System.Windows.Forms.Label();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Teal;
            this.btn_Update.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.Snow;
            this.btn_Update.Location = new System.Drawing.Point(344, 450);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(115, 37);
            this.btn_Update.TabIndex = 33;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Location = new System.Drawing.Point(223, 450);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(115, 37);
            this.btn_cancel.TabIndex = 32;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_addNewItem
            // 
            this.btn_addNewItem.BackColor = System.Drawing.Color.Teal;
            this.btn_addNewItem.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_addNewItem.FlatAppearance.BorderSize = 0;
            this.btn_addNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addNewItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addNewItem.ForeColor = System.Drawing.Color.Snow;
            this.btn_addNewItem.Location = new System.Drawing.Point(344, 450);
            this.btn_addNewItem.Name = "btn_addNewItem";
            this.btn_addNewItem.Size = new System.Drawing.Size(115, 37);
            this.btn_addNewItem.TabIndex = 31;
            this.btn_addNewItem.Text = "Add";
            this.btn_addNewItem.UseVisualStyleBackColor = false;
            // 
            // tbox_minStoreLvl
            // 
            this.tbox_minStoreLvl.Location = new System.Drawing.Point(216, 385);
            this.tbox_minStoreLvl.Name = "tbox_minStoreLvl";
            this.tbox_minStoreLvl.Size = new System.Drawing.Size(243, 27);
            this.tbox_minStoreLvl.TabIndex = 30;
            this.tbox_minStoreLvl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_minWhseLvl_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Min. Store Level";
            // 
            // tbox_minWhseLvl
            // 
            this.tbox_minWhseLvl.Location = new System.Drawing.Point(216, 337);
            this.tbox_minWhseLvl.Name = "tbox_minWhseLvl";
            this.tbox_minWhseLvl.Size = new System.Drawing.Size(243, 27);
            this.tbox_minWhseLvl.TabIndex = 28;
            this.tbox_minWhseLvl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbox_minWhseLvl_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Min. Whse Level";
            // 
            // cmbox_itemUnit
            // 
            this.cmbox_itemUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_itemUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbox_itemUnit.FormattingEnabled = true;
            this.cmbox_itemUnit.Items.AddRange(new object[] {
            "bx",
            "pcs",
            "rim",
            "kg",
            "meter",
            "grams"});
            this.cmbox_itemUnit.Location = new System.Drawing.Point(216, 266);
            this.cmbox_itemUnit.Name = "cmbox_itemUnit";
            this.cmbox_itemUnit.Size = new System.Drawing.Size(243, 28);
            this.cmbox_itemUnit.TabIndex = 26;
            // 
            // lbl_itemUnit
            // 
            this.lbl_itemUnit.AutoSize = true;
            this.lbl_itemUnit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemUnit.Location = new System.Drawing.Point(44, 269);
            this.lbl_itemUnit.Name = "lbl_itemUnit";
            this.lbl_itemUnit.Size = new System.Drawing.Size(42, 23);
            this.lbl_itemUnit.TabIndex = 25;
            this.lbl_itemUnit.Text = "Unit";
            // 
            // cmbox_itemCategory
            // 
            this.cmbox_itemCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_itemCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbox_itemCategory.FormattingEnabled = true;
            this.cmbox_itemCategory.Location = new System.Drawing.Point(216, 218);
            this.cmbox_itemCategory.Name = "cmbox_itemCategory";
            this.cmbox_itemCategory.Size = new System.Drawing.Size(243, 28);
            this.cmbox_itemCategory.TabIndex = 24;
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.Location = new System.Drawing.Point(44, 221);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(79, 23);
            this.lbl_category.TabIndex = 23;
            this.lbl_category.Text = "Category";
            // 
            // cmbox_itemBrand
            // 
            this.cmbox_itemBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_itemBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbox_itemBrand.FormattingEnabled = true;
            this.cmbox_itemBrand.Location = new System.Drawing.Point(216, 171);
            this.cmbox_itemBrand.Name = "cmbox_itemBrand";
            this.cmbox_itemBrand.Size = new System.Drawing.Size(243, 28);
            this.cmbox_itemBrand.TabIndex = 22;
            // 
            // lbl_brand
            // 
            this.lbl_brand.AutoSize = true;
            this.lbl_brand.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_brand.Location = new System.Drawing.Point(44, 174);
            this.lbl_brand.Name = "lbl_brand";
            this.lbl_brand.Size = new System.Drawing.Size(55, 23);
            this.lbl_brand.TabIndex = 21;
            this.lbl_brand.Text = "Brand";
            // 
            // tbox_itemDesc
            // 
            this.tbox_itemDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbox_itemDesc.Location = new System.Drawing.Point(216, 122);
            this.tbox_itemDesc.Name = "tbox_itemDesc";
            this.tbox_itemDesc.Size = new System.Drawing.Size(243, 27);
            this.tbox_itemDesc.TabIndex = 20;
            // 
            // tbox_itemCode
            // 
            this.tbox_itemCode.Location = new System.Drawing.Point(216, 78);
            this.tbox_itemCode.Name = "tbox_itemCode";
            this.tbox_itemCode.Size = new System.Drawing.Size(243, 27);
            this.tbox_itemCode.TabIndex = 19;
            // 
            // lbl_itemDesc
            // 
            this.lbl_itemDesc.AutoSize = true;
            this.lbl_itemDesc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemDesc.Location = new System.Drawing.Point(44, 125);
            this.lbl_itemDesc.Name = "lbl_itemDesc";
            this.lbl_itemDesc.Size = new System.Drawing.Size(96, 23);
            this.lbl_itemDesc.TabIndex = 18;
            this.lbl_itemDesc.Text = "Description";
            // 
            // lbl_itemCode
            // 
            this.lbl_itemCode.AutoSize = true;
            this.lbl_itemCode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemCode.Location = new System.Drawing.Point(44, 81);
            this.lbl_itemCode.Name = "lbl_itemCode";
            this.lbl_itemCode.Size = new System.Drawing.Size(90, 23);
            this.lbl_itemCode.TabIndex = 17;
            this.lbl_itemCode.Text = "Item Code";
            // 
            // pnl_Header
            // 
            this.pnl_Header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Header.BackColor = System.Drawing.Color.Teal;
            this.pnl_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Header.Controls.Add(this.label3);
            this.pnl_Header.ForeColor = System.Drawing.Color.SteelBlue;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(511, 53);
            this.pnl_Header.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("LuloCleanW01-One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(187, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "NEW ITEM";
            // 
            // addForm_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 525);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Header);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_addNewItem);
            this.Controls.Add(this.tbox_minStoreLvl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbox_minWhseLvl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbox_itemUnit);
            this.Controls.Add(this.lbl_itemUnit);
            this.Controls.Add(this.cmbox_itemCategory);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.cmbox_itemBrand);
            this.Controls.Add(this.lbl_brand);
            this.Controls.Add(this.tbox_itemDesc);
            this.Controls.Add(this.tbox_itemCode);
            this.Controls.Add(this.lbl_itemDesc);
            this.Controls.Add(this.lbl_itemCode);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addForm_Item";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addForm_Item";
            this.Load += new System.EventHandler(this.addForm_Item_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_addNewItem;
        private System.Windows.Forms.TextBox tbox_minStoreLvl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_minWhseLvl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbox_itemUnit;
        private System.Windows.Forms.Label lbl_itemUnit;
        private System.Windows.Forms.ComboBox cmbox_itemCategory;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.ComboBox cmbox_itemBrand;
        private System.Windows.Forms.Label lbl_brand;
        private System.Windows.Forms.TextBox tbox_itemDesc;
        private System.Windows.Forms.TextBox tbox_itemCode;
        private System.Windows.Forms.Label lbl_itemDesc;
        private System.Windows.Forms.Label lbl_itemCode;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label label3;
    }
}