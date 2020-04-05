/*
 * Created by SharpDevelop.
 * User: pavel
 * Date: 2015.03.27
 * Time: 21:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColorSplash
{
    /// <summary>
    /// Description of FullScreenImageForm.
    /// </summary>
    public partial class FullScreenImageForm : Form
    {
        private Color currentColor;
        
        public FullScreenImageForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
        
        void PicScreenMouseDown(object sender, MouseEventArgs e)
        {
            Bitmap bmp  = (Bitmap) picScreen.Image;
            currentColor = bmp.GetPixel(e.X, e.Y);
            Hide();
        }
        
        public Color CurrentColor
        {
            get { return currentColor; }
        }
    }
}
