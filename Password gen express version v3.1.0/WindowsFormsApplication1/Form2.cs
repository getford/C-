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
            //string l = "admin";
            //string p = "admin";
            //if (textBox1.Text == l && textBox2.Text == p)
            //{
            Form1 f1_main = new Form1();
            f1_main.Show();
            Hide();
            //}



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
    }
}
