using System;
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

        string first_answer = string.Empty;         // сюда запишем секретный ответ 1
        string secound_answer = string.Empty;       // сюда запишем секретный ответ 2
        string user_password = string.Empty;        // сюда запишем пароль пользователя

        private void button_restore_Click(object sender, EventArgs e)
        {
            // проверяем корректность введенных данных

            if (textBox_first_a.Text.ToString() == first_answer.ToString() && textBox_secound_a.Text.ToString() == secound_answer.ToString())
            {
                MessageBox.Show("Ваш пароль: " + user_password.ToString(), "Пароль", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Проверьте введенные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_first_a.Clear();
                textBox_secound_a.Clear();
            }
        }
        /* нажмите на фон окошка. Если логин существет, вам будет предложены секретные вопросы, если вопросы не появились проверьте логин*/
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SqlConnection connectDB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database.mdf;Integrated Security=True");

            ///////////////// Получаем первый серетный вопрос ////////////////////////////
            try
            {
                connectDB.Open();
                /*Выводим секретные вопросы в текстбоксы по вводу логина*/
                string sql_query_first_question = @"select user_first_question from introduce where user_login = '" + textBox_login_email.Text.ToString() + "'";
                SqlCommand cmd_f_q = new SqlCommand(sql_query_first_question, connectDB);
                SqlDataReader dr_f_q = cmd_f_q.ExecuteReader();
                string first_question = string.Empty;       // передаем пустую строку
                while (dr_f_q.Read())
                {
                    first_question += dr_f_q["user_first_question"];
                }
                dr_f_q.Close();
                textBox_first_q.Text = (string)first_question.ToString();

            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connectDB.Close(); }

            ///////////////////// Получаем второй секретный вопрос ////////////////////////////

            try
            {
                connectDB.Open();
                string sql_query_secound_question = @"select user_secound_question from introduce where user_login = '" + textBox_login_email.Text.ToString() + "'";
                SqlCommand cmd_s_q = new SqlCommand(sql_query_secound_question, connectDB);
                SqlDataReader dr_s_q = cmd_s_q.ExecuteReader();
                string secound_question = string.Empty;
                while (dr_s_q.Read())
                {
                    secound_question += dr_s_q["user_secound_question"];
                }
                dr_s_q.Close();
                textBox_secound_q.Text = (string)secound_question.ToString();

            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connectDB.Close(); }

            //////////////////////////////// Получаем первый ответ  ////////////////////////////

            try
            {
                connectDB.Open();
                string sql_query_first_answer = @"open symmetric key SYMMETRIC_KEY decryption by asymmetric key ASYMMETRIC_KEY with password = '%(wbwgoo$'; select CONVERT(nvarchar(50), DECRYPTBYKEY(user_first_answer)) as [user_first_answer] from [dbo].[introduce] where user_login = '" + textBox_login_email.Text.ToString() + "'";
                SqlCommand cmd_f_a = new SqlCommand(sql_query_first_answer, connectDB);
                SqlDataReader dr_f_a = cmd_f_a.ExecuteReader();
                while (dr_f_a.Read())
                {
                    first_answer += dr_f_a["user_first_answer"];
                }
                dr_f_a.Close();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connectDB.Close(); }

            // получаем второй секретный ответ 

            try
            {
                connectDB.Open();
                string sql_query_secound_answer = @"open symmetric key SYMMETRIC_KEY decryption by asymmetric key ASYMMETRIC_KEY with password = '%(wbwgoo$'; select CONVERT(nvarchar(50), DECRYPTBYKEY(user_secound_answer)) as [user_secound_answer] from [dbo].[introduce] where user_login = '" + textBox_login_email.Text.ToString() + "'";
                SqlCommand cmd_s_a = new SqlCommand(sql_query_secound_answer, connectDB);
                SqlDataReader dr_s_a = cmd_s_a.ExecuteReader();
                while (dr_s_a.Read())
                {
                    secound_answer += dr_s_a["user_secound_answer"];
                }
                dr_s_a.Close();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connectDB.Close(); }

            // получаем пароль из бд

            try
            {
                connectDB.Open();
                string sql_query_user_password = @"open symmetric key SYMMETRIC_KEY decryption by asymmetric key ASYMMETRIC_KEY with password = '%(wbwgoo$'; select CONVERT(nvarchar(50), DECRYPTBYKEY(user_password)) as [user_password] from [dbo].[introduce] where user_login = '" + textBox_login_email.Text.ToString() + "'";
                SqlCommand cmd_u_p = new SqlCommand(sql_query_user_password, connectDB);
                SqlDataReader dr_u_p = cmd_u_p.ExecuteReader();
                while (dr_u_p.Read())
                {
                    user_password += dr_u_p["user_password"];
                }
                dr_u_p.Close();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connectDB.Close(); }
        } 

        private void timer_Tick(object sender, EventArgs e)
        {

        }
    }
}


