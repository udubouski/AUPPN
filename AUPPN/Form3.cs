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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            tabPage1.Enabled = false;
            tabPage2.Enabled = false;
            tabPage3.Enabled = false;
            tabPage5.Enabled = false;
            tabPage4.Enabled = false;
            tabPage6.Enabled = false;
            tabPage7.Enabled = false;
            tabPage8.Enabled = false;
            tabPage9.Enabled = false;
            tabPage10.Enabled = false;
            textBox10.Visible = false;

            this.comboBox13.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox13_MouseWheel);
            this.comboBox14.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox14_MouseWheel);
            this.comboBox21.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox21_MouseWheel);
            this.comboBox20.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox20_MouseWheel);
            this.comboBox19.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox19_MouseWheel);
            this.comboBox8.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox8_MouseWheel);
            this.comboBox26.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox26_MouseWheel);
            this.comboBox17.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox17_MouseWheel);
            this.comboBox18.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox18_MouseWheel);
            this.comboBox9.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox9_MouseWheel);
            this.comboBox16.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox16_MouseWheel);
            this.comboBox10.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox10_MouseWheel);
            this.comboBox11.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox11_MouseWheel);
            this.comboBox15.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox15_MouseWheel);
            this.comboBox23.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox23_MouseWheel);
            this.comboBox3.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox3_MouseWheel);
            this.comboBox24.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox24_MouseWheel);
            this.comboBox6.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox6_MouseWheel);
            this.comboBox7.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox7_MouseWheel);
            this.comboBox22.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox22_MouseWheel);
            this.comboBox4.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox4_MouseWheel);
            this.comboBox12.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox12_MouseWheel);
            this.comboBox2.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox2_MouseWheel);
            this.comboBox1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox11_MouseWheel);
            this.comboBox25.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.comboBox25_MouseWheel);
        }
        public string constring = "datasource = localhost; port=3306;username=root;password=1234;charset=utf8";

        
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 main = this.Owner as Form2;
            main.but1 = false;
            main.but2 = false;
            main.but3 = false;
            Close();
            main.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.Beep(); 
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e) //button OK type_kontragents
        {
            Form2 main = this.Owner as Form2;
            if (main.but1 == true)
            {
                if (textBox1.Text == string.Empty)
                {
                    MessageBox.Show("Заполните все поля!");
                }
                    
                    else{
                    string Query = "insert ignore into bddiplom.type_kontragents(name) values ('" + this.textBox1.Text + "') ;";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Сохранено!");
                        while (myReader.Read())
                        {

                        }
                        conDataBase.Close();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Такая запись уже существует!");
                    }
                    }

                }
            

            else if (main.but2 == true)
            {
                if (textBox4.Text == string.Empty || textBox1.Text == string.Empty)
                {
                    MessageBox.Show("Заполните все поля!");
                }
                else {
                string Query = "update bddiplom.type_kontragents set name='" + this.textBox1.Text + "' where id_type='" + this.textBox4.Text + "';";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;
                try
                {
                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    MessageBox.Show("Изменено!");
                    while (myReader.Read())
                    {

                    }
                    conDataBase.Close();
                    
                }
                catch (Exception )
                {
                    MessageBox.Show("Такая запись уже существует!");
                }
                }
            }
    

            else if (main.but3 == true)
            {
                if (textBox4.Text == string.Empty)
                {
        MessageBox.Show("Заполните все поля!");
    }
        else{
                    string Query = "delete from bddiplom.type_kontragents where id_type='" + this.textBox4.Text + "' ;";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Удалено!");
                        while (myReader.Read())
                        {

                        }
                        conDataBase.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    comboBox1.Items.Clear();
                    fillcom12();
                }
            }
         
            main.load_table12();
        }

        private void button6_Click(object sender, EventArgs e) //button OK departments
        {
            Form2 main = this.Owner as Form2;
            if (main.but1 == true)
            {
                if (textBox2.Text == string.Empty)
                {
                    MessageBox.Show("Заполните все поля!");
                }
                else
                {
                    string Query = "insert ignore into bddiplom.departments(name) values ('" + this.textBox2.Text + "') ;";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Сохранено!");
                        while (myReader.Read())
                        {

                        }
                        conDataBase.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Такая запись уже существует!");
                    }
                }
            }

            else if (main.but2 == true)
            {
                if (textBox3.Text == string.Empty || textBox2.Text == string.Empty)
                {
                    MessageBox.Show("Заполните все поля!");
                }
                else
                {
                    string Query = "update bddiplom.departments set name='" + this.textBox2.Text + "' where id_department='" + this.textBox3.Text + "';";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Изменено!");
                        while (myReader.Read())
                        {

                        }
                        conDataBase.Close();
                       
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Такая запись уже существует!");
                    }
                }
            }

            else if (main.but3 == true)
            {
                if (textBox3.Text == string.Empty)
                {
                    MessageBox.Show("Заполните все поля!");
                }
                else
                {
                    string Query = "delete from bddiplom.departments where id_department='" + this.textBox3.Text + "' ;";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Удалено!");
                        while (myReader.Read())
                        {

                        }
                        conDataBase.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    comboBox20.Items.Clear();
                    fillcom4();
                }
            }
            main.load_table2();
            

        }

        private void button4_Click(object sender, EventArgs e) // button OK group_goods
        {
            Form2 main = this.Owner as Form2;
            if (main.but1 == true)
            {
                if (textBox5.Text == string.Empty)
                {
                    MessageBox.Show("Заполните все поля!");
                }
                else
                {
                    string Query = "insert ignore into bddiplom.group_goods (name,details) values ('" + this.textBox5.Text + "','" + this.textBox10.Text + "') ;";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Сохранено!");
                        while (myReader.Read())
                        {

                        }
                        conDataBase.Close();
                    }
                    catch (Exception )
                    {
                        MessageBox.Show("Такая запись уже существует!");
                    }
                }
            }

            else if (main.but2 == true)
            {
                if (textBox5.Text == string.Empty || textBox6.Text == string.Empty)
                {
                    MessageBox.Show("Заполните все поля!");
                }
                else
                {
                    string Query = "update bddiplom.group_goods set name='" + this.textBox5.Text + "',details='" + this.textBox10.Text + "' where id_group='" + this.textBox6.Text + "';";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Изменено!");
                        while (myReader.Read())
                        {

                        }
                        conDataBase.Close();
                       
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Такая запись уже существует!");
                    }
                }
            }

            else if (main.but3 == true)
            {
                if (textBox6.Text == string.Empty)
                {
                    MessageBox.Show("Заполните все поля!");
                }
                else
                {
                    string Query = "delete from bddiplom.group_goods where id_group='" + this.textBox6.Text + "' ;";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Удалено!");
                        while (myReader.Read())
                        {

                        }
                        conDataBase.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                    comboBox19.Items.Clear();
                    fillcom5();
                }
            }
            main.load_table3();
        }

        public void combo13() //combobox13 table buys1
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
                    comboBox13.Items.Add(kontrname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string sbuys1;
        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "select * from bddiplom.kontragents where name='" + comboBox13.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    sbuys1 = myReader.GetInt32("id_kontragent").ToString();
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void combo14() //combobox14 table buys2
        {
            string Query = "select * from bddiplom.managers where id_department=1";
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
                    comboBox14.Items.Add(managname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string sbuys2;
        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "select * from bddiplom.managers where fio='" + comboBox14.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    sbuys2 = myReader.GetInt32("id_manager").ToString();
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button5_Click(object sender, EventArgs e) //button OK buys
        {
           
            Form2 main = this.Owner as Form2;
            int numm1 = Convert.ToInt32(sbuys1);
            int numm2 = Convert.ToInt32(sbuys2);
            if (main.but1 == true)
            {
                 if (comboBox13.Text == string.Empty || comboBox14.Text == string.Empty || dateTimePicker1.Text == string.Empty)
            {
                MessageBox.Show("Заполните все поля!");
            }
            else {
                string Query = "insert ignore into bddiplom.buys (id_kontragent,id_manager,date) values ('" + numm1 + "', '" + numm2 + "', '" + this.dateTimePicker1.Text + "') ;";
                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                MySqlDataReader myReader;
                try
                {
                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    MessageBox.Show("Сохранено!");
                    while (myReader.Read())
                    {

                    }
                    
                    conDataBase.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Такая запись уже существует!");
                }
            }

            }

            else if (main.but2 == true)
            {
                if (textBox7.Text == string.Empty || comboBox13.Text == string.Empty || comboBox14.Text == string.Empty || dateTimePicker1.Text == string.Empty)
                {
                    MessageBox.Show("Заполните все поля!");
                }
                else
                {
                    string Query = "update bddiplom.buys set id_kontragent='" + numm1 + "',id_manager='" + numm2 + "',date= '" + this.dateTimePicker1.Text + "' where id_buy='" + this.textBox7.Text + "';";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Изменено!");
                        while (myReader.Read())
                        {

                        }
                        conDataBase.Close();
                        
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Такая запись уже существует!");
                    }
                }
            }

            else if (main.but3 == true)
            {
                if (textBox7.Text == string.Empty)
                {
                    MessageBox.Show("Заполните все поля!");
                }
                else
                {
                    string Query = "delete from bddiplom.buys where id_buy='" + this.textBox7.Text + "' ;";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Удалено!");
                        while (myReader.Read())
                        {

                        }
                        conDataBase.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    comboBox21.Items.Clear();
                    fillcom3();
                }
            }
            main.load_table1();
          
            
        }

        public void combo4() //combobox4 table goods1
        {
            string Query = "select * from bddiplom.buys";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string buyname = myReader.GetInt32("id_buy").ToString();
                    comboBox4.Items.Add(buyname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string sgood1;
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "select * from bddiplom.buys where id_buy='" + comboBox4.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    sgood1= myReader.GetInt32("id_buy").ToString();
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void combo12() //combobox12 table goods2
        {
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
                    string groupname = myReader.GetString("name");
                    comboBox12.Items.Add(groupname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string sgood2;
        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e) //combobox12 table goods2
        {
            string Query = "select * from bddiplom.group_goods where name='" + comboBox12.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    sgood2 = myReader.GetInt32("id_group").ToString();
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button15_Click(object sender, EventArgs e) //button OK goods
        {
            Form2 main = this.Owner as Form2;
            int numm1 = Convert.ToInt32(sgood1);
            int numm2 = Convert.ToInt32(sgood2);
            if (main.but1 == true)
            {
                if (comboBox22.Text == string.Empty || comboBox4.Text == string.Empty || comboBox12.Text == string.Empty || textBox26.Text == string.Empty || textBox27.Text == string.Empty || textBox28.Text == string.Empty)
                {
                    MessageBox.Show("Заполните все поля!");
                }
                else
                {
                    string Query = "insert ignore into bddiplom.goods (id_buy,id_group,name,unit_one,price) values ('" + numm1 + "', '" + numm2 + "', '" + this.textBox26.Text + "', '" + this.textBox27.Text + "', '" + this.textBox28.Text + "') ;";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Сохранено!");
                        while (myReader.Read())
                        {

                        }
                        conDataBase.Close();
                       
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Такая запись уже существует!");
                    }
                   
                }

            }

            else if (main.but2 == true)
            {
                if (textBox25.Text == string.Empty || comboBox22.Text == string.Empty || comboBox4.Text == string.Empty || comboBox12.Text == string.Empty || textBox26.Text == string.Empty || textBox27.Text == string.Empty || textBox28.Text == string.Empty)
                {
                    MessageBox.Show("Заполните все поля!");
                }
                else
                {
                    string Query = "update bddiplom.goods set id_buy='" + numm1 + "',id_group='" + numm2 + "',name='" + this.textBox26.Text + "',unit_one='" + this.textBox27.Text + "',price='" + this.textBox28.Text + "' where id_good='" + this.textBox25.Text + "';";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Изменено!");
                        while (myReader.Read())
                        {

                        }
                        conDataBase.Close();
                        
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Такая запись уже существует!");
                    }

                }
            }

            else if (main.but3 == true)
            {
                if (textBox25.Text == string.Empty)
                {
                    MessageBox.Show("Заполните все поля!");
                }
                else
                {
                    string Query = "delete from bddiplom.goods where id_good='" + this.textBox25.Text + "' ;";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Удалено!");
                        while (myReader.Read())
                        {

                        }
                        conDataBase.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    comboBox2.Items.Clear();
                    fillcom11();
                }
            }
            main.load_table11(); 
        }

        public void combo9() //combobox9 table managers
        {
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
                    string depname = myReader.GetString("name");
                    comboBox9.Items.Add(depname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string sdepart;
        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "select * from bddiplom.departments where name='" + comboBox9.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    sdepart = myReader.GetInt32("id_department").ToString();
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button13_Click(object sender, EventArgs e) //button OK managers
        {
            Form2 main = this.Owner as Form2;
            int numm = Convert.ToInt32(sdepart);
            if (main.but1 == true)
            {
                if (textBox21.Text == string.Empty || comboBox9.Text == string.Empty)
                {
                    MessageBox.Show("Заполните все поля!");
                }
                else
                {
                    string Query = "insert ignore into bddiplom.managers(fio,id_department) values ('" + this.textBox21.Text + "', '" + numm + "') ;";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Сохранено!");
                        while (myReader.Read())
                        {

                        }
                        conDataBase.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Такая запись уже существует!");
                    }
                }
            }

            else if (main.but2 == true)
            {
                if (textBox22.Text == string.Empty || textBox13.Text == string.Empty || textBox15.Text == string.Empty)
                {
                    MessageBox.Show("Заполните все поля!");
                }
                else
                {
                    string Query = "update bddiplom.managers set fio='" + this.textBox21.Text + "',id_department='" + numm + "' where id_manager='" + this.textBox22.Text + "';";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Изменено!");
                        while (myReader.Read())
                        {

                        }
                        conDataBase.Close();
                       
                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Такая запись уже существует!");
                    }
                }

            }

            else if (main.but3 == true)
            {
                if (textBox22.Text == string.Empty)
                {
                    MessageBox.Show("Заполните все поля!");
                }
                else
                {
                    string Query = "delete from bddiplom.managers where id_manager='" + this.textBox22.Text + "' ;";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Удалено!");
                        while (myReader.Read())
                        {

                        }
                        conDataBase.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    comboBox16.Items.Clear();
                    fillcom8();
                }
            }
            main.load_table8();
            
        }

        private void button10_Click(object sender, EventArgs e) //button OK expenses
        {
            Form2 main = this.Owner as Form2;
            
            if (main.but1 == true)
            {
                if (textBox13.Text == string.Empty || textBox15.Text == string.Empty)
                {
                    MessageBox.Show("Заполните все поля!");
                }
               
                else
                {
                    string Query = "insert into bddiplom.journal_expenses(inn,details) values ('" + this.textBox15.Text + "','" + this.textBox13.Text + "') ;";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Сохранено!");
                        while (myReader.Read())
                        {

                        }
                        conDataBase.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Такая запись уже существует!");
                    }
                }
            }

            else if (main.but2 == true)
            {
                if (textBox30.Text == string.Empty || textBox13.Text == string.Empty || textBox15.Text == string.Empty)
                {
                    MessageBox.Show("Заполните все поля!");
                }
                else
                {
                    string Query = "update bddiplom.journal_expenses set inn='" + this.textBox15.Text + "',details='" + this.textBox13.Text + "' where id_expense='" + this.textBox30.Text + "';";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Изменено!");
                        while (myReader.Read())
                        {

                        }
                        conDataBase.Close();
                     
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Такая запись уже существует!");
                    }
                }

            }

            else if (main.but3 == true)
            {
                if (textBox30.Text == string.Empty)
                {
                    MessageBox.Show("Заполните все поля!");
                }
                else
                {
                    string Query = "delete from bddiplom.journal_expenses where id_expense='" + this.textBox30.Text + "' ;";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Удалено!");
                        while (myReader.Read())
                        {

                        }
                        conDataBase.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    comboBox18.Items.Clear();
                    fillcom6();
                }
            }
            main.load_table5();
            
        }

        

        public void combo8() //combobox8 table kontragents
        {
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
                    string typkontrname = myReader.GetString("name");
                    comboBox8.Items.Add(typkontrname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string stypekon;
        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "select * from bddiplom.type_kontragents where name='" + comboBox8.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    stypekon = myReader.GetInt32("id_type").ToString();
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button12_Click(object sender, EventArgs e) //button OK kontragents
        {
            Form2 main = this.Owner as Form2;
             
            int numm = Convert.ToInt32(stypekon);
            
            if (main.but1 == true)
            {
                if (comboBox8.Text == string.Empty || textBox16.Text == string.Empty || textBox17.Text == string.Empty || textBox18.Text == string.Empty || textBox35.Text == string.Empty || comboBox26.Text == string.Empty)
                {
                    MessageBox.Show("Заполните все поля!");
                }
              
                else {
                    string Query = "insert into bddiplom.kontragents(id_type,id_expense,name,fio,phone,adress) values ('" + numm + "','" + this.comboBox26.Text + "', '" + this.textBox16.Text + "', '" + this.textBox17.Text + "', '" + this.textBox18.Text + "', '" + this.textBox35.Text + "') ;";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Сохранено!");
                        while (myReader.Read())
                        {

                        }
                        conDataBase.Close();


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Такая запись уже существует!");
                    }

                }
            }

            else if (main.but2 == true)
            {
                if (textBox31.Text==string.Empty || comboBox8.Text == string.Empty || textBox16.Text == string.Empty || textBox17.Text == string.Empty || textBox18.Text == string.Empty || textBox35.Text == string.Empty || comboBox26.Text == string.Empty)
                {
                    MessageBox.Show("Заполните все поля!");
                }
                else
                {
                    string Query = "update bddiplom.kontragents set id_type='" + numm + "',id_expense='" + this.comboBox26.Text + "',name='" + this.textBox16.Text + "',fio= '" + this.textBox17.Text + "',phone= '" + this.textBox18.Text + "',adress='" + this.textBox18.Text + "' where id_kontragent='" + this.textBox31.Text + "';";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Изменено!");
                        while (myReader.Read())
                        {

                        }
                        conDataBase.Close();
                        
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Такая запись уже существует!");
                    }
                }

            }

            else if (main.but3 == true)
            {
                if (textBox31.Text == string.Empty)
                {
                    MessageBox.Show("Заполните все поля!");
                }
                else
                {
                    string Query = "delete from bddiplom.kontragents where id_kontragent='" + this.textBox31.Text + "' ;";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Удалено!");
                        while (myReader.Read())
                        {

                        }
                        conDataBase.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                   
                    comboBox17.Items.Clear();
                    fillcom7();
                }
            }
            main.load_table7();
           
        }
     

        public void combo10() //combobox10 table sales1
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
                    comboBox10.Items.Add(kontrname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string ssale1;
        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "select * from bddiplom.kontragents where name='" + comboBox10.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    ssale1 = myReader.GetInt32("id_kontragent").ToString();
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void combo11() //combobox11 table sales2
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
                    comboBox11.Items.Add(managname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public string ssale2;
        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "select * from bddiplom.managers where fio='" + comboBox11.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    ssale2 = myReader.GetInt32("id_manager").ToString();
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button14_Click(object sender, EventArgs e) //button OK sales
        {
            Form2 main = this.Owner as Form2;
            int numm1 = Convert.ToInt32(ssale1);
            int numm2 = Convert.ToInt32(ssale2);
            if (main.but1 == true)
            {
                if (comboBox10.Text == string.Empty || comboBox11.Text == string.Empty || dateTimePicker2.Text == string.Empty)
                {
                    MessageBox.Show("Заполните все поля!");
                }
                else
                {
                    string Query = "insert ignore into bddiplom.sales (id_kontragent,id_manager,date) values ('" + numm1 + "', '" + numm2 + "', '" + this.dateTimePicker2.Text + "') ;";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Сохранено!");
                        while (myReader.Read())
                        {

                        }
                        conDataBase.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Такая запись уже существует!");
                    }
                }
            }

            else if (main.but2 == true)
            {
                if (textBox23.Text == string.Empty || comboBox10.Text == string.Empty || comboBox11.Text == string.Empty || dateTimePicker2.Text == string.Empty)
                {
                    MessageBox.Show("Заполните все поля!");
                }
                else
                {
                    string Query = "update bddiplom.sales set id_kontragent='" + numm1 + "',id_manager='" + numm2 + "',date= '" + this.dateTimePicker2.Text + "' where id_sale='" + this.textBox23.Text + "';";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Изменено!");
                        while (myReader.Read())
                        {

                        }
                        
                        textBox19.Clear();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Такая запись уже существует!");
                    }
                }

            }

            else if (main.but3 == true)
            {
                if (textBox23.Text == string.Empty)
                {
                    MessageBox.Show("Заполните все поля!");
                }
                else
                {
                    string Query = "delete from bddiplom.sales where id_sale='" + this.textBox23.Text + "' ;";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Удалено!");
                        while (myReader.Read())
                        {

                        }
                        conDataBase.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    comboBox15.Items.Clear();
                    fillcom9();
                }
            }
            main.load_table9(); 
    
    
        }
     
        public void combo3() //combobox3 table store1
        {
            string Query = "select * from bddiplom.sales;";
    
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string salename = myReader.GetString("id_sale");
                    comboBox3.Items.Add(salename);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public string sstor1;
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "select * from bddiplom.sales where id_sale='" + comboBox3.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    sstor1 = myReader.GetInt32("id_sale").ToString();
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       

        public string sstor2;
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "select goods.id_good from bddiplom.goods,bddiplom.buys,bddiplom.group_goods,bddiplom.kontragents where buys.id_kontragent = kontragents.id_kontragent and goods.id_buy=buys.id_buy and group_goods.id_group = goods.id_group and goods.name='" + comboBox6.Text + "' and kontragents.name ='" + this.comboBox24.Text + "' and group_goods.name='" + this.comboBox25.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    sstor2 = myReader.GetInt32("id_good").ToString();
                 
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button9_Click(object sender, EventArgs e) //button OK store
        {
            Form2 main = this.Owner as Form2;
          
            int numm1 = Convert.ToInt32(sstor1);
            int numm2 = Convert.ToInt32(sstor2);
            if (main.but1 == true)
            {
                if (textBox9.Text == "0")
                {
                    MessageBox.Show("Введите число от 1 до 9999!");
                }
                else if (comboBox23.Text == string.Empty || comboBox24.Text == string.Empty || comboBox25.Text == string.Empty || comboBox3.Text == string.Empty || comboBox6.Text == string.Empty || textBox9.Text == string.Empty)
                {
                    MessageBox.Show("Заполните все поля!");
                }
    
                else
                {
                    string Query = "insert ignore into bddiplom.store (id_sale,id_good,amount) values ('" + numm1 + "', '" + numm2 + "', '" + this.textBox9.Text + "') ;";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Сохранено!");
                        while (myReader.Read())
                        {

                        }
                        conDataBase.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Такая запись уже существует!");
                    }
                }
            }

            else if (main.but2 == true)
            {
                if (textBox8.Text == string.Empty || comboBox23.Text == string.Empty || comboBox24.Text == string.Empty || comboBox25.Text == string.Empty || comboBox3.Text == string.Empty || comboBox6.Text == string.Empty || textBox9.Text == string.Empty)
                {
                    MessageBox.Show("Заполните все поля!");
                }
                else
                {
                    string Query = "update bddiplom.store set id_sale='" + numm1 + "',id_good='" + numm2 + "',amount='" + this.textBox9.Text + "' where id_store='" + this.textBox8.Text + "';";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Изменено!");
                        while (myReader.Read())
                        {

                        }
                        conDataBase.Close();
                       
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Такая запись уже существует!");
                    }

                }
            }

            else if (main.but3 == true)
            {
                if (textBox8.Text == string.Empty)
                {
                    MessageBox.Show("Заполните все поля!");
                }
                else
                {
                    string Query = "delete from bddiplom.store where id_store='" + this.textBox8.Text + "' ;";
                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
                    MySqlDataReader myReader;
                    try
                    {
                        conDataBase.Open();
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Удалено!");
                        while (myReader.Read())
                        {

                        }
                        conDataBase.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    comboBox7.Items.Clear();
                    fillcom10();
                }
            }
            main.load_table10(); 
        }

        public void fillcom12() //data combo type_kontragents
        {
            string Query = "select * from bddiplom.type_kontragents order by id_type;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sid_type = myReader.GetInt32("id_type").ToString();
                    comboBox1.Items.Add(sid_type);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //type_kontragents
        {
            string Query = "select * from bddiplom.type_kontragents where id_type='" + comboBox1.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sid_type = myReader.GetInt32("id_type").ToString();
                    string sname = myReader.GetString("name");
                    textBox4.Text = sid_type;
                    textBox11.Text = sid_type + Environment.NewLine + sname;
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void fillcom11() //data combo goods
        {
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
                    string sid_good = myReader.GetInt32("id_good").ToString();
                    comboBox2.Items.Add(sid_good);
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
            string Query = "select goods.id_good,kontragents.name as post,buys.id_buy,group_goods.name as namegroup,goods.name,goods.unit_one,goods.price from bddiplom.goods,bddiplom.group_goods,bddiplom.buys,bddiplom.kontragents where goods.id_group = group_goods.id_group and goods.id_buy=buys.id_buy and buys.id_kontragent=kontragents.id_kontragent and goods.id_good='" + comboBox2.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sid_good = myReader.GetInt32("id_good").ToString();
                    string spost = myReader.GetString("post");
                    string sbuy = myReader.GetInt32("id_buy").ToString();
                    string snamegroup = myReader.GetString("namegroup");
                    string sname = myReader.GetString("name");
                    string sunit_one = myReader.GetString("unit_one");
                    string sprice = myReader.GetInt32("price").ToString();
                    textBox25.Text = sid_good;
                    textBox12.Text = sid_good + Environment.NewLine + spost + Environment.NewLine +sbuy + Environment.NewLine + snamegroup + Environment.NewLine + sname + Environment.NewLine + sunit_one + Environment.NewLine + sprice;
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void fillcom10() //data combo store
        {
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
                    string sid_store = myReader.GetInt32("id_store").ToString();
                    comboBox7.Items.Add(sid_store);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "select store.id_store,kontragents.name as klient,sales.id_sale, group_goods.name as nametype,goods.name,goods.id_good,store.amount,goods.price from bddiplom.buys,bddiplom.store,bddiplom.sales,bddiplom.goods,bddiplom.kontragents,bddiplom.group_goods where sales.id_kontragent=kontragents.id_kontragent and store.id_good=goods.id_good and goods.id_group = group_goods.id_group and store.id_sale =sales.id_sale and goods.id_buy = buys.id_buy and store.id_store='" + comboBox7.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sid_store = myReader.GetInt32("id_store").ToString();
                    string sid_sale = myReader.GetString("klient");
                    string ssale = myReader.GetInt32("id_sale").ToString();
                    string stype= myReader.GetString("nametype");
                    string sname = myReader.GetString("name");
                    string sgod = myReader.GetInt32("id_good").ToString();
                    string samount = myReader.GetInt32("amount").ToString();
                    string sprice = myReader.GetInt32("price").ToString();

                    textBox8.Text = sid_store;
                    textBox14.Text = sid_store + Environment.NewLine + sid_sale + Environment.NewLine + ssale + Environment.NewLine + sgod +  Environment.NewLine + stype + Environment.NewLine + sname + Environment.NewLine + samount + Environment.NewLine + sprice;
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void fillcom9() //data combo sales
        {
            string Query = "select * from bddiplom.sales;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sid_sale = myReader.GetInt32("id_sale").ToString();
                    comboBox15.Items.Add(sid_sale);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "select sales.id_sale,kontragents.name as namefirm, managers.fio as manager,sales.date from bddiplom.managers,bddiplom.sales, bddiplom.kontragents where  sales.id_manager = managers.id_manager and sales.id_kontragent = kontragents.id_kontragent and sales.id_sale='" + comboBox15.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sid_sale= myReader.GetInt32("id_sale").ToString();
                    string snamefirm = myReader.GetString("namefirm");
                    string smanager = myReader.GetString("manager");
                    string sdate = myReader.GetString("date");
                    textBox23.Text = sid_sale;
                    textBox19.Text = sid_sale + Environment.NewLine + snamefirm + Environment.NewLine + smanager + Environment.NewLine + sdate;
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void fillcom8() //data combo managers
        {
            string Query = "select * from bddiplom.managers;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sid_manager = myReader.GetInt32("id_manager").ToString();
                    comboBox16.Items.Add(sid_manager);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "select managers.id_manager, managers.fio, departments.name from bddiplom.managers,bddiplom.departments where managers.id_department=departments.id_department and managers.id_manager='" + comboBox16.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sid_manager = myReader.GetInt32("id_manager").ToString();
                    string sfio = myReader.GetString("fio");
                    string sname = myReader.GetString("name");
                    textBox22.Text = sid_manager;
                    textBox20.Text = sid_manager + Environment.NewLine + sfio + Environment.NewLine + sname;
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void fillcom7() //data combo kontragents
        {
            string Query = "select * from bddiplom.kontragents;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sid_kon = myReader.GetInt32("id_kontragent").ToString();
                    comboBox17.Items.Add(sid_kon);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "select kontragents.id_kontragent, type_kontragents.name, kontragents.name as namefirm,kontragents.fio, kontragents.phone,kontragents.adress,journal_expenses.id_expense,journal_expenses.details as rekviz,journal_expenses.inn from bddiplom.kontragents,bddiplom.type_kontragents,bddiplom.journal_expenses where kontragents.id_type = type_kontragents.id_type and journal_expenses.id_expense=kontragents.id_expense and kontragents.id_kontragent='" + comboBox17.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sid_kon = myReader.GetInt32("id_kontragent").ToString();                   
                    string sname = myReader.GetString("name");
                    string snamefirm = myReader.GetString("namefirm");
                    string sfio= myReader.GetString("fio");
                    string sphone = myReader.GetInt32("phone").ToString();
                    string sad = myReader.GetString("adress");
                    string sexp = myReader.GetInt32("id_expense").ToString();
                    string srek = myReader.GetString("rekviz");
                    string sinn = myReader.GetInt32("inn").ToString();
                    textBox31.Text = sid_kon;
                    textBox24.Text = sid_kon + Environment.NewLine + sname + Environment.NewLine + snamefirm + Environment.NewLine + sfio + Environment.NewLine + sphone + Environment.NewLine + sad + Environment.NewLine  + sexp + Environment.NewLine + srek + Environment.NewLine + sinn;
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void fillcom6() //data combo journal_expenses
        {
            string Query = "select * from bddiplom.journal_expenses;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sid_exp = myReader.GetInt32("id_expense").ToString();
                    comboBox18.Items.Add(sid_exp);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "select journal_expenses.id_expense,journal_expenses.inn,journal_expenses.details from bddiplom.journal_expenses where journal_expenses.id_expense='" + comboBox18.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sid_exp = myReader.GetInt32("id_expense").ToString();
                    string sinn = myReader.GetInt32("inn").ToString();
                    string sdets = myReader.GetString("details");
                    textBox30.Text = sid_exp;
                    textBox29.Text = sid_exp + Environment.NewLine + sinn + Environment.NewLine + sdets;
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void fillcom5() //data combo group_goods
        {
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
                    string sid_group = myReader.GetInt32("id_group").ToString();
                    comboBox19.Items.Add(sid_group);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "select * from bddiplom.group_goods where group_goods.id_group='" + comboBox19.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sid_group = myReader.GetInt32("id_group").ToString();
                    string sname = myReader.GetString("name");
                    string sdets = myReader.GetString("details");
                    textBox6.Text = sid_group;
                    textBox32.Text = sid_group + Environment.NewLine + sname + Environment.NewLine + sdets;
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void fillcom4() //data combo departments
        {
            string Query = "select * from bddiplom.departments;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sid_dep = myReader.GetInt32("id_department").ToString();
                    comboBox20.Items.Add(sid_dep);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "select * from bddiplom.departments where departments.id_department='" + comboBox20.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sid_dep = myReader.GetInt32("id_department").ToString();
                    string sname = myReader.GetString("name");
                    textBox3.Text = sid_dep;
                    textBox33.Text = sid_dep + Environment.NewLine + sname;
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void fillcom3() //data combo buys
        {
            string Query = "select * from bddiplom.buys;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sid_buy = myReader.GetInt32("id_buy").ToString();
                    comboBox21.Items.Add(sid_buy);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "select buys.id_buy,kontragents.name as namefirm, managers.fio as manager,buys.date from bddiplom.managers,bddiplom.buys, bddiplom.kontragents where  buys.id_manager = managers.id_manager and buys.id_kontragent = kontragents.id_kontragent and buys.id_buy='" + comboBox21.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string sid_buy = myReader.GetInt32("id_buy").ToString();
                    string snamefirm = myReader.GetString("namefirm");
                    string sfio = myReader.GetString("manager");
                    string sdate = myReader.GetString("date");
                    textBox7.Text = sid_buy;
                    textBox34.Text = sid_buy + Environment.NewLine + snamefirm + Environment.NewLine + sfio + Environment.NewLine + sdate;
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsDigit(ch) && ch!=8 && ch!=46)
            {
                e.Handled = true;
            }
        }

        public void goodpro() //combobox for goods
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
                    comboBox22.Items.Add(buyname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox22_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "select * from bddiplom.buys,bddiplom.kontragents where buys.id_kontragent = kontragents.id_kontragent and kontragents.name = '"+this.comboBox22.Text+"'";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string buyname = myReader.GetInt32("id_buy").ToString();
                    comboBox4.Items.Add(buyname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void comboBox22_Click(object sender, EventArgs e)
        {
            this.comboBox4.Items.Clear();
        }

        public void storepro() //combobox for store
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
                    string buyname = myReader.GetString("name");
                    comboBox23.Items.Add(buyname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBox23_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "select * from bddiplom.sales,bddiplom.kontragents where sales.id_kontragent = kontragents.id_kontragent and kontragents.name = '" + this.comboBox23.Text + "'";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string buyname = myReader.GetInt32("id_sale").ToString();
                    comboBox3.Items.Add(buyname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox23_Click(object sender, EventArgs e)
        {
            this.comboBox3.Items.Clear();
        }

        public void storepro1() //combobox for store1
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
                    comboBox24.Items.Add(buyname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox24_SelectedIndexChanged(object sender, EventArgs e)
        {

            string Query = "select  distinct group_goods.name as namegro from bddiplom.group_goods,bddiplom.goods,bddiplom.buys,bddiplom.kontragents where buys.id_kontragent = kontragents.id_kontragent and goods.id_buy = buys.id_buy and goods.id_group =group_goods.id_group  and kontragents.name = '" + this.comboBox24.Text + "'";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string buyname = myReader.GetString("namegro");
                    comboBox25.Items.Add(buyname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBox24_Click(object sender, EventArgs e)
        {
            this.comboBox25.Items.Clear();
        }

        private void comboBox25_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "select distinct goods.name as namegroup from bddiplom.group_goods,bddiplom.goods,bddiplom.buys,bddiplom.kontragents where buys.id_kontragent = kontragents.id_kontragent and goods.id_buy = buys.id_buy and goods.id_group =group_goods.id_group and group_goods.name = '" + this.comboBox25.Text + "' and kontragents.name ='" + this.comboBox24.Text + "'";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string buyname = myReader.GetString("namegroup");

                    comboBox6.Items.Add(buyname);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox25_Click(object sender, EventArgs e)
        {
            this.comboBox6.Items.Clear();
        }

        public void combo26() //kontragents inn
        {
            string Query = "select * from bddiplom.journal_expenses";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    string kontik = myReader.GetInt32("id_expense").ToString();
                    comboBox26.Items.Add(kontik);
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox26_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Query = "select kontragents.name as namego from bddiplom.journal_expenses,bddiplom.kontragents where journal_expenses.id_expense=kontragents.id_expense  and journal_expenses.id_expense = '" +this.comboBox26.Text + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                   
                    string buyname = myReader.GetString("namego");
                    label16.Text = "Занят:"+buyname;
                   
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox26_Click(object sender, EventArgs e)
        {
            label16.Text = "";
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBox7.Clear();
            comboBox13.SelectedIndex = -1;
            comboBox14.SelectedIndex = -1;
            dateTimePicker1.ResetText();
            comboBox21.SelectedIndex = -1;
            textBox34.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            comboBox20.SelectedIndex = -1;
            textBox33.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox6.Clear();
            comboBox19.SelectedIndex = -1;
            textBox32.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            comboBox26.SelectedIndex = -1;
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox35.Clear();
            comboBox8.SelectedIndex = -1;
            textBox31.Clear();
            comboBox17.SelectedIndex = -1;
            textBox24.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox13.Clear();
            textBox15.Clear();
            textBox30.Clear();
            comboBox18.SelectedIndex = -1;
            textBox29.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox22.Clear();
            textBox21.Clear();
            comboBox9.SelectedIndex = -1;
            textBox20.Clear();
            comboBox16.SelectedIndex = -1;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            comboBox10.SelectedIndex = -1;
            comboBox11.SelectedIndex = -1;
            dateTimePicker2.ResetText();
            textBox23.Clear();
            comboBox15.SelectedIndex = -1;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            comboBox23.SelectedIndex = -1;
            comboBox24.SelectedIndex = -1;
            comboBox25.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            textBox9.Clear();
            textBox8.Clear();
            comboBox7.SelectedIndex = -1;
            textBox14.Clear();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            comboBox22.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox12.SelectedIndex = -1;
            textBox26.Clear();
            textBox27.Clear();
            textBox28.Clear();
            textBox25.Clear();
            comboBox2.SelectedIndex = -1;
            textBox12.Clear();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox1.Clear();
            textBox11.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void textBox31_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

       




        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox30_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }



        private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox25_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox28_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
      

        private void textBox27_KeyPress(object sender, KeyPressEventArgs e)
        {

            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {


            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && l != '\b' && l != '.')
            {
                e.Handled = true;
            }
            
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void comboBox13_MouseWheel(object sender, MouseEventArgs e)
        {
            HandledMouseEventArgs ev = e as HandledMouseEventArgs;
            if (ev != null)
            {
                ev.Handled = true;
            }
        }

        private void comboBox14_MouseWheel(object sender, MouseEventArgs e)
        {
            HandledMouseEventArgs ev = e as HandledMouseEventArgs;
            if (ev != null)
            {
                ev.Handled = true;
            }
        }

        private void comboBox21_MouseWheel(object sender, MouseEventArgs e)
        {
            HandledMouseEventArgs ev = e as HandledMouseEventArgs;
            if (ev != null)
            {
                ev.Handled = true;
            }
        }

        private void comboBox20_MouseWheel(object sender, MouseEventArgs e)
        {
            HandledMouseEventArgs ev = e as HandledMouseEventArgs;
            if (ev != null)
            {
                ev.Handled = true;
            }
        }

        private void comboBox19_MouseWheel(object sender, MouseEventArgs e)
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

        private void comboBox26_MouseWheel(object sender, MouseEventArgs e)
        {
            HandledMouseEventArgs ev = e as HandledMouseEventArgs;
            if (ev != null)
            {
                ev.Handled = true;
            }
        }

        private void comboBox17_MouseWheel(object sender, MouseEventArgs e)
        {
            HandledMouseEventArgs ev = e as HandledMouseEventArgs;
            if (ev != null)
            {
                ev.Handled = true;
            }
        }

        private void comboBox18_MouseWheel(object sender, MouseEventArgs e)
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

        private void comboBox16_MouseWheel(object sender, MouseEventArgs e)
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

        private void comboBox11_MouseWheel(object sender, MouseEventArgs e)
        {
            HandledMouseEventArgs ev = e as HandledMouseEventArgs;
            if (ev != null)
            {
                ev.Handled = true;
            }
        }

        private void comboBox15_MouseWheel(object sender, MouseEventArgs e)
        {
            HandledMouseEventArgs ev = e as HandledMouseEventArgs;
            if (ev != null)
            {
                ev.Handled = true;
            }
        }

        private void comboBox23_MouseWheel(object sender, MouseEventArgs e)
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

        private void comboBox24_MouseWheel(object sender, MouseEventArgs e)
        {
            HandledMouseEventArgs ev = e as HandledMouseEventArgs;
            if (ev != null)
            {
                ev.Handled = true;
            }
        }

        private void comboBox25_MouseWheel(object sender, MouseEventArgs e)
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

        private void comboBox22_MouseWheel(object sender, MouseEventArgs e)
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

        private void comboBox12_MouseWheel(object sender, MouseEventArgs e)
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

        private void comboBox1_MouseWheel(object sender, MouseEventArgs e)
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

