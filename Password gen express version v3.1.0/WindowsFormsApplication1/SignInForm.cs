using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{

    public partial class SignInForm : Form
    {

        public SignInForm()
        {
            InitializeComponent();

            DataSet ds = new DataSet();

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

        private void male_pol_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void female_pol_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)      // кнопка регистрации
        {
            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\MAIN_DB.mdf;Integrated Security=True;Connect Timeout=30";

                cn.Open();
                //MessageBox.Show("its ok");

                SqlCommand cmdd = new SqlCommand("insert into introduce values ('" + Convert.ToString(textBox1.Text) + "')", cn);
                cmdd.ExecuteNonQuery();
                cn.Close();

                try
                {

                    
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }


                cn.Close();
            }
        }

    }
}
