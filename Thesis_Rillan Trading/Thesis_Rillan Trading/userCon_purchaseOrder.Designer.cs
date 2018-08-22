namespace Thesis_Rillan_Trading
{
    partial class userCon_purchaseOrder
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
            this.tbox_supplier = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_docDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_orderDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_supplierView = new System.Windows.Forms.Button();
            this.dgv_orderLine = new System.Windows.Forms.DataGridView();
            this.clmn_poItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_poItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_poQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_poItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_addItem = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_addOrder = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btn_cancelOrder = new System.Windows.Forms.Button();
            this.btn_removeItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderLine)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchase Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supplier:";
            // 
            // tbox_supplier
            // 
            this.tbox_supplier.Location = new System.Drawing.Point(216, 49);
            this.tbox_supplier.Name = "tbox_supplier";
            this.tbox_supplier.Size = new System.Drawing.Size(233, 27);
            this.tbox_supplier.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Document Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(641, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("LuloCleanW01-OneBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(785, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "OPEN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(641, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ordering Date:";
            // 
            // dtp_docDate
            // 
            this.dtp_docDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_docDate.Location = new System.Drawing.Point(789, 89);
            this.dtp_docDate.Name = "dtp_docDate";
            this.dtp_docDate.Size = new System.Drawing.Size(200, 27);
            this.dtp_docDate.TabIndex = 8;
            // 
            // dtp_orderDate
            // 
            this.dtp_orderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_orderDate.Location = new System.Drawing.Point(789, 122);
            this.dtp_orderDate.Name = "dtp_orderDate";
            this.dtp_orderDate.Size = new System.Drawing.Size(200, 27);
            this.dtp_orderDate.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Supplier Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(212, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "contact number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Contact Number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(212, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "fax number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(67, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Fax Number:";
            // 
            // btn_supplierView
            // 
            this.btn_supplierView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_supplierView.FlatAppearance.BorderSize = 0;
            this.btn_supplierView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_supplierView.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_View_More_20px;
            this.btn_supplierView.Location = new System.Drawing.Point(455, 51);
            this.btn_supplierView.Name = "btn_supplierView";
            this.btn_supplierView.Size = new System.Drawing.Size(22, 22);
            this.btn_supplierView.TabIndex = 16;
            this.btn_supplierView.UseVisualStyleBackColor = false;
            // 
            // dgv_orderLine
            // 
            this.dgv_orderLine.AllowUserToDeleteRows = false;
            this.dgv_orderLine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_orderLine.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_orderLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orderLine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmn_poItemCode,
            this.clmn_poItemDescription,
            this.clmn_unit,
            this.clmn_poQuantity,
            this.clmn_poItemPrice});
            this.dgv_orderLine.Location = new System.Drawing.Point(22, 245);
            this.dgv_orderLine.Name = "dgv_orderLine";
            this.dgv_orderLine.RowHeadersVisible = false;
            this.dgv_orderLine.RowTemplate.Height = 24;
            this.dgv_orderLine.Size = new System.Drawing.Size(1047, 185);
            this.dgv_orderLine.TabIndex = 18;
            // 
            // clmn_poItemCode
            // 
            this.clmn_poItemCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmn_poItemCode.HeaderText = "Item Code";
            this.clmn_poItemCode.Name = "clmn_poItemCode";
            this.clmn_poItemCode.Width = 107;
            // 
            // clmn_poItemDescription
            // 
            this.clmn_poItemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmn_poItemDescription.HeaderText = "Item Description";
            this.clmn_poItemDescription.Name = "clmn_poItemDescription";
            // 
            // clmn_unit
            // 
            this.clmn_unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmn_unit.HeaderText = "Unit";
            this.clmn_unit.Name = "clmn_unit";
            this.clmn_unit.Width = 65;
            // 
            // clmn_poQuantity
            // 
            this.clmn_poQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmn_poQuantity.HeaderText = "Quantity";
            this.clmn_poQuantity.Name = "clmn_poQuantity";
            this.clmn_poQuantity.Width = 94;
            // 
            // clmn_poItemPrice
            // 
            this.clmn_poItemPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmn_poItemPrice.HeaderText = "Item Price";
            this.clmn_poItemPrice.Name = "clmn_poItemPrice";
            this.clmn_poItemPrice.Width = 104;
            // 
            // btn_addItem
            // 
            this.btn_addItem.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_addItem.FlatAppearance.BorderSize = 0;
            this.btn_addItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addItem.ForeColor = System.Drawing.Color.White;
            this.btn_addItem.Location = new System.Drawing.Point(837, 212);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(113, 27);
            this.btn_addItem.TabIndex = 31;
            this.btn_addItem.Text = "Add Item";
            this.btn_addItem.UseVisualStyleBackColor = false;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(841, 494);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 20);
            this.label13.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 447);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 20);
            this.label14.TabIndex = 33;
            this.label14.Text = "Notes";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 444);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 95);
            this.textBox1.TabIndex = 34;
            // 
            // btn_addOrder
            // 
            this.btn_addOrder.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_addOrder.FlatAppearance.BorderSize = 0;
            this.btn_addOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addOrder.ForeColor = System.Drawing.Color.White;
            this.btn_addOrder.Location = new System.Drawing.Point(22, 577);
            this.btn_addOrder.Name = "btn_addOrder";
            this.btn_addOrder.Size = new System.Drawing.Size(124, 37);
            this.btn_addOrder.TabIndex = 35;
            this.btn_addOrder.Text = "ADD ORDER";
            this.btn_addOrder.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label15.Location = new System.Drawing.Point(1001, 514);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 25);
            this.label15.TabIndex = 36;
            this.label15.Text = "0.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label16.Location = new System.Drawing.Point(891, 514);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 25);
            this.label16.TabIndex = 37;
            this.label16.Text = "Total";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label17.Location = new System.Drawing.Point(876, 489);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 20);
            this.label17.TabIndex = 39;
            this.label17.Text = "Discount";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label18.Location = new System.Drawing.Point(1002, 489);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 20);
            this.label18.TabIndex = 38;
            this.label18.Text = "0.00";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label19.Location = new System.Drawing.Point(913, 469);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 20);
            this.label19.TabIndex = 40;
            this.label19.Text = "Tax";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label20.Location = new System.Drawing.Point(878, 449);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 20);
            this.label20.TabIndex = 41;
            this.label20.Text = "Subtotal";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label21.Location = new System.Drawing.Point(1002, 469);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(36, 20);
            this.label21.TabIndex = 42;
            this.label21.Text = "0.00";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label22.Location = new System.Drawing.Point(1002, 447);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 20);
            this.label22.TabIndex = 43;
            this.label22.Text = "0.00";
            // 
            // btn_cancelOrder
            // 
            this.btn_cancelOrder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cancelOrder.FlatAppearance.BorderSize = 0;
            this.btn_cancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelOrder.Location = new System.Drawing.Point(152, 577);
            this.btn_cancelOrder.Name = "btn_cancelOrder";
            this.btn_cancelOrder.Size = new System.Drawing.Size(94, 37);
            this.btn_cancelOrder.TabIndex = 44;
            this.btn_cancelOrder.Text = "Cancel";
            this.btn_cancelOrder.UseVisualStyleBackColor = false;
            // 
            // btn_removeItem
            // 
            this.btn_removeItem.BackColor = System.Drawing.Color.IndianRed;
            this.btn_removeItem.FlatAppearance.BorderSize = 0;
            this.btn_removeItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_removeItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeItem.ForeColor = System.Drawing.Color.White;
            this.btn_removeItem.Location = new System.Drawing.Point(956, 212);
            this.btn_removeItem.Name = "btn_removeItem";
            this.btn_removeItem.Size = new System.Drawing.Size(113, 27);
            this.btn_removeItem.TabIndex = 45;
            this.btn_removeItem.Text = "Remove Item";
            this.btn_removeItem.UseVisualStyleBackColor = false;
            // 
            // userCon_purchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btn_removeItem);
            this.Controls.Add(this.btn_cancelOrder);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btn_addOrder);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_addItem);
            this.Controls.Add(this.dgv_orderLine);
            this.Controls.Add(this.btn_supplierView);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtp_orderDate);
            this.Controls.Add(this.dtp_docDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbox_supplier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "userCon_purchaseOrder";
            this.Size = new System.Drawing.Size(1095, 666);
            this.Load += new System.EventHandler(this.purchaseOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_supplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_docDate;
        private System.Windows.Forms.DateTimePicker dtp_orderDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_supplierView;
        private System.Windows.Forms.DataGridView dgv_orderLine;
        private System.Windows.Forms.Button btn_addItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_poItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_poItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_poQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_poItemPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_addOrder;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btn_cancelOrder;
        private System.Windows.Forms.Button btn_removeItem;
    }
}
