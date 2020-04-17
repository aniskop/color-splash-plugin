using ColorSplash.UITheme;
using GreenBridge.Core;
using GreenBridge.Menu;

namespace ColorSplash
{
    public class ColorSplashPlugin : PlsqlDeveloperPlugin
    {
        public ColorSplashPlugin(int id, string name) : base(id, name)
        {
            RequiredCallbacks = new int[] { Callback.IDE_GET_GENERAL_PREF, Callback.IDE_GET_PERSONAL_PREF_SETS, Callback.IDE_GET_PREF_AS_STRING };
            Menu = new PlsqlDeveloperMenuBuilder().Group("Appearance").Item("Customize", Customize_Click).Build();
        }

        public static Theme CurrentTheme
        {
            get; set;
        }

        public static int PluginId
        {
            get
            {
                return 1; //TODO: fix
            }
        }

        private void Customize_Click(object sender, MenuEntryClickEventArgs e)
        {
            ColorSettingsForm f = new ColorSettingsForm();
            f.Text = "IDE colors";
            /*
             * Reread preferences each time before displaying the dialog
             * because someone might changed them using regular preferences dialog.
             */
            ColorSplash.PlsqlDeveloper.Instance.LoadPreferences();
            CurrentTheme = ThemeFactory.CreateFromPreferences(ColorSplash.PlsqlDeveloper.Instance.Preferences);
            f.InitializeByTheme(CurrentTheme);
            f.ShowDialog();
        }
    }
}
