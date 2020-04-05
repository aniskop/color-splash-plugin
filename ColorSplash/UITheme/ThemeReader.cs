using System.IO;
using ColorSplash.PlsqlDeveloperDesign;

namespace ColorSplash.UITheme
{
    public sealed class ThemeReader
    {
        private ThemeReader() { }

        /// <summary>
        /// Saves ColorTheme instance to the specified file.
        /// </summary>
        /// <param name="theme"></param>
        public static Theme ReadFromFile(string fullPath)
        {
            PreferencesDictionary prefs = new PreferencesDictionary();

            StreamReader file = new StreamReader(fullPath);
            string line = null;
            string[] prop = null;

            while ((line = file.ReadLine()) != null)
            {
                prop = line.Split('=');
                prefs.SetPreference(prop[0], prop[1]);
            }
            file.Close();

            return ThemeFactory.CreateFromPreferences(prefs);
        }
    }
}
