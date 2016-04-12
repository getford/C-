namespace WindowsFormsApplication1
{
    partial class account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(account));
            this.label_login = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_family = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.group_box_setup_acc = new System.Windows.Forms.GroupBox();
            this.label_change_avatar = new System.Windows.Forms.Label();
            this.label_change_e_mail = new System.Windows.Forms.Label();
            this.label_change_password = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_first_name = new System.Windows.Forms.TextBox();
            this.textBox_last_name = new System.Windows.Forms.TextBox();
            this.groupBox_info_account = new System.Windows.Forms.GroupBox();
            this.linkLabel_delete_account = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.group_box_setup_acc.SuspendLayout();
            this.groupBox_info_account.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login.Location = new System.Drawing.Point(6, 22);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(41, 13);
            this.label_login.TabIndex = 0;
            this.label_login.Text = "Логин:";
            this.label_login.Click += new System.EventHandler(this.label_login_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.Location = new System.Drawing.Point(6, 48);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Имя: ";
            // 
            // label_family
            // 
            this.label_family.AutoSize = true;
            this.label_family.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_family.Location = new System.Drawing.Point(6, 74);
            this.label_family.Name = "label_family";
            this.label_family.Size = new System.Drawing.Size(59, 13);
            this.label_family.TabIndex = 2;
            this.label_family.Text = "Фамилия:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(298, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // group_box_setup_acc
            // 
            this.group_box_setup_acc.Controls.Add(this.label_change_avatar);
            this.group_box_setup_acc.Controls.Add(this.label_change_e_mail);
            this.group_box_setup_acc.Controls.Add(this.label_change_password);
            this.group_box_setup_acc.Location = new System.Drawing.Point(12, 152);
            this.group_box_setup_acc.Name = "group_box_setup_acc";
            this.group_box_setup_acc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.group_box_setup_acc.Size = new System.Drawing.Size(258, 121);
            this.group_box_setup_acc.TabIndex = 18;
            this.group_box_setup_acc.TabStop = false;
            this.group_box_setup_acc.Text = "Управление аккаунтом";
            // 
            // label_change_avatar
            // 
            this.label_change_avatar.AutoSize = true;
            this.label_change_avatar.Location = new System.Drawing.Point(9, 77);
            this.label_change_avatar.Name = "label_change_avatar";
            this.label_change_avatar.Size = new System.Drawing.Size(107, 13);
            this.label_change_avatar.TabIndex = 2;
            this.label_change_avatar.Text = "Изменить аватарку";
            // 
            // label_change_e_mail
            // 
            this.label_change_e_mail.AutoSize = true;
            this.label_change_e_mail.Location = new System.Drawing.Point(9, 55);
            this.label_change_e_mail.Name = "label_change_e_mail";
            this.label_change_e_mail.Size = new System.Drawing.Size(192, 13);
            this.label_change_e_mail.TabIndex = 1;
            this.label_change_e_mail.Text = "Изменить адрес электронной почты";
            this.label_change_e_mail.Click += new System.EventHandler(this.OnClick_change_email);
            // 
            // label_change_password
            // 
            this.label_change_password.AutoSize = true;
            this.label_change_password.Location = new System.Drawing.Point(9, 33);
            this.label_change_password.Name = "label_change_password";
            this.label_change_password.Size = new System.Drawing.Size(90, 13);
            this.label_change_password.TabIndex = 0;
            this.label_change_password.Text = "Сменить пароль";
            this.label_change_password.Click += new System.EventHandler(this.OnClick);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_email.Location = new System.Drawing.Point(6, 100);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(41, 13);
            this.label_email.TabIndex = 19;
            this.label_email.Text = "E-mail: ";
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(87, 19);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.ReadOnly = true;
            this.textBox_login.Size = new System.Drawing.Size(156, 20);
            this.textBox_login.TabIndex = 20;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(87, 97);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.ReadOnly = true;
            this.textBox_email.Size = new System.Drawing.Size(156, 20);
            this.textBox_email.TabIndex = 21;
            // 
            // textBox_first_name
            // 
            this.textBox_first_name.Location = new System.Drawing.Point(87, 45);
            this.textBox_first_name.Name = "textBox_first_name";
            this.textBox_first_name.ReadOnly = true;
            this.textBox_first_name.Size = new System.Drawing.Size(156, 20);
            this.textBox_first_name.TabIndex = 22;
            // 
            // textBox_last_name
            // 
            this.textBox_last_name.Location = new System.Drawing.Point(87, 71);
            this.textBox_last_name.Name = "textBox_last_name";
            this.textBox_last_name.ReadOnly = true;
            this.textBox_last_name.Size = new System.Drawing.Size(156, 20);
            this.textBox_last_name.TabIndex = 23;
            // 
            // groupBox_info_account
            // 
            this.groupBox_info_account.Controls.Add(this.label_name);
            this.groupBox_info_account.Controls.Add(this.label_email);
            this.groupBox_info_account.Controls.Add(this.label_family);
            this.groupBox_info_account.Controls.Add(this.label_login);
            this.groupBox_info_account.Controls.Add(this.textBox_login);
            this.groupBox_info_account.Controls.Add(this.textBox_email);
            this.groupBox_info_account.Controls.Add(this.textBox_first_name);
            this.groupBox_info_account.Controls.Add(this.textBox_last_name);
            this.groupBox_info_account.Location = new System.Drawing.Point(12, 12);
            this.groupBox_info_account.Name = "groupBox_info_account";
            this.groupBox_info_account.Size = new System.Drawing.Size(258, 134);
            this.groupBox_info_account.TabIndex = 24;
            this.groupBox_info_account.TabStop = false;
            // 
            // linkLabel_delete_account
            // 
            this.linkLabel_delete_account.AutoSize = true;
            this.linkLabel_delete_account.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel_delete_account.LinkColor = System.Drawing.Color.Red;
            this.linkLabel_delete_account.Location = new System.Drawing.Point(95, 310);
            this.linkLabel_delete_account.Name = "linkLabel_delete_account";
            this.linkLabel_delete_account.Size = new System.Drawing.Size(175, 22);
            this.linkLabel_delete_account.TabIndex = 25;
            this.linkLabel_delete_account.TabStop = true;
            this.linkLabel_delete_account.Text = "Удалить аккаунт";
            this.linkLabel_delete_account.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_delete_account_LinkClicked);
            // 
            // account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(379, 341);
            this.Controls.Add(this.linkLabel_delete_account);
            this.Controls.Add(this.groupBox_info_account);
            this.Controls.Add(this.group_box_setup_acc);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "account";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Аккаунт";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.group_box_setup_acc.ResumeLayout(false);
            this.group_box_setup_acc.PerformLayout();
            this.groupBox_info_account.ResumeLayout(false);
            this.groupBox_info_account.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_family;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox group_box_setup_acc;
        private System.Windows.Forms.Label label_change_avatar;
        private System.Windows.Forms.Label label_change_e_mail;
        private System.Windows.Forms.Label label_change_password;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_first_name;
        private System.Windows.Forms.TextBox textBox_last_name;
        private System.Windows.Forms.GroupBox groupBox_info_account;
        private System.Windows.Forms.LinkLabel linkLabel_delete_account;
        public System.Windows.Forms.TextBox textBox_login;
    }
}