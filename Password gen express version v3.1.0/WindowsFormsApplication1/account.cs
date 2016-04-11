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
                label_login.Text = f1.user_login_under_avatar.Text.ToString();
            }
        }

        private void label_login_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void OnClick(object sender, EventArgs e)    // смена пароля
        {
            change_password_acc cpa = new change_password_acc();
            cpa.Show();
        }
    }
}
