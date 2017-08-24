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
    public partial class Form5 : Form
    {
        public string constring = "datasource = localhost; port=3306;username=root;password=1234;charset=utf8";
        public Form5()
        {
            InitializeComponent();
            combo1();
            combo2();
            combo3();
            groupBox2.Enabled = false;
            button6.Enabled = false;
            button5.Enabled = false;
            button4.Enabled = false;
            this.comboBox1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseWheel);
            this.comboBox2.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox2_MouseWheel);
            this.comboBox3.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox3_MouseWheel);
            this.comboBox4.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox4_MouseWheel);
            this.comboBox5.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox5_MouseWheel);

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.Beep(); 
            Application.Exit();
        }
        public void combo1() //clients
        {
            string Query = "select * from bddiplom.kontragents where id_type=2";
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

        public string sale1;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "select * from bddiplom.kontragents where name='" + comboBox1.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    sale1 = myReader.GetInt32("id_kontragent").ToString();
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void combo2() //managers sales
        {
            string Query = "select * from bddiplom.managers where id_department=2";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string managname = myReader.GetString("fio");
                    comboBox2.Items.Add(managname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string sale2;
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "select * from bddiplom.managers where fio='" + comboBox2.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    sale2 = myReader.GetInt32("id_manager").ToString();
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == string.Empty || comboBox2.Text == string.Empty)
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                int numm1 = Convert.ToInt32(sale1);
                int numm2 = Convert.ToInt32(sale2);
                string Query = "insert into bddiplom.sales (id_kontragent,id_manager,date) values ('" + numm1 + "', '" + numm2 + "', '" + this.dateTimePicker1.Text + "') ;";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;
                try
                {
                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    MessageBox.Show("Заявка принята!");
                    while (myReader.Read())
                    {

                    }
                    sale();
                    conDataBase.Close();
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Такая запись уже существует. Укажите другие данные !");
                }
            }

        }

        public void combo3() // provider
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
                    string buyname = myReader.GetString("name");
                    comboBox3.Items.Add(buyname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "select  distinct group_goods.name as namegro from bddiplom.group_goods,bddiplom.goods,bddiplom.buys,bddiplom.kontragents where buys.id_kontragent = kontragents.id_kontragent and goods.id_buy = buys.id_buy and goods.id_group =group_goods.id_group  and kontragents.name = '" + this.comboBox3.Text + "'";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string namegro = myReader.GetString("namegro");
                    comboBox4.Items.Add(namegro);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "select distinct goods.name as namegro from bddiplom.goods,bddiplom.group_goods,bddiplom.kontragents,bddiplom.buys where goods.id_buy = buys.id_buy and goods.id_group=group_goods.id_group and buys.id_kontragent = kontragents.id_kontragent and group_goods.name = '" + this.comboBox4.Text + "' and kontragents.name ='" + this.comboBox3.Text + "';";

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string namegro = myReader.GetString("namegro");
                    comboBox5.Items.Add(namegro);


                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox4_Click(object sender, EventArgs e)
        {
            comboBox5.Items.Clear();
        }

        public string persale;

        public void sale()
        {
            int numm1 = Convert.ToInt32(sale1);
            int numm2 = Convert.ToInt32(sale2);
            string Query = "select sales.id_sale from bddiplom.sales where sales.id_kontragent = '" + numm1 + "'and sales.id_manager ='" + numm2 + "' and date='" + this.dateTimePicker1.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    persale = myReader.GetInt32("id_sale").ToString();

                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public string store;
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "select goods.id_good from bddiplom.goods,bddiplom.buys,bddiplom.group_goods,bddiplom.kontragents where buys.id_kontragent = kontragents.id_kontragent and goods.id_buy=buys.id_buy and group_goods.id_group = goods.id_group and goods.name='" + comboBox5.Text + "' and kontragents.name ='" + this.comboBox3.Text + "' and group_goods.name='" + this.comboBox4.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    store = myReader.GetInt32("id_good").ToString();

                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                MessageBox.Show("Введите число от 1 до 9999!");
            }
            else if (textBox1.Text == string.Empty || comboBox5.Text == string.Empty || comboBox3.Text == string.Empty || comboBox4.Text == string.Empty)
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                int numm1 = Convert.ToInt32(persale);
                int numm2 = Convert.ToInt32(store);

                string Query = "insert into bddiplom.store (id_sale,id_good,amount) values ('" + numm1 + "', '" + numm2 + "', '" + this.textBox1.Text + "') ;";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;
                try
                {
                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    MessageBox.Show("Заявка оформлена!");
                    while (myReader.Read())
                    {

                    }
                    conDataBase.Close();
                    comboBox3.SelectedIndex = -1;
                    comboBox4.SelectedIndex = -1;
                    comboBox5.SelectedIndex = -1;
                    textBox1.Clear();
                    button6.Enabled = true;
                    button5.Enabled = true;
                    button4.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Такая позиция в заявке уже существует!");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form4 f4 = new Form4();
            f4.Show();
            Close();
        }



        private void button4_Click(object sender, EventArgs e)
        {

            Form9 f9 = new Form9();
            f9.Owner = this;
            f9.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {

            int numm1 = Convert.ToInt32(persale);
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("Select store.id_store,kontragents.name as namekon,managers.fio,sales.date,concat (group_goods.name,' ',goods.name) as nametov ,store.amount,goods.price,store.amount*goods.price as summa from bddiplom.store,bddiplom.sales,bddiplom.goods, bddiplom.kontragents,bddiplom.group_goods,bddiplom.managers where store.id_sale = sales.id_sale and sales.id_kontragent=kontragents.id_kontragent and store.id_good=goods.id_good and managers.id_manager = sales.id_manager and goods.id_group = group_goods.id_group and store.id_sale='" + numm1 + "' order by id_store;", conDataBase);

            try
            {
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

            dataGridView1.Columns[0].HeaderText = "Код";
            dataGridView1.Columns[1].HeaderText = "Клиент";
            dataGridView1.Columns[2].HeaderText = "Менеджер";
            dataGridView1.Columns[3].HeaderText = "Дата";
            dataGridView1.Columns[4].HeaderText = "Название товара";
            dataGridView1.Columns[5].HeaderText = "Количество";
            dataGridView1.Columns[6].HeaderText = "Цена";
            dataGridView1.Columns[7].HeaderText = "Сумма";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            textBox1.Clear();
            dateTimePicker1.ResetText();
            dataGridView1.DataSource = new object();
            button6.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            groupBox2.Enabled = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
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
        private void comboBox3_MouseWheel(object sender, MouseEventArgs e)
        {
            HandledMouseEventArgs ev = e as HandledMouseEventArgs;
            if (ev != null)
            {
                ev.Handled = true;
            }
        }

        private void comboBox4_MouseWheel(object sender, MouseEventArgs e)
        {
            HandledMouseEventArgs ev = e as HandledMouseEventArgs;
            if (ev != null)
            {
                ev.Handled = true;
            }
        }

        private void comboBox5_MouseWheel(object sender, MouseEventArgs e)
        {
            HandledMouseEventArgs ev = e as HandledMouseEventArgs;
            if (ev != null)
            {
                ev.Handled = true;
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 a1 = new AboutBox1();
            a1.ShowDialog();
        }

    }
}


