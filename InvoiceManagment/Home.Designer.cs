namespace InvoiceManagment
{
    partial class Home
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
            this.butCus = new System.Windows.Forms.Button();
            this.butProd = new System.Windows.Forms.Button();
            this.butInvoices = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butCus
            // 
            this.butCus.Location = new System.Drawing.Point(226, 124);
            this.butCus.Name = "butCus";
            this.butCus.Size = new System.Drawing.Size(120, 60);
            this.butCus.TabIndex = 0;
            this.butCus.Text = "Customer";
            this.butCus.UseVisualStyleBackColor = true;
            this.butCus.Click += new System.EventHandler(this.butCus_Click);
            // 
            // butProd
            // 
            this.butProd.Location = new System.Drawing.Point(54, 124);
            this.butProd.Name = "butProd";
            this.butProd.Size = new System.Drawing.Size(120, 60);
            this.butProd.TabIndex = 1;
            this.butProd.Text = "Products";
            this.butProd.UseVisualStyleBackColor = true;
            this.butProd.Click += new System.EventHandler(this.butProd_Click);
            // 
            // butInvoices
            // 
            this.butInvoices.Location = new System.Drawing.Point(403, 124);
            this.butInvoices.Name = "butInvoices";
            this.butInvoices.Size = new System.Drawing.Size(120, 60);
            this.butInvoices.TabIndex = 2;
            this.butInvoices.Text = "Invoices";
            this.butInvoices.UseVisualStyleBackColor = true;
            this.butInvoices.Click += new System.EventHandler(this.butInvoices_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = " Winhe IT";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butInvoices);
            this.Controls.Add(this.butProd);
            this.Controls.Add(this.butCus);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butCus;
        private System.Windows.Forms.Button butProd;
        private System.Windows.Forms.Button butInvoices;
        private System.Windows.Forms.Label label1;
    }
}