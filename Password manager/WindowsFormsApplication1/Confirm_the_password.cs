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
    public partial class Confirm_the_password : Form
    {
        public string acc_login = string.Empty;

        public Confirm_the_password()
        {
            InitializeComponent();
        }

        private void Confirm_the_password_Load(object sender, EventArgs e)
        {
            account acc = this.Owner as account;
            if(acc != null)
                acc_login =  acc.textBox_login.Text.ToString();
        }

        private void button_confirm_password_Click(object sender, EventArgs e)
        {
            SqlConnection connectDB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database.mdf;Integrated Security=True");
            string password_ = string.Empty;

            try
            {
                connectDB.Open();
                string sql_query_select_password = string.Format(@"open symmetric key SYMMETRIC_KEY decryption by asymmetric key ASYMMETRIC_KEY with password = '%(wbwgoo$'; select CONVERT(nvarchar(50), DECRYPTBYKEY(user_password)) as [user_password] from[dbo].[introduce] where user_login = '" + acc_login.ToString() + "'");
                SqlCommand cmd = new SqlCommand(sql_query_select_password, connectDB);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    password_ += dr["user_password"];
                }
                dr.Close();

                if (this.textBox_confirm_password.Text.ToString() == password_)
                {
                    account_more_info ami = new account_more_info();
                    ami.Owner = this;
                    ami.Show();
                    this.Hide();
                }
                else { MessageBox.Show("Введен не верный пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { connectDB.Close(); }
        }

        private void KeyDown_click(object sender, KeyEventArgs e)   // Обработка нажитий кнопок
        {
            if(e.KeyCode == Keys.Enter) { button_confirm_password_Click(sender, e); }
        }
    }
}
