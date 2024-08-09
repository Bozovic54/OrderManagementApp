namespace EntityProject
{
    partial class FrmOrderDetails
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
            this.dgwOrderDetails = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwOrderDetails
            // 
            this.dgwOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOrderDetails.Location = new System.Drawing.Point(23, 41);
            this.dgwOrderDetails.Name = "dgwOrderDetails";
            this.dgwOrderDetails.RowHeadersWidth = 51;
            this.dgwOrderDetails.RowTemplate.Height = 24;
            this.dgwOrderDetails.Size = new System.Drawing.Size(765, 397);
            this.dgwOrderDetails.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(84, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "<----";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(327, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // FrmOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgwOrderDetails);
            this.Name = "FrmOrderDetails";
            this.Text = "FrmOrderDetails";
            this.Load += new System.EventHandler(this.FrmOrderDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwOrderDetails;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox textBox1;
    }
}