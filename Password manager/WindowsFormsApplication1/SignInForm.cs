using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{

    public partial class SignInForm : Form
    { 
        public SignInForm()
        {
            InitializeComponent();

            /*Секреный вопрос 1*/
            comboBox1.Items.Add("Девичья фамилия матери");
            comboBox1.Items.Add("Модель вашей первой машины");
            comboBox1.Items.Add("Любимый писатель");
            comboBox1.Items.Add("Профессия вашего дедушки");
            /*Секретный вопрос 2*/
            comboBox2.Items.Add("Любимый номер телефона");
            comboBox2.Items.Add("Любимая книга");
            comboBox2.Items.Add("Любимое блюдо");
            comboBox2.Items.Add("Четыре последние цифры кредитной карты");
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();     // после закрытия формы, обновим форму входа (дабы были доступны новые акк из бд)
            f2.Refresh();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)      // кнопка очистки формы
        {
            if (button2.Enabled == true)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                comboBox1.ResetText();
                comboBox2.ResetText();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)      // кнопка регистрации
        {

            SqlConnection connectDB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database_site.mdf;Integrated Security=True");

            string select_cb_1 = comboBox1.SelectedItem.ToString();
            string select_cb_2 = comboBox2.SelectedItem.ToString();
            int kol;
            string password_lengh = textBox2.Text.ToString();           // пароль введенный пользователем
            kol = password_lengh.Length;                                // тут лежит длина пароля введенная пользователем

            if (textBox1.Text.ToString() != "" && textBox2.Text.ToString() != "" && textBox3.Text.ToString() != "" && textBox8.Text.ToString() != "" && textBox4.Text.ToString() != "" && textBox5.Text.ToString() != "" && select_cb_1.ToString() != "" && textBox6.Text.ToString() != "" && select_cb_2.ToString() != "" && textBox7.Text.ToString() != "")
            {
                if (textBox2.Text.ToString() == textBox3.Text.ToString())       // проверка совпадения паролей
                {
                    if (kol >= 4)
                    {
                        if (textBox2.Text.Contains('!') || textBox2.Text.Contains('@') || textBox2.Text.Contains('#') || textBox2.Text.Contains('$') || textBox2.Text.Contains('%') || textBox2.Text.Contains('&') || textBox2.Text.Contains('*') || textBox2.Text.Contains('(') || textBox2.Text.Contains(')') || textBox2.Text.Contains('[') || textBox2.Text.Contains(']'))
                        {
                            try        // создание таблицы в бд databace_site для хранения логин/пароль для авторизации на сайтах
                            {
                                SQL_func.Insert(textBox1.Text, textBox2.Text.ToString(), textBox3.Text.ToString(), textBox8.Text, textBox4.Text, textBox5.Text, select_cb_1, textBox6.Text.ToString(), select_cb_2, textBox7.Text.ToString());

                                connectDB.Open();
                                string sql_query = string.Format("CREATE TABLE {0}" + "(Name_site NVARCHAR(30)," + "URL_site NVARCHAR(30)," + "Login_site NVARCHAR(15)," + "Password_site VARBINARY (MAX)," + " Time_valid DATE)", textBox1.Text.ToString());
                                SqlCommand cmd = new SqlCommand(sql_query, connectDB);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Ваша учетная запись успешно создана, теперь вы можете войти в систему используя свой логин и пароль.", "Добро пожаловать!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (SqlException ex) { MessageBox.Show(ex.Message); }
                            finally { connectDB.Close();}
                        }
                        else { MessageBox.Show("Пароль должен содержать хотя бы один спец. символ!", "! @ # $ % & * ( ) [ ]", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    }
                    else { MessageBox.Show("Пароль должен быть длинее 4 символов!", "Ошибка пароля", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("Введенные пароли не совпадают!", "Ошибка паролей", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("Неизвестная ошибка #1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop); }       // подумать над этой ошибкой
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }
    }
}
