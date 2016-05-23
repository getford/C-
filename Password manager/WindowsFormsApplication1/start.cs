using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void start_Load(object sender, EventArgs e)
        {
            timer.Interval = 1500;
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;

            Form2 fm2 = new Form2();
            fm2.Show();
            this.Hide();
        }
    }
}