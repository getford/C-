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
            this.label_change_password = new System.Windows.Forms.Label();
            this.label_change_e_mail = new System.Windows.Forms.Label();
            this.label_change_avatar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.group_box_setup_acc.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(28, 26);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(33, 13);
            this.label_login.TabIndex = 0;
            this.label_login.Text = "Login";
            this.label_login.Click += new System.EventHandler(this.label_login_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(28, 53);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(35, 13);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Name";
            // 
            // label_family
            // 
            this.label_family.AutoSize = true;
            this.label_family.Location = new System.Drawing.Point(30, 80);
            this.label_family.Name = "label_family";
            this.label_family.Size = new System.Drawing.Size(33, 13);
            this.label_family.TabIndex = 2;
            this.label_family.Text = "family";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(351, 12);
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
            this.group_box_setup_acc.Location = new System.Drawing.Point(139, 222);
            this.group_box_setup_acc.Name = "group_box_setup_acc";
            this.group_box_setup_acc.Size = new System.Drawing.Size(211, 184);
            this.group_box_setup_acc.TabIndex = 18;
            this.group_box_setup_acc.TabStop = false;
            this.group_box_setup_acc.Text = "Управление аккаунтом";
            // 
            // label_change_password
            // 
            this.label_change_password.AutoSize = true;
            this.label_change_password.Location = new System.Drawing.Point(6, 44);
            this.label_change_password.Name = "label_change_password";
            this.label_change_password.Size = new System.Drawing.Size(90, 13);
            this.label_change_password.TabIndex = 0;
            this.label_change_password.Text = "Сменить пароль";
            this.label_change_password.Click += new System.EventHandler(this.OnClick);
            // 
            // label_change_e_mail
            // 
            this.label_change_e_mail.AutoSize = true;
            this.label_change_e_mail.Location = new System.Drawing.Point(6, 70);
            this.label_change_e_mail.Name = "label_change_e_mail";
            this.label_change_e_mail.Size = new System.Drawing.Size(192, 13);
            this.label_change_e_mail.TabIndex = 1;
            this.label_change_e_mail.Text = "Изменить адрес электронной почты";
            // 
            // label_change_avatar
            // 
            this.label_change_avatar.AutoSize = true;
            this.label_change_avatar.Location = new System.Drawing.Point(6, 94);
            this.label_change_avatar.Name = "label_change_avatar";
            this.label_change_avatar.Size = new System.Drawing.Size(107, 13);
            this.label_change_avatar.TabIndex = 2;
            this.label_change_avatar.Text = "Изменить аватарку";
            // 
            // account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 500);
            this.Controls.Add(this.group_box_setup_acc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_family);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "account";
            this.Load += new System.EventHandler(this.account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.group_box_setup_acc.ResumeLayout(false);
            this.group_box_setup_acc.PerformLayout();
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
    }
}