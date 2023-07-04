namespace L4D2ModInstaller.Ui
{
    partial class FurtherModInfo
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
            lbAuthor = new Label();
            lbName = new Label();
            lbComments = new Label();
            tbComments = new TextBox();
            lbIsLimited = new Label();
            lbHasMainMod = new Label();
            lbHasVoice1 = new Label();
            lbHasVoice2 = new Label();
            gbMain = new GroupBox();
            gbMain.SuspendLayout();
            SuspendLayout();
            // 
            // lbAuthor
            // 
            lbAuthor.AutoSize = true;
            lbAuthor.Location = new Point(6, 36);
            lbAuthor.Name = "lbAuthor";
            lbAuthor.Size = new Size(44, 17);
            lbAuthor.TabIndex = 0;
            lbAuthor.Text = "作者：";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(6, 19);
            lbName.Name = "lbName";
            lbName.Size = new Size(44, 17);
            lbName.TabIndex = 1;
            lbName.Text = "名称：";
            // 
            // lbComments
            // 
            lbComments.AutoSize = true;
            lbComments.Location = new Point(6, 53);
            lbComments.Name = "lbComments";
            lbComments.Size = new Size(44, 17);
            lbComments.TabIndex = 2;
            lbComments.Text = "备注：";
            // 
            // tbComments
            // 
            tbComments.Location = new Point(56, 53);
            tbComments.Multiline = true;
            tbComments.Name = "tbComments";
            tbComments.ReadOnly = true;
            tbComments.ScrollBars = ScrollBars.Horizontal;
            tbComments.Size = new Size(157, 178);
            tbComments.TabIndex = 3;
            // 
            // lbIsLimited
            // 
            lbIsLimited.AutoSize = true;
            lbIsLimited.Location = new Point(6, 234);
            lbIsLimited.Name = "lbIsLimited";
            lbIsLimited.Size = new Size(92, 17);
            lbIsLimited.TabIndex = 4;
            lbIsLimited.Text = "是否为限制级：";
            // 
            // lbHasMainMod
            // 
            lbHasMainMod.AutoSize = true;
            lbHasMainMod.Location = new Point(6, 251);
            lbHasMainMod.Name = "lbHasMainMod";
            lbHasMainMod.Size = new Size(104, 17);
            lbHasMainMod.TabIndex = 5;
            lbHasMainMod.Text = "是否含有主模组：";
            // 
            // lbHasVoice1
            // 
            lbHasVoice1.AutoSize = true;
            lbHasVoice1.Location = new Point(6, 268);
            lbHasVoice1.Name = "lbHasVoice1";
            lbHasVoice1.Size = new Size(116, 17);
            lbHasVoice1.TabIndex = 6;
            lbHasVoice1.Text = "是否含有一代音频：";
            // 
            // lbHasVoice2
            // 
            lbHasVoice2.AutoSize = true;
            lbHasVoice2.Location = new Point(6, 285);
            lbHasVoice2.Name = "lbHasVoice2";
            lbHasVoice2.Size = new Size(116, 17);
            lbHasVoice2.TabIndex = 7;
            lbHasVoice2.Text = "是否含有二代音频：";
            // 
            // gbMain
            // 
            gbMain.Controls.Add(lbName);
            gbMain.Controls.Add(lbHasVoice2);
            gbMain.Controls.Add(lbAuthor);
            gbMain.Controls.Add(lbHasVoice1);
            gbMain.Controls.Add(lbComments);
            gbMain.Controls.Add(lbHasMainMod);
            gbMain.Controls.Add(tbComments);
            gbMain.Controls.Add(lbIsLimited);
            gbMain.Location = new Point(12, 12);
            gbMain.Name = "gbMain";
            gbMain.Size = new Size(250, 311);
            gbMain.TabIndex = 8;
            gbMain.TabStop = false;
            gbMain.Text = "主要信息";
            // 
            // FurtherModInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 641);
            Controls.Add(gbMain);
            Name = "FurtherModInfo";
            Text = "详细信息";
            Load += FurtherModInfo_Load;
            gbMain.ResumeLayout(false);
            gbMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbAuthor;
        private Label lbName;
        private Label lbComments;
        private TextBox tbComments;
        private Label lbIsLimited;
        private Label lbHasMainMod;
        private Label lbHasVoice1;
        private Label lbHasVoice2;
        private GroupBox gbMain;
    }
}