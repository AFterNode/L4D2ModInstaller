using L4D2ModInstaller.Settings;
using Newtonsoft.Json;
using System.Text;

namespace L4D2ModInstaller
{
    internal static class Program
    {
        public const string VERSION = "1.0.0";
        public static string CONFIG_FILE = Directory.GetCurrentDirectory() + "\\config.json";

        public static Configuration config;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            // º”‘ÿ≈‰÷√
            try
            {
                if (!File.Exists(CONFIG_FILE))
                {
                    File.WriteAllText(CONFIG_FILE, JsonConvert.SerializeObject(new Configuration()));
                }
                var c = JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(CONFIG_FILE));
                if (c == null) config = new Configuration(); else config = c;
            } catch (Exception ex)
            {
                MessageBox.Show("≈‰÷√º”‘ÿ ß∞‹£¨Ω´ π”√ƒ¨»œ≈‰÷√£∫" + ex.ToString());
                config = new Configuration();
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow());
        }
    }
}