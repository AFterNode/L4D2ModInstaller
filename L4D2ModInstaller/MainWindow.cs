using L4D2ModInstaller.Security;
using L4D2ModInstaller.Settings;
using L4D2ModInstaller.Utils;
using Newtonsoft.Json;
using System.Diagnostics;

namespace L4D2ModInstaller
{
    public partial class MainWindow : Form
    {
        private Manifest? currentManifest = null;

        public MainWindow()
        {
            InitializeComponent();
            tbInstallPath.Text = SteamUtil.GetL4D2InstallPath();
            Control.CheckForIllegalCrossThreadCalls = false;

            string softwareInfo = "";
            softwareInfo += "L4D2ModInstaller " + Program.VERSION + "\n";
            lbSoftwareInfo.Text = softwareInfo;
        }

        private async void btnSelectModpack_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "选择文件";
            dlg.Filter = "模组包文件(*.l4d2mp)|";
            var result = dlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                string path = dlg.FileName;
                await Task.Run(() =>
                {
                    DeleteModCache();

                    lbExtractProgress.Text = "正在读取";
                    try
                    {
                        // ZipArchive arch = ZipFile.Open(path, ZipArchiveMode.Read, Encoding.UTF8);
                        // arch.ExtractToDirectory("cache\\mod");
                        ZipUtils.ExtractToDirectory(path, "cache\\mod");

                        lbExtractProgress.Text = "正在加载信息";
                        if (!File.Exists("cache\\mod\\manifest.json"))
                        {
                            lbExtractProgress.Text = "错误：模组信息不存在";
                            DeleteModCache();
                            return;
                        }

                        currentManifest = JsonConvert.DeserializeObject<Manifest>(File.ReadAllText("cache\\mod\\manifest.json"));
                        lbSelectedModpack.Text = currentManifest.name;
                        if (currentManifest.hasMainMod) lbHasMainMod.Text = "是否含有MainMod：是"; else lbHasMainMod.Text = "是否含有MainMod：否";

                        string voiceModStatus = "是否含有语音：";
                        if (currentManifest.hasVoice) voiceModStatus += "二代";
                        if (currentManifest.hasVoice && currentManifest.hasV1Voice) voiceModStatus += "+一代";
                        if (!currentManifest.hasVoice && !currentManifest.hasV1Voice) voiceModStatus += "否";
                        lbHasVoice.Text = voiceModStatus;

                        if (currentManifest.require18) lbIs18.Text = "是否为限制级：是"; else lbIs18.Text = "是否为限制级：否";

                        lbExtractProgress.Text = "预加载完成";
                    }
                    catch (Exception ex)
                    {
                        lbExtractProgress.Text = ex.Message;
                        File.WriteAllText("error.log", ex.ToString());
                        MessageBox.Show("加载出错，已输出详细错误信息：" + ex.ToString());
                        DeleteModCache();
                    }
                });
            }
            else
            {
                MessageBox.Show("文件选择失败");
            }
        }

        private void DeleteModCache()
        {
            if (Directory.Exists("cache\\mod"))
            {
                FileUtils.DeletFolder("cache\\mod");
            }
        }

        private async void btnCopyAndCompress_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "ZIP(*.zip)|";
            var result = dlg.ShowDialog();
            if (result != DialogResult.OK)
            {
                MessageBox.Show("文件选择失败");
                return;
            }

            await Task.Run(() =>
            {
                try
                {
                    L4D2.CopyAndCompressFile(tbInstallPath.Text, lbPreprocessProgress, pbPreprocess, dlg.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("备份出错：" + ex.ToString());
                }
            });
        }

        private async void btnStartPreprocess_Click(object sender, EventArgs e)
        {
            if (currentManifest == null)
            {
                MessageBox.Show("请先预加载模组包文件");
                return;
            }

            await Task.Run(() =>
            {
                L4D2.PreprocessFiles(tbInstallPath.Text, lbPreprocessProgress, currentManifest.hasVoice, currentManifest.hasV1Voice, currentManifest.hasMainMod);
            });
        }

        private void OnClose(object sender, FormClosedEventArgs e)
        {
            DeleteModCache();
        }

        private async void btnInstallMod_Click(object sender, EventArgs e)
        {
            if (currentManifest == null)
            {
                MessageBox.Show("请先加载模组文件");
                return;
            }

            if (currentManifest.require18 && !Program.config.allowLimitedContent)
            {
                MessageBox.Show("当前模组含有限制级内容，如需继续安装请在设置中确认");
                return;
            }

            if (Program.config.ignoreSecurityAlert)
            {
                bool detected = false;

                if (SecurityManager.CheckBinaryModification())
                {
                    detected = true;
                    MessageBox.Show("当前模组对游戏本体进行过多修改，如需继续安装请在设置中启用“忽略安全警报");
                }

                if (detected) return;
            }

            await Task.Run(() =>
            {
                // 安装文件
                if (currentManifest.hasMainMod)
                {
                    lbInstallProgress.Text = "安装主模组";
                    FileUtils.CopyDirToDir(Directory.GetCurrentDirectory() + "\\cache\\mod\\main", tbInstallPath.Text);
                }
                if (currentManifest.hasVoice)
                {
                    lbInstallProgress.Text = "安装二代音频";
                    FileUtils.CopyDirToDir(Directory.GetCurrentDirectory() + "\\cache\\mod\\voice\\v2\\voice", tbInstallPath.Text + "\\left4dead2\\sound\\player\\survivor\\voice");
                }
                if (currentManifest.hasV1Voice)
                {
                    lbInstallProgress.Text = "安装一代音频";
                    FileUtils.CopyDirToDir(Directory.GetCurrentDirectory() + "\\cache\\mod\\voice\\v1\\voice", tbInstallPath.Text + "\\left4dead2_dlc1\\sound\\player\\survivor\\voice");
                    FileUtils.CopyDirToDir(Directory.GetCurrentDirectory() + "\\cache\\mod\\voice\\v1\\voice", tbInstallPath.Text + "\\left4dead2_dlc2\\sound\\player\\survivor\\voice");
                    FileUtils.CopyDirToDir(Directory.GetCurrentDirectory() + "\\cache\\mod\\voice\\v1\\voice", tbInstallPath.Text + "\\left4dead2_dlc3\\sound\\player\\survivor\\voice");
                }
                MessageBox.Show("安装完成");
            });
        }

        private async void btnRestore_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                lbInstallProgress.Text = "移动文件中";
                Directory.Move(tbInstallPath.Text + "\\update_bak", tbInstallPath.Text + "\\update");
                lbInstallProgress.Text = "执行完成";
            });
        }

        private void btnRebuildAudioCache_Click(object sender, EventArgs e)
        {
            lbInstallProgress.Text = "正在启动游戏";
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "explorer.exe";
            psi.Arguments = "steam://rungameid/550//+novid +snd_rebuildaudiocache +exit";
            Process proc = new Process();
            proc.StartInfo = psi;
            proc.Start();
            proc.WaitForExit();
            lbInstallProgress.Text = "已启动游戏并执行命令";
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            new SettingsWindow().Visible = true;
        }
    }
}
