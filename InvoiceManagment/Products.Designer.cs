namespace InvoiceManagment
{
    partial class Products
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            this.butSearch = new System.Windows.Forms.Button();
            this.butHome = new System.Windows.Forms.Button();
            this.butEditProd = new System.Windows.Forms.Button();
            this.butDelProd = new System.Windows.Forms.Button();
            this.butAddProd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(510, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.Location = new System.Drawing.Point(36, 12);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.Size = new System.Drawing.Size(285, 20);
            this.txtbxSearch.TabIndex = 1;
            // 
            // butSearch
            // 
            this.butSearch.Location = new System.Drawing.Point(350, 12);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(75, 23);
            this.butSearch.TabIndex = 2;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = true;
            // 
            // butHome
            // 
            this.butHome.Location = new System.Drawing.Point(471, 12);
            this.butHome.Name = "butHome";
            this.butHome.Size = new System.Drawing.Size(75, 23);
            this.butHome.TabIndex = 3;
            this.butHome.Text = "Home";
            this.butHome.UseVisualStyleBackColor = true;
            this.butHome.Click += new System.EventHandler(this.butHome_Click);
            // 
            // butEditProd
            // 
            this.butEditProd.Location = new System.Drawing.Point(350, 226);
            this.butEditProd.Name = "butEditProd";
            this.butEditProd.Size = new System.Drawing.Size(90, 23);
            this.butEditProd.TabIndex = 4;
            this.butEditProd.Text = "Edit Product";
            this.butEditProd.UseVisualStyleBackColor = true;
            this.butEditProd.Click += new System.EventHandler(this.butEditProd_Click);
            // 
            // butDelProd
            // 
            this.butDelProd.Location = new System.Drawing.Point(456, 226);
            this.butDelProd.Name = "butDelProd";
            this.butDelProd.Size = new System.Drawing.Size(90, 23);
            this.butDelProd.TabIndex = 5;
            this.butDelProd.Text = "Delete Product";
            this.butDelProd.UseVisualStyleBackColor = true;
            // 
            // butAddProd
            // 
            this.butAddProd.Location = new System.Drawing.Point(244, 226);
            this.butAddProd.Name = "butAddProd";
            this.butAddProd.Size = new System.Drawing.Size(90, 23);
            this.butAddProd.TabIndex = 6;
            this.butAddProd.Text = "Add Product";
            this.butAddProd.UseVisualStyleBackColor = true;
            this.butAddProd.Click += new System.EventHandler(this.butAddProd_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.butAddProd);
            this.Controls.Add(this.butDelProd);
            this.Controls.Add(this.butEditProd);
            this.Controls.Add(this.butHome);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.txtbxSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Products";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbxSearch;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.Button butHome;
        private System.Windows.Forms.Button butEditProd;
        private System.Windows.Forms.Button butDelProd;
        private System.Windows.Forms.Button butAddProd;
    }
}