using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.CodeDom;
using System.Data.OleDb;

using System.Data.SqlClient;
using System.Data.Sql;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            
             
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)              // log in
        { 
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database.mdf;Integrated Security=True");
            try
            {
                connect.Open();
                SqlCommand cmd_select = new SqlCommand("select user_password from introduce where user_login = '" + textBox1.Text.ToString() + "'", connect);
                SqlDataReader dr = cmd_select.ExecuteReader();
                if (textBox1.Text.ToString() == "" || textBox2.Text.ToString() == "")
                {
                    MessageBox.Show("Поля заполнены не корректно (возможно вы не ввели логин или пароль!). Пожалуйста, попробуйте снова!");
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    while (dr.Read())
                    {
                        if (textBox2.Text.ToString() == dr.GetString(0))
                        {
                            Form1 f1_main = new Form1();
                            f1_main.Owner = this;
                            f1_main.Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Введен не верный пароль!(Логин верный!). Если вы забыли ваш пароль, вы можете воспользоваться формой восстановления пароля!");
                        }
                    }
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)       // login textbox
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)       // password  textbox
        {

        }

        private void button4_Click(object sender, EventArgs e)              // close button
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)     // регистрация 
        {
            if (linkLabel2.Enabled == true)
            {
                SignInForm sgn_form = new SignInForm();
                sgn_form.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)      // свернуть
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Restore_Password frm = new Form_Restore_Password();
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection connectDB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database.mdf;Integrated Security=True");

            try
            {
                connectDB.Open();
                MessageBox.Show("OK", "Соединение установленно!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Соединение с бд НЕ установленно!", ex.Message);
            }
            finally
            {
                connectDB.Close();
            }
        }

        private void Key_Down(object sender, KeyEventArgs e)  // сюда писать обработку нажатия кнопок
        {
            if(e.KeyCode == Keys.Enter)     // при нажатие на "Enter" будет обрабатываться кнопка "Войти"
            {
                button1_Click(sender, e);
            }
        }
    }
}
