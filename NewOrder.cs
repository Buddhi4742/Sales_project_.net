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
    public partial class NewOrder : Form
    {

        double up = 0;
        
        public NewOrder()
        {
            InitializeComponent();
        }

        private void NewOrder_Load(object sender, EventArgs e)
        {

            String cs = @"Data Source=(local);Initial Catalog=ShopDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            String sq = "select Itemtype from Item";
            SqlCommand cm = new SqlCommand(sq, con);

            SqlDataReader dr;
            dr = cm.ExecuteReader();



            while (dr.Read())
            {
                string itemtype = dr.GetString(0);
                this.cmb_itemtype.Items.Add(itemtype);

            }



        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmb_itemtype_SelectedIndexChanged(object sender, EventArgs e)
        {


            String cs = @"Data Source=(local);Initial Catalog=ShopDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            String sq = "select Unitprice from Item where Itemtype= '"+this.cmb_itemtype.SelectedItem+"'";
            SqlCommand cm = new SqlCommand(sq, con);

            SqlDataReader dr;
            dr = cm.ExecuteReader();

            dr.Read();

           up = Double.Parse(dr.GetString(0));

           this.txt_unitprice.Text = up.ToString(); 
        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {
            if (this.txt_unitprice.Text != "" && this.txt_qty.Text != "")
            {
                int qty = Int32.Parse(this.txt_qty.Text);


                this.txt_totcost.Text = (qty * up).ToString();

            }
         
            



        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (this.txt_totcost.Text != "" && this.txt_unitprice.Text != "" && this.txt_qty.Text != "" && this.cmb_itemtype.Text != "")
            {
                String cs = @"Data Source=(local);Initial Catalog=ShopDB;Integrated Security=True";
                SqlConnection con = new SqlConnection(cs);
                con.Open();

                String sql = "insert into Item_Orders(Itemtype,Unitprice,Qty,Tot_cost) values('" + this.cmb_itemtype.SelectedItem + "','" + this.txt_unitprice.Text + "','" + this.txt_qty.Text + "','" + this.txt_totcost.Text + "')";
                SqlCommand cm = new SqlCommand(sql, con);

                cm.ExecuteNonQuery();

                MessageBox.Show("New order Added ");

                con.Close();
            }

        }
    }
}
