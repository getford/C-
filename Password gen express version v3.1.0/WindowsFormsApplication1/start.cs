using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void start_Load(object sender, EventArgs e)
        {
            timer.Interval = 3000;
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;

            Form2 fm2 = new Form2();
            fm2.Show();
            Hide();


        }
    }
}