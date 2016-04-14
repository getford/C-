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
            string pw = string.Empty;       // сюда положим расшифрованный пароль
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database.mdf;Integrated Security=True");
            try
            {
                connect.Open();
                string sql_quert_select_password = string.Format("open symmetric key SYMMETRIC_KEY decryption by asymmetric key ASYMMETRIC_KEY with password = '%(wbwgoo$'; select CONVERT(nvarchar(50), DECRYPTBYKEY(user_password)) as [user_password] from [dbo].[introduce] where user_login = '" + textBox1.Text.ToString() + "'");
                SqlCommand cmd_select = new SqlCommand(sql_quert_select_password, connect);
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
                        pw += dr["user_password"];

                        if (textBox2.Text.ToString() == pw.ToString())
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
                    dr.Close();

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

        private void Key_Down(object sender, KeyEventArgs e)  // сюда писать обработку нажатия кнопок
        {
            if(e.KeyCode == Keys.Enter)     // при нажатие на "Enter" будет обрабатываться кнопка "Войти"
            {
                button1_Click(sender, e);
            }
        }
    }
}
