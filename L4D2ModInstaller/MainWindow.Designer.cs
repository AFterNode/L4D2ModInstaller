namespace L4D2ModInstaller
{
    partial class MainWindow
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
            gbStep1 = new GroupBox();
            lbExtractProgress = new Label();
            btnSelectModpack = new Button();
            lbHasVoice = new Label();
            lbHasMainMod = new Label();
            lbSelectedModpack = new Label();
            gbStep2 = new GroupBox();
            tbInstallPath = new TextBox();
            lbInstallPathNotice = new Label();
            gbStep3 = new GroupBox();
            lbPreprocessProgress = new Label();
            pbPreprocess = new ProgressBar();
            btnStartPreprocess = new Button();
            lbPreprocessNotice = new Label();
            btnCopyAndCompress = new Button();
            gbStep4 = new GroupBox();
            btnRebuildAudioCache = new Button();
            lbInstallProgress = new Label();
            btnRestore = new Button();
            btnInstallMod = new Button();
            gbOther = new GroupBox();
            lbIs18 = new Label();
            gbStep1.SuspendLayout();
            gbStep2.SuspendLayout();
            gbStep3.SuspendLayout();
            gbStep4.SuspendLayout();
            SuspendLayout();
            // 
            // gbStep1
            // 
            gbStep1.Controls.Add(lbIs18);
            gbStep1.Controls.Add(lbExtractProgress);
            gbStep1.Controls.Add(btnSelectModpack);
            gbStep1.Controls.Add(lbHasVoice);
            gbStep1.Controls.Add(lbHasMainMod);
            gbStep1.Controls.Add(lbSelectedModpack);
            gbStep1.Location = new Point(12, 12);
            gbStep1.Name = "gbStep1";
            gbStep1.Size = new Size(533, 138);
            gbStep1.TabIndex = 0;
            gbStep1.TabStop = false;
            gbStep1.Text = "步骤一：选择并预加载模组包";
            // 
            // lbExtractProgress
            // 
            lbExtractProgress.AutoSize = true;
            lbExtractProgress.Location = new Point(6, 109);
            lbExtractProgress.Name = "lbExtractProgress";
            lbExtractProgress.Size = new Size(64, 17);
            lbExtractProgress.TabIndex = 5;
            lbExtractProgress.Text = "[加载进度]";
            // 
            // btnSelectModpack
            // 
            btnSelectModpack.Location = new Point(6, 73);
            btnSelectModpack.Name = "btnSelectModpack";
            btnSelectModpack.Size = new Size(75, 23);
            btnSelectModpack.TabIndex = 3;
            btnSelectModpack.Text = "选择文件";
            btnSelectModpack.UseVisualStyleBackColor = true;
            btnSelectModpack.Click += btnSelectModpack_Click;
            // 
            // lbHasVoice
            // 
            lbHasVoice.AutoSize = true;
            lbHasVoice.Location = new Point(6, 53);
            lbHasVoice.Name = "lbHasVoice";
            lbHasVoice.Size = new Size(92, 17);
            lbHasVoice.TabIndex = 2;
            lbHasVoice.Text = "是否含有语音：";
            // 
            // lbHasMainMod
            // 
            lbHasMainMod.AutoSize = true;
            lbHasMainMod.Location = new Point(6, 36);
            lbHasMainMod.Name = "lbHasMainMod";
            lbHasMainMod.Size = new Size(125, 17);
            lbHasMainMod.TabIndex = 1;
            lbHasMainMod.Text = "是否含有MainMod：";
            // 
            // lbSelectedModpack
            // 
            lbSelectedModpack.AutoSize = true;
            lbSelectedModpack.Location = new Point(6, 19);
            lbSelectedModpack.Name = "lbSelectedModpack";
            lbSelectedModpack.Size = new Size(104, 17);
            lbSelectedModpack.TabIndex = 0;
            lbSelectedModpack.Text = "已选择的模组包：";
            // 
            // gbStep2
            // 
            gbStep2.Controls.Add(tbInstallPath);
            gbStep2.Controls.Add(lbInstallPathNotice);
            gbStep2.Location = new Point(12, 156);
            gbStep2.Name = "gbStep2";
            gbStep2.Size = new Size(307, 71);
            gbStep2.TabIndex = 1;
            gbStep2.TabStop = false;
            gbStep2.Text = "步骤2：配置L4D2安装位置";
            // 
            // tbInstallPath
            // 
            tbInstallPath.Location = new Point(10, 39);
            tbInstallPath.Name = "tbInstallPath";
            tbInstallPath.Size = new Size(291, 23);
            tbInstallPath.TabIndex = 1;
            // 
            // lbInstallPathNotice
            // 
            lbInstallPathNotice.AutoSize = true;
            lbInstallPathNotice.Location = new Point(6, 19);
            lbInstallPathNotice.Name = "lbInstallPathNotice";
            lbInstallPathNotice.Size = new Size(152, 17);
            lbInstallPathNotice.TabIndex = 0;
            lbInstallPathNotice.Text = "自动获取的位置不一定准确";
            // 
            // gbStep3
            // 
            gbStep3.Controls.Add(lbPreprocessProgress);
            gbStep3.Controls.Add(pbPreprocess);
            gbStep3.Controls.Add(btnStartPreprocess);
            gbStep3.Controls.Add(lbPreprocessNotice);
            gbStep3.Controls.Add(btnCopyAndCompress);
            gbStep3.Location = new Point(12, 233);
            gbStep3.Name = "gbStep3";
            gbStep3.Size = new Size(307, 250);
            gbStep3.TabIndex = 2;
            gbStep3.TabStop = false;
            gbStep3.Text = "步骤三：预处理游戏文件";
            // 
            // lbPreprocessProgress
            // 
            lbPreprocessProgress.AutoSize = true;
            lbPreprocessProgress.Location = new Point(10, 196);
            lbPreprocessProgress.Name = "lbPreprocessProgress";
            lbPreprocessProgress.Size = new Size(76, 17);
            lbPreprocessProgress.TabIndex = 4;
            lbPreprocessProgress.Text = "[预处理进度]";
            // 
            // pbPreprocess
            // 
            pbPreprocess.Location = new Point(6, 216);
            pbPreprocess.Name = "pbPreprocess";
            pbPreprocess.Size = new Size(295, 23);
            pbPreprocess.TabIndex = 3;
            // 
            // btnStartPreprocess
            // 
            btnStartPreprocess.Location = new Point(6, 170);
            btnStartPreprocess.Name = "btnStartPreprocess";
            btnStartPreprocess.Size = new Size(296, 23);
            btnStartPreprocess.TabIndex = 2;
            btnStartPreprocess.Text = "预处理游戏文件";
            btnStartPreprocess.UseVisualStyleBackColor = true;
            btnStartPreprocess.Click += btnStartPreprocess_Click;
            // 
            // lbPreprocessNotice
            // 
            lbPreprocessNotice.AutoSize = true;
            lbPreprocessNotice.Location = new Point(6, 19);
            lbPreprocessNotice.Name = "lbPreprocessNotice";
            lbPreprocessNotice.Size = new Size(296, 119);
            lbPreprocessNotice.TabIndex = 1;
            lbPreprocessNotice.Text = "注意：建议预先备份安装目录中以下文件方便后续恢复\r\nupdates\r\nleft4dead2\r\nleft4dead2_dlc1\r\nleft4dead2_dlc2\r\nleft4dead2_dlc3\r\nupdate";
            // 
            // btnCopyAndCompress
            // 
            btnCopyAndCompress.Location = new Point(6, 141);
            btnCopyAndCompress.Name = "btnCopyAndCompress";
            btnCopyAndCompress.Size = new Size(295, 23);
            btnCopyAndCompress.TabIndex = 0;
            btnCopyAndCompress.Text = "自动备份（建议手动选择压缩软件备份）\r\n";
            btnCopyAndCompress.UseVisualStyleBackColor = true;
            btnCopyAndCompress.Click += btnCopyAndCompress_Click;
            // 
            // gbStep4
            // 
            gbStep4.Controls.Add(btnRebuildAudioCache);
            gbStep4.Controls.Add(lbInstallProgress);
            gbStep4.Controls.Add(btnRestore);
            gbStep4.Controls.Add(btnInstallMod);
            gbStep4.Location = new Point(551, 12);
            gbStep4.Name = "gbStep4";
            gbStep4.Size = new Size(263, 471);
            gbStep4.TabIndex = 3;
            gbStep4.TabStop = false;
            gbStep4.Text = "步骤4：安装模组";
            // 
            // btnRebuildAudioCache
            // 
            btnRebuildAudioCache.Location = new Point(6, 76);
            btnRebuildAudioCache.Name = "btnRebuildAudioCache";
            btnRebuildAudioCache.Size = new Size(251, 23);
            btnRebuildAudioCache.TabIndex = 4;
            btnRebuildAudioCache.Text = "重建音频库（有语音时必须执行）";
            btnRebuildAudioCache.UseVisualStyleBackColor = true;
            btnRebuildAudioCache.Click += btnRebuildAudioCache_Click;
            // 
            // lbInstallProgress
            // 
            lbInstallProgress.AutoSize = true;
            lbInstallProgress.Location = new Point(6, 102);
            lbInstallProgress.Name = "lbInstallProgress";
            lbInstallProgress.Size = new Size(64, 17);
            lbInstallProgress.TabIndex = 3;
            lbInstallProgress.Text = "[安装进度]";
            // 
            // btnRestore
            // 
            btnRestore.Location = new Point(6, 47);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(251, 23);
            btnRestore.TabIndex = 2;
            btnRestore.Text = "恢复游戏（完成全部安装后执行）";
            btnRestore.UseVisualStyleBackColor = true;
            btnRestore.Click += btnRestore_Click;
            // 
            // btnInstallMod
            // 
            btnInstallMod.Location = new Point(6, 19);
            btnInstallMod.Name = "btnInstallMod";
            btnInstallMod.Size = new Size(251, 23);
            btnInstallMod.TabIndex = 0;
            btnInstallMod.Text = "点击安装模组文件";
            btnInstallMod.UseVisualStyleBackColor = true;
            btnInstallMod.Click += btnInstallMod_Click;
            // 
            // gbOther
            // 
            gbOther.Location = new Point(325, 156);
            gbOther.Name = "gbOther";
            gbOther.Size = new Size(220, 325);
            gbOther.TabIndex = 4;
            gbOther.TabStop = false;
            gbOther.Text = "其他";
            // 
            // lbIs18
            // 
            lbIs18.AutoSize = true;
            lbIs18.Location = new Point(264, 19);
            lbIs18.Name = "lbIs18";
            lbIs18.Size = new Size(92, 17);
            lbIs18.TabIndex = 6;
            lbIs18.Text = "是否为限制级：";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 493);
            Controls.Add(gbOther);
            Controls.Add(gbStep4);
            Controls.Add(gbStep3);
            Controls.Add(gbStep2);
            Controls.Add(gbStep1);
            Name = "MainWindow";
            Text = "求生之路2模组包安装器";
            FormClosed += OnClose;
            gbStep1.ResumeLayout(false);
            gbStep1.PerformLayout();
            gbStep2.ResumeLayout(false);
            gbStep2.PerformLayout();
            gbStep3.ResumeLayout(false);
            gbStep3.PerformLayout();
            gbStep4.ResumeLayout(false);
            gbStep4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbStep1;
        private Label lbHasVoice;
        private Label lbHasMainMod;
        private Label lbSelectedModpack;
        private Label lbExtractProgress;
        private Button btnSelectModpack;
        private GroupBox gbStep2;
        private TextBox tbInstallPath;
        private Label lbInstallPathNotice;
        private GroupBox gbStep3;
        private Button btnStartPreprocess;
        private Label lbPreprocessNotice;
        private Button btnCopyAndCompress;
        private Label lbPreprocessProgress;
        private ProgressBar pbPreprocess;
        private GroupBox gbStep4;
        private Button btnInstallMod;
        private Button btnRestore;
        private Label lbInstallProgress;
        private Button btnRebuildAudioCache;
        private GroupBox gbOther;
        private Label lbIs18;
    }
}