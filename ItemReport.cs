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
    public partial class ItemReport : Form
    {
        public ItemReport()
        {
            InitializeComponent();
        }

        private void ItemReport_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            this.crystalReportViewer1.ReportSource = @"E:\NIBM Project\Windows Forms\Sales_project\Sales_project\Item.rpt";
            this.crystalReportViewer1.RefreshReport();
        }
    }
}
