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
    public partial class change_password_acc : Form
    {
        string string_old_password = string.Empty;      // сюда положим старый пароль
        string string_user_login = string.Empty;        // тут лежит логин пользователя который зашел в систему

        public change_password_acc()
        {
            InitializeComponent();
        }

        private void change_password_acc_Load(object sender, EventArgs e)
        {
            account acc = this.Owner as account;
            if (acc != null)
            {
                string_user_login = acc.textBox_login.Text.ToString();
            }
            else { MessageBox.Show("Неизвестная ошибка #2", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button_change_password_Click(object sender, EventArgs e)
        {
            SqlConnection connectDB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database.mdf;Integrated Security=True");

            try
            {
                connectDB.Open();
                string sql_query_old_password = string.Format(@"select user_password from introduce where user_login = '" + string_user_login + "'");
                SqlCommand cmd = new SqlCommand(sql_query_old_password, connectDB);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string_old_password += dr["user_password"];
                }
                dr.Close();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connectDB.Close(); }

            if (textBox_old_password.Text.ToString() == string_old_password.ToString())
            {
                if (textBox_new_password.Text.Contains('!') || textBox_new_password.Text.Contains('@') || textBox_new_password.Text.Contains('#') || textBox_new_password.Text.Contains('$') || textBox_new_password.Text.Contains('%') || textBox_new_password.Text.Contains('&') || textBox_new_password.Text.Contains('*') || textBox_new_password.Text.Contains('(') || textBox_new_password.Text.Contains(')') || textBox_new_password.Text.Contains('[') || textBox_new_password.Text.Contains(']'))
                {
                    if (textBox_new_password.Text.ToString() == textBox_re_new_password.Text.ToString())
                    {
                        try
                        {
                            connectDB.Open();
                            string sql_query_password_change = string.Format(@"update introduce set user_password = '" + textBox_new_password.Text.ToString() + "', user_re_password = '" + textBox_re_new_password.Text.ToString() + "' where user_login = '" + string_user_login.ToString() + "'");
                            SqlCommand cmd = new SqlCommand(sql_query_password_change, connectDB);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Смена пароля прошла успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (SqlException ex) { MessageBox.Show(ex.Message); }
                        finally { connectDB.Close(); }
                    }
                    else { MessageBox.Show("Введенные пароли не совпадают. Попробуйте снова.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("Ваш пароль должен содержать хотя бы один специальный символ @ # $ % ^ & * ( ) ( ) [ ]", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("Не верный старый пароль. Попробуйте снова.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            /*Изменение пароля дописать*/
        }


    }
}

/*
            
            textBox_old_password.Clear();
            textBox_old_password.PasswordChar = '*';
            textBox_new_password.Clear();
            textBox_new_password.PasswordChar = '*';
            textBox_re_new_password.Clear();
            textBox_re_new_password.PasswordChar = '*';
*/
