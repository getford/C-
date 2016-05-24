using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class account_more_info : Form
    {
        System.Diagnostics.Stopwatch t = new System.Diagnostics.Stopwatch();
        public account_more_info()
        {
            InitializeComponent();

            timer.Interval = 2000;      // 
            timer.Start();              // стартуем
            t.Start();                  // стартует проверка точности
            timer.Tick += new EventHandler(timer_Tick);
            progressBar_timer.Maximum = 30;         // 30 секунд
        }

        private void account_more_info_Load(object sender, EventArgs e)
        {
            Confirm_the_password ctp = this.Owner as Confirm_the_password;
            if (ctp != null)
                this.textBox_login.Text = ctp.acc_login;
            else { MessageBox.Show("Неопределенная ошибка #4", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            SqlConnection connectDB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database.mdf;Integrated Security=True");
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database_site.mdf;Integrated Security=True");

            /*Имя*/
            try
            {
                connectDB.Open();
                string sql_query_f_n = @"select user_first_name from introduce where user_login = '" + ctp.acc_login.ToString() + "'";
                SqlCommand cmd_f_n = new SqlCommand(sql_query_f_n, connectDB);
                SqlDataReader dr = cmd_f_n.ExecuteReader();
                while (dr.Read())
                {
                    textBox_first_name.Text += dr["user_first_name"];
                }
                dr.Close();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connectDB.Close(); }
            /*фамилия*/
            try
            {
                connectDB.Open();
                string sql_query_l_n = @"select user_last_name from introduce where user_login = '" + ctp.acc_login.ToString() + "'";
                SqlCommand cmd_l_n = new SqlCommand(sql_query_l_n, connectDB);
                SqlDataReader dr = cmd_l_n.ExecuteReader();
                while (dr.Read())
                {
                    textBox_last_name.Text += dr["user_last_name"];
                }
                dr.Close();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connectDB.Close(); }
            /*e-mail*/
            try
            {
                connectDB.Open();
                string sql_query_email = @"select user_e_mail from introduce where user_login = '" + ctp.acc_login.ToString() + "'";
                SqlCommand cmd_u_email = new SqlCommand(sql_query_email, connectDB);
                SqlDataReader dr = cmd_u_email.ExecuteReader();
                while (dr.Read())
                {
                    textBox_email.Text += dr["user_e_mail"];
                }
                dr.Close();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connectDB.Close(); }
            /*Первый секретный вопрос*/
            try
            {
                connectDB.Open();
                string sql_query_f_q = @"select user_first_question from introduce where user_login = '" + ctp.acc_login.ToString() + "'";
                SqlCommand cmd_u_f_q = new SqlCommand(sql_query_f_q, connectDB);
                SqlDataReader dr = cmd_u_f_q.ExecuteReader();
                while (dr.Read())
                {
                    textBox_first_question.Text += dr["user_first_question"];
                }
                dr.Close();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connectDB.Close(); }
            /*Второй секретный вопрос*/
            try
            {
                connectDB.Open();
                string sql_query_s_q = @"select user_secound_question from introduce where user_login = '" + ctp.acc_login.ToString() + "'";
                SqlCommand cmd_u_s_q = new SqlCommand(sql_query_s_q, connectDB);
                SqlDataReader dr = cmd_u_s_q.ExecuteReader();
                while (dr.Read())
                {
                    textBox_secound_question.Text += dr["user_secound_question"];
                }
                dr.Close();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connectDB.Close(); }
            /*Первый секретный ответ*/
            try
            {
                connectDB.Open();
                string sql_query_first_answer = @"open symmetric key SYMMETRIC_KEY decryption by asymmetric key ASYMMETRIC_KEY with password = '%(wbwgoo$'; 
                    select CONVERT(nvarchar(50), DECRYPTBYKEY(user_first_answer)) as [user_first_answer] from [dbo].[introduce] where user_login = '" + ctp.acc_login.ToString() + "'";
                SqlCommand cmd_f_a = new SqlCommand(sql_query_first_answer, connectDB);
                SqlDataReader dr_f_a = cmd_f_a.ExecuteReader();
                while (dr_f_a.Read())
                {
                    textBox_first_answer.Text += dr_f_a["user_first_answer"];
                }
                dr_f_a.Close();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connectDB.Close(); }
            /*Второй секретный ответ*/
            try
            {
                connectDB.Open();
                string sql_query_secound_answer = @"open symmetric key SYMMETRIC_KEY decryption by asymmetric key ASYMMETRIC_KEY with password = '%(wbwgoo$'; 
                    select CONVERT(nvarchar(50), DECRYPTBYKEY(user_secound_answer)) as [user_secound_answer] from [dbo].[introduce] where user_login = '" + ctp.acc_login.ToString() + "'";
                SqlCommand cmd_s_a = new SqlCommand(sql_query_secound_answer, connectDB);
                SqlDataReader dr_s_a = cmd_s_a.ExecuteReader();
                while (dr_s_a.Read())
                {
                    textBox_secound_answer.Text += dr_s_a["user_secound_answer"];
                }
                dr_s_a.Close();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connectDB.Close(); }

            /*Показываем пользователю количество паролей в его базе данных*/
            try
            {
                connect.Open();
                string count_passwords = string.Empty;
                string sql_query_count = $"select count(*) Password_site from {ctp.acc_login.ToString()}";
                SqlCommand cmd_count = new SqlCommand(sql_query_count, connect);
                SqlDataReader dr = cmd_count.ExecuteReader();
                while (dr.Read())
                {
                    count_passwords = string.Empty;
                    count_passwords += dr["Password_site"];
                }
                label_count_passwords.ForeColor = Color.Green;
                label_count_passwords.Text = "Количество паролей в базе: " + count_passwords.ToString();
                dr.Close();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connect.Close(); }
        }

        private void linkLabel_delete_account_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить аккаунт?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection connectDB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database.mdf;Integrated Security=True");
                SqlConnection connectDB_site = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database_site.mdf;Integrated Security=True");

                try             // удаляем таблицу паролей
                {
                    connectDB_site.Open();
                    string sql_query_del = string.Format("drop table {0}", this.textBox_login.Text.ToString());
                    SqlCommand cmd = new SqlCommand(sql_query_del, connectDB_site);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex) { MessageBox.Show(ex.Message); }
                finally { connectDB_site.Close(); }

                try             // удаляем аккаунт
                {
                    connectDB.Open();
                    string sql_query_del = string.Format("delete from introduce where user_login = '" + this.textBox_login.Text.ToString() + "'");
                    SqlCommand cmd = new SqlCommand(sql_query_del, connectDB);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ваш аккаунт успешно удален из базы данных.\nПерезапустите приложение.", "Удаление прошло успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                catch (SqlException ex) { MessageBox.Show(ex.Message); }
                finally { connectDB.Close(); }
            }
            else { /*Тут что-то должно быть, а может и не должно :)*/}
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            progressBar_timer.Increment(1);
            if(progressBar_timer.Value == progressBar_timer.Maximum)
            {
                t.Stop();
                timer.Stop();
                this.Close();
            }
        }

        private void account_more_info_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Информация о пользователе, который авторизовался в проложении\nНа данной форме содержаться секретные ответы для восстановления доступа к вашему аккаунту, пожалуйста, не показывайте их никому!", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
