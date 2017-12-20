namespace InvoiceManagment
{
    partial class AddProducts
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
            this.butHome = new System.Windows.Forms.Button();
            this.butProd = new System.Windows.Forms.Button();
            this.txtbxProdName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbxDes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxPurchPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbxSelPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbxQty = new System.Windows.Forms.TextBox();
            this.butAddProd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butHome
            // 
            this.butHome.Location = new System.Drawing.Point(463, 25);
            this.butHome.Name = "butHome";
            this.butHome.Size = new System.Drawing.Size(75, 23);
            this.butHome.TabIndex = 1;
            this.butHome.Text = "Home";
            this.butHome.UseVisualStyleBackColor = true;
            this.butHome.Click += new System.EventHandler(this.butHome_Click);
            // 
            // butProd
            // 
            this.butProd.Location = new System.Drawing.Point(358, 25);
            this.butProd.Name = "butProd";
            this.butProd.Size = new System.Drawing.Size(75, 23);
            this.butProd.TabIndex = 2;
            this.butProd.Text = "Products";
            this.butProd.UseVisualStyleBackColor = true;
            this.butProd.Click += new System.EventHandler(this.butProd_Click);
            // 
            // txtbxProdName
            // 
            this.txtbxProdName.Location = new System.Drawing.Point(155, 68);
            this.txtbxProdName.Name = "txtbxProdName";
            this.txtbxProdName.Size = new System.Drawing.Size(320, 20);
            this.txtbxProdName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // txtbxDes
            // 
            this.txtbxDes.Location = new System.Drawing.Point(155, 102);
            this.txtbxDes.Name = "txtbxDes";
            this.txtbxDes.Size = new System.Drawing.Size(320, 20);
            this.txtbxDes.TabIndex = 5;
            this.txtbxDes.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Purchase Price";
            // 
            // txtbxPurchPrice
            // 
            this.txtbxPurchPrice.Location = new System.Drawing.Point(155, 131);
            this.txtbxPurchPrice.Name = "txtbxPurchPrice";
            this.txtbxPurchPrice.Size = new System.Drawing.Size(100, 20);
            this.txtbxPurchPrice.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Selling Price";
            // 
            // txtbxSelPrice
            // 
            this.txtbxSelPrice.Location = new System.Drawing.Point(155, 161);
            this.txtbxSelPrice.Name = "txtbxSelPrice";
            this.txtbxSelPrice.Size = new System.Drawing.Size(100, 20);
            this.txtbxSelPrice.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Quantity";
            // 
            // txtbxQty
            // 
            this.txtbxQty.Location = new System.Drawing.Point(155, 197);
            this.txtbxQty.Name = "txtbxQty";
            this.txtbxQty.Size = new System.Drawing.Size(100, 20);
            this.txtbxQty.TabIndex = 11;
            // 
            // butAddProd
            // 
            this.butAddProd.Location = new System.Drawing.Point(463, 226);
            this.butAddProd.Name = "butAddProd";
            this.butAddProd.Size = new System.Drawing.Size(75, 23);
            this.butAddProd.TabIndex = 13;
            this.butAddProd.Text = "Add Product";
            this.butAddProd.UseVisualStyleBackColor = true;
            this.butAddProd.Click += new System.EventHandler(this.butAddProd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Add Product";
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.butAddProd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbxQty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbxSelPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbxPurchPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbxDes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbxProdName);
            this.Controls.Add(this.butProd);
            this.Controls.Add(this.butHome);
            this.Name = "AddProducts";
            this.Text = "Add Products";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butHome;
        private System.Windows.Forms.Button butProd;
        private System.Windows.Forms.TextBox txtbxProdName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbxDes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxPurchPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbxSelPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbxQty;
        private System.Windows.Forms.Button butAddProd;
        private System.Windows.Forms.Label label7;
    }
}