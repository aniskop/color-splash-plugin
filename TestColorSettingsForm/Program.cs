using System;
using System.Windows.Forms;
using ColorSplash;
using ColorSplash.UITheme;
using ColorSplash.PlsqlDeveloperDesign;
using System.Drawing;

namespace TestColorSettingsForm
{
    /// <summary>
    /// Class with program entry point.
    /// </summary>
    internal sealed class Program
    {
        /// <summary>
        /// Program entry point.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Color c = Color.FromKnownColor(KnownColor.Red);
            //Color c = Color.FromArgb(255, Color.Red);

            /* ColorPreference cc = new ColorPreference("cc", c);
             Console.WriteLine(cc.ToFileString());


            */
            Console.WriteLine(1 << 1);
            Console.WriteLine(1 << 2);
            Color c = ValueFromString("16777164");
            Console.WriteLine(c);
            Console.WriteLine("Makestring=" + MakeString(c));

            ColorSplash.ColorSplashPlugin.CurrentTheme = ThemeReader.ReadFromFile(@"c:\temp\black.theme");

            PlsqlDeveloper.Instance.LoadPreferences();
            ColorSettingsForm f = new ColorSettingsForm();
            //Theme t = ThemeFactory.CreateFromPreferences(PlsqlDeveloper.Instance.Preferences);
			f.InitializeByTheme(ColorSplash.ColorSplashPlugin.CurrentTheme);
			Application.Run(f);
        }

        public static Color ValueFromString(string text)
        {
            int val = Convert.ToInt32(text);
            Console.WriteLine("int val=" + val);
            byte[] bytes = BitConverter.GetBytes(val);
            for (int i = 0; i < bytes.Length; i++)
            {
                Console.WriteLine("byte[" + i + "]=" + bytes[i]);
            }
            return Color.FromArgb(0, bytes[0], bytes[1], bytes[2]);
        }

        public static string MakeString(Color value)
        {
            // PL/SQL developer does not store alpha value, so always use 0
            //byte[] bytes = { value.B, value.G, value.R, 0 };
            //byte[] bytes = { 0, value.B, value.G, value.R };
            //int c = BitConverter.ToInt32(bytes, 0);
            int c = 0;
            byte[] b = { value.R, value.G, value.B, 0x00  };
            c = BitConverter.ToInt32(b, 0);
            /*if (!BitConverter.IsLittleEndian)
            {
                c = value.R;
                c = c << 8;
                c |= value.G;
                c = c << 8;
                c |= value.B;

            }
            else
            {
                Console.WriteLine("lit");
                c = value.B;
                c = c << 8;
                c |= value.G;
                c = c << 8;
                c |= value.R;
            }*/
            return Convert.ToString(c);
        }
    }
}
