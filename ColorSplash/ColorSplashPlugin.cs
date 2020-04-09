using System;
using ColorSplash.UITheme;
using RGiesecke.DllExport;
using System.IO;
using System.Windows.Forms;
using System.Collections;

namespace ColorSplash
{
    /// <summary>
    /// Description of MyClass.
    /// </summary>
    public class ColorSplashPlugin
    {
        private const int COLOR_SPLASH_MENU_INDEX = 1;

        [DllExport("IdentifyPlugIn", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static string IdentifyPlugIn(int id)
        {
            return "Color Splash (IDE color settings)";
        }

        [DllExport("CreateMenuItem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static string CreateMenuItem(int index)
        {
            if (index == COLOR_SPLASH_MENU_INDEX)
            {
                return "ITEM=Colors";
            }
            else return "";
        }

        [DllExport("OnMenuClick", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static void OnMenuClick(int index)
        {
            try
            {
                if (index == COLOR_SPLASH_MENU_INDEX)
                {
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
            catch (Exception e)
            {
                string lofFilePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Temp\\ColorSplashCrash.log";
                File.WriteAllText(lofFilePath, e.StackTrace);
                if (e.Data.Count > 0)
                {
                    File.AppendAllText(lofFilePath, "\n\nAdditional data:\n");
                    foreach (DictionaryEntry de in e.Data)
                    {
                        //TODO: inefficient open/close file on every write
                        File.AppendAllText(lofFilePath, "\"" + de.Key.ToString() + "\"=\"" + de.Value.ToString() + "\"\n");
                    }
                }
                //TODO: ask if user wants file to be opened
                MessageBox.Show(e.Message + "\nSee " + lofFilePath + " for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
