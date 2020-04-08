using ColorSplash.PlsqlDeveloperDesign;
using System.Windows.Forms;

namespace ColorSplash.UITheme
{
    public sealed class ThemeFactory
    {
        private ThemeFactory() { }

        /// <summary>
        /// Initializes Theme attributes by PL/SQL Developer preferences value.
        /// Call after preferences has been loaded.
        /// </summary>
        /// <returns></returns>
        public static Theme CreateFromPreferences(PreferencesDictionary prefs)
        {
            Theme t = new Theme();
            InitializeSyntax(t, prefs);
            InitializeEditor(t, prefs);
            InitializeGrid(t, prefs);
            InitializeBrowser(t, prefs);
            InitializeError(t, prefs);
            t.HighlightColor = prefs.GetPreferenceColor(Preference.HIGHLIGHT_COLOR);
            t.SearchHitColor = prefs.GetPreferenceColor(Preference.SEARCH_HIT_COLOR);
            return t;
        }

        private static void InitializeSyntax(Theme t, PreferencesDictionary prefs)
        {
            InitializeKeywords(t, prefs);
            InitializeNumbers(t, prefs);
            InitializeStrings(t, prefs);
            InitializeComments(t, prefs);
            InitializeSymbols(t, prefs);
        }

        private static void InitializeKeywords(Theme t, PreferencesDictionary prefs)
        {
            t.Syntax.Keywords.FontColor = prefs.GetPreferenceColor(Preference.KEYWORDS_COLOR);
            t.Syntax.Keywords.BackgroundColor = prefs.GetPreferenceColor(Preference.KEYWORDS_BG_COLOR);
            t.Syntax.Keywords.Bold = prefs.GetPreferenceBool(Preference.KEYWORDS_BOLD);
            t.Syntax.Keywords.Italic = prefs.GetPreferenceBool(Preference.KEYWORDS_ITALIC);
        }

        private static void InitializeNumbers(Theme t, PreferencesDictionary prefs)
        {
            t.Syntax.Numbers.FontColor = prefs.GetPreferenceColor(Preference.NUMBERS_COLOR);
            t.Syntax.Numbers.BackgroundColor = prefs.GetPreferenceColor(Preference.NUMBERS_BG_COLOR);
            t.Syntax.Numbers.Bold = prefs.GetPreferenceBool(Preference.NUMBERS_BOLD);
            t.Syntax.Numbers.Italic = prefs.GetPreferenceBool(Preference.NUMBERS_ITALIC);
        }

        private static void InitializeStrings(Theme t, PreferencesDictionary prefs)
        {
            t.Syntax.Strings.FontColor = prefs.GetPreferenceColor(Preference.STRINGS_COLOR);
            t.Syntax.Strings.BackgroundColor = prefs.GetPreferenceColor(Preference.STRINGS_BG_COLOR);
            t.Syntax.Strings.Bold = prefs.GetPreferenceBool(Preference.STRINGS_BOLD);
            t.Syntax.Strings.Italic = prefs.GetPreferenceBool(Preference.STRINGS_ITALIC);
        }

        private static void InitializeComments(Theme t, PreferencesDictionary prefs)
        {
            t.Syntax.Comments.FontColor = prefs.GetPreferenceColor(Preference.COMMENTS_COLOR);
            t.Syntax.Comments.BackgroundColor = prefs.GetPreferenceColor(Preference.COMMENTS_BG_COLOR);
            t.Syntax.Comments.Bold = prefs.GetPreferenceBool(Preference.COMMENTS_BOLD);
            t.Syntax.Comments.Italic = prefs.GetPreferenceBool(Preference.COMMENTS_ITALIC);
        }

        private static void InitializeSymbols(Theme t, PreferencesDictionary prefs)
        {
            t.Syntax.Symbols.FontColor = prefs.GetPreferenceColor(Preference.SYMBOLS_COLOR);
            t.Syntax.Symbols.BackgroundColor = prefs.GetPreferenceColor(Preference.SYMBOLS_BG_COLOR);
            t.Syntax.Symbols.Bold = prefs.GetPreferenceBool(Preference.SYMBOLS_BOLD);
            t.Syntax.Symbols.Italic = prefs.GetPreferenceBool(Preference.SYMBOLS_ITALIC);
        }

        private static void InitializeEditor(Theme t, PreferencesDictionary prefs)
        {
            t.Editor.FontEffect.BackgroundColor = prefs.GetPreferenceColor(Preference.EDITOR_BG_COLOR);
            t.Editor.FontName = prefs.GetPreferenceString(Preference.EDITOR_FONT_NAME);
            t.Editor.FontSize = prefs.GetPreferenceInt(Preference.EDITOR_FONT_SIZE);
            t.Editor.FontEffect.FontColor = prefs.GetPreferenceColor(Preference.EDITOR_COLOR);
            t.Editor.FontEffect.Bold = prefs.GetPreferenceBool(Preference.EDITOR_BOLD);
            t.Editor.FontEffect.Italic = prefs.GetPreferenceBool(Preference.EDITOR_ITALIC);
        }

        private static void InitializeGrid(Theme t, PreferencesDictionary prefs)
        {
            t.Grid.BackgroundColor = prefs.GetPreferenceColor(Preference.GRID_BG_COLOR);
            t.Grid.FontColor = prefs.GetPreferenceColor(Preference.GRID_COLOR);
            t.Grid.NullValueColor = prefs.GetPreferenceColor(Preference.NULL_VALUE_COLOR);
            t.Grid.AlternateRowColor = prefs.GetPreferenceColor(Preference.ALTERNATE_ROW_COLOR);
        }

        private static void InitializeBrowser(Theme t, PreferencesDictionary prefs)
        {
            t.Browser.FontEffect.BackgroundColor = prefs.GetPreferenceColor(Preference.BROWSER_BG_COLOR);
            t.Browser.FontEffect.FontColor = prefs.GetPreferenceColor(Preference.BROWSER_COLOR);
            t.Browser.FontEffect.Bold = prefs.GetPreferenceBool(Preference.BROWSER_BOLD);
            t.Browser.FontEffect.Italic = prefs.GetPreferenceBool(Preference.BROWSER_ITALIC);
        }

        private static void InitializeError(Theme t, PreferencesDictionary prefs)
        {
            t.ErrorBackgroundColor = prefs.GetPreferenceColor(Preference.ERROR_BG_COLOR);
            t.ErrorTextColor = prefs.GetPreferenceColor(Preference.ERROR_COLOR);
        }

        /// <summary>
        /// Creates instance of ColorTheme from specified file.
        /// </summary>
        /// <returns></returns>
        public static Theme CreateFromFile()
        {
            return null;
        }
    }
}
