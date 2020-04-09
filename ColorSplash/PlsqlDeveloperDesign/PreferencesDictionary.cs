using System.Collections.Specialized;

namespace ColorSplash.PlsqlDeveloperDesign
{
    public class PreferencesDictionary
    {
        private StringDictionary prefs = null;

        public PreferencesDictionary()
        {
            prefs = new StringDictionary();
        }

        public string GetPreference(string name)
        {
            if (prefs.ContainsKey(name))
            {
                return prefs[name];
            }
            else
            {
                return string.Empty;
            }
        }

        //TODO: the caller may not change pointer to another dictionary
        public StringDictionary AllPreferences { get { return prefs; } }


        public IntPreference GetPreferenceInt(string name)
        {
            return new IntPreference(name, GetPreference(name));
        }

        public ColorPreference GetPreferenceColor(string name)
        {
            return new ColorPreference(name, GetPreference(name));
        }

        public BoolPreference GetPreferenceBool(string name)
        {
            return new BoolPreference(name, GetPreference(name));
        }

        public StringPreference GetPreferenceString(string name)
        {
            return new StringPreference(name, GetPreference(name));
        }

        /// <summary>
        /// Saves preference to cache as string value.
        /// Later it can be saved to file.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public void SetPreference(string name, string value)
        {
            prefs[name] = value;
        }

        public void SetPreference(ColorPreference p)
        {
            SetPreference(p.Name, p.ToString());
        }

        public void SetPreference(BoolPreference p)
        {
            SetPreference(p.Name, p.ToString());
        }

        public void SetPreference(IntPreference p)
        {
            SetPreference(p.Name, p.ToString());
        }

        public void SetPreference(StringPreference p)
        {
            SetPreference(p.Name, p.ToString());
        }

        public void Clear()
        {
            prefs.Clear();
        }
    }

}
