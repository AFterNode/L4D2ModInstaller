using L4D2ModInstaller.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L4D2ModInstaller.Ui
{
    public partial class FurtherModInfo : Form
    {
        private Manifest mf;

        public FurtherModInfo(Manifest mf)
        {
            InitializeComponent();

            this.mf = mf;
        }

        private void FurtherModInfo_Load(object sender, EventArgs e)
        {
            lbName.Text += mf.name;
            lbAuthor.Text += mf.author;
            tbComments.Text += mf.comment;
            if (mf.require18) lbIsLimited.Text += "是"; else lbIsLimited.Text += "否";
            if (mf.hasV1Voice) lbHasVoice1.Text += "是"; else lbHasVoice1.Text += "否";
            if (mf.hasVoice) lbHasVoice2.Text += "是"; else lbHasVoice2.Text += "否";
            if (mf.hasMainMod) lbHasMainMod.Text += "是"; else lbHasMainMod.Text += "否";
        }
    }
}
