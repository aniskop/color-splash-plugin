using System.IO;

namespace ColorSplash.UITheme
{
    public sealed class ThemeWriter
    {
        private ThemeWriter() { }

        /// <summary>
        /// Saves ColorTheme instance to the specified file.
        /// </summary>
        /// <param name="theme"></param>
        public static void SaveToFile(Theme theme, string fullPath)
        {
            StreamWriter file = new StreamWriter(fullPath);

            WriteKeywords(theme, file);
            WriteNumbers(theme, file);
            WriteStrings(theme, file);
            WriteComments(theme, file);
            WriteSymbols(theme, file);
            WriteEditor(theme, file);
            WriteGrid(theme, file);
            WriteBrowser(theme, file);
            WriteError(theme, file);

            file.WriteLine(theme.HighlightColor.ToFileString());
            file.WriteLine(theme.SearchHitColor.ToFileString());

            file.Close();
        }

        private static void WriteKeywords(Theme t, StreamWriter file)
        {
            file.WriteLine(t.Syntax.Keywords.FontColor.ToFileString());
            file.WriteLine(t.Syntax.Keywords.BackgroundColor.ToFileString());
            file.WriteLine(t.Syntax.Keywords.Bold.ToFileString());
            file.WriteLine(t.Syntax.Keywords.Italic.ToFileString());
        }

        private static void WriteNumbers(Theme t, StreamWriter file)
        {
            file.WriteLine(t.Syntax.Numbers.FontColor.ToFileString());
            file.WriteLine(t.Syntax.Numbers.BackgroundColor.ToFileString());
            file.WriteLine(t.Syntax.Numbers.Bold.ToFileString());
            file.WriteLine(t.Syntax.Numbers.Italic.ToFileString());
        }

        private static void WriteStrings(Theme t, StreamWriter file)
        {
            file.WriteLine(t.Syntax.Strings.FontColor.ToFileString());
            file.WriteLine(t.Syntax.Strings.BackgroundColor.ToFileString());
            file.WriteLine(t.Syntax.Strings.Bold.ToFileString());
            file.WriteLine(t.Syntax.Strings.Italic.ToFileString());
        }

        private static void WriteComments(Theme t, StreamWriter file)
        {
            file.WriteLine(t.Syntax.Comments.FontColor.ToFileString());
            file.WriteLine(t.Syntax.Comments.BackgroundColor.ToFileString());
            file.WriteLine(t.Syntax.Comments.Bold.ToFileString());
            file.WriteLine(t.Syntax.Comments.Italic.ToFileString());
        }

        private static void WriteSymbols(Theme t, StreamWriter file)
        {
            file.WriteLine(t.Syntax.Symbols.FontColor.ToFileString());
            file.WriteLine(t.Syntax.Symbols.BackgroundColor.ToFileString());
            file.WriteLine(t.Syntax.Symbols.Bold.ToFileString());
            file.WriteLine(t.Syntax.Symbols.Italic.ToFileString());
        }

        private static void WriteEditor(Theme t, StreamWriter file)
        {
            file.WriteLine(t.Editor.FontEffect.BackgroundColor.ToFileString());
            file.WriteLine(t.Editor.FontName.ToFileString());
            file.WriteLine(t.Editor.FontSize.ToFileString());
            file.WriteLine(t.Editor.FontEffect.FontColor.ToFileString());
            file.WriteLine(t.Editor.FontEffect.Bold.ToFileString());
            file.WriteLine(t.Editor.FontEffect.Italic.ToFileString());
        }

        private static void WriteGrid(Theme t, StreamWriter file)
        {
            file.WriteLine(t.Grid.BackgroundColor.ToFileString());
            file.WriteLine(t.Grid.FontColor.ToFileString());
            file.WriteLine(t.Grid.NullValueColor.ToFileString());
            file.WriteLine(t.Grid.AlternateRowColor.ToFileString());
        }

        private static void WriteBrowser(Theme t, StreamWriter file)
        {
            file.WriteLine(t.Browser.FontEffect.BackgroundColor.ToFileString());
            file.WriteLine(t.Browser.FontEffect.FontColor.ToFileString());
            file.WriteLine(t.Browser.FontEffect.Bold.ToFileString());
            file.WriteLine(t.Browser.FontEffect.Italic.ToFileString());
        }

        private static void WriteError(Theme t, StreamWriter file)
        {
            file.WriteLine(t.ErrorBackgroundColor.ToFileString());
            file.WriteLine(t.ErrorTextColor.ToFileString());
        }
    }
}
