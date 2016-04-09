using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class SQL_query_form_restore_password : Form_Restore_Password
    {
        static public SqlConnection connectDB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database.mdf;Integrated Security=True");


        public static string Query_first_question(string _login, string s)
        {
            try
            {
                connectDB.Open();
                /*Выводим секретные вопросы в текстбоксы по вводу логина*/
                string sql_query_first_question = @"select user_first_question from introduce where user_login = '" + _login + "'";
                SqlCommand cmd_f_q = new SqlCommand(sql_query_first_question, connectDB);
                SqlDataReader dr_f_q = cmd_f_q.ExecuteReader();
                string first_question = string.Empty;       // передаем пустую строку
                while (dr_f_q.Read())
                {
                    first_question += dr_f_q["user_first_question"];
                    
                }
                dr_f_q.Close();
                s = (string)first_question.ToString();

            }
            catch (SqlException ex) { ex.ToString(); }
            finally { connectDB.Close(); }

            return s;
        }
    }
}
