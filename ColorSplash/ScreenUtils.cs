/*
 * Created by SharpDevelop.
 * User: pavel
 * Date: 2015.03.27
 * Time: 19:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace ColorSplash
{
    /// <summary>
    /// Description of Class1.
    /// </summary>
    public class ScreenUtils
        
    {
        private ScreenUtils()
        {
        }
        
        /// <summary>
        /// Makes screenshot of primary display.
        /// </summary>
        /// <returns>Screenshot as a Bitmap.</returns>
        public static Bitmap Screenshot()
        {
            Bitmap scr = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppRgb);
            Graphics gfx = Graphics.FromImage(scr);
            gfx.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                               Screen.PrimaryScreen.Bounds.Y,
                               0, 0,
                               Screen.PrimaryScreen.Bounds.Size,
                               CopyPixelOperation.SourceCopy);
            return scr;
        }
    }
}
