using ColorSplash.PlsqlDeveloperDesign;

namespace ColorSplash.UITheme
{
    public class Theme
    {
        public Theme()
        {
            Syntax = new SyntaxTheme();
            Editor = new EditorTheme();
            Grid = new GridTheme();
            Browser = new BrowserTheme();
            HighlightColor = new ColorPreference(Preference.HIGHLIGHT_COLOR, null);
            SearchHitColor = new ColorPreference(Preference.SEARCH_HIT_COLOR, null);
            ErrorTextColor = new ColorPreference(Preference.ERROR_COLOR, null);
            ErrorBackgroundColor = new ColorPreference(Preference.ERROR_BG_COLOR, null);
        }

        public string Name
        {
            get; set;
        }

        public SyntaxTheme Syntax
        {
            get; private set;
        }

        public EditorTheme Editor
        {
            get; set;
        }

        public GridTheme Grid
        {
            get; set;
        }

        public BrowserTheme Browser
        {
            get; set;
        }

        public ColorPreference HighlightColor
        {
            get; set;
        }

        public ColorPreference SearchHitColor
        {
            get; set;
        }

        public ColorPreference ErrorTextColor
        {
            get; set;
        }

        public ColorPreference ErrorBackgroundColor
        {
            get; set;
        }

    }
}

