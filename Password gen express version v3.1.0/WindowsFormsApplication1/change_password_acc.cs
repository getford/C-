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
        public change_password_acc()
        {
            InitializeComponent();
        }

        private void textBox_old_password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_old_password_Click(object sender, EventArgs e)
        {
            
            textBox_old_password.Clear();
            textBox_old_password.PasswordChar = '*';
            textBox_new_password.Clear();
            textBox_new_password.PasswordChar = '*';
            textBox_re_new_password.Clear();
            textBox_re_new_password.PasswordChar = '*';


        }

        private void button_change_password_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DB\Database.mdf;Integrated Security=True");

            try
            {
                connect.Open();
                string st = "";
                Form1 f1 = this.Owner as Form1;
                if (f1 != null)
                {
                    st = f1.user_login_under_avatar.Text.ToString();
                }

                SqlCommand cmd_get_old_password = new SqlCommand(@"select user_password from [introduce] where user_login = '" + st.ToString() + "'", connect);

                SqlDataReader dr = cmd_get_old_password.ExecuteReader();
                while (dr.Read())
                {
                    if (st.ToString() != dr.GetString(0))
                    {
                        MessageBox.Show("OK");
                    }
                }
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
    }
}
