namespace WindowsFormsApplication1
{
    partial class Confirm_the_password
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirm_the_password));
            this.textBox_confirm_password = new System.Windows.Forms.TextBox();
            this.button_confirm_password = new System.Windows.Forms.Button();
            this.label_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_confirm_password
            // 
            this.textBox_confirm_password.Location = new System.Drawing.Point(101, 62);
            this.textBox_confirm_password.Name = "textBox_confirm_password";
            this.textBox_confirm_password.PasswordChar = '*';
            this.textBox_confirm_password.Size = new System.Drawing.Size(237, 20);
            this.textBox_confirm_password.TabIndex = 0;
            this.textBox_confirm_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_confirm_password
            // 
            this.button_confirm_password.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_confirm_password.Location = new System.Drawing.Point(167, 88);
            this.button_confirm_password.Name = "button_confirm_password";
            this.button_confirm_password.Size = new System.Drawing.Size(105, 23);
            this.button_confirm_password.TabIndex = 1;
            this.button_confirm_password.Text = "Подтвердить";
            this.button_confirm_password.UseVisualStyleBackColor = true;
            this.button_confirm_password.Click += new System.EventHandler(this.button_confirm_password_Click);
            this.button_confirm_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown_click);
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Location = new System.Drawing.Point(9, 9);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(427, 39);
            this.label_info.TabIndex = 2;
            this.label_info.Text = "Вы действительно хотите просмотреть полный профиль?\r\nВнимание! Вся зашифрованная " +
    "информация, будет расшифрована при просмотре\r\nУ вас 1 минута, после чего вам пот" +
    "ребуется ввести пароль снова\r\n";
            // 
            // Confirm_the_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 126);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.button_confirm_password);
            this.Controls.Add(this.textBox_confirm_password);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Confirm_the_password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подтвердите пароль";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Confirm_the_password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_confirm_password;
        private System.Windows.Forms.Button button_confirm_password;
        private System.Windows.Forms.Label label_info;
    }
}