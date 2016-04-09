using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form_Restore_Password : Form
    {
        public Form_Restore_Password()
        {
            InitializeComponent();
        }

        private void Form_Restore_Password_Load(object sender, EventArgs e)
        {
            
        }

        

        private void button_restore_Click(object sender, EventArgs e)
        {
            string s = string.Empty;
            SQL_query_form_restore_password.Query_first_question(textBox_login_email.Text, s);
            textBox_first_q.Text = s.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}


/*
                //*********************************************************************************************
                string sql_query_secound_question = @"select user_secound_question from introduce where user_login = '" + textBox_login_email.Text.ToString() + "'";
                SqlCommand cmd_s_q = new SqlCommand(sql_query_secound_question, connectDB);
                SqlDataReader dr_s_q = cmd_s_q.ExecuteReader();
                string secound_question = string.Empty;
                while (dr_s_q.Read())
                {
                    secound_question += dr_s_q["user_secound_question"];
                }
                dr_s_q.Close();
                textBox_secound_q.Text = secound_question;

            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connectDB.Close(); }
*/

