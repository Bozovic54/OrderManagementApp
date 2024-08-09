namespace EntityProject
{
    partial class FrmMain
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
            this.dgwOrders = new System.Windows.Forms.DataGridView();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnOrderDetails = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbmSearch = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwOrders
            // 
            this.dgwOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrders.Location = new System.Drawing.Point(22, 61);
            this.dgwOrders.Name = "dgwOrders";
            this.dgwOrders.RowHeadersWidth = 51;
            this.dgwOrders.RowTemplate.Height = 24;
            this.dgwOrders.Size = new System.Drawing.Size(854, 417);
            this.dgwOrders.TabIndex = 0;
            this.dgwOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOrders_CellClick);
            this.dgwOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOrders_CellDoubleClick);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(920, 61);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(85, 34);
            this.btnAddOrder.TabIndex = 1;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(791, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(685, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.TabIndex = 4;
            // 
            // btnOrderDetails
            // 
            this.btnOrderDetails.Location = new System.Drawing.Point(920, 117);
            this.btnOrderDetails.Name = "btnOrderDetails";
            this.btnOrderDetails.Size = new System.Drawing.Size(85, 34);
            this.btnOrderDetails.TabIndex = 5;
            this.btnOrderDetails.Text = "Details";
            this.btnOrderDetails.UseVisualStyleBackColor = true;
            this.btnOrderDetails.Click += new System.EventHandler(this.btnOrderDetails_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.label1.Location = new System.Drawing.Point(438, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search by:";
            // 
            // cbmSearch
            // 
            this.cbmSearch.FormattingEnabled = true;
            this.cbmSearch.Items.AddRange(new object[] {
            "Employee",
            "Customer",
            "Product"});
            this.cbmSearch.Location = new System.Drawing.Point(533, 27);
            this.cbmSearch.Name = "cbmSearch";
            this.cbmSearch.Size = new System.Drawing.Size(121, 24);
            this.cbmSearch.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(920, 171);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 33);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 533);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbmSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOrderDetails);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.dgwOrders);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwOrders;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnOrderDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbmSearch;
        private System.Windows.Forms.Button btnDelete;
    }
}

