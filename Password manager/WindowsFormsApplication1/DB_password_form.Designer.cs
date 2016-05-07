namespace WindowsFormsApplication1
{
    partial class DB_password_form
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
            System.Windows.Forms.Label label_info_app;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DB_password_form));
            this.textBox_name_site = new System.Windows.Forms.TextBox();
            this.textBox_URL_site = new System.Windows.Forms.TextBox();
            this.textBox_login_site = new System.Windows.Forms.TextBox();
            this.textBox_password_site = new System.Windows.Forms.TextBox();
            this.button_authorization_site = new System.Windows.Forms.Button();
            this.button_register = new System.Windows.Forms.Button();
            this.textBox_user_login_now = new System.Windows.Forms.TextBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.groupBox_textboxes = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_valid_password = new System.Windows.Forms.DateTimePicker();
            this.groupBox_buttons = new System.Windows.Forms.GroupBox();
            this.button_register_site = new System.Windows.Forms.Button();
            this.listView_site_login_password = new System.Windows.Forms.ListView();
            this.groupBox_info_user_name = new System.Windows.Forms.GroupBox();
            this.checkBox_show_password = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            label_info_app = new System.Windows.Forms.Label();
            this.groupBox_textboxes.SuspendLayout();
            this.groupBox_buttons.SuspendLayout();
            this.groupBox_info_user_name.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_info_app
            // 
            label_info_app.AutoSize = true;
            label_info_app.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            label_info_app.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            label_info_app.Location = new System.Drawing.Point(12, 438);
            label_info_app.Name = "label_info_app";
            label_info_app.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label_info_app.Size = new System.Drawing.Size(871, 13);
            label_info_app.TabIndex = 15;
            label_info_app.Text = "PassWord Manager - v1.0.0 © Vladimir Zhigalo BSTU Minsk 2016    _________________" +
    "_________________________________________________________________________";
            label_info_app.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_name_site
            // 
            this.textBox_name_site.Location = new System.Drawing.Point(6, 19);
            this.textBox_name_site.Name = "textBox_name_site";
            this.textBox_name_site.Size = new System.Drawing.Size(200, 20);
            this.textBox_name_site.TabIndex = 1;
            // 
            // textBox_URL_site
            // 
            this.textBox_URL_site.Location = new System.Drawing.Point(6, 45);
            this.textBox_URL_site.Name = "textBox_URL_site";
            this.textBox_URL_site.Size = new System.Drawing.Size(200, 20);
            this.textBox_URL_site.TabIndex = 2;
            // 
            // textBox_login_site
            // 
            this.textBox_login_site.Location = new System.Drawing.Point(6, 71);
            this.textBox_login_site.Name = "textBox_login_site";
            this.textBox_login_site.Size = new System.Drawing.Size(200, 20);
            this.textBox_login_site.TabIndex = 3;
            // 
            // textBox_password_site
            // 
            this.textBox_password_site.Location = new System.Drawing.Point(6, 97);
            this.textBox_password_site.Name = "textBox_password_site";
            this.textBox_password_site.Size = new System.Drawing.Size(200, 20);
            this.textBox_password_site.TabIndex = 4;
            // 
            // button_authorization_site
            // 
            this.button_authorization_site.Location = new System.Drawing.Point(6, 19);
            this.button_authorization_site.Name = "button_authorization_site";
            this.button_authorization_site.Size = new System.Drawing.Size(200, 23);
            this.button_authorization_site.TabIndex = 5;
            this.button_authorization_site.Text = "Авторизация";
            this.button_authorization_site.UseVisualStyleBackColor = true;
            this.button_authorization_site.Click += new System.EventHandler(this.button_authorization_site_Click);
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(6, 48);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(200, 23);
            this.button_register.TabIndex = 6;
            this.button_register.Text = "Записать в бд";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // textBox_user_login_now
            // 
            this.textBox_user_login_now.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_user_login_now.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_user_login_now.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox_user_login_now.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_user_login_now.Location = new System.Drawing.Point(28, 19);
            this.textBox_user_login_now.Multiline = true;
            this.textBox_user_login_now.Name = "textBox_user_login_now";
            this.textBox_user_login_now.ReadOnly = true;
            this.textBox_user_login_now.ShortcutsEnabled = false;
            this.textBox_user_login_now.Size = new System.Drawing.Size(178, 26);
            this.textBox_user_login_now.TabIndex = 8;
            this.textBox_user_login_now.TabStop = false;
            this.textBox_user_login_now.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(6, 77);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(200, 23);
            this.button_clear.TabIndex = 9;
            this.button_clear.Text = "Очистить поля";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(6, 106);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(200, 23);
            this.button_delete.TabIndex = 10;
            this.button_delete.Text = "Удалить запись";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // groupBox_textboxes
            // 
            this.groupBox_textboxes.Controls.Add(this.dateTimePicker_valid_password);
            this.groupBox_textboxes.Controls.Add(this.textBox_name_site);
            this.groupBox_textboxes.Controls.Add(this.textBox_URL_site);
            this.groupBox_textboxes.Controls.Add(this.textBox_login_site);
            this.groupBox_textboxes.Controls.Add(this.textBox_password_site);
            this.groupBox_textboxes.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox_textboxes.Location = new System.Drawing.Point(663, 95);
            this.groupBox_textboxes.Name = "groupBox_textboxes";
            this.groupBox_textboxes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox_textboxes.Size = new System.Drawing.Size(212, 158);
            this.groupBox_textboxes.TabIndex = 11;
            this.groupBox_textboxes.TabStop = false;
            // 
            // dateTimePicker_valid_password
            // 
            this.dateTimePicker_valid_password.Location = new System.Drawing.Point(6, 123);
            this.dateTimePicker_valid_password.MaxDate = new System.DateTime(2096, 9, 29, 0, 0, 0, 0);
            this.dateTimePicker_valid_password.MinDate = new System.DateTime(1996, 9, 29, 0, 0, 0, 0);
            this.dateTimePicker_valid_password.Name = "dateTimePicker_valid_password";
            this.dateTimePicker_valid_password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker_valid_password.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_valid_password.TabIndex = 14;
            // 
            // groupBox_buttons
            // 
            this.groupBox_buttons.Controls.Add(this.button_register_site);
            this.groupBox_buttons.Controls.Add(this.button_register);
            this.groupBox_buttons.Controls.Add(this.button_authorization_site);
            this.groupBox_buttons.Controls.Add(this.button_delete);
            this.groupBox_buttons.Controls.Add(this.button_clear);
            this.groupBox_buttons.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox_buttons.Location = new System.Drawing.Point(663, 259);
            this.groupBox_buttons.Name = "groupBox_buttons";
            this.groupBox_buttons.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox_buttons.Size = new System.Drawing.Size(212, 166);
            this.groupBox_buttons.TabIndex = 12;
            this.groupBox_buttons.TabStop = false;
            // 
            // button_register_site
            // 
            this.button_register_site.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_register_site.Location = new System.Drawing.Point(6, 135);
            this.button_register_site.Name = "button_register_site";
            this.button_register_site.Size = new System.Drawing.Size(200, 23);
            this.button_register_site.TabIndex = 11;
            this.button_register_site.Text = "Зарегистрироваться на сайте";
            this.button_register_site.UseVisualStyleBackColor = true;
            this.button_register_site.Click += new System.EventHandler(this.button_register_site_Click);
            // 
            // listView_site_login_password
            // 
            this.listView_site_login_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_site_login_password.Location = new System.Drawing.Point(12, 12);
            this.listView_site_login_password.Name = "listView_site_login_password";
            this.listView_site_login_password.Size = new System.Drawing.Size(645, 413);
            this.listView_site_login_password.TabIndex = 13;
            this.listView_site_login_password.UseCompatibleStateImageBehavior = false;
            this.listView_site_login_password.View = System.Windows.Forms.View.Details;
            this.listView_site_login_password.SelectedIndexChanged += new System.EventHandler(this.listView_site_login_password_SelectedIndexChanged);
            this.listView_site_login_password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListView_MouseClick);
            // 
            // groupBox_info_user_name
            // 
            this.groupBox_info_user_name.Controls.Add(this.textBox_user_login_now);
            this.groupBox_info_user_name.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox_info_user_name.Location = new System.Drawing.Point(663, 12);
            this.groupBox_info_user_name.Name = "groupBox_info_user_name";
            this.groupBox_info_user_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox_info_user_name.Size = new System.Drawing.Size(212, 54);
            this.groupBox_info_user_name.TabIndex = 14;
            this.groupBox_info_user_name.TabStop = false;
            this.groupBox_info_user_name.Text = "Вы вошли под именем: ";
            // 
            // checkBox_show_password
            // 
            this.checkBox_show_password.AutoSize = true;
            this.checkBox_show_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_show_password.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox_show_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_show_password.Location = new System.Drawing.Point(669, 72);
            this.checkBox_show_password.Name = "checkBox_show_password";
            this.checkBox_show_password.Size = new System.Drawing.Size(112, 17);
            this.checkBox_show_password.TabIndex = 16;
            this.checkBox_show_password.Text = "Показать пароль";
            this.checkBox_show_password.UseVisualStyleBackColor = true;
            this.checkBox_show_password.CheckedChanged += new System.EventHandler(this.checkBox_show_password_CheckedChanged);
            // 
            // DB_password_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 467);
            this.Controls.Add(this.checkBox_show_password);
            this.Controls.Add(label_info_app);
            this.Controls.Add(this.groupBox_info_user_name);
            this.Controls.Add(this.listView_site_login_password);
            this.Controls.Add(this.groupBox_buttons);
            this.Controls.Add(this.groupBox_textboxes);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DB_password_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ваша база паролей";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DB_password_form_Load);
            this.groupBox_textboxes.ResumeLayout(false);
            this.groupBox_textboxes.PerformLayout();
            this.groupBox_buttons.ResumeLayout(false);
            this.groupBox_info_user_name.ResumeLayout(false);
            this.groupBox_info_user_name.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_name_site;
        private System.Windows.Forms.TextBox textBox_URL_site;
        private System.Windows.Forms.TextBox textBox_login_site;
        private System.Windows.Forms.Button button_authorization_site;
        private System.Windows.Forms.Button button_register;
        public System.Windows.Forms.TextBox textBox_user_login_now;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.GroupBox groupBox_textboxes;
        private System.Windows.Forms.GroupBox groupBox_buttons;
        private System.Windows.Forms.ListView listView_site_login_password;
        private System.Windows.Forms.DateTimePicker dateTimePicker_valid_password;
        private System.Windows.Forms.GroupBox groupBox_info_user_name;
        private System.Windows.Forms.CheckBox checkBox_show_password;
        public System.Windows.Forms.TextBox textBox_password_site;
        private System.Windows.Forms.Button button_register_site;
        private System.Windows.Forms.Timer timer;
    }
}