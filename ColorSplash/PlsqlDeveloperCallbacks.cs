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
    public delegate string IdeGetGeneralPrefCallback(string name);
    
    /// <summary>
    /// Description of PlsqlDeveloperCallbacks.
    /// </summary>
    public sealed class PlsqlDeveloperCallbacks
    {
        private PlsqlDeveloperCallbacks()
        {
        }
        private static IdeGetGeneralPrefCallback ideGetPref;
        
        public const int IDE_GET_GENERAL_PREF = 218;
        
        public static void RegisterCallback(int index, IntPtr func)
        {
            switch (index)
            {
                case IDE_GET_GENERAL_PREF:
                    ideGetPref = (IdeGetGeneralPrefCallback) Marshal.GetDelegateForFunctionPointer(func, typeof(IdeGetGeneralPrefCallback));
                    break;
                default:
                    throw new ArgumentException(String.Format("Unknown PL/SQL developer callback index {0}.", index));
            }
        }
        
        public static string IdeGetGeneralPref(string name)
        {
            if (ideGetPref == null)
            {
                return null;
            }
            return ideGetPref(name);
        }
        
    }
}
