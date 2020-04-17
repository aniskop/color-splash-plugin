using System;
using System.IO;
using ColorSplash.PlsqlDeveloperDesign;
using System.Windows.Forms;
using System.Collections;

namespace ColorSplash
{
    /// <summary>
    /// Description of PlsqlDevPreferences.
    /// </summary>
    public class PlsqlDeveloper
    {

        private static PlsqlDeveloper instance;
        private string userPrefFilePath = null;
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
            userPrefFilePath = GetUserPreferencesFilePath();
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
            StreamWriter newWriter = new StreamWriter(userPrefFilePath);

            string line = null;
            string[] prop = null;
            char[] delim = { '=' };

            while ((line = originalReader.ReadLine()) != null)
            {
                if ("[Preferences]".Equals(line))
                {
                    // Print all color preferences first.
                    // Then just skip color settings from original file and write everthing else.
                    foreach (DictionaryEntry e in Preferences.AllPreferences)
                    {
                        newWriter.WriteLine(string.Format("{0}={1}", e.Key.ToString(), e.Value.ToString()));
                    }
                }

                // Just skip color preferences as thy were set before.
                // And write what has left.
                if (!Preference.ContainsHighlightPreference(line))
                {
                    newWriter.WriteLine(line);
                }
            }

            originalReader.Close();
            newWriter.Close();
        }

        private string CreateBackupFile()
        {
            string backup = userPrefFilePath + ".bak";
            File.Copy(userPrefFilePath, backup, true);
            return backup;
        }

        public void LoadPreferences()
        {
            Preferences.Clear();
            LoadPreferencesFromFile(GetSystemDefaultPreferencesFilePath());
            LoadPreferencesFromFile(GetUserPreferencesFilePath());
        }
        private void LoadPreferencesFromFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                StreamReader r = new StreamReader(filePath);
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
                MessageBox.Show("Could not find preferences file \"" + userPrefFilePath + "\".", "Preferences not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private string GetSystemDefaultPreferencesFilePath()
        {
            //TODO: use pl/sql dev home dir
            //TODO: also program files folder depends on 32/64 bit
            return string.Format(@"c:\program files\plsql developer {0}\Preferences\Default.ini", version);
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

        public string GetPersonalPrefSets()
        {
            return PlsqlDeveloperCallbacks.IdeGetPersonalPrefSets();
        }

        public string IdeGetPrefAsString(int pluginId, string prefSet, string name, string defaultValue)
        {
            return PlsqlDeveloperCallbacks.IdeGetPrefAsString(pluginId, prefSet, name, defaultValue);
        }

        public string IdeGetGeneralPref(string name)
        {
            return PlsqlDeveloperCallbacks.IdeGetGeneralPref(name);
        }
    }
}
