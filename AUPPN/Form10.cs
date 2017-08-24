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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        public string constring = "datasource = localhost; port=3306;username=root;password=1234;charset=utf8";
       

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.Beep(); 
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Query = "select managers.fio,sum(store.amount*goods.price) as summa from bddiplom.store,bddiplom.goods,bddiplom.sales,bddiplom.managers where managers.id_manager = sales.id_manager and sales.id_sale =store.id_sale and store.id_good=goods.id_good and sales.date between '" + this.dateTimePicker1.Value.ToString("yyyy.MM.dd") + "' and '" + this.dateTimePicker2.Value.ToString("yyyy.MM.dd") + "' group by managers.fio ";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                this.chart1.Series[0].Points.Clear();
                while (myReader.Read())
                {
                    this.chart1.Series[0].Points.AddXY(myReader.GetString("fio"), myReader.GetInt32("summa"));
                }
                conDataBase.Close();
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.Columns[0].HeaderText = "ФИО";
            dataGridView1.Columns[1].HeaderText = "Сумма";
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 a1 = new AboutBox1();
            a1.ShowDialog();
        }



    }
}
