namespace L4D2ModInstaller.Settings
{
    partial class SettingsWindow
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
            cbAllow18 = new CheckBox();
            cbIgnoreSecurityAlert = new CheckBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // cbAllow18
            // 
            cbAllow18.AutoSize = true;
            cbAllow18.Location = new Point(12, 12);
            cbAllow18.Name = "cbAllow18";
            cbAllow18.Size = new Size(111, 21);
            cbAllow18.TabIndex = 0;
            cbAllow18.Text = "允许限制级内容";
            cbAllow18.UseVisualStyleBackColor = true;
            // 
            // cbIgnoreSecurityAlert
            // 
            cbIgnoreSecurityAlert.AutoSize = true;
            cbIgnoreSecurityAlert.Location = new Point(12, 39);
            cbIgnoreSecurityAlert.Name = "cbIgnoreSecurityAlert";
            cbIgnoreSecurityAlert.Size = new Size(99, 21);
            cbIgnoreSecurityAlert.TabIndex = 1;
            cbIgnoreSecurityAlert.Text = "忽略安全警报";
            cbIgnoreSecurityAlert.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 415);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(214, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "保存";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // SettingsWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 450);
            Controls.Add(btnSave);
            Controls.Add(cbIgnoreSecurityAlert);
            Controls.Add(cbAllow18);
            Name = "SettingsWindow";
            Text = "设置";
            Load += SettingsWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbAllow18;
        private CheckBox cbIgnoreSecurityAlert;
        private Button btnSave;
    }
}