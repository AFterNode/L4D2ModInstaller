using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L4D2ModInstaller.Utils
{
    internal class SteamUtil
    {
        public static string GetSteamInstallPath()
        {
            var s = Registry.GetValue("HKEY_CURRENT_USER\\Software\\Valve\\Steam", "SteamPath", null);
            if (s != null) return s.ToString().Replace("/", "\\"); else return "";
        }

        public static string GetL4D2InstallPath()
        {
            return GetSteamInstallPath() + "\\steamapps\\common\\Left 4 Dead 2";
        }
    }
}
