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
using System.Diagnostics;
using System.Windows.Input;

namespace WindowsFormsApplication1
{
    public partial class DB_password_form : Form
    {
        public DB_password_form()
        {
            InitializeComponent();
            fill_ListView();
        }

        private void DB_password_form_Load(object sender, EventArgs e)
        {
            Form1 f1 = this.Owner as Form1;
            if(f1 != null)
            {
                textBox_user_login_now.Text = f1.textBox_user_login_under_avatar.Text.ToString();
            }
            else
            {
                MessageBox.Show("Неизвестная ошибка #6", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            data();
        }

        private void Initialize_List()
        {
            listView_site_login_password.GridLines = true;
            listView_site_login_password.AllowColumnReorder = true;
            listView_site_login_password.LabelEdit = true;
            listView_site_login_password.FullRowSelect = true;
            listView_site_login_password.View = View.Details; // стиль вывода в таблицу
        }

        private void fill_ListView()
        {
            Initialize_List();
            try
            {
                listView_site_login_password.Columns.Add("Информация о сайте", listView_site_login_password.Width / 5);
                listView_site_login_password.Columns.Add("Адрес сайта", listView_site_login_password.Width / 5);
                listView_site_login_password.Columns.Add("Логин", listView_site_login_password.Width / 5);
                listView_site_login_password.Columns.Add("Пароль", listView_site_login_password.Width / 5);
                listView_site_login_password.Columns.Add("Дата валидности пароля", listView_site_login_password.Width / 5);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void data()
        {
            SqlConnection connectDB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database_site.mdf;Integrated Security=True");
            try
            {
                connectDB.Open();
                string sql_query = $"select * from {textBox_user_login_now.Text}";
                SqlCommand cmd = new SqlCommand(sql_query, connectDB);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                listView_site_login_password.Clear();
                fill_ListView();

                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem(dt.Rows[i][0].ToString());
                    for(int j = 1; j < dt.Columns.Count; j++)
                    {
                        if(j == 3)          // в поле пароль, пишем "пароль зашифрован"
                        {
                            lvi.SubItems.Add("Пароль зашифрован");
                            continue;
                        }
                        else { }
                        lvi.SubItems.Add(dt.Rows[i][j].ToString());
                        if (dt.Rows[i][4].ToString() == System.DateTime.Today.ToString())
                        {
                            lvi.ForeColor = Color.Red;
                        }
                    }
                    listView_site_login_password.Items.Add(lvi);
                }
                da.Dispose();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connectDB.Close(); }
        }


        //public void refresh_data()      // функция обновления датагрида... после того как внесли запись, обновиться грид
        //{
        //    SqlConnection connectDB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database_site.mdf;Integrated Security=True");
        //    try
        //    {
        //        connectDB.Open();
        //        string sql_query = string.Format("select * from {0}", textBox_user_login_now.Text);
        //        SqlCommand cmd = new SqlCommand(sql_query, connectDB);

        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        dataGridView1.DataSource = dt;

        //        //////////////////////////////////////////

        //        SqlDataReader dr = cmd.ExecuteReader();
        //        listView_site_login_password.Items.Clear();
        //        if (dr.HasRows)
        //        {
        //            listView_site_login_password.Items.Clear();
        //            listView_site_login_password.BeginUpdate();
        //            while (dr.Read())
        //            {
        //                listView_site_login_password.Items.Add(dr["Name_site"].ToString());
        //                listView_site_login_password.Items.Add(dr["URL_site"].ToString());
        //                listView_site_login_password.Items.Add(dr["Login_site"].ToString());
        //                listView_site_login_password.Items.Add("Пароль зашифрован");
        //                listView_site_login_password.Items.Add(dr["Time_valid"].ToString());
        //            }
        //            listView_site_login_password.EndUpdate();

        //        }
        //        dr.Close();


        //    }
        //    catch (SqlException ex) { MessageBox.Show(ex.Message); }
        //    finally { connectDB.Close(); }
        //}

        private void button_authorization_site_Click(object sender, EventArgs e)        // обработка авторизации
        {
            Process.Start("C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe", textBox_URL_site.Text.ToString());
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            SqlConnection connectDB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database_site.mdf;Integrated Security=True");

            try
            {
                connectDB.Open();
                string sql_query_insert = string.Format("open symmetric key SYMMETRIC_KEY decryption by asymmetric key ASYMMETRIC_KEY with password = '()w(wovbomj@%veuoextufz)b)bmh'; declare @Symmetric_key_GUID as [uniqueidentifier] set @Symmetric_key_GUID = KEY_GUID('SYMMETRIC_KEY') if (@Symmetric_key_GUID is not null) begin INSERT INTO {0} values (@Name_site, @URL_site, @Login_site, ENCRYPTBYKEY(@Symmetric_key_GUID, N'@Password_site'), @Time_valid) end", textBox_user_login_now.Text.ToString());

                SqlCommand cmd = new SqlCommand(sql_query_insert, connectDB);
                if (textBox_name_site.Text != "" || textBox_URL_site.Text != "" || textBox_login_site.Text != "" || textBox_password_site.Text != "")
                {
                    cmd.Parameters.AddWithValue(@"Name_site", textBox_name_site.Text.ToString());
                    cmd.Parameters.AddWithValue(@"URL_site", textBox_URL_site.Text.ToString());
                    cmd.Parameters.AddWithValue(@"Login_site", textBox_login_site.Text.ToString());
                    cmd.Parameters.AddWithValue(@"Password_site", textBox_password_site.Text.ToString());
                    cmd.Parameters.AddWithValue(@"Time_valid", dateTimePicker_valid_password.Value);
                    cmd.ExecuteNonQuery();
                    data();         // обновление таблицы
                                    // Очистим поля ввода
                    textBox_name_site.Clear();
                    textBox_URL_site.Clear();
                    textBox_login_site.Clear();
                    textBox_password_site.Clear();
                    dateTimePicker_valid_password.Value = System.DateTime.Now;
                }
                else { MessageBox.Show("Поля не могут быть пустыми!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connectDB.Close(); }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_name_site.Clear();
            textBox_URL_site.Clear();
            textBox_login_site.Clear();
            textBox_password_site.Clear();
            dateTimePicker_valid_password.Value = System.DateTime.Now;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            SqlConnection connectDB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database_site.mdf;Integrated Security=True");
            try
            {
                connectDB.Open();
                string sql_query = $"delete from {textBox_user_login_now.Text.ToString()} where URL_site = '{textBox_URL_site.Text}' and Name_site = '{textBox_name_site.Text}'";
                SqlCommand cmd = new SqlCommand(sql_query, connectDB);
                cmd.ExecuteNonQuery();
                        // Очистим поля удаления
                textBox_name_site.Clear();
                textBox_URL_site.Clear();
                textBox_login_site.Clear();
                textBox_password_site.Clear();
                dateTimePicker_valid_password.Value = System.DateTime.Now;
                data();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { connectDB.Close(); }
        }

        private void listView_site_login_password_SelectedIndexChanged(object sender, EventArgs e)
        {
            /** При нажитии на строку - данные строки в textbox*/
            textBox_name_site.Text = listView_site_login_password.FocusedItem.SubItems[0].Text;
            textBox_URL_site.Text = listView_site_login_password.FocusedItem.SubItems[1].Text;
            textBox_login_site.Text = listView_site_login_password.FocusedItem.SubItems[2].Text;
            textBox_password_site.Text = listView_site_login_password.FocusedItem.SubItems[3].Text;
        }

        private void ListView_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}