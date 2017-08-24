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
    public partial class Form4 : Form
    {
        public DataTable dbdatasett;
        Form7 f7 = new Form7();
        public string constring = "datasource = localhost; port=3306;username=root;password=1234;charset=utf8";
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Close();
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.Beep(); 
            Application.Exit();
        }

        private void группыТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.Show();
            f7.Text = "Группы товаров";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select id_group,name from bddiplom.group_goods order by id_group;", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                f7.dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            f7.dataGridView1.Columns[0].HeaderText = "Код";
            f7.dataGridView1.Columns[1].HeaderText = "Группы";
        }

        private void менеджерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.Show();
            f7.Text = "Менеджеры";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select managers.id_manager,managers.fio,departments.name from bddiplom.managers,bddiplom.departments where managers.id_department = departments.id_department order by id_manager;", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                f7.dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            f7.dataGridView1.Columns[0].HeaderText = "Код";
            f7.dataGridView1.Columns[1].HeaderText = "ФИО";
            f7.dataGridView1.Columns[2].HeaderText = "Отдел";
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.Show();
            f7.Text = "Поставщики";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select  kontragents.id_kontragent,kontragents.name,kontragents.fio, kontragents.phone,kontragents.adress,journal_expenses.details,journal_expenses.inn from bddiplom.journal_expenses,bddiplom.kontragents,bddiplom.type_kontragents where kontragents.id_type = type_kontragents.id_type and journal_expenses.id_expense = kontragents.id_expense and kontragents.id_type=1 order by id_kontragent;", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                f7.dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            f7.dataGridView1.Columns[0].HeaderText = "Код";
            f7.dataGridView1.Columns[1].HeaderText = "Название";
            f7.dataGridView1.Columns[2].HeaderText = "Директор";
            f7.dataGridView1.Columns[3].HeaderText = "Телефон";
            f7.dataGridView1.Columns[4].HeaderText = "Адрес";
            f7.dataGridView1.Columns[5].HeaderText = "Рекзвизиты";
            f7.dataGridView1.Columns[6].HeaderText = "ИНН";
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.Show();
            f7.Text = "Клиент";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select kontragents.id_kontragent,kontragents.name,kontragents.fio, kontragents.phone,kontragents.adress,journal_expenses.details,journal_expenses.inn from bddiplom.journal_expenses,bddiplom.kontragents,bddiplom.type_kontragents where kontragents.id_type = type_kontragents.id_type and journal_expenses.id_expense = kontragents.id_expense and kontragents.id_type=2 order by id_kontragent;", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                f7.dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            f7.dataGridView1.Columns[0].HeaderText = "Код";
            f7.dataGridView1.Columns[1].HeaderText = "Название";
            f7.dataGridView1.Columns[2].HeaderText = "Директор";
            f7.dataGridView1.Columns[3].HeaderText = "Телефон";
            f7.dataGridView1.Columns[4].HeaderText = "Адрес";
            f7.dataGridView1.Columns[5].HeaderText = "Рекзвизиты";
            f7.dataGridView1.Columns[6].HeaderText = "ИНН";
        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.Owner = this;
            
            f7.Text = "Товары";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select goods.id_good,kontragents.name as namekon,concat(group_goods.name ,' ',goods.name) as nameer,goods.unit_one,goods.price from bddiplom.goods,bddiplom.group_goods,bddiplom.buys,bddiplom.kontragents where goods.id_group = group_goods.id_group and goods.id_buy=buys.id_buy and buys.id_kontragent = kontragents.id_kontragent order by id_good;", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdatasett = new DataTable();
                sda.Fill(dbdatasett);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdatasett;
                f7.dataGridView1.DataSource = bSource;
                sda.Update(dbdatasett);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            f7.dataGridView1.Columns[0].HeaderText = "Код";
            f7.dataGridView1.Columns[1].HeaderText = "Поставщик";
            f7.dataGridView1.Columns[2].HeaderText = "Название товара";
            f7.dataGridView1.Columns[3].HeaderText = "Единица измерения";
            f7.dataGridView1.Columns[4].HeaderText = "Цена";
            f7.groupBox1.Visible = true;
            f7.combo1();
            f7.combo2();
            f7.button3.Visible = true;
            f7.ShowDialog();
        }

        private void прайслистToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void журналЗаявокToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.Show();
            f7.Text = "Журнал заявок";
        

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("Select store.id_store,sales.date,kontragents.name as namekon,kontragents.fio as director,concat (group_goods.name ,' ',goods.name) as nameer,store.amount,goods.price,store.amount*goods.price as summa from bddiplom.store,bddiplom.sales,bddiplom.goods, bddiplom.kontragents,bddiplom.group_goods,bddiplom.managers,bddiplom.journal_expenses where kontragents.id_expense=journal_expenses.id_expense and store.id_sale = sales.id_sale and sales.id_kontragent=kontragents.id_kontragent and store.id_good=goods.id_good and managers.id_manager = sales.id_manager and goods.id_group = group_goods.id_group order by id_store;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdatasett = new DataTable();
                sda.Fill(dbdatasett);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdatasett;
                f7.dataGridView1.DataSource = bSource;
                sda.Update(dbdatasett);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            f7.dataGridView1.Columns[0].HeaderText = "Код";
            f7.dataGridView1.Columns[1].HeaderText = "Дата";
            f7.dataGridView1.Columns[2].HeaderText = "Клиент";
            f7.dataGridView1.Columns[3].HeaderText = "Директор";
            f7.dataGridView1.Columns[4].HeaderText = "Название товара";
            f7.dataGridView1.Columns[5].HeaderText = "Количество";
            f7.dataGridView1.Columns[6].HeaderText = "Цена";
            f7.dataGridView1.Columns[7].HeaderText = "Сумма";
            f7.button4.Visible = true;
        }

        private void журналЗаявокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.Show();
            f7.Text = "Журнал поставщиков";


            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select buys.id_buy,kontragents.name as namefirm, managers.fio as manager,buys.date from bddiplom.managers,bddiplom.buys, bddiplom.kontragents where  buys.id_manager = managers.id_manager and buys.id_kontragent = kontragents.id_kontragent order by id_buy;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdatasett = new DataTable();
                sda.Fill(dbdatasett);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdatasett;
                f7.dataGridView1.DataSource = bSource;
                sda.Update(dbdatasett);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            f7.dataGridView1.Columns[0].HeaderText = "Код";
            f7.dataGridView1.Columns[1].HeaderText = "Поставщик";
            f7.dataGridView1.Columns[2].HeaderText = "Менеджер";
            f7.dataGridView1.Columns[3].HeaderText = "Дата";
        }

        private void журналПродажToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.Show();
            f7.Text = "Журнал клиентов";


            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select sales.id_sale,kontragents.name as namefirm, managers.fio as manager,sales.date from bddiplom.managers,bddiplom.sales, bddiplom.kontragents where  sales.id_manager = managers.id_manager and sales.id_kontragent = kontragents.id_kontragent order by id_sale;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdatasett = new DataTable();
                sda.Fill(dbdatasett);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdatasett;
                f7.dataGridView1.DataSource = bSource;
                sda.Update(dbdatasett);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            f7.dataGridView1.Columns[0].HeaderText = "Код";
            f7.dataGridView1.Columns[1].HeaderText = "Клиент";
            f7.dataGridView1.Columns[2].HeaderText = "Менеджер";
            f7.dataGridView1.Columns[3].HeaderText = "Дата";
        }

        private void поКатегориямТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void поМенеджерамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 f10 = new Form10();
            f10.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 a1 = new AboutBox1();
            a1.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.Show();
            f7.Text = "Журнал заявок";


            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("Select store.id_store,sales.date,kontragents.name as namekon,kontragents.fio as director,concat (group_goods.name ,' ',goods.name) as nameer,store.amount,goods.price,store.amount*goods.price as summa from bddiplom.store,bddiplom.sales,bddiplom.goods, bddiplom.kontragents,bddiplom.group_goods,bddiplom.managers,bddiplom.journal_expenses where kontragents.id_expense=journal_expenses.id_expense and store.id_sale = sales.id_sale and sales.id_kontragent=kontragents.id_kontragent and store.id_good=goods.id_good and managers.id_manager = sales.id_manager and goods.id_group = group_goods.id_group order by id_store;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdatasett = new DataTable();
                sda.Fill(dbdatasett);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdatasett;
                f7.dataGridView1.DataSource = bSource;
                sda.Update(dbdatasett);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            f7.dataGridView1.Columns[0].HeaderText = "Код";
            f7.dataGridView1.Columns[1].HeaderText = "Дата";
            f7.dataGridView1.Columns[2].HeaderText = "Клиент";
            f7.dataGridView1.Columns[3].HeaderText = "Директор";
            f7.dataGridView1.Columns[4].HeaderText = "Название товара";
            f7.dataGridView1.Columns[5].HeaderText = "Количество";
            f7.dataGridView1.Columns[6].HeaderText = "Цена";
            f7.dataGridView1.Columns[7].HeaderText = "Сумма";
            f7.button4.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Close();
            Form7 f7 = new Form7();
            f7.Owner = this;

            f7.Text = "Товары";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select goods.id_good,kontragents.name as namekon,concat(group_goods.name ,' ',goods.name) as nameer,goods.unit_one,goods.price from bddiplom.goods,bddiplom.group_goods,bddiplom.buys,bddiplom.kontragents where goods.id_group = group_goods.id_group and goods.id_buy=buys.id_buy and buys.id_kontragent = kontragents.id_kontragent order by id_good;", conDataBase);
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdatasett = new DataTable();
                sda.Fill(dbdatasett);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdatasett;
                f7.dataGridView1.DataSource = bSource;
                sda.Update(dbdatasett);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            f7.dataGridView1.Columns[0].HeaderText = "Код";
            f7.dataGridView1.Columns[1].HeaderText = "Поставщик";
            f7.dataGridView1.Columns[2].HeaderText = "Название товара";
            f7.dataGridView1.Columns[3].HeaderText = "Единица измерения";
            f7.dataGridView1.Columns[4].HeaderText = "Цена";
            f7.groupBox1.Visible = true;
            f7.combo1();
            f7.combo2();
            f7.button3.Visible = true;
            f7.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Close();
            this.Hide();
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Close();
            this.Hide();
            Form10 f10 = new Form10();
            f10.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //is.Hide();
            Form8 f8 = new Form8();
            f8.Show();
        }

   
    }
}
