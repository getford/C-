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

//using System.Data.SqlClient;
//using System.Data.Sql;
//using System.Data.Common;
//using System.Data.Odbc;
//using System.Data.SqlTypes;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB_app.mdf;Integrated Security=True";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)              // X button
        {
            // проверка, подключена ли бд

            OleDbConnection connectDB = new OleDbConnection(connStr);

            try
            {
                connectDB.Open();
            }
            catch (OleDbException se)
            {
                MessageBox.Show("Ошибка подключения к БД", se.Message);
                return;
            }

            MessageBox.Show("Соединение с БД установленно!");

        }

        private void button1_Click(object sender, EventArgs e)              // log in
        {
            //string l = "admin";
            //string p = "admin";
            //if(textBox1.Text == l && textBox2.Text == p)
            //{
            //    Form1 f1_main = new Form1();
            //    f1_main.Show();
            //    Hide();
            //}
            
            


            //OleDbConnection conn = new OleDbConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DB_app.mdf;Integrated Security=True");
            //OleDbCommand com = new OleDbCommand();
            //OleDbDataAdapter adap = new OleDbDataAdapter();
            //DataSet ds = new DataSet();
            //DataTable dt = new DataTable();

            //com.Connection = conn;
            //com.CommandText = "Select count (*) from login_table";
            //conn.Open();
            //adap.SelectCommand = com;
            //adap.Fill(ds);
            //dt = ds.Tables[0];
            //dataGridView1.DataSource = dt;

            //com.CommandText = "Insert into login_table (Login, Password) Values ('" + textBox1.Text + "', '" + textBox2.Text + "');";





            //SqlCommand sqlcmd = new SqlCommand("Insert into Login" + "(Login) Values (@Login)", connect);
            //SqlParameter sqlparm = new SqlParameter();
            //sqlparm.ParameterName = @"Login";
            //sqlparm.Value = "qwe";
            //sqlparm.SqlDbType = SqlDbType.NVarChar;
            //sqlcmd.Parameters.Add(sqlparm);


        }

        private void button2_Click(object sender, EventArgs e)              // sign in
        {

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

// log in
/*
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
    */

// sign in

/*
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

    */