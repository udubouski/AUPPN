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
    public partial class Form7 : Form
    {
        
        public string constring = "datasource = localhost; port=3306;username=root;password=1234;charset=utf8";
        public Form7()
        {
            InitializeComponent();
            groupBox1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            this.comboBox1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseWheel);
            this.comboBox2.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox2_MouseWheel);

        }
        private void comboBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            HandledMouseEventArgs ev = e as HandledMouseEventArgs;
            if (ev != null)
            {
                ev.Handled = true;
            }
        }
        private void comboBox2_MouseWheel(object sender, MouseEventArgs e)
        {
            HandledMouseEventArgs ev = e as HandledMouseEventArgs;
            if (ev != null)
            {
                ev.Handled = true;
            }
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.Beep(); 
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Form4 f4 = new Form4();
            f4.Show();
            
        }

        public void combo1() //providers
        {
            string Query = "select * from bddiplom.kontragents where id_type=1";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string kontrname = myReader.GetString("name");
                    comboBox1.Items.Add(kontrname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form4 main = this.Owner as Form4;
            DataView DV = new DataView(main.dbdatasett);
            DV.RowFilter = string.Format("namekon Like '%{0}%'", comboBox1.Text);
            dataGridView1.DataSource = DV;
            
        }

        public void combo2() //group_goods
        {
            string Query = "select * from bddiplom.group_goods ";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string kontrname = myReader.GetString("name");
                    comboBox2.Items.Add(kontrname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form4 main = this.Owner as Form4;
            DataView DV = new DataView(main.dbdatasett);
            DV.RowFilter = string.Format("nameer Like '%{0}%'", comboBox2.Text);
            dataGridView1.DataSource = DV;
         
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = -1;
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 a1 = new AboutBox1();
            a1.ShowDialog();
        }

       

    


    }
}
