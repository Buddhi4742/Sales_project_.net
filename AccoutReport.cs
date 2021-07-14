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
    public partial class AccoutReport : Form
    {
        public AccoutReport()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            this.crystalReportViewer1.ReportSource = @"E:\NIBM Project\Windows Forms\Sales_project\Sales_project\Account.rpt";
            this.crystalReportViewer1.RefreshReport();

        }
    }
}
