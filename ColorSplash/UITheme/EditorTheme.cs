using ColorSplash.PlsqlDeveloperDesign;

namespace ColorSplash.UITheme
{
    public class EditorTheme
    {
        public EditorTheme()
        {
            FontEffect = new TextEffect();
            FontEffect.BackgroundColor = new ColorPreference(Preference.EDITOR_BG_COLOR, null);
            FontEffect.FontColor = new ColorPreference(Preference.EDITOR_COLOR, null);
            FontEffect.Bold = new BoolPreference(Preference.EDITOR_BOLD, false);
            FontEffect.Italic = new BoolPreference(Preference.EDITOR_ITALIC, false);

            FontName = new StringPreference(Preference.EDITOR_FONT_NAME, "");
            FontSize = new IntPreference(Preference.EDITOR_FONT_SIZE, 10);
        }

        public TextEffect FontEffect
        {
            get; set;
        }

        public StringPreference FontName
        {
            get; set;
        }

        public IntPreference FontSize
        {
            get; set;
        }
    }
}
