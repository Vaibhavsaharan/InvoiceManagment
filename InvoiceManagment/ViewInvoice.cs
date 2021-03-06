﻿using System;
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
    public partial class ViewInvoice : Form
    {
        public ViewInvoice()
        {
            InitializeComponent();
        }

        private void butHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private void butInv_Click(object sender, EventArgs e)
        {
            this.Hide();
            Invoices invo = new Invoices();
            invo.Show();
        }
    }
}
