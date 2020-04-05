using System.Windows.Forms;
using System.Drawing;
/*
 * Created by SharpDevelop.
 * User: pavel
 * Date: 2015.03.27
 * Time: 21:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
 
namespace ColorSplash
{
    partial class FullScreenImageForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        
        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            this.picScreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // picScreen
            // 
            this.picScreen.Location = new System.Drawing.Point(12, 12);
            this.picScreen.Name = "picScreen";
            this.picScreen.Size = new System.Drawing.Size(345, 217);
            this.picScreen.TabIndex = 0;
            this.picScreen.TabStop = false;
            this.picScreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicScreenMouseDown);
            // 
            // FullScreenImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 241);
            this.Controls.Add(this.picScreen);
            this.Name = "FullScreenImageForm";
            this.Text = "FullScreenImageForm";
            this.Load += new System.EventHandler(this.FullScreenImageFormLoad);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FullScreenImageFormKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picScreen)).EndInit();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.PictureBox picScreen;
        
        void FullScreenImageFormLoad(object sender, System.EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            picScreen.Top = 0;
            picScreen.Left = 0;
            picScreen.Height = Height;
            picScreen.Width = Width;
        }
        
        void FullScreenImageFormKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        
        public void SetImage(Bitmap img)
        {
            picScreen.Image = img;
        }
    }
}
