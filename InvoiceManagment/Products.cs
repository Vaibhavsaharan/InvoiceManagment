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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void butAddProd_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProducts addprod=new AddProducts();
            addprod.Show();
        }

        private void butEditProd_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditProducts editprod = new EditProducts();
            editprod.Show();
        }
    }
}
