using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class SQL_func
    {
        static public SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database.mdf;Integrated Security=True");

        /*запрос для регистрации*/
        public static void select(DataGridView dgv)
        {
            try
            {
                connect.Open();
                SqlDataAdapter command_data_adapter = new SqlDataAdapter(@"SELECT user_login, user_password, user_e_mail FROM [introduce]", connect);
                DataTable dt = new DataTable();
                command_data_adapter.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        public static void Insert(string _userlogin, string _userpassword, string _reuserpassword, string _useremail, string _userfirstname, string _userlastname, string _userfirstqst, string _userfirstansw, string _usersecoundqsr, string _usersecoungansw)
        {
            try
            {
                connect.Open();
                SqlCommand commandInsert = new SqlCommand("INSERT INTO [introduce] VALUES (@user_login, @user_password, @user_re_password, @user_e_mail, @user_first_name, @user_last_name, @user_first_question, @user_first_answer, @user_secound_question, @user_secound_answer)", connect);
                commandInsert.Parameters.AddWithValue(@"user_login", _userlogin);
                commandInsert.Parameters.AddWithValue(@"user_password", _userpassword);
                commandInsert.Parameters.AddWithValue(@"user_re_password", _reuserpassword);
                commandInsert.Parameters.AddWithValue(@"user_e_mail", _useremail);
                commandInsert.Parameters.AddWithValue(@"user_first_name", _userfirstname);
                commandInsert.Parameters.AddWithValue(@"user_last_name", _userlastname);
                commandInsert.Parameters.AddWithValue(@"user_first_question", _userfirstqst);
                commandInsert.Parameters.AddWithValue(@"user_first_answer", _userfirstansw);
                commandInsert.Parameters.AddWithValue(@"user_secound_question", _usersecoundqsr);
                commandInsert.Parameters.AddWithValue(@"user_secound_answer", _usersecoungansw);
                commandInsert.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connect.Close();
            }
        }
    }
}
