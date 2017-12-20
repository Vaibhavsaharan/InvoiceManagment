using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManagment
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void butProd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products prds = new Products();
            prds.Show();
        }

        private void butCus_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customers cus = new Customers();
            cus.Show();
        }

        private void butInvoices_Click(object sender, EventArgs e)
        {
            this.Hide();
            Invoices invo = new Invoices();
            invo.Show();
        }
    }
}
