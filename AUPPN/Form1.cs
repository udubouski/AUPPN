using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;
namespace AUPPN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar='*';
            textBox2.MaxLength = 10;
            groupBox2.Enabled = false;
        }
        public string constring = "datasource = localhost; port=3306;username=root;password=1234;charset=utf8";

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.Beep(); 
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty)
            {
                MessageBox.Show("Пожалуйста,введите все данные!");
            }
            else
            {
                try
                {
                    MySqlConnection myConn = new MySqlConnection(constring);
                    MySqlCommand SelectComand = new MySqlCommand("select * from bddiplom.administrator where login='" + this.textBox1.Text + "' and password='" + this.textBox2.Text + "';", myConn);
                    MySqlDataReader myReader;
                    myConn.Open();
                    myReader = SelectComand.ExecuteReader();
                    int count = 0;
                    while (myReader.Read())
                    {
                        count++;
                    }

                    if (count == 1)
                    {
                        MessageBox.Show("Авторизация пройдена!");
                        this.Hide();
                        Form2 f2 = new Form2();
                        f2.ShowDialog();
                    }

                    else if (count > 1)
                    {
                        MessageBox.Show("Дупликат данных. Доступ запрещен!");
                    }

                    else
                    {
                        MessageBox.Show("Ошибка. Проверьте введенные данные!");
                    }

                    myConn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4= new Form4();
            f4.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button4.Visible = true;
            groupBox1.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            button4.Visible = false;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            button4.Visible = false;
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
         if (e.KeyCode == Keys.Enter)
                {
                    try
                    {
                        MySqlConnection myConn = new MySqlConnection(constring);
                        MySqlCommand SelectComand = new MySqlCommand("select * from bddiplom.administrator where login='" + this.textBox1.Text + "' and password='" + this.textBox2.Text + "';", myConn);
                        MySqlDataReader myReader;
                        myConn.Open();
                        myReader = SelectComand.ExecuteReader();
                        int count = 0;
                        while (myReader.Read())
                        {
                            count++;
                        }

                        if (count == 1)
                        {
                            MessageBox.Show("Авторизация пройдена!");
                            this.Hide();
                            Form2 f2 = new Form2();
                            f2.ShowDialog();
                        }

                        else if (count > 1)
                        {
                            MessageBox.Show("Дупликат данных. Доступ запрещен!");
                        }

                        else
                        {
                            MessageBox.Show("Ошибка. Проверьте введенные данные!");
                        }

                        myConn.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы действительно хотите выйти?", "Выйти", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();

            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 a1 = new AboutBox1();
            a1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = new MySqlConnection(constring);
            try
            {
                myConn.Open();
                MessageBox.Show("Соединение активно!");
                myConn.Close();
                groupBox2.Enabled = true;
            }

            catch (Exception)
            {
                MessageBox.Show("Соединение отсутствует. Проверьте настройки!");
            }
        }
    }
}
