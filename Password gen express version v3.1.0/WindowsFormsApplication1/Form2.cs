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

        private void button3_Click(object sender, EventArgs e)              // X button
        {
            if(button3.Enabled == true)
            {
                textBox1.Clear();
                textBox2.Clear();
            }

        }

        private void button1_Click(object sender, EventArgs e)              // log in
        {
            StreamReader login_file_reader = new StreamReader(System.Environment.UserName + "_login.txt");
            StreamReader password_file_reader = new StreamReader(System.Environment.UserName + "_password.txt");

            string l = "";
            string p = "";
            while (!login_file_reader.EndOfStream && !password_file_reader.EndOfStream)
            {
                l += login_file_reader.ReadLine();
                p += password_file_reader.ReadLine();
            }


            if (textBox1.Text == l && textBox2.Text == p)
            {
                Form1 f1 = new Form1();
                f1.Show();
                Hide();
            }
            else
                MessageBox.Show("Не верный логин или пароль!");

        }

        private void button2_Click(object sender, EventArgs e)              // sign in
        {
            StreamWriter login_file;
            FileInfo login_f = new FileInfo(System.Environment.UserName + "_login.txt");
            login_file = login_f.AppendText();
            login_file.WriteLine(textBox1.Text);
            login_file.Close();

            StreamWriter password_file;
            FileInfo password_f = new FileInfo(System.Environment.UserName + "_password.txt");
            password_file = password_f.AppendText();
            password_file.WriteLine(textBox2.Text);
            password_file.Close();
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
    }
}