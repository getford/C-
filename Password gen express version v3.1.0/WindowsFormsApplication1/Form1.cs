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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == null)
                Close();
            else
            {
                SaveFileDialog save_password = new SaveFileDialog();

                save_password.FileName = Environment.UserName + "_password.txt";
                if (save_password.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamWriter wr = new System.IO.StreamWriter(save_password.FileName);
                    wr.Write(System.DateTimeOffset.Now + " UTC" + Environment.NewLine + Environment.NewLine);
                    wr.Write("User: " + Environment.UserName + Environment.NewLine + Environment.NewLine);
                    wr.Write(textBox2.Text);
                    wr.Close();
                }
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версия приложения: v3.3.3");
        }   // версия приложенния
        private void историяОбновленийToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show(
                $"История обновлений:\n\nv1.0.0 - Создано окно (09.02.2016)\nv1.0.1 - Добавлена панель меню (файл, настройки, о приложении)\nv1.0.2 - Генерация цифрового пароля по кнопке Generation\nv1.0.3 - Добавлена генерация пароля цифро-буквенного с выводом в окошко\nv2.0.0 - Генерация паролей c кракозябрами\nv2.1.0 - Добавлена кнопка copy и clear\nv3.0.0 - Весь базовый функционал\nv3.1.0 - Добавлена иконка приложения(а также в трее). Добавлены цифры\nv3.2.0 - Подсветка пароля цветом (зависит от сложности)\nv3.3.2 - Добавлена возможность выводы сгенерированных паролей в файл\nv3.3.3 - Исправленые мелкие баги");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)       // поле вывода пароля
        {
            int N;
            N = (int)numericUpDown1.Value;

            if (N >= 4 && N < 6)
            {
                textBox1.BackColor = Color.Red;
            }
            if (N >= 6 && N < 8)
            {
                textBox1.BackColor = Color.Orange;
            }
            if (N >= 8 && N < 10)
            {
                textBox1.BackColor = Color.Olive;
            }
            if (N >= 10 && N <= 29)
            {
                textBox1.BackColor = Color.Green;
            }

        }

        public void button1_Click(object sender, EventArgs e)              // кнопка генерации
        {
            char s;
            int[] num = new int[18];
            char[] liter_full = new char[] { '!', '@', '#', '$', '%', '&', '(', ')', '[', ']', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] liter_m = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };   // 26
            char[] liter_b = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };   // 26
            char[] liter_c = new char[] { '!', '@', '#', '$', '%', '&', '(', ')', '[', ']' };   // 10
            char[] liter_m_b = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };   // 52
            char[] liter_m_c = new char[] { '!', '@', '#', '$', '%', '&', '(', ')', '[', ']', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };   // 26
            char[] liter_b_c = new char[] { '!', '@', '#', '$', '%', '&', '(', ')', '[', ']', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };   // 26
            char[] liter_n = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] liter_c_n = new char[] { '!', '@', '#', '$', '%', '&', '(', ')', '[', ']', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };   // 20
            char[] liter_m_n = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };   // 26
            char[] liter_b_n = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };   // 26
            char[] liter_m_b_c = new char[] { '!', '@', '#', '$', '%', '&', '(', ')', '[', ']', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };   // 52
            char[] liter_m_b_n = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };   // 52
            char[] liter_m_c_n = new char[] { '!', '@', '#', '$', '%', '&', '(', ')', '[', ']', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };   // 26
            char[] liter_b_c_n = new char[] { '!', '@', '#', '$', '%', '&', '(', ')', '[', ']', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };   // 26

            Random rnd = new Random();

            int N;
            N = (int)numericUpDown1.Value;

            if (checkBox2.Checked == true && checkBox1.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false)     // маленькие
            {
                textBox1.Text = ("Password: ");

                for (int i = 0; i < N; i++)
                {
                    s = liter_m[rnd.Next(26)];
                    textBox1.Text += (s);
                }
                textBox2.Text += textBox1.Text + Environment.NewLine;

            }
            if (checkBox2.Checked == false && checkBox1.Checked == true && checkBox3.Checked == false && checkBox4.Checked == false)    // большие
            {
                textBox1.Text = ("Password: ");

                for (int i = 0; i < N; i++)
                {
                    s = liter_b[rnd.Next(26)];
                    textBox1.Text += (s);
                }
                textBox2.Text += textBox1.Text + Environment.NewLine;
            }
            if (checkBox2.Checked == false && checkBox1.Checked == false && checkBox3.Checked == true && checkBox4.Checked == false)    // кракозябры
            {
                textBox1.Text = ("Password: ");

                for (int i = 0; i < N; i++)
                {
                    s = liter_c[rnd.Next(10)];
                    textBox1.Text += (s);
                }
                textBox2.Text += textBox1.Text + Environment.NewLine;
            }
            if (checkBox2.Checked == false && checkBox1.Checked == false && checkBox3.Checked == false && checkBox4.Checked == true)    // цифры
            {
                textBox1.Text = ("Password: ");

                for (int i = 0; i < N; i++)
                {
                    s = liter_n[rnd.Next(10)];
                    textBox1.Text += (s);
                }
                textBox2.Text += textBox1.Text + Environment.NewLine;
            }

            if (checkBox2.Checked == true && checkBox1.Checked == true && checkBox3.Checked == false && checkBox4.Checked == false)     // маленькие большие
            {
                textBox1.Text = ("Password: ");

                for (int i = 0; i < N; i++)
                {
                    s = liter_m_b[rnd.Next(52)];
                    textBox1.Text += (s);
                }
                textBox2.Text += textBox1.Text + Environment.NewLine;
            }

            if (checkBox2.Checked == true && checkBox1.Checked == false && checkBox3.Checked == true && checkBox4.Checked == false)     // малекние кракозябры
            {
                textBox1.Text = ("Password: ");

                for (int i = 0; i < N; i++)
                {
                    s = liter_m_c[rnd.Next(36)];
                    textBox1.Text += (s);
                }
                textBox2.Text += textBox1.Text + Environment.NewLine;
            }

            if (checkBox2.Checked == true && checkBox1.Checked == false && checkBox3.Checked == false && checkBox4.Checked == true)     // малекние цифры
            {
                textBox1.Text = ("Password: ");

                for (int i = 0; i < N; i++)
                {
                    s = liter_m_n[rnd.Next(36)];
                    textBox1.Text += (s);
                }
                textBox2.Text += textBox1.Text + Environment.NewLine;
            }
            if (checkBox2.Checked == false && checkBox1.Checked == true && checkBox3.Checked == false && checkBox4.Checked == true)     // большие цифры
            {
                textBox1.Text = ("Password: ");

                for (int i = 0; i < N; i++)
                {
                    s = liter_b_n[rnd.Next(36)];
                    textBox1.Text += (s);
                }
                textBox2.Text += textBox1.Text + Environment.NewLine;
            }
            if (checkBox2.Checked == false && checkBox1.Checked == true && checkBox3.Checked == true && checkBox4.Checked == false)     // большие кракозябры
            {
                textBox1.Text = ("Password: ");

                for (int i = 0; i < N; i++)
                {
                    s = liter_b_c[rnd.Next(36)];
                    textBox1.Text += (s);
                }
                textBox2.Text += textBox1.Text + Environment.NewLine;
            }
            if (checkBox2.Checked == true && checkBox1.Checked == true && checkBox3.Checked == true && checkBox4.Checked == false)     // маленькие большие кракозябры
            {
                textBox1.Text = ("Password: ");

                for (int i = 0; i < N; i++)
                {
                    s = liter_m_b_c[rnd.Next(56)];
                    textBox1.Text += (s);
                }
                textBox2.Text += textBox1.Text + Environment.NewLine;
            }
            if (checkBox2.Checked == true && checkBox1.Checked == true && checkBox3.Checked == false && checkBox4.Checked == true)     // маленькие большие цифры
            {
                textBox1.Text = ("Password: ");

                for (int i = 0; i < N; i++)
                {
                    s = liter_m_b_n[rnd.Next(56)];
                    textBox1.Text += (s);
                }
                textBox2.Text += textBox1.Text + Environment.NewLine;
            }
            if (checkBox2.Checked == true && checkBox1.Checked == false && checkBox3.Checked == true && checkBox4.Checked == true)     // маленькие кракозябры цифры
            {
                textBox1.Text = ("Password: ");

                for (int i = 0; i < N; i++)
                {
                    s = liter_m_c_n[rnd.Next(46)];
                    textBox1.Text += (s);
                }
                textBox2.Text += textBox1.Text + Environment.NewLine;
            }
            if (checkBox2.Checked == false && checkBox1.Checked == false && checkBox3.Checked == true && checkBox4.Checked == true)     // кракозябры цифры
            {
                textBox1.Text = ("Password: ");

                for (int i = 0; i < N; i++)
                {
                    s = liter_c_n[rnd.Next(20)];
                    textBox1.Text += (s);
                }
                textBox2.Text += textBox1.Text + Environment.NewLine;
            }
            if (checkBox2.Checked == false && checkBox1.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true)      // большие кракозябры цифры
            {
                textBox1.Text = ("Password: ");

                for (int i = 0; i < N; i++)
                {
                    s = liter_b_c_n[rnd.Next(46)];
                    textBox1.Text += (s);
                }
                textBox2.Text += textBox1.Text + Environment.NewLine;
            }
            if (checkBox2.Checked == true && checkBox1.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true)       // маленькие большие кракозябры цифры 
            {
                textBox1.Text = ("Password: ");

                for (int i = 0; i < N; i++)
                {
                    s = liter_full[rnd.Next(72)];
                    textBox1.Text += (s);
                }
                textBox2.Text += textBox1.Text + Environment.NewLine;
            }


        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)    // установка длины пароля
        {

        }
        public void checkBox1_CheckedChanged(object sender, EventArgs e)       // выбор больших букв
        {

        }
        public void checkBox2_CheckedChanged(object sender, EventArgs e)       // выбор маленьких букв
        {

        }
        public void checkBox3_CheckedChanged(object sender, EventArgs e)       // выбор кракозябр
        {

        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }   // выбор цифр
        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "Нажмите для генерации пароля");       // Всплывающая подсказка

            toolTip2.ToolTipTitle = ("Путь к файлу C:\\ ... .txt");
            toolTip2.SetToolTip(button4, "Нажмите для сохранения в файл!");
        }
        private void благодарностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Хотелось бы поблагодарить моего друга fish, \nкоторый оказал помощь с графической составляющей приложения, \nа также за тестирование данного приложения");
        }
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = ("Здесь будет ваш пароль!");
            textBox1.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

        private void ночнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Gray;
            textBox1.BackColor = Color.Gray;
            textBox2.BackColor = Color.Gray;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void дневнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            textBox1.BackColor = Color.WhiteSmoke;
            textBox2.BackColor = Color.WhiteSmoke;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            System.IO.StreamWriter File = new System.IO.StreamWriter(@"C:\" + Environment.UserName + "_password.txt");

            if (button4.Enabled == true)
            {
                File.Write(System.DateTimeOffset.Now + " UTC" + Environment.NewLine + Environment.NewLine);
                File.Write("User: " + Environment.UserName + Environment.NewLine + Environment.NewLine);
                File.WriteLine(textBox2.Text);
                if (File != null)
                    File.Close();
                MessageBox.Show("Данные успешно записаны!\nФайл находиться на диске C:\\username_password.txt");
            }
        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Enabled == true)
                textBox2.Clear();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            button4.Enabled = true;
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == null)
            {
                MessageBox.Show("Не создано ни одного пароля!");
            }
            else
            {
                SaveFileDialog save_password = new SaveFileDialog();

                save_password.FileName = Environment.UserName + "_password.txt";
                if (save_password.ShowDialog() == DialogResult.OK)
                {
                    System.IO.StreamWriter wr = new System.IO.StreamWriter(save_password.FileName);
                    wr.Write(System.DateTimeOffset.Now + " UTC" + Environment.NewLine + Environment.NewLine);
                    wr.Write("User: " + Environment.UserName + Environment.NewLine + Environment.NewLine);
                    wr.Write(textBox2.Text);
                    wr.Close();
                }
            }
        }

        private void разработчикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2_adm = new Form2();
            f2_adm.Show();

        }
    }
}


//v3.3.6