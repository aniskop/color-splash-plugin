using ColorSplash.PlsqlDeveloperDesign;

namespace ColorSplash.UITheme
{
    public class SyntaxTheme
    {
        public SyntaxTheme()
        {
            Keywords = new TextEffect();
            Keywords.FontColor = new ColorPreference(Preference.KEYWORDS_COLOR, null);
            Keywords.BackgroundColor = new ColorPreference(Preference.KEYWORDS_BG_COLOR, null);
            Keywords.Bold = new BoolPreference(Preference.KEYWORDS_BOLD, false);
            Keywords.Italic = new BoolPreference(Preference.KEYWORDS_ITALIC, false);

            Numbers = new TextEffect();
            Numbers.FontColor = new ColorPreference(Preference.NUMBERS_COLOR, null);
            Numbers.BackgroundColor = new ColorPreference(Preference.NUMBERS_BG_COLOR, null);
            Numbers.Bold = new BoolPreference(Preference.NUMBERS_BOLD, false);
            Numbers.Italic = new BoolPreference(Preference.NUMBERS_ITALIC, false);

            Strings = new TextEffect();
            Strings.FontColor = new ColorPreference(Preference.STRINGS_COLOR, null);
            Strings.BackgroundColor = new ColorPreference(Preference.STRINGS_BG_COLOR, null);
            Strings.Bold = new BoolPreference(Preference.STRINGS_BOLD, false);
            Strings.Italic = new BoolPreference(Preference.STRINGS_ITALIC, false);

            Comments = new TextEffect();
            Comments.FontColor = new ColorPreference(Preference.COMMENTS_COLOR, null);
            Comments.BackgroundColor = new ColorPreference(Preference.COMMENTS_BG_COLOR, null);
            Comments.Bold = new BoolPreference(Preference.COMMENTS_BOLD, false);
            Comments.Italic = new BoolPreference(Preference.COMMENTS_ITALIC, false);

            Symbols = new TextEffect();
            Symbols.FontColor = new ColorPreference(Preference.SYMBOLS_COLOR, null);
            Symbols.BackgroundColor = new ColorPreference(Preference.SYMBOLS_BG_COLOR, null);
            Symbols.Bold = new BoolPreference(Preference.SYMBOLS_BOLD, false);
            Symbols.Italic = new BoolPreference(Preference.SYMBOLS_ITALIC, false);

        }

        public TextEffect Keywords
        {
            get; set;
        }

        public TextEffect Numbers
        {
            get; set;
        }

        public TextEffect Strings
        {
            get; set;
        }

        public TextEffect Comments
        {
            get; set;
        }

        public TextEffect Symbols
        {
            get; set;
        }
    }
}
