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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet1.introduce". При необходимости она может быть перемещена или удалена.
            this.introduceTableAdapter1.Fill(this.databaseDataSet1.introduce);
            SQL_func.select(this.dataGridView2);    // password

            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.introduce". При необходимости она может быть перемещена или удалена.
            this.introduceTableAdapter.Fill(this.databaseDataSet.introduce);
            SQL_func.select(this.dataGridView1);    // login
        }

        private void button1_Click(object sender, EventArgs e)              // log in
        {

            for(int i = 0; i < dataGridView1.Columns.Count && i < dataGridView2.Columns.Count; i++)    // столбцы
            {
                for(int j = 0; j < dataGridView1.Rows.Count && j < dataGridView2.Rows.Count; j++)   // строки
                {
                    if(dataGridView1[i, j].Value.ToString() == textBox1.Text.ToString() && dataGridView2[i, j].Value.ToString() == textBox2.Text.ToString())
                    {
                            Form1 f1_main = new Form1();
                            f1_main.Show();
                            Hide();
                    }
                    //if(dataGridView1[i, j].Value.ToString() != textBox1.Text.ToString() && dataGridView2[i, j].Value.ToString() != textBox2.Text.ToString())
                    //{
                    //    MessageBox.Show("Error");
                    //}
                }
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
            System.Environment.Exit(0);
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
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
