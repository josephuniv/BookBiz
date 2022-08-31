namespace BookBiz.GUI
{
    partial class frmSearchlist
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
            this.lblClientname = new System.Windows.Forms.Label();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnListorders = new System.Windows.Forms.Button();
            this.cmbClientname = new System.Windows.Forms.ComboBox();
            this.dataGridViewDetails = new System.Windows.Forms.DataGridView();
            this.btnListdetails = new System.Windows.Forms.Button();
            this.txtOrderid = new System.Windows.Forms.TextBox();
            this.lblOrderid = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClientname
            // 
            this.lblClientname.AutoSize = true;
            this.lblClientname.Location = new System.Drawing.Point(75, 43);
            this.lblClientname.Name = "lblClientname";
            this.lblClientname.Size = new System.Drawing.Size(64, 13);
            this.lblClientname.TabIndex = 1;
            this.lblClientname.Text = "Client Name";
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(78, 144);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(625, 162);
            this.dataGridViewOrders.TabIndex = 2;
            this.dataGridViewOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellContentClick);
            this.dataGridViewOrders.SelectionChanged += new System.EventHandler(this.dataGridViewOrders_SelectionChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(291, 58);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnListorders
            // 
            this.btnListorders.Location = new System.Drawing.Point(78, 115);
            this.btnListorders.Name = "btnListorders";
            this.btnListorders.Size = new System.Drawing.Size(80, 23);
            this.btnListorders.TabIndex = 4;
            this.btnListorders.Text = "List All orders";
            this.btnListorders.UseVisualStyleBackColor = true;
            this.btnListorders.Click += new System.EventHandler(this.btnListorders_Click);
            // 
            // cmbClientname
            // 
            this.cmbClientname.FormattingEnabled = true;
            this.cmbClientname.Location = new System.Drawing.Point(78, 60);
            this.cmbClientname.Name = "cmbClientname";
            this.cmbClientname.Size = new System.Drawing.Size(121, 21);
            this.cmbClientname.TabIndex = 5;
            // 
            // dataGridViewDetails
            // 
            this.dataGridViewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetails.Location = new System.Drawing.Point(78, 367);
            this.dataGridViewDetails.Name = "dataGridViewDetails";
            this.dataGridViewDetails.Size = new System.Drawing.Size(625, 165);
            this.dataGridViewDetails.TabIndex = 6;
            // 
            // btnListdetails
            // 
            this.btnListdetails.Location = new System.Drawing.Point(198, 340);
            this.btnListdetails.Name = "btnListdetails";
            this.btnListdetails.Size = new System.Drawing.Size(96, 23);
            this.btnListdetails.TabIndex = 8;
            this.btnListdetails.Text = "List Order Details";
            this.btnListdetails.UseVisualStyleBackColor = true;
            this.btnListdetails.Click += new System.EventHandler(this.btnListdetails_Click);
            // 
            // txtOrderid
            // 
            this.txtOrderid.Location = new System.Drawing.Point(78, 340);
            this.txtOrderid.Name = "txtOrderid";
            this.txtOrderid.Size = new System.Drawing.Size(100, 20);
            this.txtOrderid.TabIndex = 9;
            // 
            // lblOrderid
            // 
            this.lblOrderid.AutoSize = true;
            this.lblOrderid.Location = new System.Drawing.Point(75, 324);
            this.lblOrderid.Name = "lblOrderid";
            this.lblOrderid.Size = new System.Drawing.Size(45, 13);
            this.lblOrderid.TabIndex = 10;
            this.lblOrderid.Text = "Order Id";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(628, 555);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmSearchlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 607);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblOrderid);
            this.Controls.Add(this.txtOrderid);
            this.Controls.Add(this.btnListdetails);
            this.Controls.Add(this.dataGridViewDetails);
            this.Controls.Add(this.cmbClientname);
            this.Controls.Add(this.btnListorders);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.lblClientname);
            this.Name = "frmSearchlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search list Orders";
            this.Load += new System.EventHandler(this.frmSearchlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblClientname;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnListorders;
        private System.Windows.Forms.ComboBox cmbClientname;
        private System.Windows.Forms.DataGridView dataGridViewDetails;
        private System.Windows.Forms.Button btnListdetails;
        private System.Windows.Forms.TextBox txtOrderid;
        private System.Windows.Forms.Label lblOrderid;
        private System.Windows.Forms.Button btnClose;
    }
}