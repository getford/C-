namespace WindowsFormsApplication1
{
    partial class change_password_acc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(change_password_acc));
            this.textBox_old_password = new System.Windows.Forms.TextBox();
            this.textBox_new_password = new System.Windows.Forms.TextBox();
            this.textBox_re_new_password = new System.Windows.Forms.TextBox();
            this.button_change_password = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_old_password
            // 
            this.textBox_old_password.Location = new System.Drawing.Point(12, 36);
            this.textBox_old_password.Name = "textBox_old_password";
            this.textBox_old_password.PasswordChar = '*';
            this.textBox_old_password.Size = new System.Drawing.Size(237, 20);
            this.textBox_old_password.TabIndex = 0;
            this.textBox_old_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_new_password
            // 
            this.textBox_new_password.Location = new System.Drawing.Point(12, 124);
            this.textBox_new_password.Name = "textBox_new_password";
            this.textBox_new_password.PasswordChar = '*';
            this.textBox_new_password.Size = new System.Drawing.Size(237, 20);
            this.textBox_new_password.TabIndex = 1;
            this.textBox_new_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_re_new_password
            // 
            this.textBox_re_new_password.Location = new System.Drawing.Point(12, 163);
            this.textBox_re_new_password.Name = "textBox_re_new_password";
            this.textBox_re_new_password.PasswordChar = '*';
            this.textBox_re_new_password.Size = new System.Drawing.Size(237, 20);
            this.textBox_re_new_password.TabIndex = 2;
            this.textBox_re_new_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_change_password
            // 
            this.button_change_password.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_change_password.Location = new System.Drawing.Point(62, 211);
            this.button_change_password.Name = "button_change_password";
            this.button_change_password.Size = new System.Drawing.Size(135, 23);
            this.button_change_password.TabIndex = 3;
            this.button_change_password.Text = "Сменить пароль";
            this.button_change_password.UseVisualStyleBackColor = true;
            this.button_change_password.Click += new System.EventHandler(this.button_change_password_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Текущий пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Новый пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Повторите пароль";
            // 
            // change_password_acc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 249);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_change_password);
            this.Controls.Add(this.textBox_re_new_password);
            this.Controls.Add(this.textBox_new_password);
            this.Controls.Add(this.textBox_old_password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "change_password_acc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение пароля";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.change_password_acc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_old_password;
        private System.Windows.Forms.TextBox textBox_new_password;
        private System.Windows.Forms.TextBox textBox_re_new_password;
        private System.Windows.Forms.Button button_change_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}