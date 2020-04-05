using System;
using ColorSplash.UITheme;
using RGiesecke.DllExport;

namespace ColorSplash
{
    /// <summary>
    /// Description of MyClass.
    /// </summary>
    public class ColorSplashPlugin
    {
        private const int COLOR_SPLASH_MENU_INDEX = 1;

        [DllExport("IdentifyPlugIn", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static string IdentifyPlugIn(int id) {
            return "Color Splash (IDE color settings)";
        }
        
        [DllExport("CreateMenuItem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static string CreateMenuItem(int index) {
            if (index == COLOR_SPLASH_MENU_INDEX) {
                return "ITEM=Colors";
            } else return "";
        }
        
        [DllExport("OnMenuClick", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static void OnMenuClick(int index) {
            if (index == COLOR_SPLASH_MENU_INDEX) {
                ColorSettingsForm f = new ColorSettingsForm();
                f.Text = "IDE colors";
                /*
                 * Reread preferences each time before displaying the dialog
                 * because someone might changed them using regular preferences dialog.
                 */
                PlsqlDeveloper.Instance.LoadPreferences();
                CurrentTheme = ThemeFactory.CreateFromPreferences(PlsqlDeveloper.Instance.Preferences);
                f.InitializeByTheme(CurrentTheme);
                f.ShowDialog();
            }
        }
        
        [DllExport("RegisterCallback", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static void RegisterCallback(int index, IntPtr func)
        {
            if (index == PlsqlDeveloperCallbacks.IDE_GET_GENERAL_PREF)
            {
                PlsqlDeveloperCallbacks.RegisterCallback(index, func);
            }
        }

        public static Theme CurrentTheme
        {
            get; set;
        }
    }
}
