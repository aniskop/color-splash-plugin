/*
 * Created by SharpDevelop.
 * User: pavel
 * Date: 2015.03.07
 * Time: 21:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;

namespace ColorSplash
{
    /*
     * For each PL/SQL developer callback there is a constant for index value
     * and a delegate.
     */
    /// <summary>
    /// Delegate for PL/SQL developer IDE_GetGeneralPref function 
    /// </summary>
    public delegate IntPtr IdeGetGeneralPrefCallback(string name);
    public delegate IntPtr IdeGetPersonalPrefSetsCallback();
    public delegate IntPtr IdeGetPrefAsStringCallback(int pluginId, string prefSet, string name, string defaultValue);

    /// <summary>
    /// Description of PlsqlDeveloperCallbacks.
    /// </summary>
    public sealed class PlsqlDeveloperCallbacks
    {
        private PlsqlDeveloperCallbacks()
        {
        }
        private static IdeGetGeneralPrefCallback ideGetPref;
        private static IdeGetPersonalPrefSetsCallback ideGetPersonalPrefSets;
        private static IdeGetPrefAsStringCallback ideGetPrefAsString;

        public const int IDE_GET_PERSONAL_PREF_SETS = 210;
        public const int IDE_GET_GENERAL_PREF = 218;
        public const int IDE_GET_PREF_AS_STRING = 212;

        public static void RegisterCallback(int index, IntPtr func)
        {
            switch (index)
            {
                case IDE_GET_GENERAL_PREF:
                    ideGetPref = (IdeGetGeneralPrefCallback)Marshal.GetDelegateForFunctionPointer(func, typeof(IdeGetGeneralPrefCallback));
                    break;
                case IDE_GET_PERSONAL_PREF_SETS:
                    ideGetPersonalPrefSets = (IdeGetPersonalPrefSetsCallback)Marshal.GetDelegateForFunctionPointer(func, typeof(IdeGetPersonalPrefSetsCallback));
                    break;
                case IDE_GET_PREF_AS_STRING:
                    ideGetPrefAsString = (IdeGetPrefAsStringCallback)Marshal.GetDelegateForFunctionPointer(func, typeof(IdeGetPrefAsStringCallback));
                    break;
                default:
                    throw new ArgumentException(string.Format("Unknown PL/SQL developer callback index {0}.", index));
            }
        }

        public static string IdeGetGeneralPref(string name)
        {
            if (ideGetPref == null)
            {
                return null;
            }
            return Marshal.PtrToStringAnsi(ideGetPref(name));
        }

        public static string IdeGetPersonalPrefSets()
        {
            if (ideGetPersonalPrefSets == null)
            {
                return null;
            }
            IntPtr ptr = ideGetPersonalPrefSets();
            return Marshal.PtrToStringAnsi(ptr);
        }

        public static string IdeGetPrefAsString(int pluginId, string prefSet, string name, string defaultValue)
        {
            if (ideGetPrefAsString == null)
            {
                return null;
            }
            return Marshal.PtrToStringAnsi(ideGetPrefAsString(pluginId, prefSet, name, defaultValue));
        }

    }
}
