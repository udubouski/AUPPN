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
    public partial class Form2 : Form
    {
        public bool but1 = false;
        public bool but2 = false;
        public bool but3 = false;
        DataTable dbdataset, dbdataset1, dbdataset2, dbdataset3, dbdataset4, dbdataset5,dbdataset6,dbdataset7,dbdataset8,dbdataset9;
        public string constring = "datasource = localhost; port=3306;username=root;password=1234;charset=utf8";
        public Form2()
        {
            InitializeComponent();
            this.comboBox1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseWheel);
            this.comboBox2.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox2_MouseWheel);
            this.comboBox3.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox3_MouseWheel);
            this.comboBox4.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox4_MouseWheel);
            this.comboBox5.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox5_MouseWheel);
            this.comboBox6.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox6_MouseWheel);
            this.comboBox7.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox7_MouseWheel);
            this.comboBox8.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox8_MouseWheel);
            this.comboBox9.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox9_MouseWheel);
            this.comboBox10.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox10_MouseWheel);
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            load_table1(); //table buys
            load_table5(); //table journal_expences
            load_table7(); //table kontragents
            load_table8(); //table managers
            load_table9(); //table sales
            load_table10(); //table store
            load_table11(); //table goods
           load_table12();
           load_table2();
            load_table3();
            com2(); // departments com
            com4(); // type_kontragents name
            com3(); // group_goods com
            zag();
            zag1();
            zag2();
            zag3();
            zag4();
            zag5();
            zag6();
          
        }

       
        
        private void button2_Click(object sender, EventArgs e) // button add 
        {
            this.Hide();
            but1 = true;
            Form3 f3 = new Form3();
            f3.Owner = this;
            f3.Text = "Добавление";
            if (tabControl1.SelectedTab == tabPage1)
            {
                f3.textBox7.Enabled = false;
                f3.groupBox2.Enabled = false;
                f3.combo13(); //buys1
                f3.combo14(); //buys2
                f3.tabPage1.Enabled = true;
                f3.tabControl1.SelectedIndex = 0;
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                f3.textBox3.Enabled = false;
                f3.groupBox4.Enabled = false;
                f3.tabPage2.Enabled = true;
                f3.tabControl1.SelectedIndex = 1;
            }
            else if (tabControl1.SelectedTab == tabPage3)
            {
                f3.textBox6.Enabled = false;
                f3.groupBox6.Enabled = false;
                f3.tabPage3.Enabled = true;
                f3.tabControl1.SelectedIndex = 2;
            }
            else if (tabControl1.SelectedTab == tabPage4)
            {
                f3.textBox31.Enabled = false;
                f3.groupBox8.Enabled = false;
                f3.combo8(); // kontragents
                f3.combo26();
                f3.tabPage4.Enabled = true;
                f3.tabControl1.SelectedIndex = 3;
            }
            else if (tabControl1.SelectedTab == tabPage5)
            {
                f3.textBox30.Enabled = false;
                f3.groupBox10.Enabled = false;
                f3.tabPage5.Enabled = true;
                f3.tabControl1.SelectedIndex = 4;
            }
            else if (tabControl1.SelectedTab == tabPage6)
            {
                f3.textBox22.Enabled = false;
                f3.groupBox12.Enabled = false;

                f3.combo9(); // managers
                f3.tabPage6.Enabled = true;
                f3.tabControl1.SelectedIndex = 5;
            }
            else if (tabControl1.SelectedTab == tabPage7)
            {

                f3.textBox23.Enabled = false;
                f3.groupBox14.Enabled = false;
                f3.combo10(); //sales1
                f3.combo11(); //sales2
                f3.tabPage7.Enabled = true;
                f3.tabControl1.SelectedIndex = 6;
            }
            else if (tabControl1.SelectedTab == tabPage8)
            {
                f3.textBox8.Enabled = false;
                f3.groupBox16.Enabled = false;
                f3.storepro(); //store1
                f3.storepro1();
                f3.tabPage8.Enabled = true;
                f3.tabControl1.SelectedIndex = 7;
            }
            else if (tabControl1.SelectedTab == tabPage9)
            {
                f3.textBox25.Enabled = false;
                f3.groupBox18.Enabled = false;
                f3.goodpro(); //goods1
                f3.combo12(); // goods2
                f3.tabPage9.Enabled = true;
                f3.tabControl1.SelectedIndex = 8;
            }
            else if (tabControl1.SelectedTab == tabPage10)
            {
                f3.textBox4.Enabled = false;
                f3.groupBox20.Enabled = false;
                f3.tabPage10.Enabled = true;
                f3.tabControl1.SelectedIndex = 9;
            }
            f3.ShowDialog();   
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Form1 f1 = new Form1();
            f1.Show();
            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.Beep(); 
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e) //button update
        {
            this.Hide();
            but2 = true;
            Form3 f3 = new Form3();
            f3.Owner = this;
            f3.Text = "Изменение";
            if (tabControl1.SelectedTab == tabPage1)
            {
                f3.combo13(); //buys1
                f3.combo14(); //buys2
                f3.fillcom3();
                f3.tabPage1.Enabled = true;
                f3.tabControl1.SelectedIndex = 0;
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                f3.fillcom4();
                f3.tabPage2.Enabled = true;
                f3.tabControl1.SelectedIndex = 1;
            }
            else if (tabControl1.SelectedTab == tabPage3)
            {
                f3.fillcom5();
                f3.tabPage3.Enabled = true;
                f3.tabControl1.SelectedIndex = 2;
            }
            else if (tabControl1.SelectedTab == tabPage4)
            {
                f3.combo8(); // kontragents
                f3.combo26();
                f3.fillcom7();
                f3.tabPage4.Enabled = true;
                f3.tabControl1.SelectedIndex = 3;
            }
            else if (tabControl1.SelectedTab == tabPage5)
            {

                f3.fillcom6();
                f3.tabPage5.Enabled = true;
                f3.tabControl1.SelectedIndex = 4;
            }
            else if (tabControl1.SelectedTab == tabPage6)
            {
                f3.combo9(); // managers
                f3.fillcom8();
                f3.tabPage6.Enabled = true;
                f3.tabControl1.SelectedIndex = 5;
            }
            else if (tabControl1.SelectedTab == tabPage7)
            {
                f3.combo10(); //sales1
                f3.combo11(); //sales2
                f3.fillcom9();
                f3.tabPage7.Enabled = true;
                f3.tabControl1.SelectedIndex = 6;
            }
            else if (tabControl1.SelectedTab == tabPage8)
            {
                f3.storepro(); //store1
                f3.storepro1();
                f3.fillcom10();
                f3.tabPage8.Enabled = true;
                f3.tabControl1.SelectedIndex = 7;
            }
            else if (tabControl1.SelectedTab == tabPage9)
            {
                f3.goodpro(); // goods1
                f3.combo12(); // goods2
                f3.fillcom11();
                f3.tabPage9.Enabled = true;
                f3.tabControl1.SelectedIndex = 8;
            }
            else if (tabControl1.SelectedTab == tabPage10)
            {
                f3.fillcom12();
                f3.tabPage10.Enabled = true;
                f3.tabControl1.SelectedIndex = 9;
            }
            f3.ShowDialog();   
        }

        private void button4_Click(object sender, EventArgs e) //button delete
        {
          this.Hide();
            but3 = true;
            Form3 f3 = new Form3();
            f3.Owner = this;
            f3.Text = "Удаление";
            if (tabControl1.SelectedTab == tabPage1)
            {
                f3.comboBox13.Enabled = false;
                f3.comboBox14.Enabled = false;
                f3.dateTimePicker1.Enabled = false;
                f3.fillcom3();
                f3.tabPage1.Enabled = true;
                f3.tabControl1.SelectedIndex = 0;
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                f3.textBox2.Enabled=false;
                f3.fillcom4();
                f3.tabPage2.Enabled = true;
                f3.tabControl1.SelectedIndex = 1;
            }
            else if (tabControl1.SelectedTab == tabPage3)
            {
                f3.textBox5.Enabled = false;
                f3.fillcom5();
                f3.tabPage3.Enabled = true;
                f3.tabControl1.SelectedIndex = 2;
            }
            else if (tabControl1.SelectedTab == tabPage4)
            {
                f3.comboBox8.Enabled = false;
                f3.comboBox26.Enabled = false;
                f3.textBox16.Enabled = false;
                f3.textBox17.Enabled = false;
                f3.textBox18.Enabled = false;
                f3.textBox35.Enabled = false;
                f3.fillcom7();
                f3.tabPage4.Enabled = true;
                f3.tabControl1.SelectedIndex = 3;
            }
            else if (tabControl1.SelectedTab == tabPage5)
            {
                f3.textBox15.Enabled = false;
                f3.textBox13.Enabled = false;
  
                f3.fillcom6();
                f3.tabPage5.Enabled = true;
                f3.tabControl1.SelectedIndex = 4;
            }
            else if (tabControl1.SelectedTab == tabPage6)
            {
                f3.textBox21.Enabled = false;
                f3.comboBox9.Enabled = false;
                f3.fillcom8();
                f3.tabPage6.Enabled = true;
                f3.tabControl1.SelectedIndex = 5;
            }
            else if (tabControl1.SelectedTab == tabPage7)
            {
                f3.comboBox10.Enabled = false;
                f3.comboBox11.Enabled = false;
                f3.dateTimePicker2.Enabled = false;
                f3.fillcom9();
                f3.tabPage7.Enabled = true;
                f3.tabControl1.SelectedIndex = 6;
            }
            else if (tabControl1.SelectedTab == tabPage8)
            {
                f3.comboBox23.Enabled = false;
                f3.comboBox24.Enabled = false;
                f3.comboBox25.Enabled = false;
                f3.comboBox3.Enabled = false;
                f3.comboBox6.Enabled = false;
                f3.textBox9.Enabled = false;
                f3.fillcom10();
                f3.tabPage8.Enabled = true;
                f3.tabControl1.SelectedIndex = 7;
            }
            else if (tabControl1.SelectedTab == tabPage9)
            {
                f3.comboBox22.Enabled = false;
                f3.comboBox4.Enabled = false;
                f3.comboBox12.Enabled = false;
                f3.textBox26.Enabled = false;
                f3.textBox27.Enabled = false;
                f3.textBox28.Enabled = false;
                f3.fillcom11();
                f3.tabPage9.Enabled = true;
                f3.tabControl1.SelectedIndex = 8;
            }
            else if (tabControl1.SelectedTab == tabPage10)
            {
                f3.textBox1.Enabled = false;
                f3.fillcom12();
                f3.tabPage10.Enabled = true;
                f3.tabControl1.SelectedIndex = 9;
            }
            f3.ShowDialog();   
        }
        
        
        public void load_table12() //load table type_kontragents
        {
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select * from bddiplom.type_kontragents order by id_type;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset7 = new DataTable();
                sda.Fill(dbdataset7);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset7;
                dataGridView12.DataSource = bSource;
                sda.Update(dbdataset7);
                dataGridView12.Columns[0].HeaderText = "Код";
                dataGridView12.Columns[1].HeaderText = "Название";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void load_table2() //load table departments
        {
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select * from bddiplom.departments order by id_department;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset1 = new DataTable();
                sda.Fill(dbdataset1);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset1;
                dataGridView2.DataSource = bSource;
                sda.Update(dbdataset1);
                dataGridView2.Columns[0].HeaderText = "Код";
                dataGridView2.Columns[1].HeaderText = "Название";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void load_table3() //load table group_goods
        {
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select id_group,name from bddiplom.group_goods order by id_group;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset2 = new DataTable();
                sda.Fill(dbdataset2);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset2;
                dataGridView3.DataSource = bSource;
                sda.Update(dbdataset2);
                dataGridView3.Columns[0].HeaderText = "Код";
                dataGridView3.Columns[1].HeaderText = "Название";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void load_table1() //load table buys
        {
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select buys.id_buy,kontragents.name as namefirm, managers.fio as manager,buys.date from bddiplom.managers,bddiplom.buys, bddiplom.kontragents where  buys.id_manager = managers.id_manager and buys.id_kontragent = kontragents.id_kontragent order by id_buy;", conDataBase);
           
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
                dataGridView1.Columns[0].HeaderText = "Код";
                dataGridView1.Columns[1].HeaderText = "Поставщик";
                dataGridView1.Columns[2].HeaderText = "Менеджер";
                dataGridView1.Columns[3].HeaderText = "Дата";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            
        }


        public void load_table5() //load table journal_expences
        {
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select * from bddiplom.journal_expenses order by id_expense", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset4 = new DataTable();
                sda.Fill(dbdataset4);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset4;
                dataGridView5.DataSource = bSource;
                sda.Update(dbdataset4);
                dataGridView5.Columns[0].HeaderText = "Код";
                dataGridView5.Columns[1].HeaderText = "ИНН";
                dataGridView5.Columns[2].HeaderText = "Реквизиты";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void load_table7() //load table kontragents
        {

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select kontragents.id_kontragent, type_kontragents.name, kontragents.name as namefirm,kontragents.fio, kontragents.phone,kontragents.adress,journal_expenses.details,journal_expenses.inn from bddiplom.journal_expenses,bddiplom.kontragents,bddiplom.type_kontragents where kontragents.id_type = type_kontragents.id_type and journal_expenses.id_expense = kontragents.id_expense order by id_kontragent;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset3 = new DataTable();
                sda.Fill(dbdataset3);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset3;
                dataGridView7.DataSource = bSource;
                sda.Update(dbdataset3);
                dataGridView7.Columns[0].HeaderText = "Код";
                dataGridView7.Columns[1].HeaderText = "Тип";
                dataGridView7.Columns[2].HeaderText = "Название";
                dataGridView7.Columns[3].HeaderText = "Директор";
                dataGridView7.Columns[4].HeaderText = "Телефон";
                dataGridView7.Columns[5].HeaderText = "Адрес";
                dataGridView7.Columns[6].HeaderText = "Реквизиты";
                dataGridView7.Columns[7].HeaderText = "ИНН";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void load_table8() //load table managers
        {

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select managers.id_manager, managers.fio, departments.name from bddiplom.managers,bddiplom.departments where managers.id_department=departments.id_department order by id_manager;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset5 = new DataTable();
                sda.Fill(dbdataset5);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset5;
                dataGridView8.DataSource = bSource;
                sda.Update(dbdataset5);
                dataGridView8.Columns[0].HeaderText = "Код";
                dataGridView8.Columns[1].HeaderText = "ФИО";
                dataGridView8.Columns[2].HeaderText = "Отдел";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void load_table9() //load table sales
        {

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select sales.id_sale,kontragents.name as namefirm, managers.fio as manager,sales.date from bddiplom.managers,bddiplom.sales, bddiplom.kontragents where  sales.id_manager = managers.id_manager and sales.id_kontragent = kontragents.id_kontragent order by id_sale;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset6 = new DataTable();
                sda.Fill(dbdataset6);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset6;
                dataGridView9.DataSource = bSource;
                sda.Update(dbdataset6);
                dataGridView9.Columns[0].HeaderText = "Код";
                dataGridView9.Columns[1].HeaderText = "Клиент";
                dataGridView9.Columns[2].HeaderText = "Отдел";
                dataGridView9.Columns[3].HeaderText = "Дата";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void load_table10() //load table store
        {

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("Select store.id_store,kontragents.name as namekon,group_goods.name as nametype, goods.name,store.amount,goods.price,store.amount*goods.price as summa from bddiplom.store,bddiplom.sales,bddiplom.goods, bddiplom.kontragents,bddiplom.group_goods where store.id_sale = sales.id_sale and sales.id_kontragent=kontragents.id_kontragent and store.id_good=goods.id_good and goods.id_group = group_goods.id_group order by id_store;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset9 = new DataTable();
                sda.Fill(dbdataset9);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset9;
                dataGridView10.DataSource = bSource;
                sda.Update(dbdataset9);
                dataGridView10.Columns[0].HeaderText = "Код";
                dataGridView10.Columns[1].HeaderText = "Клиент";
                dataGridView10.Columns[2].HeaderText = "Группа товара";
                dataGridView10.Columns[3].HeaderText = "Название";
                dataGridView10.Columns[4].HeaderText = "Количество";
                dataGridView10.Columns[5].HeaderText = "Цена";
                dataGridView10.Columns[6].HeaderText = "Сумма";
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void load_table11() //load table goods
        {

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select goods.id_good,kontragents.name as namekon,group_goods.name as namegroup,goods.name,goods.unit_one,goods.price from bddiplom.goods,bddiplom.group_goods,bddiplom.buys,bddiplom.kontragents where goods.id_group = group_goods.id_group and goods.id_buy=buys.id_buy and buys.id_kontragent = kontragents.id_kontragent order by id_good;", conDataBase);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset8 = new DataTable();
                sda.Fill(dbdataset8);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset8;
                dataGridView11.DataSource = bSource;
                sda.Update(dbdataset8);
                dataGridView11.Columns[0].HeaderText = "Код";
                dataGridView11.Columns[1].HeaderText = "Поставщик";
                dataGridView11.Columns[2].HeaderText = "Группа товара";
                dataGridView11.Columns[3].HeaderText = "Название";
                dataGridView11.Columns[4].HeaderText = "Единица измерения";
                dataGridView11.Columns[5].HeaderText = "Цена";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // buys namefirm
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("Namefirm Like '%{0}%'",textBox1.Text);
            dataGridView1.DataSource = DV;

        }

        public void AutoCompleteText()
        {
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string Query = "select kontragents.name as namefirm from bddiplom.managers,bddiplom.buys, bddiplom.kontragents where  buys.id_manager = managers.id_manager and buys.id_kontragent = kontragents.id_kontragent;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetString("namefirm");
                    coll.Add(sname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox1.AutoCompleteCustomSource = coll;
        }

        private void textBox2_TextChanged(object sender, EventArgs e) // buys manager
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("manager Like '%{0}%'", textBox2.Text);
            dataGridView1.DataSource = DV;

        }

        public void autobuy2()
        {
            textBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string Query = "select managers.fio as manager from bddiplom.managers,bddiplom.buys, bddiplom.kontragents where  buys.id_manager = managers.id_manager and buys.id_kontragent = kontragents.id_kontragent;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetString("manager");
                    coll.Add(sname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox2.AutoCompleteCustomSource = coll;
        }

        bool f1 = true;
        bool f2 = false;
        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == String.Empty)
            {
                MessageBox.Show("Выберите поле!");
            }
            else if (f1==true)
            {
                dataGridView1.Sort(dataGridView1.Columns[comboBox1.Text], ListSortDirection.Ascending);
                f1 = false;
                f2 = true;
            }

            else if (f2==true)
            {
                dataGridView1.Sort(dataGridView1.Columns[comboBox1.Text], ListSortDirection.Descending);
                f2 = false;
                f1 = true;
            }

        }

        public void zag()
        {
            dataGridView1.Columns[0].Name = "Код";
            dataGridView1.Columns[1].Name = "Поставщик";
            dataGridView1.Columns[2].Name = "Менеджер";
            dataGridView1.Columns[3].Name = "Дата";
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                string com = dataGridView1.Columns[i].Name;
                comboBox1.Items.Add(com);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e) // departments name
        {
            DataView DV = new DataView(dbdataset1);
            DV.RowFilter = string.Format("name Like '%{0}%'", textBox3.Text);
            dataGridView2.DataSource = DV;
        }

        public void autodep()
        {
            textBox3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox3.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string Query = "select * from bddiplom.departments";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetString("name");
                    coll.Add(sname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox3.AutoCompleteCustomSource = coll;
        }


        private void textBox4_TextChanged(object sender, EventArgs e) //group_goods name
        {
            DataView DV = new DataView(dbdataset2);
            DV.RowFilter = string.Format("Name Like '%{0}%'", textBox4.Text);
            dataGridView3.DataSource = DV;

        }

        public void autoggod()
        {
            textBox4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox4.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string Query = "select * from bddiplom.group_goods";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetString("name");
                    coll.Add(sname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox4.AutoCompleteCustomSource = coll;
        }

        private void textBox5_TextChanged(object sender, EventArgs e) //kontragents name
        {
            DataView DV = new DataView(dbdataset3);
            DV.RowFilter = string.Format("name Like '%{0}%'", textBox5.Text);
            dataGridView7.DataSource = DV; 
        }

        public void autokon()
        {
            textBox5.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox5.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string Query = "select type_kontragents.name from bddiplom.kontragents,bddiplom.type_kontragents where kontragents.id_type = type_kontragents.id_type;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetString("name");
                    coll.Add(sname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox5.AutoCompleteCustomSource = coll;
        }

        private void textBox6_TextChanged(object sender, EventArgs e) //kontragents fio
        {
            DataView DV = new DataView(dbdataset3);
            DV.RowFilter = string.Format("fio Like '%{0}%'", textBox6.Text);
            dataGridView7.DataSource = DV; 
        }

        public void autokon2()
        {
            textBox6.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox6.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string Query = "select kontragents.fio from bddiplom.kontragents;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetString("fio");
                    coll.Add(sname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox6.AutoCompleteCustomSource = coll;
        }

        private void textBox7_TextChanged(object sender, EventArgs e) //kontragents namefirm
        {
            DataView DV = new DataView(dbdataset3);
            DV.RowFilter = string.Format("namefirm Like '%{0}%'", textBox7.Text);
            dataGridView7.DataSource = DV; 
        }

        public void autokon3()
        {
            textBox7.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox7.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string Query = "select kontragents.name as namefirm from bddiplom.kontragents;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetString("namefirm");
                    coll.Add(sname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox7.AutoCompleteCustomSource = coll;
        }

        private void textBox8_TextChanged(object sender, EventArgs e) //kontragents phone
        {
            DataView DV = new DataView(dbdataset3);
            DV.RowFilter = string.Format("Convert(phone,'System.String') Like '%{0}%'" , textBox8.Text); 
            dataGridView7.DataSource = DV;
        }

        public void autokon4()
        {
            textBox8.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox8.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string Query = "select kontragents.phone from bddiplom.kontragents;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetInt32("phone").ToString();
                    coll.Add(sname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox8.AutoCompleteCustomSource = coll;
        }

        bool a1 = true;
        bool a2 = false;
        private void button7_Click(object sender, EventArgs e)
        {
          
            if (comboBox3.Text == String.Empty)
            {
                MessageBox.Show("Выберите поле!");
            }
            else if (a1 == true)
            {
                dataGridView2.Sort(dataGridView2.Columns[comboBox3.Text], ListSortDirection.Ascending);
                a1 = false;
                a2 = true;
            }

            else if (a2 == true)
            {
                dataGridView2.Sort(dataGridView2.Columns[comboBox3.Text], ListSortDirection.Descending);
                a2 = false;
                a1 = true;
            }
        }

        public void com2()
        {
            dataGridView2.Columns[0].Name = "Код";
            dataGridView2.Columns[1].Name = "Название";
            for (int i = 0; i < dataGridView2.Columns.Count; i++)
            {
                string com = dataGridView2.Columns[i].Name;
                comboBox3.Items.Add(com);
            }
        }

        public void com3()
        {
            dataGridView3.Columns[0].Name = "Код";
            dataGridView3.Columns[1].Name = "Название";
            for (int i = 0; i < dataGridView3.Columns.Count; i++)
            {
                string com = dataGridView3.Columns[i].Name;
                comboBox2.Items.Add(com);             
            }
        }

        bool b1 = true;
        bool b2 = false;
        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == String.Empty)
            {
                MessageBox.Show("Выберите поле!");
            }
            else if (b1 == true)
            {
                dataGridView3.Sort(dataGridView3.Columns[comboBox2.Text], ListSortDirection.Ascending);
                b1 = false;
                b2 = true;
            }

            else if (b2 == true)
            {
                dataGridView3.Sort(dataGridView3.Columns[comboBox2.Text], ListSortDirection.Descending);
                b2 = false;
                b1 = true;
            }
        }



        bool с1 = true;
        bool с2 = false;
        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text == String.Empty)
            {
                MessageBox.Show("Выберите поле!");
            }
            else if (с1 == true)
            {
                dataGridView7.Sort(dataGridView7.Columns[comboBox4.Text], ListSortDirection.Ascending);
                с1 = false;
                с2 = true;
            }

            else if (с2 == true)
            {
                dataGridView7.Sort(dataGridView7.Columns[comboBox4.Text], ListSortDirection.Descending);
                с2 = false;
                с1 = true;
            }
        }

        public void zag1()
        {
            dataGridView7.Columns[0].Name = "Код";
            dataGridView7.Columns[1].Name = "Тип";
            dataGridView7.Columns[2].Name = "Название";
            dataGridView7.Columns[3].Name = "Директор";
            dataGridView7.Columns[4].Name = "Телефон";
            dataGridView7.Columns[5].Name = "Адрес";
            dataGridView7.Columns[6].Name = "Реквизиты";
            dataGridView7.Columns[7].Name = "ИНН";
            for (int i = 0; i < dataGridView7.Columns.Count; i++)
            {
                string com = dataGridView7.Columns[i].Name;
                comboBox4.Items.Add(com);
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e) // journal_expenses inn
        {
            DataView DV = new DataView(dbdataset4);
            DV.RowFilter = string.Format("Convert(inn,'System.String') Like '%{0}%'", textBox11.Text);
            dataGridView5.DataSource = DV;
        }

        public void autojrn1()
        {
            textBox11.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox11.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string Query = "select journal_expenses.inn from bddiplom.journal_expenses;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetInt32("inn").ToString();
                    coll.Add(sname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox11.AutoCompleteCustomSource = coll;
        }

        private void textBox10_TextChanged(object sender, EventArgs e) //journal_expenses details
        {
            DataView DV = new DataView(dbdataset4);
            DV.RowFilter = string.Format("details Like '%{0}%'", textBox10.Text);
            dataGridView5.DataSource = DV;
        }

        public void autojrn2()
        {
            textBox10.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox10.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string Query = "select journal_expenses.details from bddiplom.journal_expenses;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetString("details");
                    coll.Add(sname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox10.AutoCompleteCustomSource = coll;
        }

        bool d1 = true;
        bool d2 = false;
        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox5.Text == String.Empty)
            {
                MessageBox.Show("Выберите поле!");
            }
            else if (d1 == true)
            {
                dataGridView5.Sort(dataGridView5.Columns[comboBox5.Text], ListSortDirection.Ascending);
                d1 = false;
                d2 = true;
            }

            else if (d2 == true)
            {
                dataGridView5.Sort(dataGridView5.Columns[comboBox5.Text], ListSortDirection.Descending);
                d2 = false;
                d1 = true;
            }
        }

        public void zag2()
        {
            dataGridView5.Columns[0].Name = "Код";
            dataGridView5.Columns[1].Name = "ИНН";
            dataGridView5.Columns[2].Name = "Реквизиты";
           
            for (int i = 0; i < dataGridView5.Columns.Count; i++)
            {
                string com = dataGridView5.Columns[i].Name;
                comboBox5.Items.Add(com);
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e) // managers fio
        {
            DataView DV = new DataView(dbdataset5);
            DV.RowFilter = string.Format("fio Like '%{0}%'", textBox12.Text);
            dataGridView8.DataSource = DV;
        }

        public void automan()
        {
            textBox12.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox12.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string Query = "select managers.fio from bddiplom.managers;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetString("fio");
                    coll.Add(sname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox12.AutoCompleteCustomSource = coll;
        }

        private void textBox13_TextChanged(object sender, EventArgs e) // managers name
        {
            DataView DV = new DataView(dbdataset5);
            DV.RowFilter = string.Format("name Like '%{0}%'", textBox13.Text);
            dataGridView8.DataSource = DV;
        }

        public void automan1()
        {
            textBox13.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox13.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string Query = "select departments.name from bddiplom.departments;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetString("name");
                    coll.Add(sname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox13.AutoCompleteCustomSource = coll;
        }


        bool e1 = true;
        bool e2 = false;
        private void button10_Click(object sender, EventArgs e)
        {
            if (comboBox6.Text == String.Empty)
            {
                MessageBox.Show("Выберите поле!");
            }
            else if (e1 == true)
            {
                dataGridView8.Sort(dataGridView8.Columns[comboBox6.Text], ListSortDirection.Ascending);
                e1 = false;
                e2 = true;
            }

            else if (e2 == true)
            {
                dataGridView8.Sort(dataGridView8.Columns[comboBox6.Text], ListSortDirection.Descending);
                e2 = false;
                e1 = true;
            }
        }

        public void zag3()
        {
            dataGridView8.Columns[0].Name = "Код";
            dataGridView8.Columns[1].Name = "ФИО";
            dataGridView8.Columns[2].Name = "Отдел";

            for (int i = 0; i < dataGridView8.Columns.Count; i++)
            {
                string com = dataGridView8.Columns[i].Name;
                comboBox6.Items.Add(com);
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e) //buys date
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("Convert(date,'System.String') Like '%{0}%'", textBox14.Text);
            dataGridView1.DataSource = DV;

        }

        public void autobuy1()
        {
            textBox14.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox14.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string Query = "select buys.date  from bddiplom.buys;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetDateTime("date").ToString();
                    coll.Add(sname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox14.AutoCompleteCustomSource = coll;
        }

        private void textBox15_TextChanged(object sender, EventArgs e) //sale namefirm
        {
            DataView DV = new DataView(dbdataset6);
            DV.RowFilter = string.Format("namefirm Like '%{0}%'", textBox15.Text);
            dataGridView9.DataSource = DV;
        }

        public void autosale()
        {
            textBox15.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox15.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string Query = "select kontragents.name as namefirm from bddiplom.managers,bddiplom.sales, bddiplom.kontragents where  sales.id_manager = managers.id_manager and sales.id_kontragent = kontragents.id_kontragent;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetString("namefirm");
                    coll.Add(sname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox15.AutoCompleteCustomSource = coll;
        }

        private void textBox16_TextChanged(object sender, EventArgs e) //sales manager
        {
            DataView DV = new DataView(dbdataset6);
            DV.RowFilter = string.Format("manager Like '%{0}%'", textBox16.Text);
            dataGridView9.DataSource = DV;
        }

        public void autosale1()
        {
            textBox16.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox16.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string Query = "select managers.fio as manager from bddiplom.managers,bddiplom.sales, bddiplom.kontragents where  sales.id_manager = managers.id_manager and sales.id_kontragent = kontragents.id_kontragent;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetString("manager");
                    coll.Add(sname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox16.AutoCompleteCustomSource = coll;
        }

        private void textBox17_TextChanged(object sender, EventArgs e) //sales date
        {
            DataView DV = new DataView(dbdataset6);
            DV.RowFilter = string.Format("Convert(date,'System.String') Like '%{0}%'", textBox17.Text);
            dataGridView9.DataSource = DV;   
        }

        public void autosale2()
        {
            textBox17.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox17.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string Query = "select sales.date from bddiplom.sales;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetDateTime("date").ToString();
                    coll.Add(sname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox17.AutoCompleteCustomSource = coll;
        }

        bool g1 = true;
        bool g2 = false;
        private void button11_Click(object sender, EventArgs e)
        {
            if (comboBox7.Text == String.Empty)
            {
                MessageBox.Show("Выберите поле!");
            }
            else if (g1 == true)
            {
                dataGridView9.Sort(dataGridView9.Columns[comboBox7.Text], ListSortDirection.Ascending);
                g1 = false;
                g2 = true;
            }

            else if (g2 == true)
            {
                dataGridView9.Sort(dataGridView9.Columns[comboBox7.Text], ListSortDirection.Descending);
                g2 = false;
                g1 = true;
            }
        }

        public void zag4()
        {
            dataGridView9.Columns[0].Name = "Код";
            dataGridView9.Columns[1].Name = "Клиент";
            dataGridView9.Columns[2].Name = "Менеджер";
            dataGridView9.Columns[3].Name = "Дата";
            for (int i = 0; i < dataGridView9.Columns.Count; i++)
            {
                string com = dataGridView9.Columns[i].Name;
                comboBox7.Items.Add(com);
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e) //type_kontragents name
        {
           
            DataView DV = new DataView(dbdataset7);
            DV.RowFilter = string.Format("name Like '%{0}%'", textBox18.Text);
            dataGridView12.DataSource = DV;
        }

        public void com4()
        {
            dataGridView12.Columns[0].Name = "Код";
            dataGridView12.Columns[1].Name = "Название";
            for (int i = 0; i < dataGridView12.Columns.Count; i++)
            {
                string com = dataGridView12.Columns[i].Name;
                comboBox8.Items.Add(com);
            }
        }

        bool h1 = true;
        bool h2 = false;
        private void button12_Click(object sender, EventArgs e)
        {
            if (comboBox8.Text == String.Empty)
            {
                MessageBox.Show("Выберите поле!");
            }
            else if (h1 == true)
            {
                dataGridView12.Sort(dataGridView12.Columns[comboBox8.Text], ListSortDirection.Ascending);
                h1 = false;
                h2 = true;
            }

            else if (h2 == true)
            {
                dataGridView12.Sort(dataGridView12.Columns[comboBox8.Text], ListSortDirection.Descending);
                h2 = false;
                h1 = true;
            }
        }

        public void autotype()
        {
            textBox18.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox18.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string Query = "select * from bddiplom.type_kontragents";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetString("name");
                    coll.Add(sname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox18.AutoCompleteCustomSource = coll;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            AutoCompleteText(); // buys namefirm
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            autobuy2(); // buys manager
        }

        private void textBox14_Click(object sender, EventArgs e)
        {
            autobuy1(); // buys date
        }
      

        private void textBox3_Click(object sender, EventArgs e)
        {
            autodep(); // departments name
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            autoggod(); // group_goods name
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            autokon(); // kontragents name
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            autokon2(); // kontragents fio
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            autokon3(); // kontragents namefirm
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            autokon4(); // kontragents phone
        }

        

        private void textBox11_Click(object sender, EventArgs e)
        {
            autojrn1(); // journal_expenses inn
        }

        private void textBox10_Click(object sender, EventArgs e)
        {
            autojrn2(); // journal_expenses details
        }

        private void textBox12_Click(object sender, EventArgs e)
        {
            automan(); // manager fio
        }

        private void textBox13_Click(object sender, EventArgs e)
        {
            automan1(); // manager name
        }

        private void textBox15_Click(object sender, EventArgs e)
        {
            autosale(); // sales namefirm
        }

        private void textBox16_Click(object sender, EventArgs e)
        {
            autosale1(); // sales manager
        }

        private void textBox17_Click(object sender, EventArgs e)
        {
            autosale2(); // sales date
        }

        private void textBox18_Click(object sender, EventArgs e)
        {
            autotype(); // type_kontragents name
        }

        private void textBox19_TextChanged(object sender, EventArgs e) 
        {
            DataView DV = new DataView(dbdataset8);
            DV.RowFilter = string.Format("namekon Like '%{0}%'", textBox19.Text);
            dataGridView11.DataSource = DV;
        }

        public void autogod()
        {
            textBox19.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox19.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string Query = "select * from bddiplom.kontragents where id_type=1;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetString("name");
                    coll.Add(sname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox19.AutoCompleteCustomSource = coll;
        }

        private void textBox19_Click(object sender, EventArgs e)
        {
            autogod();
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset8);
            DV.RowFilter = string.Format("namegroup Like '%{0}%'", textBox20.Text);
            dataGridView11.DataSource = DV;
        }

        public void autogod1()
        {
            textBox20.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox20.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string Query = "select * from bddiplom.group_goods;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetString("name");
                    coll.Add(sname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox20.AutoCompleteCustomSource = coll;
        }

        private void textBox20_Click(object sender, EventArgs e)
        {
            autogod1();
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset8);
            DV.RowFilter = string.Format("name Like '%{0}%'", textBox21.Text);
            dataGridView11.DataSource = DV;
        }

        public void autogod2()
        {
            textBox21.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox21.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string Query = "select * from bddiplom.goods;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetString("name");
                    coll.Add(sname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox21.AutoCompleteCustomSource = coll;
        }

        private void textBox21_Click(object sender, EventArgs e)
        {
            autogod2();
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset8);
            DV.RowFilter = string.Format("unit_one Like '%{0}%'", textBox22.Text);
            dataGridView11.DataSource = DV;
        }

        public void autogod3()
        {
            textBox22.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox22.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string Query = "select * from bddiplom.goods;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetString("unit_one");
                    coll.Add(sname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox22.AutoCompleteCustomSource = coll;
        }

        private void textBox22_Click(object sender, EventArgs e)
        {
            autogod3();
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset8);
            DV.RowFilter = string.Format("Convert(price,'System.String') Like '%{0}%'", textBox23.Text);
            dataGridView11.DataSource = DV;
        }

        public void autogod4()
        {
            textBox23.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox23.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string Query = "select * from bddiplom.goods;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetInt32("price").ToString();
                    coll.Add(sname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox23.AutoCompleteCustomSource = coll;
        }

        private void textBox23_Click(object sender, EventArgs e)
        {
            autogod4();
        }

        bool k1 = true;
        bool k2 = false;
        private void button13_Click(object sender, EventArgs e)
        {
            if (comboBox9.Text == String.Empty)
            {
                MessageBox.Show("Выберите поле!");
            }
            else if (k1 == true)
            {
                dataGridView11.Sort(dataGridView11.Columns[comboBox9.Text], ListSortDirection.Ascending);
                k1 = false;
                k2 = true;
            }

            else if (k2 == true)
            {
                dataGridView11.Sort(dataGridView11.Columns[comboBox9.Text], ListSortDirection.Descending);
                k2 = false;
                k1 = true;
            }
        }

        public void zag6()
        {
            dataGridView11.Columns[0].Name = "Код";
            dataGridView11.Columns[1].Name = "Поставщик";
            dataGridView11.Columns[2].Name = "Группа товара";
            dataGridView11.Columns[3].Name = "Название";
            dataGridView11.Columns[4].Name = "Единица измерения";
            dataGridView11.Columns[5].Name = "Цена";
            for (int i = 0; i < dataGridView11.Columns.Count; i++)
            {
                string com = dataGridView11.Columns[i].Name;
                comboBox9.Items.Add(com);
            }
        }
        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset9);
            DV.RowFilter = string.Format("namekon Like '%{0}%'", textBox24.Text);
            dataGridView10.DataSource = DV;
        }

        public void autosor()
        {
            textBox24.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox24.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string Query = "select * from bddiplom.kontragents where id_type=2;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetString("name");
                    coll.Add(sname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox24.AutoCompleteCustomSource = coll;
        }

        private void textBox24_Click(object sender, EventArgs e)
        {
            autosor();
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset9);
            DV.RowFilter = string.Format("nametype Like '%{0}%'", textBox25.Text);
            dataGridView10.DataSource = DV;
        }

        public void autosor1()
        {
            textBox25.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox25.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string Query = "select * from bddiplom.group_goods;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetString("name");
                    coll.Add(sname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox25.AutoCompleteCustomSource = coll;
        }

        private void textBox25_Click(object sender, EventArgs e)
        {
            autosor1();
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset9);
            DV.RowFilter = string.Format("name Like '%{0}%'", textBox26.Text);
            dataGridView10.DataSource = DV;
        }

        public void autosor2()
        {
            textBox26.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox26.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string Query = "select * from bddiplom.goods;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetString("name");
                    coll.Add(sname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox26.AutoCompleteCustomSource = coll;
        }

        private void textBox26_Click(object sender, EventArgs e)
        {
            autosor2();
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset9);
            DV.RowFilter = string.Format("Convert(amount,'System.String') Like '%{0}%'", textBox27.Text);
            dataGridView10.DataSource = DV;
        }

        public void autosor3()
        {
            textBox27.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox27.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string Query = "select * from bddiplom.store;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetInt32("amount").ToString();
                    coll.Add(sname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox27.AutoCompleteCustomSource = coll;
        }

        private void textBox27_Click(object sender, EventArgs e)
        {
            autosor3();
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset9);
            DV.RowFilter = string.Format("Convert(price,'System.String') Like '%{0}%'", textBox28.Text);
            dataGridView10.DataSource = DV;
        }

        public void autosor4()
        {
            textBox28.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox28.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string Query = "select * from bddiplom.goods,bddiplom.store where store.id_good = goods.id_good;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetInt32("price").ToString();
                    coll.Add(sname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox28.AutoCompleteCustomSource = coll;
        }

        private void textBox28_Click(object sender, EventArgs e)
        {
            autosor4();
        }

        bool l1 = true;
        bool l2 = false;
        private void button14_Click(object sender, EventArgs e)
        {
            if (comboBox10.Text == String.Empty)
            {
                MessageBox.Show("Выберите поле!");
            }
            else if (l1 == true)
            {
                dataGridView10.Sort(dataGridView10.Columns[comboBox10.Text], ListSortDirection.Ascending);
                l1 = false;
                l2 = true;
            }

            else if (l2 == true)
            {
                dataGridView10.Sort(dataGridView10.Columns[comboBox10.Text], ListSortDirection.Descending);
                l2 = false;
                l1 = true;
            }
        }

        public void zag5()
        {
            dataGridView10.Columns[0].Name = "Код";
            dataGridView10.Columns[1].Name = "Клиент";
            dataGridView10.Columns[2].Name = "Группа товара";
            dataGridView10.Columns[3].Name = "Название";
            dataGridView10.Columns[4].Name = "Количество";
            dataGridView10.Columns[5].Name = "Цена";
            dataGridView10.Columns[6].Name = "Сумма";
            for (int i = 0; i < dataGridView10.Columns.Count; i++)
            {
                string com = dataGridView10.Columns[i].Name;
                comboBox10.Items.Add(com);
            }
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset9);
            DV.RowFilter = string.Format("Convert(summa,'System.String') Like '%{0}%'", textBox29.Text);
            dataGridView10.DataSource = DV;
        }

        public void autosor5()
        {
            textBox29.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox29.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string Query = "select store.amount,goods.price,store.amount*goods.price as summa from bddiplom.goods,bddiplom.store where store.id_good = goods.id_good;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetInt32("summa").ToString();
                    coll.Add(sname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox29.AutoCompleteCustomSource = coll;
        }

        private void textBox29_Click(object sender, EventArgs e)
        {
            autosor5();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset3);
            DV.RowFilter = string.Format("details Like '%{0}%'", textBox9.Text);
            dataGridView7.DataSource = DV;
        }

        public void autodetai()
        {
            textBox9.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox9.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string Query = "select journal_expenses.details from bddiplom.journal_expenses;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetString("details");
                    coll.Add(sname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox9.AutoCompleteCustomSource = coll;
        }

        private void textBox9_Click(object sender, EventArgs e)
        {
            autodetai();
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

            DataView DV = new DataView(dbdataset3);
            DV.RowFilter = string.Format("Convert(inn,'System.String') Like '%{0}%'", textBox30.Text);
            dataGridView7.DataSource = DV;
        }

        public void autoinn()
        {
            textBox30.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox30.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string Query = "select journal_expenses.inn from bddiplom.journal_expenses;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetInt32("inn").ToString();
                    coll.Add(sname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox30.AutoCompleteCustomSource = coll;
        }

        private void textBox30_Click(object sender, EventArgs e)
        {
            autoinn();
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset3);
            DV.RowFilter = string.Format("adress Like '%{0}%'", textBox31.Text);
            dataGridView7.DataSource = DV; 
        }

        public void autokonad()
        {
            textBox31.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox31.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

            string Query = "select kontragents.adress as namefirm from bddiplom.kontragents;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sname = myReader.GetString("namefirm");
                    coll.Add(sname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox31.AutoCompleteCustomSource = coll;
        }

        private void textBox31_Click(object sender, EventArgs e)
        {
            autokonad();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("Convert(date,'System.String') Like '%{0}%'", dateTimePicker1.Text);
            dataGridView1.DataSource = DV;
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox14.Clear();
            dateTimePicker1.ResetText();
            comboBox1.SelectedIndex = -1;
            load_table1();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            comboBox3.SelectedIndex = -1;
            load_table2();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            comboBox2.SelectedIndex = -1;
            load_table3();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox30.Clear();
            textBox31.Clear();
            comboBox4.SelectedIndex = -1;
            load_table7();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox11.Clear();
            textBox10.Clear();
            comboBox5.SelectedIndex = -1;
            load_table5();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox12.Clear();
            textBox13.Clear();
            comboBox6.SelectedIndex = -1;
            load_table8();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset6);
            DV.RowFilter = string.Format("Convert(date,'System.String') Like '%{0}%'", dateTimePicker2.Text);
            dataGridView9.DataSource = DV;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            dateTimePicker2.ResetText();
            comboBox7.SelectedIndex = -1;
            load_table9();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox24.Clear();
            textBox25.Clear();
            textBox26.Clear();
            textBox27.Clear();
            textBox28.Clear();
            textBox29.Clear();
            comboBox10.SelectedIndex = -1;
            load_table10();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox22.Clear();
            textBox23.Clear();
            comboBox9.SelectedIndex = -1;
            load_table11();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox18.Clear();
            comboBox8.SelectedIndex = -1;
            load_table12();
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

        private void comboBox6_MouseWheel(object sender, MouseEventArgs e)
        {
            HandledMouseEventArgs ev = e as HandledMouseEventArgs;
            if (ev != null)
            {
                ev.Handled = true;
            }
        }

        private void comboBox7_MouseWheel(object sender, MouseEventArgs e)
        {
            HandledMouseEventArgs ev = e as HandledMouseEventArgs;
            if (ev != null)
            {
                ev.Handled = true;
            }
        }

        private void comboBox8_MouseWheel(object sender, MouseEventArgs e)
        {
            HandledMouseEventArgs ev = e as HandledMouseEventArgs;
            if (ev != null)
            {
                ev.Handled = true;
            }
        }

        private void comboBox9_MouseWheel(object sender, MouseEventArgs e)
        {
            HandledMouseEventArgs ev = e as HandledMouseEventArgs;
            if (ev != null)
            {
                ev.Handled = true;
            }
        }

        private void comboBox10_MouseWheel(object sender, MouseEventArgs e)
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
