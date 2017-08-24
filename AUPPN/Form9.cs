using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AUPPN
{
    public partial class Form9 : Form
    {
       
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            Form5 main = this.Owner as Form5;
           
            try
            {               
                this.saleeTableAdapter.FillBy1(this.bddiplomDataSet.salee, ((int)(System.Convert.ChangeType(main.persale, typeof(int)))));
           
                this.reportViewer1.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
     
        }

     
    }
}
