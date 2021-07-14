using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sales_project
{
    public partial class Login : Form
    {
        string ID = "Employee";
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_emp_Click(object sender, EventArgs e)
        {

            if (this.txt_emppass.Text != "" && this.txt_empuser.Text != "")
            {
                String cs = @"Data Source=(local);Initial Catalog=ShopDB;Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();


                SqlDataAdapter data = new SqlDataAdapter("Select Count(*) From Account where UsernameID ='" + this.txt_empuser.Text + "'and Password='"+this.txt_emppass.Text+"'", con);
                DataTable table = new DataTable();
                data.Fill(table);

                if (table.Rows[0][0].ToString() == "1")
                {
                   
                    MessageBox.Show("Login Complete");
                    this.Hide();
                    Selection frm= new Selection(ID);
                    frm.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Wrong Username Or password, Re enter");
                    this.txt_emppass.Text = "";
                    this.txt_empuser.Text = "";

                }
            }
        }
    }
}
