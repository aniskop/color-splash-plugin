using System;
using System.IO;
using ColorSplash.PlsqlDeveloperDesign;
using System.Windows.Forms;

namespace ColorSplash
{
    /// <summary>
    /// Description of PlsqlDevPreferences.
    /// </summary>
    public class PlsqlDeveloper
    {

        private static PlsqlDeveloper instance;
        private string prefFilePath = null;
        private bool preferencesLoaded = false;
        private string version = "13";

        public static PlsqlDeveloper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PlsqlDeveloper();
                }
                return instance;
            }
        }

        private PlsqlDeveloper()
        {
            Preferences = new PreferencesDictionary();
            prefFilePath = GetUserPreferencesFilePath();
            //LoadPreferences();
        }

        public PreferencesDictionary Preferences
        {
            get;
        }

        public void SavePreferences()
        {
            if (!preferencesLoaded)
            {
                return;
            }

            string original = CreateBackupFile();
            //to-do: check if backup created successfully
            StreamReader originalReader = new StreamReader(original);
            StreamWriter newWriter = new StreamWriter(prefFilePath);

            string line = null;
            string[] prop = null;
            char[] delim = { '=' };

            while ((line = originalReader.ReadLine()) != null)
            {
                /*
                 * If line contains setting editable by plugin
                 * then read value from array and write to file.
                 * Otherwise write the text from original file.
                 */
                if (Preference.ContainsHighlightPreference(line))
                {
                    prop = line.Split(delim);
                    newWriter.WriteLine(String.Format("{0}={1}", prop[0], Preferences.GetPreference(prop[0])));
                }
                else
                {
                    newWriter.WriteLine(line);
                }
            }

            originalReader.Close();
            newWriter.Close();
        }

        private string CreateBackupFile()
        {
            string backup = prefFilePath + ".bak";
            File.Copy(prefFilePath, backup, true);
            return backup;
        }

        public void LoadPreferences()
        {
            Preferences.Clear();
            LoadPreferencesFromFile(GetDefaultPreferencesFilePath());
            LoadPreferencesFromFile(GetUserPreferencesFilePath());
        }
        private void LoadPreferencesFromFile(string filePath)
        {
            if (File.Exists(prefFilePath))
            {
                StreamReader r = new StreamReader(prefFilePath);
                string line = null;
                string[] prop;
                char[] delim = { '=' };

                while ((line = r.ReadLine()) != null)
                {
                    if (Preference.ContainsHighlightPreference(line))
                    {
                        prop = line.Split(delim);
                        Preferences.SetPreference(prop[0], prop[1]);
                    }
                }

                r.Close();

                preferencesLoaded = true;
            }
            else
            {
                MessageBox.Show("Could not find preferences file \"" + prefFilePath + "\".", "Preferences not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetUserPreferencesFilePath()
        {
            /*if (IsWindows7())
            {*/
            return String.Format("{0}\\PLSQL Developer {1}\\Preferences\\{2}\\default.ini",
                                 System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                                 version,
                                 System.Environment.UserName);
            //}
            //return null;
        }

        private string GetDefaultPreferencesFilePath()
        {
            //TODO: use pl/sql dev home dir
            //TODO: also program files folder depends on 32/64 bit
            return String.Format(@"c:\program files\plsql developer {0}\Preferences\Default.ini", version);
        }

        private bool IsWindows7()
        {
            if ("Win32NT".Equals(Environment.OSVersion.Platform.ToString()))
            {
                char[] t = { '.' };
                string[] s = Environment.OSVersion.Version.ToString().Split(t);
                if ("6".Equals(s[0]) && "1".Equals(s[1]))
                {
                    return true;
                }

            }
            return false;
        }

    }
}
