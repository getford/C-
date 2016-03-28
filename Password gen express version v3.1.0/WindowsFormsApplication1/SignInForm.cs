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
            string select_cb_1 = comboBox1.SelectedItem.ToString();
            string select_cb_2 = comboBox2.SelectedItem.ToString();

            if (textBox1.Text != "" && textBox2.Text.ToString() != "" && textBox3.Text.ToString() != "" && textBox8.Text != "" && textBox4.Text != "" && textBox5.Text != "" && select_cb_1 != "" && textBox6.Text != "" && select_cb_2 != "" && textBox7.Text.ToString() != "" )
            {
                if (textBox2.Text.ToString() == textBox3.Text.ToString())       // проверка совпадения паролей
                {
                    SQL_func.Insert(textBox1.Text, textBox2.Text.ToString(), textBox3.Text.ToString(), textBox8.Text, textBox4.Text, textBox5.Text, select_cb_1, textBox6.Text.ToString(), select_cb_2, textBox7.Text.ToString());
                }
                else
                    MessageBox.Show("Введенные пароли не совпадают!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }
    }
}
