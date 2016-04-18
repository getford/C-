namespace WindowsFormsApplication1
{
    partial class change_email_acc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(change_email_acc));
            this.textBox_new_email = new System.Windows.Forms.TextBox();
            this.button_change_email = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_new_email
            // 
            this.textBox_new_email.Location = new System.Drawing.Point(12, 22);
            this.textBox_new_email.Name = "textBox_new_email";
            this.textBox_new_email.Size = new System.Drawing.Size(237, 20);
            this.textBox_new_email.TabIndex = 0;
            this.textBox_new_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_change_email
            // 
            this.button_change_email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_change_email.Location = new System.Drawing.Point(56, 48);
            this.button_change_email.Name = "button_change_email";
            this.button_change_email.Size = new System.Drawing.Size(149, 23);
            this.button_change_email.TabIndex = 1;
            this.button_change_email.Text = "Внести изменения";
            this.button_change_email.UseVisualStyleBackColor = true;
            this.button_change_email.Click += new System.EventHandler(this.button_change_email_Click);
            // 
            // change_email_acc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 91);
            this.Controls.Add(this.button_change_email);
            this.Controls.Add(this.textBox_new_email);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "change_email_acc";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение e-mail";
            this.TopMost = true;
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.OnClick_Help_Button);
            this.Load += new System.EventHandler(this.change_email_acc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_new_email;
        private System.Windows.Forms.Button button_change_email;
    }
}