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
    public partial class Main : Form
    {

        string ID="";
        public Main()
        {

            InitializeComponent();
        
        }

      

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Signup frm = new Signup();
            frm.ShowDialog();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.ShowDialog();
        }

      

      

        private void rad_yes_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rad_yes.Checked == true)
            {

                this.panel1.Enabled = true;

            }
            
        }

        private void rad_no_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rad_no.Checked==true)
            {
                this.panel1.Enabled = false;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.rad_yes.Checked = false;
            this.rad_no.Checked = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_go_Click(object sender, EventArgs e)
        {
            
           ID= this.txt_ID.Text;

           
            Selection frm = new Selection(ID);
            frm.ShowDialog();
      
         
        }

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {
            if (this.txt_ID.Text != "")
            {
                this.btn_go.Enabled = true;
            }
            else
            {
                this.btn_go.Enabled = false;
            }
        }
    }
}
