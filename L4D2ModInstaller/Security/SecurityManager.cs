using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4D2ModInstaller.Security
{
    internal class SecurityManager
    {
        public static bool CheckBinaryModification()
        {
            return File.Exists("\\cache\\mod\\main\\bin");
        }
    }
}
