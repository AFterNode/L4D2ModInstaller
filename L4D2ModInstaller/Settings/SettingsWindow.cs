using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L4D2ModInstaller.Settings
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            Configuration c = Program.config;

            cbAllow18.Checked = c.allowLimitedContent;
            cbIgnoreSecurityAlert.Checked = c.ignoreSecurityAlert;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Configuration c = new Configuration();

                c.allowLimitedContent = cbAllow18.Checked;
                c.ignoreSecurityAlert = cbIgnoreSecurityAlert.Checked;

                Program.config = c;
                File.WriteAllText(Program.CONFIG_FILE, JsonConvert.SerializeObject(c));
            } catch (Exception ex)
            {
                MessageBox.Show("配置文件保存失败：" + ex.ToString());
            }
        }
    }
}
