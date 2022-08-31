namespace BookBiz.GUI
{
    partial class frmOrders
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblUnitprice = new System.Windows.Forms.Label();
            this.lblQuantity2 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblBookid = new System.Windows.Forms.Label();
            this.lblClentid = new System.Windows.Forms.Label();
            this.lstPrice = new System.Windows.Forms.ListBox();
            this.lstUnitprice = new System.Windows.Forms.ListBox();
            this.btnPlaceorder = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lstQuantity = new System.Windows.Forms.ListBox();
            this.lstBookid = new System.Windows.Forms.ListBox();
            this.btnAdditem = new System.Windows.Forms.Button();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.cmbBookid = new System.Windows.Forms.ComboBox();
            this.cmbClientid = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancelorder = new System.Windows.Forms.Button();
            this.lblOrderid = new System.Windows.Forms.Label();
            this.cmbOrderid = new System.Windows.Forms.ComboBox();
            this.btnSearchlist = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.lblUnitprice);
            this.groupBox1.Controls.Add(this.lblQuantity2);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Controls.Add(this.lblBookid);
            this.groupBox1.Controls.Add(this.lblClentid);
            this.groupBox1.Controls.Add(this.lstPrice);
            this.groupBox1.Controls.Add(this.lstUnitprice);
            this.groupBox1.Controls.Add(this.btnPlaceorder);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.lstQuantity);
            this.groupBox1.Controls.Add(this.lstBookid);
            this.groupBox1.Controls.Add(this.btnAdditem);
            this.groupBox1.Controls.Add(this.nudQuantity);
            this.groupBox1.Controls.Add(this.cmbBookid);
            this.groupBox1.Controls.Add(this.cmbClientid);
            this.groupBox1.Location = new System.Drawing.Point(44, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 322);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Order";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(447, 256);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 46;
            this.lblTotal.Text = "Total";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(447, 128);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 45;
            this.lblPrice.Text = "Price";
            // 
            // lblUnitprice
            // 
            this.lblUnitprice.AutoSize = true;
            this.lblUnitprice.Location = new System.Drawing.Point(320, 127);
            this.lblUnitprice.Name = "lblUnitprice";
            this.lblUnitprice.Size = new System.Drawing.Size(53, 13);
            this.lblUnitprice.TabIndex = 44;
            this.lblUnitprice.Text = "Unit Price";
            // 
            // lblQuantity2
            // 
            this.lblQuantity2.AutoSize = true;
            this.lblQuantity2.Location = new System.Drawing.Point(194, 128);
            this.lblQuantity2.Name = "lblQuantity2";
            this.lblQuantity2.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity2.TabIndex = 43;
            this.lblQuantity2.Text = "Quantity";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(67, 128);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(44, 13);
            this.lblId.TabIndex = 42;
            this.lblId.Text = "Book Id";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(191, 79);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 41;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblBookid
            // 
            this.lblBookid.AutoSize = true;
            this.lblBookid.Location = new System.Drawing.Point(66, 79);
            this.lblBookid.Name = "lblBookid";
            this.lblBookid.Size = new System.Drawing.Size(44, 13);
            this.lblBookid.TabIndex = 40;
            this.lblBookid.Text = "Book Id";
            // 
            // lblClentid
            // 
            this.lblClentid.AutoSize = true;
            this.lblClentid.Location = new System.Drawing.Point(66, 26);
            this.lblClentid.Name = "lblClentid";
            this.lblClentid.Size = new System.Drawing.Size(44, 13);
            this.lblClentid.TabIndex = 39;
            this.lblClentid.Text = "Client id";
            // 
            // lstPrice
            // 
            this.lstPrice.FormattingEnabled = true;
            this.lstPrice.Location = new System.Drawing.Point(447, 147);
            this.lstPrice.Name = "lstPrice";
            this.lstPrice.Size = new System.Drawing.Size(120, 95);
            this.lstPrice.TabIndex = 38;
            // 
            // lstUnitprice
            // 
            this.lstUnitprice.FormattingEnabled = true;
            this.lstUnitprice.Location = new System.Drawing.Point(320, 147);
            this.lstUnitprice.Name = "lstUnitprice";
            this.lstUnitprice.Size = new System.Drawing.Size(120, 95);
            this.lstUnitprice.TabIndex = 37;
            // 
            // btnPlaceorder
            // 
            this.btnPlaceorder.Location = new System.Drawing.Point(597, 275);
            this.btnPlaceorder.Name = "btnPlaceorder";
            this.btnPlaceorder.Size = new System.Drawing.Size(93, 23);
            this.btnPlaceorder.TabIndex = 36;
            this.btnPlaceorder.Text = "Place The Order";
            this.btnPlaceorder.UseVisualStyleBackColor = true;
            this.btnPlaceorder.Click += new System.EventHandler(this.btnPlaceorder_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTotal.Location = new System.Drawing.Point(447, 275);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(120, 20);
            this.txtTotal.TabIndex = 35;
            this.txtTotal.Text = "0";
            // 
            // lstQuantity
            // 
            this.lstQuantity.FormattingEnabled = true;
            this.lstQuantity.Location = new System.Drawing.Point(193, 147);
            this.lstQuantity.Name = "lstQuantity";
            this.lstQuantity.Size = new System.Drawing.Size(120, 95);
            this.lstQuantity.TabIndex = 34;
            // 
            // lstBookid
            // 
            this.lstBookid.FormattingEnabled = true;
            this.lstBookid.Location = new System.Drawing.Point(67, 147);
            this.lstBookid.Name = "lstBookid";
            this.lstBookid.Size = new System.Drawing.Size(120, 95);
            this.lstBookid.TabIndex = 33;
            // 
            // btnAdditem
            // 
            this.btnAdditem.Location = new System.Drawing.Point(335, 95);
            this.btnAdditem.Name = "btnAdditem";
            this.btnAdditem.Size = new System.Drawing.Size(75, 23);
            this.btnAdditem.TabIndex = 32;
            this.btnAdditem.Text = "Add Item";
            this.btnAdditem.UseVisualStyleBackColor = true;
            this.btnAdditem.Click += new System.EventHandler(this.btnAdditem_Click);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(194, 95);
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 20);
            this.nudQuantity.TabIndex = 31;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbBookid
            // 
            this.cmbBookid.FormattingEnabled = true;
            this.cmbBookid.Location = new System.Drawing.Point(67, 95);
            this.cmbBookid.Name = "cmbBookid";
            this.cmbBookid.Size = new System.Drawing.Size(121, 21);
            this.cmbBookid.TabIndex = 30;
            // 
            // cmbClientid
            // 
            this.cmbClientid.FormattingEnabled = true;
            this.cmbClientid.Location = new System.Drawing.Point(66, 45);
            this.cmbClientid.Name = "cmbClientid";
            this.cmbClientid.Size = new System.Drawing.Size(121, 21);
            this.cmbClientid.TabIndex = 29;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancelorder);
            this.groupBox2.Controls.Add(this.lblOrderid);
            this.groupBox2.Controls.Add(this.cmbOrderid);
            this.groupBox2.Location = new System.Drawing.Point(50, 347);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(714, 66);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cancel order";
            // 
            // btnCancelorder
            // 
            this.btnCancelorder.Location = new System.Drawing.Point(372, 31);
            this.btnCancelorder.Name = "btnCancelorder";
            this.btnCancelorder.Size = new System.Drawing.Size(100, 23);
            this.btnCancelorder.TabIndex = 2;
            this.btnCancelorder.Text = "Cancel The Order";
            this.btnCancelorder.UseVisualStyleBackColor = true;
            this.btnCancelorder.Click += new System.EventHandler(this.btnCancelorder_Click);
            // 
            // lblOrderid
            // 
            this.lblOrderid.AutoSize = true;
            this.lblOrderid.Location = new System.Drawing.Point(188, 15);
            this.lblOrderid.Name = "lblOrderid";
            this.lblOrderid.Size = new System.Drawing.Size(45, 13);
            this.lblOrderid.TabIndex = 1;
            this.lblOrderid.Text = "Order Id";
            // 
            // cmbOrderid
            // 
            this.cmbOrderid.FormattingEnabled = true;
            this.cmbOrderid.Location = new System.Drawing.Point(188, 31);
            this.cmbOrderid.Name = "cmbOrderid";
            this.cmbOrderid.Size = new System.Drawing.Size(121, 21);
            this.cmbOrderid.TabIndex = 0;
            // 
            // btnSearchlist
            // 
            this.btnSearchlist.Location = new System.Drawing.Point(612, 455);
            this.btnSearchlist.Name = "btnSearchlist";
            this.btnSearchlist.Size = new System.Drawing.Size(122, 23);
            this.btnSearchlist.TabIndex = 31;
            this.btnSearchlist.Text = "Search/List Order";
            this.btnSearchlist.UseVisualStyleBackColor = true;
            this.btnSearchlist.Click += new System.EventHandler(this.btnSearchlist_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(659, 527);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearchlist);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add List Orders";
            this.Load += new System.EventHandler(this.frmOrders_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblUnitprice;
        private System.Windows.Forms.Label lblQuantity2;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblBookid;
        private System.Windows.Forms.Label lblClentid;
        private System.Windows.Forms.ListBox lstPrice;
        private System.Windows.Forms.ListBox lstUnitprice;
        private System.Windows.Forms.Button btnPlaceorder;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ListBox lstQuantity;
        private System.Windows.Forms.ListBox lstBookid;
        private System.Windows.Forms.Button btnAdditem;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.ComboBox cmbBookid;
        private System.Windows.Forms.ComboBox cmbClientid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelorder;
        private System.Windows.Forms.Label lblOrderid;
        private System.Windows.Forms.ComboBox cmbOrderid;
        private System.Windows.Forms.Button btnSearchlist;
        private System.Windows.Forms.Button btnClose;
    }
}