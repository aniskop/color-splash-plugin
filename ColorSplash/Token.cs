/*
 * Created by SharpDevelop.
 * User: pavel
 * Date: 2015.03.03
 * Time: 18:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ColorSplash
{
    /// <summary>
    /// Description of TokenInfo.
    /// </summary>
    public class Token
    {
        private int offset;
        private string text;
        private bool isHighlighted = false;
        
        public Token(int offset, string text)
        {
            init(offset, text, false);
        }
        
        public Token(int offset, string text, bool highlighted)
        {
            init(offset, text, highlighted);
        }

        private void init(int offset, string text, bool highlighted)
        {
            this.offset = offset;
            this.text = text;
            this.isHighlighted = highlighted;
        }
        
        public int Offset
        {
            get { return offset; }
        }
        
        public string Text
        {
            get { return text; }
        }
        public int Length
        {
            get { return text.Length; }
        }
        
        public bool Highlighted
        {
            get { return isHighlighted; }
        }
    }
}
