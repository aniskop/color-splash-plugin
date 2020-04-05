using ColorSplash.PlsqlDeveloperDesign;

namespace ColorSplash.UITheme
{
    public class BrowserTheme
    {
        public BrowserTheme()
        {
            FontEffect = new TextEffect();
            FontEffect.BackgroundColor = new ColorPreference(Preference.BROWSER_BG_COLOR, null);
            FontEffect.FontColor = new ColorPreference(Preference.BROWSER_COLOR, null);
            FontEffect.Bold = new BoolPreference(Preference.BROWSER_BOLD, false);
            FontEffect.Italic = new BoolPreference(Preference.BROWSER_ITALIC, false);
        }

        public TextEffect FontEffect
        {
            get; set;
        }
    }
}
