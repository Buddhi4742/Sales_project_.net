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
    public partial class CheckOrder : Form
    {
        string ID;
        public CheckOrder(string ID)
        {
            InitializeComponent();
            this.ID = ID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CheckOrder_Load(object sender, EventArgs e)
        {
            this.txt_ID.Text = ID;
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            String cs = @"Data Source=(local);Initial Catalog=ShopDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();


        }

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {

            String cs = @"Data Source=(local);Initial Catalog=ShopDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            

                String sq = "select Itemtype from Cust_orders where Cust_ID='"+this.txt_ID.Text+"'";
                SqlCommand cm = new SqlCommand(sq, con);

                SqlDataReader dr;
                dr = cm.ExecuteReader();



                while (dr.Read())
                {
                    string itemtype = dr.GetString(0);
                    this.cmb_itemtype.Items.Add(itemtype);

                }
            }

        private void cmb_itemtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmb_itemtype.Text != "")
            {
                String cs = @"Data Source=(local);Initial Catalog=ShopDB;Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();

                String sq = "select Unitprice,Tot_cost,Qty from Cust_orders where Itemtype= '" + this.cmb_itemtype.Text + "'";
                SqlCommand cm = new SqlCommand(sq, con);

                SqlDataReader dr;
                dr = cm.ExecuteReader();

                dr.Read();

                this.lbl_price.Text = dr.GetString(0);
                this.lbl_cost.Text = dr.GetString(1);
                this.lbl_qty.Text = dr.GetString(2);
                


            }
        }

        }
    }

