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
    public partial class NewItem : Form
    {
        public NewItem()
        {
            InitializeComponent();
        }

        private void txt_itemcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
             String cs = @"Data Source=(local);Initial Catalog=ShopDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

             SqlDataAdapter data =new SqlDataAdapter("Select Count(*) From Item where Itemcode ='"+this.txt_itemcode.Text+"'and Itemname='"+this.txt_itemname.Text+"'",con);
                DataTable table = new DataTable();
                data.Fill(table);

                if (table.Rows[0][0].ToString() != "1")
                {
                    String sql = "insert into Item(Itemcode,Itemname,Itemtype,Unitprice) values('" + this.txt_itemcode.Text + "','" + this.txt_itemname.Text + "','" + this.txt_itemtype.Text + "','"+this.txt_price.Text+"')";
                    SqlCommand cm = new SqlCommand(sql, con);

                    cm.ExecuteNonQuery();

                    MessageBox.Show("New Item Added ");

                    con.Close();

                }
                else
                {
                    MessageBox.Show("Same item Already Exists");
                    this.txt_itemname.Text = "";
                    this.txt_itemcode.Text = "";


                }
        }
    }
}
