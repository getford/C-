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
    public partial class change_email_acc : Form
    {
        string string_user_login = string.Empty;        // тут лежит логин пользователя после загрузки формы

        public change_email_acc()
        {
            InitializeComponent();
        }

        private void change_email_acc_Load(object sender, EventArgs e)
        {
            account acc = this.Owner as account;
            if (acc != null)
            {
                string_user_login = acc.textBox_login.Text.ToString();
            }
            else { MessageBox.Show("Неизвестная ошибка #3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button_change_email_Click(object sender, EventArgs e)
        {
            SqlConnection connectDB = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database.mdf;Integrated Security=True");

            try
            {
                connectDB.Open();
                string sql_query_email_change = string.Format(@"update introduce set user_e_mail = '" + textBox_new_email.Text.ToString() + "' where user_login = '" + string_user_login + "'");
                SqlCommand cmd = new SqlCommand(sql_query_email_change, connectDB);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ваш email успешно изменен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(SqlException ex) { MessageBox.Show(ex.Message); }
            finally { connectDB.Close(); }

        }

        private void OnClick_Help_Button(object sender, CancelEventArgs e)
        {
            MessageBox.Show("   Воспользуйтесь этой формой если вы хотите изменить e-mail. \n   Впишите желаемый e-mail в поле и нажмите кнопку 'Внести \n   изменения' ", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
