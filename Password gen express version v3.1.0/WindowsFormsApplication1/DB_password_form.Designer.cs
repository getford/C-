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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DB_password_form));
            this.textBox_name_site = new System.Windows.Forms.TextBox();
            this.textBox_URL_site = new System.Windows.Forms.TextBox();
            this.textBox_login_site = new System.Windows.Forms.TextBox();
            this.textBox_password_site = new System.Windows.Forms.TextBox();
            this.button_authorization_site = new System.Windows.Forms.Button();
            this.button_register = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database_siteDataSet = new WindowsFormsApplication1.Database_siteDataSet();
            this.qqqBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qqqTableAdapter = new WindowsFormsApplication1.Database_siteDataSetTableAdapters.qqqTableAdapter();
            this.Label_user_login_now = new System.Windows.Forms.Label();
            this.textBox_user_login_now = new System.Windows.Forms.TextBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_siteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qqqBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_name_site
            // 
            this.textBox_name_site.Location = new System.Drawing.Point(536, 12);
            this.textBox_name_site.Name = "textBox_name_site";
            this.textBox_name_site.Size = new System.Drawing.Size(291, 20);
            this.textBox_name_site.TabIndex = 1;
            // 
            // textBox_URL_site
            // 
            this.textBox_URL_site.Location = new System.Drawing.Point(536, 38);
            this.textBox_URL_site.Name = "textBox_URL_site";
            this.textBox_URL_site.Size = new System.Drawing.Size(291, 20);
            this.textBox_URL_site.TabIndex = 2;
            // 
            // textBox_login_site
            // 
            this.textBox_login_site.Location = new System.Drawing.Point(536, 64);
            this.textBox_login_site.Name = "textBox_login_site";
            this.textBox_login_site.Size = new System.Drawing.Size(291, 20);
            this.textBox_login_site.TabIndex = 3;
            // 
            // textBox_password_site
            // 
            this.textBox_password_site.Location = new System.Drawing.Point(536, 90);
            this.textBox_password_site.Name = "textBox_password_site";
            this.textBox_password_site.Size = new System.Drawing.Size(291, 20);
            this.textBox_password_site.TabIndex = 4;
            // 
            // button_authorization_site
            // 
            this.button_authorization_site.Location = new System.Drawing.Point(597, 116);
            this.button_authorization_site.Name = "button_authorization_site";
            this.button_authorization_site.Size = new System.Drawing.Size(185, 23);
            this.button_authorization_site.TabIndex = 5;
            this.button_authorization_site.Text = "Авторизация";
            this.button_authorization_site.UseVisualStyleBackColor = true;
            this.button_authorization_site.Click += new System.EventHandler(this.button_authorization_site_Click);
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(597, 171);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(185, 23);
            this.button_register.TabIndex = 6;
            this.button_register.Text = "Записать в бд";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(498, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // database_siteDataSet
            // 
            this.database_siteDataSet.DataSetName = "Database_siteDataSet";
            this.database_siteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qqqBindingSource
            // 
            this.qqqBindingSource.DataMember = "qqq";
            this.qqqBindingSource.DataSource = this.database_siteDataSet;
            // 
            // qqqTableAdapter
            // 
            this.qqqTableAdapter.ClearBeforeFill = true;
            // 
            // Label_user_login_now
            // 
            this.Label_user_login_now.AutoSize = true;
            this.Label_user_login_now.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Label_user_login_now.ForeColor = System.Drawing.Color.Black;
            this.Label_user_login_now.Location = new System.Drawing.Point(12, 474);
            this.Label_user_login_now.Name = "Label_user_login_now";
            this.Label_user_login_now.Size = new System.Drawing.Size(174, 18);
            this.Label_user_login_now.TabIndex = 7;
            this.Label_user_login_now.Text = "Вы вошли под именем: ";
            // 
            // textBox_user_login_now
            // 
            this.textBox_user_login_now.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_user_login_now.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox_user_login_now.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox_user_login_now.Location = new System.Drawing.Point(200, 471);
            this.textBox_user_login_now.Name = "textBox_user_login_now";
            this.textBox_user_login_now.ReadOnly = true;
            this.textBox_user_login_now.ShortcutsEnabled = false;
            this.textBox_user_login_now.Size = new System.Drawing.Size(173, 17);
            this.textBox_user_login_now.TabIndex = 8;
            this.textBox_user_login_now.TabStop = false;
            this.textBox_user_login_now.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(597, 201);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(185, 23);
            this.button_clear.TabIndex = 9;
            this.button_clear.Text = "Очистить поля";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(597, 231);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(185, 23);
            this.button_delete.TabIndex = 10;
            this.button_delete.Text = "Удалить запись";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // DB_password_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 526);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.textBox_user_login_now);
            this.Controls.Add(this.Label_user_login_now);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.button_authorization_site);
            this.Controls.Add(this.textBox_password_site);
            this.Controls.Add(this.textBox_login_site);
            this.Controls.Add(this.textBox_URL_site);
            this.Controls.Add(this.textBox_name_site);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DB_password_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ваша база паролей";
            this.Load += new System.EventHandler(this.DB_password_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_siteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qqqBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database_siteDataSet database_siteDataSet;
        private System.Windows.Forms.BindingSource qqqBindingSource;
        private Database_siteDataSetTableAdapters.qqqTableAdapter qqqTableAdapter;
        private System.Windows.Forms.TextBox textBox_name_site;
        private System.Windows.Forms.TextBox textBox_URL_site;
        private System.Windows.Forms.TextBox textBox_login_site;
        private System.Windows.Forms.TextBox textBox_password_site;
        private System.Windows.Forms.Button button_authorization_site;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Label Label_user_login_now;
        public System.Windows.Forms.TextBox textBox_user_login_now;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_delete;
    }
}