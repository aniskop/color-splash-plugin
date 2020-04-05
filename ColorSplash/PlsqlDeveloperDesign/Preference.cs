namespace ColorSplash.PlsqlDeveloperDesign
{
    public sealed class Preference
    {
        public const string KEYWORDS_COLOR = "KeywordsColor";
        public const string KEYWORDS_BG_COLOR = "KeywordsBkg";
        public const string KEYWORDS_BOLD = "KeywordsBold";
        public const string KEYWORDS_ITALIC = "KeywordsItalic";

        public const string COMMENTS_COLOR = "CommentColor";
        public const string COMMENTS_BG_COLOR = "CommentBkg";
        public const string COMMENTS_BOLD = "CommentBold";
        public const string COMMENTS_ITALIC = "CommentItalic";

        public const string STRINGS_COLOR = "StringsColor";
        public const string STRINGS_BG_COLOR = "StringsBkg";
        public const string STRINGS_BOLD = "StringsBold";
        public const string STRINGS_ITALIC = "StringsItalic";

        public const string NUMBERS_COLOR = "NumbersColor";
        public const string NUMBERS_BG_COLOR = "NumbersBkg";
        public const string NUMBERS_BOLD = "NumbersBold";
        public const string NUMBERS_ITALIC = "NumbersItalic";

        public const string SYMBOLS_COLOR = "SymbolsColor";
        public const string SYMBOLS_BG_COLOR = "SymbolsBkg";
        public const string SYMBOLS_BOLD = "SymbolsBold";
        public const string SYMBOLS_ITALIC = "SymbolsItalic";

        public const string EDITOR_COLOR = "EditorFontColor";
        public const string EDITOR_BOLD = "EditorFontBold";
        public const string EDITOR_ITALIC = "EditorFontItalic";
        public const string EDITOR_BG_COLOR = "EditorBkg";
        public const string EDITOR_FONT_NAME = "EditorFontName";
        public const string EDITOR_FONT_SIZE = "EditorFontSize";

        public const string BROWSER_BG_COLOR = "BrowserBkg";
        public const string BROWSER_BOLD = "BrowserFontBold";
        public const string BROWSER_ITALIC = "BrowserFontItalic";
        public const string BROWSER_COLOR = "BrowserFontColor";

        public const string HIGHLIGHT_COLOR = "HighlightCol";
        public const string SEARCH_HIT_COLOR = "SearchHitCol";
        public const string ERROR_COLOR = "ErrorTextCol";
        public const string ERROR_BG_COLOR = "ErrorBkgCol";

        public const string GRID_BG_COLOR = "GridBkg";
        public const string GRID_COLOR = "GridFontColor";

        public const string NULL_VALUE_COLOR = "NullValueColor";

        public const string ALTERNATE_ROW_COLOR = "AltRowColor";

        private static string[] preferences =
        {
            KEYWORDS_COLOR,
            KEYWORDS_BG_COLOR,
            KEYWORDS_BOLD,
            KEYWORDS_ITALIC,

            COMMENTS_COLOR,
            COMMENTS_BG_COLOR,
            COMMENTS_BOLD,
            COMMENTS_ITALIC,

            STRINGS_COLOR,
            STRINGS_BG_COLOR,
            STRINGS_BOLD,
            STRINGS_ITALIC,

            NUMBERS_COLOR,
            NUMBERS_BG_COLOR,
            NUMBERS_BOLD,
            NUMBERS_ITALIC,

            SYMBOLS_COLOR,
            SYMBOLS_BG_COLOR,
            SYMBOLS_BOLD,
            SYMBOLS_ITALIC,

            EDITOR_COLOR,
            EDITOR_BOLD,
            EDITOR_ITALIC,
            EDITOR_BG_COLOR,
            EDITOR_FONT_NAME,
            EDITOR_FONT_SIZE,

            BROWSER_BG_COLOR,
            BROWSER_BOLD,
            BROWSER_ITALIC,
            BROWSER_COLOR,

            HIGHLIGHT_COLOR,
            SEARCH_HIT_COLOR,
            ERROR_COLOR,
            ERROR_BG_COLOR,

            GRID_BG_COLOR,
            GRID_COLOR,

            NULL_VALUE_COLOR,

            ALTERNATE_ROW_COLOR
        };

        private Preference()
        {

        }

        /// <summary>
        /// Checks if the preference given is related to syntax highlighting.
        /// </summary>
        /// <param name="name">Preference name</param>
        /// <returns></returns>
        public static bool IsHighlightPreference(string name)
        {
            for (int i = 0; i < preferences.Length; i++)
            {
                if (preferences[i].Equals(name))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ContainsHighlightPreference(string text)
        {
            if (text == null || "".Equals(text))
            {
                return false;
            }

            for (int i = 0; i < preferences.Length; i++)
            {
                /*
                 * PL/SQL developer syntax highlight preferences
                 * are listed in file as preference_name=value.
                 * So if the string given starts with preference name,
                 * then it is line with preference and its value.
                 */
                if (text.IndexOf(preferences[i]) == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
