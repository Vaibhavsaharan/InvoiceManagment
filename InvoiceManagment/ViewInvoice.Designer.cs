namespace InvoiceManagment
{
    partial class ViewInvoice
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
            this.butInv = new System.Windows.Forms.Button();
            this.butHome = new System.Windows.Forms.Button();
            this.butSearch = new System.Windows.Forms.Button();
            this.txtbxSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // butInv
            // 
            this.butInv.Location = new System.Drawing.Point(393, 17);
            this.butInv.Name = "butInv";
            this.butInv.Size = new System.Drawing.Size(73, 23);
            this.butInv.TabIndex = 23;
            this.butInv.Text = "Invoice";
            this.butInv.UseVisualStyleBackColor = true;
            this.butInv.Click += new System.EventHandler(this.butInv_Click);
            // 
            // butHome
            // 
            this.butHome.Location = new System.Drawing.Point(472, 17);
            this.butHome.Name = "butHome";
            this.butHome.Size = new System.Drawing.Size(75, 23);
            this.butHome.TabIndex = 22;
            this.butHome.Text = "Home";
            this.butHome.UseVisualStyleBackColor = true;
            this.butHome.Click += new System.EventHandler(this.butHome_Click);
            // 
            // butSearch
            // 
            this.butSearch.Location = new System.Drawing.Point(282, 14);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(75, 23);
            this.butSearch.TabIndex = 21;
            this.butSearch.Text = "Search";
            this.butSearch.UseVisualStyleBackColor = true;
            // 
            // txtbxSearch
            // 
            this.txtbxSearch.Location = new System.Drawing.Point(37, 17);
            this.txtbxSearch.Name = "txtbxSearch";
            this.txtbxSearch.Size = new System.Drawing.Size(155, 20);
            this.txtbxSearch.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(510, 194);
            this.dataGridView1.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(209, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(56, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // ViewInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.butInv);
            this.Controls.Add(this.butHome);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.txtbxSearch);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewInvoice";
            this.Text = "View Invoice";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butInv;
        private System.Windows.Forms.Button butHome;
        private System.Windows.Forms.Button butSearch;
        private System.Windows.Forms.TextBox txtbxSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}