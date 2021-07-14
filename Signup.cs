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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void btn_create_Click(object sender, EventArgs e)
        {  String cs = @"Data Source=(local);Initial Catalog=ShopDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

             SqlDataAdapter data =new SqlDataAdapter("Select Count(*) From Account where UsernameID ='"+this.txt_empuser.Text+"'",con);
                DataTable table = new DataTable();
                data.Fill(table);

                if (table.Rows[0][0].ToString() != "1")
                {

                    String sql = "insert into Account(Name,UsernameID,Password) values('" + this.txt_empname.Text + "','" + this.txt_empuser.Text + "','" + this.txt_pass.Text + "')";
                    SqlCommand cm = new SqlCommand(sql, con);

                    cm.ExecuteNonQuery();

                    MessageBox.Show("Account created ");

                    con.Close();

                }
                else
                {
                    MessageBox.Show("Account is Already created ");

                }
}

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
