using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AUPPN
{
    public partial class Form8 : Form
    {
        public string constring = "datasource = localhost; port=3306;username=root;password=1234;charset=utf8";
        public Form8()
        {
            InitializeComponent();
            //combo1();
           
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            string ss = thisDay.ToString("d");
            this.pricelistTableAdapter.Fill(this.bddiplomDataSetpricelist.pricelist);
            reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("ReportParameter1", ss));
            this.reportViewer1.RefreshReport();

        }
    }
}
