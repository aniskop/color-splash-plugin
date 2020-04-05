using ColorSplash.PlsqlDeveloperDesign;

namespace ColorSplash.UITheme
{
    public class TextEffect
    {
        public TextEffect()
        {
            FontColor = null;
            BackgroundColor = null;
            Bold = null;
            Italic = null;
        }

        public ColorPreference FontColor
        {
            get; set;
        }

        public BoolPreference Bold
        {
            get; set;
        }

        public BoolPreference Italic
        {
            get; set;
        }

        public ColorPreference BackgroundColor
        {
            get; set;
        }

    }
}
