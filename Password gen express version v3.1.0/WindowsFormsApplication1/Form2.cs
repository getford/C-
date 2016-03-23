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
//using System.Data.Common;
//using System.Data.Odbc;
//using System.Data.SqlTypes;

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

        private void button3_Click(object sender, EventArgs e)              // проверка соединения button
        {
            // проверка, подключена ли бд

            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\MAIN_DB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand();

            try
            {
                cn.Open();
                MessageBox.Show("Connected ok!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error", ex.Message);
                return;
            }

        }

        private void button1_Click(object sender, EventArgs e)              // log in
        {
            //string l = "admin";
            //string p = "admin";
            //if (textBox1.Text == l && textBox2.Text == p)
            //{
            Form1 f1_main = new Form1();
            f1_main.Show();
            Hide();
            //}



        }

        private void button2_Click(object sender, EventArgs e)              // sign in
        {
            if(button2.Enabled == true)
            {
                SignInForm sgn_form = new SignInForm();
                sgn_form.Show();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
