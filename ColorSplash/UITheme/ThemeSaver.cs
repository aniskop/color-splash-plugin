using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorSplash.UITheme
{
    public class ThemeSaver
    {
        private Theme colorTheme;
        public ThemeSaver(Theme t)
        {
            colorTheme = t;
        }

        public void Save()
        {
            string personalPrefSets = PlsqlDeveloper.Instance.GetPersonalPrefSets();
            string ss = PlsqlDeveloper.Instance.IdeGetPrefAsString(ColorSplashPlugin.PluginId, "Default VM", "EditorFontName", "default value") +
                "//" + PlsqlDeveloper.Instance.IdeGetPrefAsString(ColorSplashPlugin.PluginId, "", "EditorFontName", "default value") +
                "::" + PlsqlDeveloper.Instance.IdeGetGeneralPref("EditorFontName");

            MessageBox.Show("personal pref sets=" + personalPrefSets + "\n prevalue=" + ss);
        }
    }
}
