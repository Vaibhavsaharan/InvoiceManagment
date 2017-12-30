namespace InvoiceManagment
{
    partial class Customers
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
            this.butAddCus = new System.Windows.Forms.Button();
            this.butHome = new System.Windows.Forms.Button();
            this.butSearch = new System.Windows.Forms.Button();
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            this.grdCustomers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // butAddCus
            // 
            this.butAddCus.Location = new System.Drawing.Point(457, 226);
            this.butAddCus.Name = "butAddCus";
            this.butAddCus.Size = new System.Drawing.Size(90, 23);
            this.butAddCus.TabIndex = 13;
            this.butAddCus.Text = "Add Customer";
            this.butAddCus.UseVisualStyleBackColor = true;
            this.butAddCus.Click += new System.EventHandler(this.butAddCus_Click);
            // 
            // butHome
            // 
            this.butHome.Location = new System.Drawing.Point(472, 12);
            this.butHome.Name = "butHome";
            this.butHome.Size = new System.Drawing.Size(75, 23);
            this.butHome.TabIndex = 10;
            this.butHome.Text = "Home";
            this.butHome.UseVisualStyleBackColor = true;
            this.butHome.Click += new System.EventHandler(this.butHome_Click);
            // 
            // butSearch
            // 
            this.butSearch.Location = new System.Drawing.Point(351, 12);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(75, 23);
            this.butSearch.TabIndex = 9;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = true;
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.Location = new System.Drawing.Point(37, 12);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.Size = new System.Drawing.Size(285, 20);
            this.txtbxSearch.TabIndex = 8;
            // 
            // grdCustomers
            // 
            this.grdCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustomers.Location = new System.Drawing.Point(37, 55);
            this.grdCustomers.Name = "grdCustomers";
            this.grdCustomers.Size = new System.Drawing.Size(510, 150);
            this.grdCustomers.TabIndex = 7;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.butAddCus);
            this.Controls.Add(this.butHome);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.txtbxSearch);
            this.Controls.Add(this.grdCustomers);
            this.Name = "Customers";
            this.Text = "Customers";
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAddCus;
        private System.Windows.Forms.Button butHome;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.TextBox txtbxSearch;
        private System.Windows.Forms.DataGridView grdCustomers;
    }
}