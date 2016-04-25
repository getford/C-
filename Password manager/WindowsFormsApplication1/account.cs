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
using System.Data.Sql;
namespace WindowsFormsApplication1
{
    public partial class account : Form
    {
        public account()
        {
            InitializeComponent();
        }

        private void account_Load(object sender, EventArgs e)
        {
            Form1 f1 = this.Owner as Form1;
            if (f1 != null)
            {
                textBox_login.Text = f1.textBox_user_login_under_avatar.Text.ToString();
            }

            SqlConnection connectDB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database.mdf;Integrated Security=True");

            try
            {
                connectDB.Open();
                string sql_query_f_n = @"select user_first_name from introduce where user_login = '" + f1.textBox_user_login_under_avatar.Text.ToString() + "'";
                SqlCommand cmd_f_n = new SqlCommand(sql_query_f_n, connectDB);
                SqlDataReader dr = cmd_f_n.ExecuteReader();
                while(dr.Read())
                {
                    textBox_first_name.Text += dr["user_first_name"];
                }
                dr.Close();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connectDB.Close(); }

            try
            {
                connectDB.Open();
                string sql_query_l_n = @"select user_last_name from introduce where user_login = '" + f1.textBox_user_login_under_avatar.Text.ToString() + "'";
                SqlCommand cmd_l_n = new SqlCommand(sql_query_l_n, connectDB);
                SqlDataReader dr = cmd_l_n.ExecuteReader();
                while(dr.Read())
                {
                    textBox_last_name.Text += dr["user_last_name"];
                }
                dr.Close();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connectDB.Close(); }

            try
            {
                connectDB.Open();
                string sql_query_email = @"select user_e_mail from introduce where user_login = '" + f1.textBox_user_login_under_avatar.Text.ToString() + "'";
                SqlCommand cmd_u_email = new SqlCommand(sql_query_email, connectDB);
                SqlDataReader dr = cmd_u_email.ExecuteReader();
                while(dr.Read())
                {
                    textBox_email.Text += dr["user_e_mail"];
                }
                dr.Close();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connectDB.Close(); }
        }

        private void OnClick(object sender, EventArgs e)    // смена пароля
        {
            change_password_acc cpa = new change_password_acc();
            cpa.Owner = this;
            cpa.Show();
        }

        private void OnClick_change_email(object sender, EventArgs e)   // смена email
        {
            change_email_acc cea = new change_email_acc();
            cea.Owner = this;
            cea.Show();
        }

        private void linkLabel_delete_account_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if(MessageBox.Show("Вы действительно хотите удалить аккаунт?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection connectDB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database.mdf;Integrated Security=True");
                SqlConnection connectDB_site = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database_site.mdf;Integrated Security=True");

                try             // удаляем таблицу паролей
                {
                    connectDB_site.Open();
                    string sql_query_del = string.Format("drop table {0}", textBox_login.Text.ToString());
                    SqlCommand cmd = new SqlCommand(sql_query_del, connectDB_site);
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex) { MessageBox.Show(ex.Message); }
                finally { connectDB_site.Close(); }

                try             // удаляем аккаунт
                {
                    connectDB.Open();
                    string sql_query_del = string.Format("delete from introduce where user_login = '" + textBox_login.Text.ToString() + "'");
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

        private void OnClick_help_button(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Информация о пользователе\nДля изменения пароля или электронной почты, нажмите на соответствующую надпись.", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void On_Click_more_info(object sender, EventArgs e)         // показать полную информацию об аккаунте
        {
            Confirm_the_password ctp = new Confirm_the_password();
            ctp.Owner = this;
            ctp.Show();
        }
    }
}
