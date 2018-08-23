namespace Thesis_Rillan_Trading
{
    partial class formPurchaseOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPurchaseOrder));
            this.btn_removeItem = new System.Windows.Forms.Button();
            this.btn_cancelOrder = new System.Windows.Forms.Button();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.lbl_tax = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl_discount = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_addOrder = new System.Windows.Forms.Button();
            this.tbox_notes = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_itemView = new System.Windows.Forms.Button();
            this.dgv_orderLine = new System.Windows.Forms.DataGridView();
            this.itemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_poItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_poItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_poQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_poItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_suppFaxNum = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_suppContactNum = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_suppAddress = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_orderDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_docDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_supplier = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_Footer = new System.Windows.Forms.Panel();
            this.lbl_Role = new System.Windows.Forms.Label();
            this.lbl_DateTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_findMode = new System.Windows.Forms.Button();
            this.btn_orderMode = new System.Windows.Forms.Button();
            this.btn_find = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderLine)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnl_Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_removeItem
            // 
            this.btn_removeItem.BackColor = System.Drawing.Color.IndianRed;
            this.btn_removeItem.FlatAppearance.BorderSize = 0;
            this.btn_removeItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_removeItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeItem.ForeColor = System.Drawing.Color.White;
            this.btn_removeItem.Location = new System.Drawing.Point(975, 232);
            this.btn_removeItem.Name = "btn_removeItem";
            this.btn_removeItem.Size = new System.Drawing.Size(113, 27);
            this.btn_removeItem.TabIndex = 77;
            this.btn_removeItem.Text = "Remove Item";
            this.btn_removeItem.UseVisualStyleBackColor = false;
            // 
            // btn_cancelOrder
            // 
            this.btn_cancelOrder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cancelOrder.FlatAppearance.BorderSize = 0;
            this.btn_cancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelOrder.Location = new System.Drawing.Point(171, 597);
            this.btn_cancelOrder.Name = "btn_cancelOrder";
            this.btn_cancelOrder.Size = new System.Drawing.Size(94, 37);
            this.btn_cancelOrder.TabIndex = 76;
            this.btn_cancelOrder.Text = "Cancel";
            this.btn_cancelOrder.UseVisualStyleBackColor = false;
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_subtotal.Location = new System.Drawing.Point(1004, 462);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(36, 20);
            this.lbl_subtotal.TabIndex = 75;
            this.lbl_subtotal.Text = "0.00";
            // 
            // lbl_tax
            // 
            this.lbl_tax.AutoSize = true;
            this.lbl_tax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_tax.Location = new System.Drawing.Point(1004, 489);
            this.lbl_tax.Name = "lbl_tax";
            this.lbl_tax.Size = new System.Drawing.Size(36, 20);
            this.lbl_tax.TabIndex = 74;
            this.lbl_tax.Text = "0.00";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label20.Location = new System.Drawing.Point(904, 464);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 20);
            this.label20.TabIndex = 73;
            this.label20.Text = "Subtotal";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label19.Location = new System.Drawing.Point(939, 489);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 20);
            this.label19.TabIndex = 72;
            this.label19.Text = "Tax";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label17.Location = new System.Drawing.Point(902, 514);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 20);
            this.label17.TabIndex = 71;
            this.label17.Text = "Discount";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_discount
            // 
            this.lbl_discount.AutoSize = true;
            this.lbl_discount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_discount.Location = new System.Drawing.Point(1004, 514);
            this.lbl_discount.Name = "lbl_discount";
            this.lbl_discount.Size = new System.Drawing.Size(36, 20);
            this.lbl_discount.TabIndex = 70;
            this.lbl_discount.Text = "0.00";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(917, 553);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 25);
            this.label16.TabIndex = 69;
            this.label16.Text = "Total";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(1003, 553);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(50, 25);
            this.lbl_total.TabIndex = 68;
            this.lbl_total.Text = "0.00";
            // 
            // btn_addOrder
            // 
            this.btn_addOrder.BackColor = System.Drawing.Color.Teal;
            this.btn_addOrder.FlatAppearance.BorderSize = 0;
            this.btn_addOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addOrder.ForeColor = System.Drawing.Color.White;
            this.btn_addOrder.Location = new System.Drawing.Point(41, 597);
            this.btn_addOrder.Name = "btn_addOrder";
            this.btn_addOrder.Size = new System.Drawing.Size(124, 37);
            this.btn_addOrder.TabIndex = 67;
            this.btn_addOrder.Text = "ADD ORDER";
            this.btn_addOrder.UseVisualStyleBackColor = false;
            this.btn_addOrder.Click += new System.EventHandler(this.btn_addOrder_Click);
            // 
            // tbox_notes
            // 
            this.tbox_notes.Location = new System.Drawing.Point(100, 464);
            this.tbox_notes.Multiline = true;
            this.tbox_notes.Name = "tbox_notes";
            this.tbox_notes.Size = new System.Drawing.Size(315, 83);
            this.tbox_notes.TabIndex = 66;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(46, 467);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 20);
            this.label14.TabIndex = 65;
            this.label14.Text = "Notes";
            // 
            // btn_itemView
            // 
            this.btn_itemView.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_itemView.FlatAppearance.BorderSize = 0;
            this.btn_itemView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_itemView.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_itemView.ForeColor = System.Drawing.Color.White;
            this.btn_itemView.Location = new System.Drawing.Point(856, 232);
            this.btn_itemView.Name = "btn_itemView";
            this.btn_itemView.Size = new System.Drawing.Size(113, 27);
            this.btn_itemView.TabIndex = 63;
            this.btn_itemView.Text = "Add Item";
            this.btn_itemView.UseVisualStyleBackColor = false;
            this.btn_itemView.Click += new System.EventHandler(this.btn_itemView_Click);
            // 
            // dgv_orderLine
            // 
            this.dgv_orderLine.AllowUserToAddRows = false;
            this.dgv_orderLine.AllowUserToDeleteRows = false;
            this.dgv_orderLine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_orderLine.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_orderLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_orderLine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemID,
            this.clmn_poItemCode,
            this.clmn_poItemDescription,
            this.clmn_unit,
            this.clmn_poQuantity,
            this.clmn_poItemPrice});
            this.dgv_orderLine.Location = new System.Drawing.Point(41, 265);
            this.dgv_orderLine.Name = "dgv_orderLine";
            this.dgv_orderLine.RowHeadersVisible = false;
            this.dgv_orderLine.RowTemplate.Height = 24;
            this.dgv_orderLine.Size = new System.Drawing.Size(1047, 185);
            this.dgv_orderLine.TabIndex = 62;
            this.dgv_orderLine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_orderLine_CellContentClick);
            // 
            // itemID
            // 
            this.itemID.HeaderText = "ID";
            this.itemID.Name = "itemID";
            this.itemID.Visible = false;
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
            // lbl_suppFaxNum
            // 
            this.lbl_suppFaxNum.AutoSize = true;
            this.lbl_suppFaxNum.Location = new System.Drawing.Point(236, 200);
            this.lbl_suppFaxNum.Name = "lbl_suppFaxNum";
            this.lbl_suppFaxNum.Size = new System.Drawing.Size(84, 20);
            this.lbl_suppFaxNum.TabIndex = 60;
            this.lbl_suppFaxNum.Text = "fax number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(91, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 20);
            this.label12.TabIndex = 59;
            this.label12.Text = "Fax Number:";
            // 
            // lbl_suppContactNum
            // 
            this.lbl_suppContactNum.AutoSize = true;
            this.lbl_suppContactNum.Location = new System.Drawing.Point(236, 171);
            this.lbl_suppContactNum.Name = "lbl_suppContactNum";
            this.lbl_suppContactNum.Size = new System.Drawing.Size(113, 20);
            this.lbl_suppContactNum.TabIndex = 58;
            this.lbl_suppContactNum.Text = "contact number";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(91, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 20);
            this.label10.TabIndex = 57;
            this.label10.Text = "Contact Number:";
            // 
            // lbl_suppAddress
            // 
            this.lbl_suppAddress.AutoSize = true;
            this.lbl_suppAddress.Location = new System.Drawing.Point(236, 141);
            this.lbl_suppAddress.Name = "lbl_suppAddress";
            this.lbl_suppAddress.Size = new System.Drawing.Size(121, 20);
            this.lbl_suppAddress.TabIndex = 56;
            this.lbl_suppAddress.Text = "Supplier Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 55;
            this.label7.Text = "Address:";
            // 
            // dtp_orderDate
            // 
            this.dtp_orderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_orderDate.Location = new System.Drawing.Point(813, 174);
            this.dtp_orderDate.Name = "dtp_orderDate";
            this.dtp_orderDate.Size = new System.Drawing.Size(200, 27);
            this.dtp_orderDate.TabIndex = 54;
            this.dtp_orderDate.Value = new System.DateTime(2018, 8, 23, 0, 0, 0, 0);
            // 
            // dtp_docDate
            // 
            this.dtp_docDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_docDate.Location = new System.Drawing.Point(813, 141);
            this.dtp_docDate.Name = "dtp_docDate";
            this.dtp_docDate.Size = new System.Drawing.Size(200, 27);
            this.dtp_docDate.TabIndex = 53;
            this.dtp_docDate.Value = new System.DateTime(2018, 8, 23, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(665, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "Ordering Date:";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("LuloCleanW01-OneBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(809, 108);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(71, 23);
            this.lbl_status.TabIndex = 51;
            this.lbl_status.Text = "OPEN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(665, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(665, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Document Date:";
            // 
            // tbox_supplier
            // 
            this.tbox_supplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbox_supplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbox_supplier.Location = new System.Drawing.Point(240, 101);
            this.tbox_supplier.Name = "tbox_supplier";
            this.tbox_supplier.Size = new System.Drawing.Size(233, 27);
            this.tbox_supplier.TabIndex = 48;
            this.tbox_supplier.TextChanged += new System.EventHandler(this.tbox_supplier_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Supplier:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(36, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 28);
            this.label1.TabIndex = 46;
            this.label1.Text = "Purchase Order";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_orderMode);
            this.panel1.Controls.Add(this.btn_findMode);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1133, 41);
            this.panel1.TabIndex = 78;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnl_Footer
            // 
            this.pnl_Footer.BackColor = System.Drawing.Color.CadetBlue;
            this.pnl_Footer.Controls.Add(this.lbl_Role);
            this.pnl_Footer.Controls.Add(this.lbl_DateTime);
            this.pnl_Footer.Location = new System.Drawing.Point(-2, 649);
            this.pnl_Footer.Name = "pnl_Footer";
            this.pnl_Footer.Size = new System.Drawing.Size(1132, 33);
            this.pnl_Footer.TabIndex = 79;
            // 
            // lbl_Role
            // 
            this.lbl_Role.AutoSize = true;
            this.lbl_Role.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Role.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Role.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Role.Location = new System.Drawing.Point(20, 5);
            this.lbl_Role.Name = "lbl_Role";
            this.lbl_Role.Size = new System.Drawing.Size(112, 23);
            this.lbl_Role.TabIndex = 3;
            this.lbl_Role.Text = "Administrator";
            // 
            // lbl_DateTime
            // 
            this.lbl_DateTime.AutoSize = true;
            this.lbl_DateTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateTime.ForeColor = System.Drawing.Color.White;
            this.lbl_DateTime.Location = new System.Drawing.Point(941, 7);
            this.lbl_DateTime.Name = "lbl_DateTime";
            this.lbl_DateTime.Size = new System.Drawing.Size(158, 20);
            this.lbl_DateTime.TabIndex = 3;
            this.lbl_DateTime.Text = "hh:mm January 1, 2018";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(774, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 82;
            this.label5.Text = "Window Mode:";
            // 
            // btn_findMode
            // 
            this.btn_findMode.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_findMode.FlatAppearance.BorderSize = 0;
            this.btn_findMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_findMode.ForeColor = System.Drawing.Color.White;
            this.btn_findMode.Location = new System.Drawing.Point(890, 7);
            this.btn_findMode.Name = "btn_findMode";
            this.btn_findMode.Size = new System.Drawing.Size(112, 27);
            this.btn_findMode.TabIndex = 81;
            this.btn_findMode.Text = "Find";
            this.btn_findMode.UseVisualStyleBackColor = false;
            this.btn_findMode.Click += new System.EventHandler(this.btn_findMode_Click);
            // 
            // btn_orderMode
            // 
            this.btn_orderMode.BackColor = System.Drawing.Color.DarkCyan;
            this.btn_orderMode.FlatAppearance.BorderSize = 0;
            this.btn_orderMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_orderMode.ForeColor = System.Drawing.Color.White;
            this.btn_orderMode.Location = new System.Drawing.Point(1008, 7);
            this.btn_orderMode.Name = "btn_orderMode";
            this.btn_orderMode.Size = new System.Drawing.Size(112, 27);
            this.btn_orderMode.TabIndex = 80;
            this.btn_orderMode.Text = "Order";
            this.btn_orderMode.UseVisualStyleBackColor = false;
            this.btn_orderMode.Click += new System.EventHandler(this.btn_orderMode_Click);
            // 
            // btn_find
            // 
            this.btn_find.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_find.FlatAppearance.BorderSize = 0;
            this.btn_find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_find.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_find.ForeColor = System.Drawing.Color.White;
            this.btn_find.Location = new System.Drawing.Point(41, 597);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(124, 37);
            this.btn_find.TabIndex = 83;
            this.btn_find.Text = "FIND";
            this.btn_find.UseVisualStyleBackColor = false;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btn_Back.ForeColor = System.Drawing.Color.Snow;
            this.btn_Back.Image = ((System.Drawing.Image)(resources.GetObject("btn_Back.Image")));
            this.btn_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Back.Location = new System.Drawing.Point(1, 1);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(78, 38);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "BACK";
            this.btn_Back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // formPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1129, 679);
            this.Controls.Add(this.btn_find);
            this.Controls.Add(this.pnl_Footer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_removeItem);
            this.Controls.Add(this.btn_cancelOrder);
            this.Controls.Add(this.lbl_subtotal);
            this.Controls.Add(this.lbl_tax);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lbl_discount);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_addOrder);
            this.Controls.Add(this.tbox_notes);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_itemView);
            this.Controls.Add(this.dgv_orderLine);
            this.Controls.Add(this.lbl_suppFaxNum);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_suppContactNum);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_suppAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtp_orderDate);
            this.Controls.Add(this.dtp_docDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbox_supplier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formPurchaseOrder";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rillan Trading - Purchase Order";
            this.Load += new System.EventHandler(this.formPurchaseOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_orderLine)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_Footer.ResumeLayout(false);
            this.pnl_Footer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_removeItem;
        private System.Windows.Forms.Button btn_cancelOrder;
        private System.Windows.Forms.Label lbl_subtotal;
        private System.Windows.Forms.Label lbl_tax;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl_discount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_addOrder;
        private System.Windows.Forms.TextBox tbox_notes;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_itemView;
        private System.Windows.Forms.DataGridView dgv_orderLine;
        private System.Windows.Forms.Label lbl_suppFaxNum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_suppContactNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_suppAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_orderDate;
        private System.Windows.Forms.DateTimePicker dtp_docDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_supplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel pnl_Footer;
        private System.Windows.Forms.Label lbl_Role;
        private System.Windows.Forms.Label lbl_DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_poItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_poItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_poQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_poItemPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_findMode;
        private System.Windows.Forms.Button btn_orderMode;
        private System.Windows.Forms.Button btn_find;
    }
}