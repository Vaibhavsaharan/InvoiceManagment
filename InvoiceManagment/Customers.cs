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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void butHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void butAddCus_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCustomer addCus = new AddCustomer();
            addCus.Show();
        }
    }
}
