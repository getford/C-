namespace WindowsFormsApplication1
{
    partial class Form_help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_help));
            this.button_folder_readme = new System.Windows.Forms.Button();
            this.openFileDialog_ = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // button_folder_readme
            // 
            this.button_folder_readme.Location = new System.Drawing.Point(12, 12);
            this.button_folder_readme.Name = "button_folder_readme";
            this.button_folder_readme.Size = new System.Drawing.Size(340, 23);
            this.button_folder_readme.TabIndex = 0;
            this.button_folder_readme.Text = "Открыть папку проекта с файлами руководства";
            this.button_folder_readme.UseVisualStyleBackColor = true;
            this.button_folder_readme.Click += new System.EventHandler(this.button_folder_readme_Click);
            // 
            // openFileDialog_
            // 
            this.openFileDialog_.FileName = "openFileDialog_";
            // 
            // Form_help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 47);
            this.Controls.Add(this.button_folder_readme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_help";
            this.Text = "Информация";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_folder_readme;
        private System.Windows.Forms.OpenFileDialog openFileDialog_;
    }
}