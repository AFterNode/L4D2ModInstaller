using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4D2ModInstaller.Utils
{
    public class Manifest
    {
        public string name = "";
        public bool hasMainMod = false;
        public bool hasVoice = false;
        public bool hasV1Voice = false;

        // 是否为限制级
        public bool require18 = false;

        // 作者
        public string author = "未指定";
        // 备注
        public string comment = "";
    }
}
