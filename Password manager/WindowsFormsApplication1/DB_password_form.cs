﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using System.Data.SqlClient;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Selenium;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class DB_password_form : Form
    {
        string count_passwords = string.Empty;          // тут будет лежать количество паролей

        public DB_password_form()
        {
            InitializeComponent();
            fill_ListView();
        }

        private void DB_password_form_Load(object sender, EventArgs e)
        {
            Form1 f1 = this.Owner as Form1;
            if (f1 != null)
            {
                textBox_user_login_now.Text = f1.textBox_user_login_under_avatar.Text.ToString();
                //textBox_password_site.Text = f1.textBox1.Text.ToString();                           // при открытии главной формы значение созданного пароля передается на добавление в бд
            }
            else { MessageBox.Show("Неизвестная ошибка #6", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            data();         // вызываем заполнение таблицы записями из бд (пароли скрыты по дефолту)

            label_status.ForeColor = Color.Gray;
        }

        public void show_password()
        {
            if(checkBox_show_password.Checked == true)
                data_plus();
            else
                data();
        }       // функция выбора показать пароль или не показать

        private void Initialize_List()
        {
            listView_site_login_password.GridLines = true;
            listView_site_login_password.AllowColumnReorder = true;
            listView_site_login_password.LabelEdit = true;
            listView_site_login_password.FullRowSelect = true;
            listView_site_login_password.View = View.Details; // стиль вывода в таблицу
        }       // инициализация listview

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
        }           // инициализация listview (колонки)

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

                /*Показываем пользователю количество паролей в его базе данных*/
                string sql_query_count = $"select count(*) Password_site from {textBox_user_login_now.Text.ToString()}";
                SqlCommand cmd_count = new SqlCommand(sql_query_count, connectDB);
                SqlDataReader dr = cmd_count.ExecuteReader();
                while (dr.Read())
                {
                    count_passwords = string.Empty;
                    count_passwords += dr["Password_site"];
                }
                label_status.Text = $"PassWord Manager - v{Application.ProductVersion.ToString()} © Vladimir Zhigalo BSTU Minsk 2016    _______________________________________________________________________    Количество паролей в базе: {count_passwords.ToString()}";
                dr.Close();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem(dt.Rows[i][0].ToString());
                    for(int j = 1; j < dt.Columns.Count; j++)
                    {
                        if (j == 3)          // в поле пароль, пишем "пароль зашифрован"
                        {
                            lvi.SubItems.Add("Пароль зашифрован");
                            continue;
                        }
                        else { }
                        lvi.SubItems.Add(dt.Rows[i][j].ToString());
                        /* Тут будем решать с датой*/
                        DateTime _date_last_change_password = DateTime.Parse((string)dt.Rows[i][4].ToString());     // тут будет дата из таблицы
                        DateTime _date_today = DateTime.Parse((string)DateTime.Today.ToString());                   // настоящая дата
                        if (_date_today >= _date_last_change_password)
                        {
                            lvi.ForeColor = Color.Red;              // красим строку талбицы в красный если пришла дата
                        }
                    }
                    listView_site_login_password.Items.Add(lvi);
                }
                da.Dispose();
                textBox_password_site.PasswordChar = '*';
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connectDB.Close(); }
        }       // ====================== пароли в таблице скрыты! ============================

        private void data_plus()
        {
            SqlConnection connectDB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database_site.mdf;Integrated Security=True");
            try
            {
                connectDB.Open();
                string sql_query = $"open symmetric key SYMMETRIC_KEY decryption by asymmetric key ASYMMETRIC_KEY with password = '()w(wovbomj@%veuoextufz)b)bmh'; select Name_site, URL_site, Login_site, CONVERT(nvarchar(50), DECRYPTBYKEY(Password_site)) as [Password_site], Time_valid from [dbo].[{textBox_user_login_now.Text.ToString()}]";
                SqlCommand cmd = new SqlCommand(sql_query, connectDB);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                listView_site_login_password.Clear();
                fill_ListView();

                /*Показываем пользователю количество паролей в его базе данных*/
                string sql_query_count = $"select count(*) Password_site from {textBox_user_login_now.Text.ToString()}";
                SqlCommand cmd_count = new SqlCommand(sql_query_count, connectDB);
                SqlDataReader dr = cmd_count.ExecuteReader();
                while (dr.Read())
                {
                    count_passwords = string.Empty;
                    count_passwords += dr["Password_site"];
                }
                label_status.Text = $"PassWord Manager - v{Application.ProductVersion.ToString()} © Vladimir Zhigalo BSTU Minsk 2016    _______________________________________________________________________    Количество паролей в базе: {count_passwords.ToString()}";
                dr.Close();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem(dt.Rows[i][0].ToString());
                    for (int j = 1; j < dt.Columns.Count; j++)
                    {
                        lvi.SubItems.Add(dt.Rows[i][j].ToString());
                        /* Тут будем решать с датой*/
                        DateTime _date_last_change_password = DateTime.Parse((string)dt.Rows[i][4].ToString());     // тут будет дата из таблицы
                        DateTime _date_today = DateTime.Parse((string)DateTime.Today.ToString());                   // настоящая дата
                        if (_date_today >= _date_last_change_password)
                        {
                            lvi.ForeColor = Color.Red;              // красим строку талбицы в красный если пришла дата
                        }
                    }
                    listView_site_login_password.Items.Add(lvi);
                }
                da.Dispose();
                textBox_password_site.PasswordChar = '\0';
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connectDB.Close(); }
        }   // ====================== пароли в таблице открыты! ============================

        private void button_register_Click(object sender, EventArgs e)
        {
            SqlConnection connectDB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database_site.mdf;Integrated Security=True");
            try
            {
                connectDB.Open();
                string sql_query_insert = $"open symmetric key SYMMETRIC_KEY decryption by asymmetric key ASYMMETRIC_KEY with password = '()w(wovbomj@%veuoextufz)b)bmh'; declare @Symmetric_key_GUID as [uniqueidentifier] set @Symmetric_key_GUID = KEY_GUID('SYMMETRIC_KEY') if (@Symmetric_key_GUID is not null) begin INSERT INTO {textBox_user_login_now.Text.ToString()} values (@Name_site, @URL_site, @Login_site, ENCRYPTBYKEY(@Symmetric_key_GUID, @Password_site), @Time_valid) end";
                SqlCommand cmd = new SqlCommand(sql_query_insert, connectDB);
                if (textBox_name_site.Text != "" || textBox_URL_site.Text != "" || textBox_login_site.Text != "" || textBox_password_site.Text != "")
                {
                    cmd.Parameters.AddWithValue(@"Name_site", textBox_name_site.Text.ToString());
                    cmd.Parameters.AddWithValue(@"URL_site", textBox_URL_site.Text.ToString());
                    cmd.Parameters.AddWithValue(@"Login_site", textBox_login_site.Text.ToString());
                    cmd.Parameters.AddWithValue(@"Password_site", textBox_password_site.Text.ToString());
                    cmd.Parameters.AddWithValue(@"Time_valid", dateTimePicker_valid_password.Value);
                    cmd.ExecuteNonQuery();
                    show_password();         // обновление таблицы
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
        }    // добавить запись в бд

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_name_site.Clear();
            textBox_URL_site.Clear();
            textBox_login_site.Clear();
            textBox_password_site.Clear();
            dateTimePicker_valid_password.Value = System.DateTime.Now;
        }       // очистка текстбоксов

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
                show_password();         // обновление таблицы
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { connectDB.Close(); }
        }     // уладение записи из бд

        private void listView_site_login_password_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_name_site.Text = listView_site_login_password.FocusedItem.SubItems[0].Text;
            textBox_URL_site.Text = listView_site_login_password.FocusedItem.SubItems[1].Text;
            textBox_login_site.Text = listView_site_login_password.FocusedItem.SubItems[2].Text;
            textBox_password_site.Text = listView_site_login_password.FocusedItem.SubItems[3].Text;
        }   // При нажитии на строку - данные строки в textbox

        private void checkBox_show_password_CheckedChanged(object sender, EventArgs e)
        {
            show_password();
        }       // показать/не показать пароль

        static ISelenium ise;
        private void button_authorization_site_Click(object sender, EventArgs e)
        {
     
            string _password = string.Empty;           // тут лежит расшифрованный пароль
            SqlConnection connectDB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database_site.mdf;Integrated Security=True");
            try
            {
                connectDB.Open();
                string sql_query = $"open symmetric key SYMMETRIC_KEY decryption by asymmetric key ASYMMETRIC_KEY with password = '()w(wovbomj@%veuoextufz)b)bmh'; select CONVERT(nvarchar(50), DECRYPTBYKEY(Password_site)) as [Password_site] from [dbo].[{textBox_user_login_now.Text.ToString()}] where URL_site = '{textBox_URL_site.Text.ToString()}'";
                SqlCommand cmd = new SqlCommand(sql_query, connectDB);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    _password += dr["Password_site"];
                }
                dr.Close();
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { connectDB.Close(); }
            /*для сайта mail.ru*/

            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(textBox_URL_site.Text.ToString());        // переходим на сайт
            driver.Manage().Window.Maximize();                                  // окно браузера на весь экран
            IWebElement login_input = driver.FindElement(By.Id("mailbox__login"));          // заполняем поле логин
            login_input.SendKeys(textBox_login_site.Text.ToString());
            IWebElement password_input = driver.FindElement(By.Id("mailbox__password"));    // заполняем поле пароля
            password_input.SendKeys(_password);
            IWebElement site_button_enter = driver.FindElement(By.Id("mailbox__auth__button"));     // нажатие на кнопку входа
            site_button_enter.Click();

        }       // обработка авторизации

        private void button_register_site_Click(object sender, EventArgs e)             // регистрация на сайте
        {
            string _site_title = string.Empty;          // будем записывать в название сайта
            string _site_URL = string.Empty;            // адрес сайта, потом в бд
            string _site_login = string.Empty;          // логин на сайте
            string _site_password = string.Empty;       // пароль сайта
            string _site_ = "https://twitter.com/";

            IWebDriver driver = new FirefoxDriver();
            ise = new WebDriverBackedSelenium(driver, _site_);
            ise.Start();                // запускаем драйвер
            ise.Open(_site_);           // переходим на сайт

            _site_URL = ise.GetLocation();      // получаем адрес сайта и помещаем в переменную
            _site_title = ise.GetTitle();       // получаем заголовок сайта и в переменную
            ise.Open("https://twitter.com/signup");         // откроет форму регистрации
            Thread.Sleep(15000);               // время на заполнение формы регистрации на сайте(15с)    1000 = 1секунда

            _site_login = ise.GetValue("full-name");
            _site_password = ise.GetValue("password");
            ise.Click("submit_button");  
            
            // кнопка авторизации открыть при релизе


            
            SqlConnection connectDB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database_site.mdf;Integrated Security=True");
            try
            {
                connectDB.Open();
                string sql_query = $"open symmetric key SYMMETRIC_KEY decryption by asymmetric key ASYMMETRIC_KEY with password = '()w(wovbomj@%veuoextufz)b)bmh'; declare @Symmetric_key_GUID as [uniqueidentifier] set @Symmetric_key_GUID = KEY_GUID('SYMMETRIC_KEY') if (@Symmetric_key_GUID is not null) begin INSERT INTO {textBox_user_login_now.Text.ToString()} values (@Name_site, @URL_site, @Login_site, ENCRYPTBYKEY(@Symmetric_key_GUID, @Password_site), @Time_valid) end";
                SqlCommand cmd = new SqlCommand(sql_query, connectDB);
                cmd.Parameters.AddWithValue(@"Name_site", _site_title.ToString());
                cmd.Parameters.AddWithValue(@"URL_site", _site_URL.ToString());
                cmd.Parameters.AddWithValue(@"Login_site", _site_login.ToString());
                cmd.Parameters.AddWithValue(@"Password_site", _site_password.ToString());
                cmd.Parameters.AddWithValue(@"Time_valid", dateTimePicker_valid_password.Value.AddDays(15));
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Ваши сведения о регистрации с сайта {_site_URL.ToString()} успешно добавлены в базу.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                show_password();         // обновление таблицы
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { connectDB.Close(); }
        }
    }
}


///*первый вариант*/
///ise = new WebDriverBackedSelenium(driver, "http://mail.ru/");
//ise.Start();                // запуск selenium
//ise.Open("http://mail.ru/");            // говорим какой сайт открыть
//ise.WindowMaximize();       // разворачиваем браузер на фул экран
///*заполняем поля и клацаем на кнопку войти*/
//ise.Type("mailbox__login", textBox_login_site.Text.ToString());
//ise.Type("mailbox__password", _password);
//ise.Click("mailbox__auth__button");

/*запасной вариант авторизации*/


//string res = $"Title: {_site_title}\nURL:{_site_URL}\nName: {_site_login}\nPassword: {_site_password}";
//MessageBox.Show(res, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
//string _site = $"http://mail.ru/";         // тут лежит адрес сайта  


      