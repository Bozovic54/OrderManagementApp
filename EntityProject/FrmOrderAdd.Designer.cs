namespace EntityProject
{
    partial class FrmOrderAdd
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
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.dgwOrderDetails = new System.Windows.Forms.DataGridView();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnAddDetails = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblCusomer = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(32, 65);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(121, 24);
            this.cmbEmployee.TabIndex = 0;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(201, 61);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(121, 24);
            this.cmbCustomer.TabIndex = 1;
            // 
            // dgwOrderDetails
            // 
            this.dgwOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrderDetails.Location = new System.Drawing.Point(32, 252);
            this.dgwOrderDetails.Name = "dgwOrderDetails";
            this.dgwOrderDetails.RowHeadersWidth = 51;
            this.dgwOrderDetails.RowTemplate.Height = 24;
            this.dgwOrderDetails.Size = new System.Drawing.Size(571, 201);
            this.dgwOrderDetails.TabIndex = 3;
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(32, 182);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(121, 24);
            this.cmbProduct.TabIndex = 6;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(360, 63);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(130, 22);
            this.txtDate.TabIndex = 7;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(523, 61);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(80, 28);
            this.btnAddOrder.TabIndex = 8;
            this.btnAddOrder.Text = "Add ";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnAddDetails
            // 
            this.btnAddDetails.Location = new System.Drawing.Point(523, 179);
            this.btnAddDetails.Name = "btnAddDetails";
            this.btnAddDetails.Size = new System.Drawing.Size(80, 27);
            this.btnAddDetails.TabIndex = 9;
            this.btnAddDetails.Text = "Add";
            this.btnAddDetails.UseVisualStyleBackColor = true;
            this.btnAddDetails.Click += new System.EventHandler(this.btnAddDetails_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(201, 184);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 22);
            this.txtPrice.TabIndex = 10;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(360, 184);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(121, 22);
            this.txtQuantity.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(632, 423);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.lblEmployee.Location = new System.Drawing.Point(49, 41);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(79, 17);
            this.lblEmployee.TabIndex = 14;
            this.lblEmployee.Text = "Employee";
            // 
            // lblCusomer
            // 
            this.lblCusomer.AutoSize = true;
            this.lblCusomer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCusomer.Location = new System.Drawing.Point(222, 41);
            this.lblCusomer.Name = "lblCusomer";
            this.lblCusomer.Size = new System.Drawing.Size(79, 17);
            this.lblCusomer.TabIndex = 15;
            this.lblCusomer.Text = "Customer";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.lblDateTime.Location = new System.Drawing.Point(386, 43);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(81, 17);
            this.lblDateTime.TabIndex = 16;
            this.lblDateTime.Text = "Date/Time";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.lblProduct.Location = new System.Drawing.Point(62, 162);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(66, 17);
            this.lblProduct.TabIndex = 17;
            this.lblProduct.Text = "Product";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.label5.Location = new System.Drawing.Point(238, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.label6.Location = new System.Drawing.Point(386, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Quantity";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(14, 9);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(57, 18);
            this.lblOrder.TabIndex = 20;
            this.lblOrder.Text = "Order:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Order Details:";
            // 
            // FrmOrderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblCusomer);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnAddDetails);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.dgwOrderDetails);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.cmbEmployee);
            this.Name = "FrmOrderAdd";
            this.Text = "FrmOrderAdd";
            this.Load += new System.EventHandler(this.FrmOrderAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.DataGridView dgwOrderDetails;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnAddDetails;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblCusomer;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label label1;
    }
}