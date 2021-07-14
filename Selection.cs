using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sales_project
{
    public partial class Selection : Form
    {
        string ID;
        public Selection(string ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void placeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaceOrder frm = new PlaceOrder(ID);
            frm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewItem frm = new NewItem();
            frm.ShowDialog();
        }

        private void itemOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewOrder frm = new NewOrder();
            frm.ShowDialog();
        }

        private void checkOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckOrder frm = new CheckOrder(ID);
            frm.ShowDialog();
        }

        private void Selection_Load(object sender, EventArgs e)
        {
            if (this.ID == "Employee")
            {
                this.employeeToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.employeeToolStripMenuItem.Enabled = false;
            }


        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccoutReport frm = new AccoutReport();
            frm.ShowDialog();
        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemReport frm = new ItemReport();
            frm.ShowDialog();
        }

        private void shopOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShopOrdersReport frm = new ShopOrdersReport();
            frm.ShowDialog();

        }

        private void customerOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustOrdersReport frm = new CustOrdersReport();
            frm.ShowDialog();
        }
    }
}
