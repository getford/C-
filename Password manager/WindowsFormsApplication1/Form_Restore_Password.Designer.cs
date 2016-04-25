namespace WindowsFormsApplication1
{
    partial class Form_Restore_Password
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Restore_Password));
            this.textBox_login_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.introduceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.introduceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button_restore = new System.Windows.Forms.Button();
            this.introduceBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_first_q = new System.Windows.Forms.TextBox();
            this.textBox_first_a = new System.Windows.Forms.TextBox();
            this.textBox_secound_q = new System.Windows.Forms.TextBox();
            this.textBox_secound_a = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.introduceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.introduceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.introduceBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_login_email
            // 
            this.textBox_login_email.Location = new System.Drawing.Point(49, 38);
            this.textBox_login_email.Name = "textBox_login_email";
            this.textBox_login_email.Size = new System.Drawing.Size(227, 20);
            this.textBox_login_email.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(55, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин указанный при регистрации";
            // 
            // button_restore
            // 
            this.button_restore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_restore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_restore.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button_restore.Location = new System.Drawing.Point(97, 247);
            this.button_restore.Name = "button_restore";
            this.button_restore.Size = new System.Drawing.Size(129, 39);
            this.button_restore.TabIndex = 4;
            this.button_restore.Text = "Восстановить";
            this.button_restore.UseVisualStyleBackColor = true;
            this.button_restore.Click += new System.EventHandler(this.button_restore_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 319);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // textBox_first_q
            // 
            this.textBox_first_q.Location = new System.Drawing.Point(49, 103);
            this.textBox_first_q.Name = "textBox_first_q";
            this.textBox_first_q.ReadOnly = true;
            this.textBox_first_q.ShortcutsEnabled = false;
            this.textBox_first_q.Size = new System.Drawing.Size(227, 20);
            this.textBox_first_q.TabIndex = 7;
            // 
            // textBox_first_a
            // 
            this.textBox_first_a.Location = new System.Drawing.Point(49, 129);
            this.textBox_first_a.Name = "textBox_first_a";
            this.textBox_first_a.ShortcutsEnabled = false;
            this.textBox_first_a.Size = new System.Drawing.Size(227, 20);
            this.textBox_first_a.TabIndex = 8;
            // 
            // textBox_secound_q
            // 
            this.textBox_secound_q.Location = new System.Drawing.Point(49, 182);
            this.textBox_secound_q.Name = "textBox_secound_q";
            this.textBox_secound_q.ReadOnly = true;
            this.textBox_secound_q.ShortcutsEnabled = false;
            this.textBox_secound_q.Size = new System.Drawing.Size(227, 20);
            this.textBox_secound_q.TabIndex = 9;
            // 
            // textBox_secound_a
            // 
            this.textBox_secound_a.Location = new System.Drawing.Point(49, 208);
            this.textBox_secound_a.Name = "textBox_secound_a";
            this.textBox_secound_a.ShortcutsEnabled = false;
            this.textBox_secound_a.Size = new System.Drawing.Size(227, 20);
            this.textBox_secound_a.TabIndex = 10;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(55, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ответьте на первый вопрос";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(55, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ответьте на второй вопрос";
            // 
            // Form_Restore_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 319);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_secound_a);
            this.Controls.Add(this.textBox_secound_q);
            this.Controls.Add(this.textBox_first_a);
            this.Controls.Add(this.textBox_first_q);
            this.Controls.Add(this.button_restore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_login_email);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Restore_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Восстановление пароля";
            this.Load += new System.EventHandler(this.Form_Restore_Password_Load);
            ((System.ComponentModel.ISupportInitialize)(this.introduceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.introduceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.introduceBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_login_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource introduceBindingSource;
        private System.Windows.Forms.BindingSource introduceBindingSource1;
        private System.Windows.Forms.Button button_restore;
        private System.Windows.Forms.BindingSource introduceBindingSource2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_first_q;
        private System.Windows.Forms.TextBox textBox_first_a;
        private System.Windows.Forms.TextBox textBox_secound_q;
        private System.Windows.Forms.TextBox textBox_secound_a;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}