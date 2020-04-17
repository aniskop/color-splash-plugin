using RGiesecke.DllExport;
using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace ColorSplash
{
    public class ColorSplashPluginFacade
    {
        private static ColorSplashPlugin Me;

        [DllExport("IdentifyPlugIn", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static string IdentifyPlugIn(int id)
        {
            Me = new ColorSplashPlugin(id, "Color Splash (IDE color settings)");
            return Me.Name;
        }

        [DllExport("CreateMenuItem", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static string CreateMenuItem(int index)
        {
            return Me.Menu.Entry(index).ToString();
        }

        [DllExport("OnMenuClick", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        public static void OnMenuClick(int index)
        {
            try
            {
                Me.Menu.HandleClick(index);
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
            Me.RegisterRequiredCallback(index, func);
        }
    }
}
