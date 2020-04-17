using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using ColorSplash.PlsqlDeveloperDesign;
using ColorSplash.UITheme;

namespace ColorSplash
{
    /// <summary>
    /// Description of ColorSettingsForm.
    /// </summary>
    public partial class ColorSettingsForm : Form
    {
        public ColorSettingsForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        void BtnEditorBgColorClick(object sender, EventArgs e)
        {
            ChooseColor(richSampleCode, ColorSplashPlugin.CurrentTheme.Editor.FontEffect.BackgroundColor, null);
            btnEditorBgColor.BackColor = richSampleCode.BackColor;

            SetThemeAndPreference(ColorSplashPlugin.CurrentTheme.Syntax.Keywords.BackgroundColor, btnEditorBgColor.BackColor);
            SetThemeAndPreference(ColorSplashPlugin.CurrentTheme.Syntax.Numbers.BackgroundColor, btnEditorBgColor.BackColor);
            SetThemeAndPreference(ColorSplashPlugin.CurrentTheme.Syntax.Strings.BackgroundColor, btnEditorBgColor.BackColor);
            SetThemeAndPreference(ColorSplashPlugin.CurrentTheme.Syntax.Comments.BackgroundColor, btnEditorBgColor.BackColor);
            SetThemeAndPreference(ColorSplashPlugin.CurrentTheme.Syntax.Symbols.BackgroundColor, btnEditorBgColor.BackColor);
        }

        #region My custom methods

        private delegate void ColorPickCallback();

        private FontStyle GetStyle(bool bold, bool italic)
        {
            FontStyle newStyle = FontStyle.Regular;
            if (bold)
            {
                newStyle = newStyle | FontStyle.Bold;
            }

            if (italic)
            {
                newStyle = newStyle | FontStyle.Italic;
            }
            return newStyle;
        }

        void Update(List<Token> tokens, Color fontColor, bool fontBold, bool fontItalic)
        {
            if (tokens == null)
            {
                return;
            }

            foreach (Token t in tokens)
            {
                richSampleCode.Select(t.Offset, t.Length);
                richSampleCode.SelectionColor = fontColor;
                Font currentFont = richSampleCode.SelectionFont;
                richSampleCode.SelectionFont = new Font(currentFont, GetStyle(fontBold, fontItalic));
                if (SampleCode.Instance.IsHighlighted(t.Text))
                {
                    richSampleCode.SelectionBackColor = btnHlightColor.BackColor;
                }
            }
        }

        void UpdateKeywords()
        {
            Update(SampleCode.Instance.Keywords, btnKeywordsColor.BackColor, chkKeywordsBold.Checked, chkKeywordsItalic.Checked);
        }

        void UpdateComments()
        {
            Update(SampleCode.Instance.Comments, btnCommentsColor.BackColor, chkCommentsBold.Checked, chkCommentsItalic.Checked);
        }

        void UpdateStrings()
        {
            Update(SampleCode.Instance.Strings, btnStringsColor.BackColor, chkStringsBold.Checked, chkStringsItalic.Checked);
        }

        void UpdateNumbers()
        {
            Update(SampleCode.Instance.Numbers, btnNumbersColor.BackColor, chkNumbersBold.Checked, chkNumbersItalic.Checked);
        }

        void UpdateSymbols()
        {
            Update(SampleCode.Instance.Delimiters, btnSymbolsColor.BackColor, chkSymbolsBold.Checked, chkSymbolsItalic.Checked);
        }

        void UpdateIdentifiers()
        {
            Update(SampleCode.Instance.Identifiers, btnEditorColor.BackColor, chkEditorBold.Checked, chkEditorItalic.Checked);
        }

        void PickColor(Button dest, ColorPreference p, ColorPickCallback callback)
        {
            Cursor old = Cursor.Current;
            Cursor.Current = new Cursor(Properties.Resources.picker_icon.GetHbitmap());
            Bitmap shot = ScreenUtils.Screenshot();
            FullScreenImageForm form = new FullScreenImageForm();
            form.SetImage(shot);
            form.ShowDialog();
            Show();

            if (form.CurrentColor != null)
            {
                dest.BackColor = form.CurrentColor;
                SetThemeAndPreference(p, dest.BackColor);
                PlsqlDeveloper.Instance.Preferences.SetPreference(p);

                form.Dispose();
                shot.Dispose();
                if (callback != null)
                {
                    callback();
                }
            }
            Cursor.Current = old;
        }

        void ChooseColor(Control dest, ColorPreference p, ColorPickCallback callback)
        {
            dlgColor.Color = dest.BackColor;

            DialogResult result = dlgColor.ShowDialog();
            if (result == DialogResult.OK)
            {
                dest.BackColor = dlgColor.Color;
                SetThemeAndPreference(p, dest.BackColor);
                PlsqlDeveloper.Instance.Preferences.SetPreference(p);
                if (callback != null)
                {
                    callback();
                }
            }
        }
        #endregion

        void BtnKeywordsColorClick(object sender, EventArgs e)
        {
            ChooseColor(btnKeywordsColor, ColorSplashPlugin.CurrentTheme.Syntax.Keywords.FontColor, UpdateKeywords);
        }

        void BtnCommentsColorClick(object sender, EventArgs e)
        {
            ChooseColor(btnCommentsColor, ColorSplashPlugin.CurrentTheme.Syntax.Comments.FontColor, UpdateComments);
        }

        void BtnStringsColorClick(object sender, EventArgs e)
        {
            ChooseColor(btnStringsColor, ColorSplashPlugin.CurrentTheme.Syntax.Strings.FontColor, UpdateStrings);
        }

        void BtnNumbersColorClick(object sender, EventArgs e)
        {
            ChooseColor(btnNumbersColor, ColorSplashPlugin.CurrentTheme.Syntax.Numbers.FontColor, UpdateNumbers);
        }

        void BtnSymbolsColorClick(object sender, EventArgs e)
        {
            ChooseColor(btnSymbolsColor, ColorSplashPlugin.CurrentTheme.Syntax.Symbols.FontColor, UpdateSymbols);
        }

        void ChkKeywordsItalicCheckedChanged(object sender, EventArgs e)
        {
            SetThemeAndPreference(ColorSplashPlugin.CurrentTheme.Syntax.Keywords.Italic, chkKeywordsItalic.Checked);
            UpdateKeywords();
        }

        void ChkCommentsBoldCheckedChanged(object sender, EventArgs e)
        {
            SetThemeAndPreference(ColorSplashPlugin.CurrentTheme.Syntax.Comments.Bold, chkCommentsBold.Checked);
            UpdateComments();
        }

        void ChkCommentsItalicCheckedChanged(object sender, EventArgs e)
        {
            SetThemeAndPreference(ColorSplashPlugin.CurrentTheme.Syntax.Comments.Italic, chkCommentsItalic.Checked);
            UpdateComments();
        }

        void ChkStringsBoldCheckedChanged(object sender, EventArgs e)
        {
            SetThemeAndPreference(ColorSplashPlugin.CurrentTheme.Syntax.Strings.Bold, chkStringsBold.Checked);
            UpdateStrings();
        }

        void ChkStringsItalicCheckedChanged(object sender, EventArgs e)
        {
            SetThemeAndPreference(ColorSplashPlugin.CurrentTheme.Syntax.Strings.Italic, chkStringsItalic.Checked);
            UpdateStrings();
        }

        void ChkNumbersBoldCheckedChanged(object sender, EventArgs e)
        {
            SetThemeAndPreference(ColorSplashPlugin.CurrentTheme.Syntax.Numbers.Bold, chkNumbersBold.Checked);
            UpdateNumbers();
        }

        void ChkNumbersItalicCheckedChanged(object sender, EventArgs e)
        {
            SetThemeAndPreference(ColorSplashPlugin.CurrentTheme.Syntax.Numbers.Italic, chkNumbersItalic.Checked);
            UpdateNumbers();
        }

        void ChkSymbolsBoldCheckedChanged(object sender, EventArgs e)
        {
            SetThemeAndPreference(ColorSplashPlugin.CurrentTheme.Syntax.Symbols.Bold, chkSymbolsBold.Checked);
            UpdateSymbols();
        }

        void ChkSymbolsItalicCheckedChanged(object sender, EventArgs e)
        {
            SetThemeAndPreference(ColorSplashPlugin.CurrentTheme.Syntax.Symbols.Italic, chkSymbolsItalic.Checked);
            UpdateSymbols();
        }

        void ChkKeywordsBoldCheckedChanged(object sender, System.EventArgs e)
        {
            SetThemeAndPreference(ColorSplashPlugin.CurrentTheme.Syntax.Keywords.Bold, chkKeywordsBold.Checked);
            UpdateKeywords();
        }
        public void InitializeByTheme(Theme theme)
        {
            richSampleCode.Text = SampleCode.Instance.Text;

            InitializeSyntax(theme);
            InitializeEditor(theme);
            InitializeGrid(theme);
            InitializeBrowser(theme);

            btnHlightColor.BackColor = theme.HighlightColor.Value;
            btnSearchHitColor.BackColor = theme.SearchHitColor.Value;
            btnErrorBgColor.BackColor = theme.ErrorBackgroundColor.Value;
            btnErrorTxtColor.BackColor = theme.ErrorTextColor.Value;

            UpdatePreview();
        }


        private void InitializeSyntax(Theme theme)
        {
            btnKeywordsColor.BackColor = theme.Syntax.Keywords.FontColor.Value;
            chkKeywordsBold.Checked = theme.Syntax.Keywords.Bold.Value;
            chkKeywordsItalic.Checked = theme.Syntax.Keywords.Italic.Value;

            btnCommentsColor.BackColor = theme.Syntax.Comments.FontColor.Value;
            chkCommentsBold.Checked = theme.Syntax.Comments.Bold.Value;
            chkCommentsItalic.Checked = theme.Syntax.Comments.Italic.Value;

            btnNumbersColor.BackColor = theme.Syntax.Numbers.FontColor.Value;
            chkNumbersBold.Checked = theme.Syntax.Numbers.Bold.Value;
            chkNumbersItalic.Checked = theme.Syntax.Numbers.Italic.Value;

            btnSymbolsColor.BackColor = theme.Syntax.Symbols.FontColor.Value;
            chkSymbolsBold.Checked = theme.Syntax.Symbols.Bold.Value;
            chkSymbolsItalic.Checked = theme.Syntax.Symbols.Italic.Value;

            btnStringsColor.BackColor = theme.Syntax.Strings.FontColor.Value;
            chkStringsBold.Checked = theme.Syntax.Strings.Bold.Value;
            chkStringsItalic.Checked = theme.Syntax.Strings.Italic.Value;
        }

        private void InitializeEditor(Theme theme)
        {
            chkEditorBold.Checked = theme.Editor.FontEffect.Bold.Value;
            chkEditorItalic.Checked = theme.Editor.FontEffect.Italic.Value;

            //TODO: correct handle color when it is not in preferences
            if (theme.Editor.FontEffect.FontColor.Value.IsEmpty)
            {
                btnEditorColor.BackColor = Color.White;
            }
            else
            {
                btnEditorColor.BackColor = theme.Editor.FontEffect.FontColor.Value;
            }

            richSampleCode.Font = new Font(theme.Editor.FontName.Value,
                //TODO: deafult font size
                                           Math.Max(theme.Editor.FontSize.Value, 10),
                                           GetStyle(chkEditorBold.Checked, chkEditorItalic.Checked));

            btnEditorBgColor.BackColor = theme.Editor.FontEffect.BackgroundColor.Value;
            richSampleCode.BackColor = btnEditorBgColor.BackColor;
        }

        private void InitializeGrid(Theme theme)
        {
            btnGridBgColor.BackColor = theme.Grid.BackgroundColor.Value;
            btnNullColor.BackColor = theme.Grid.NullValueColor.Value;
            btnAlternateColor.BackColor = theme.Grid.AlternateRowColor.Value;
        }

        private void InitializeBrowser(Theme theme)
        {
            btnBrowserBgColor.BackColor = theme.Browser.FontEffect.BackgroundColor.Value;
            btnBrowserFont.BackColor = theme.Browser.FontEffect.FontColor.Value;
            chkBrowserBold.Checked = theme.Browser.FontEffect.Bold.Value;
            chkBrowserItalic.Checked = theme.Browser.FontEffect.Italic.Value;
        }


        void ColorSettingsFormLoad(object sender, EventArgs e)
        {
            UpdatePreview();
            // Reset the selection and position cursor at the beginning
            richSampleCode.Select(0, 0);
        }

        void BtnCancelClick(object sender, EventArgs e)
        {
            Close();
        }

        void BtnOKClick(object sender, EventArgs e)
        {
            ColorSplashPlugin.CurrentTheme.Grid.FontColor.Value = ColorSplashPlugin.CurrentTheme.Editor.FontEffect.FontColor.Value;
            SaveThemeToPreferences(ColorSplashPlugin.CurrentTheme);
            PlsqlDeveloper.Instance.SavePreferences();
            MessageBox.Show("Successfully saved.\nChanges will take effect after you restart PL/SQL Developer.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            Close();
        }

        void ChkEditorBoldCheckedChanged(object sender, EventArgs e)
        {
            SetThemeAndPreference(ColorSplashPlugin.CurrentTheme.Editor.FontEffect.Bold, chkEditorBold.Checked);
            UpdateIdentifiers();
        }

        void ChkEditorItalicCheckedChanged(object sender, EventArgs e)
        {
            SetThemeAndPreference(ColorSplashPlugin.CurrentTheme.Editor.FontEffect.Italic, chkEditorItalic.Checked);
            UpdateIdentifiers();
        }

        void BtnEditorBgPickerClick(object sender, EventArgs e)
        {
            PickColor(btnEditorBgColor, ColorSplashPlugin.CurrentTheme.Editor.FontEffect.BackgroundColor, null);
            richSampleCode.BackColor = btnEditorBgColor.BackColor;
            SetThemeAndPreference(ColorSplashPlugin.CurrentTheme.Syntax.Keywords.BackgroundColor, btnEditorBgColor.BackColor);
            SetThemeAndPreference(ColorSplashPlugin.CurrentTheme.Syntax.Numbers.BackgroundColor, btnEditorBgColor.BackColor);
            SetThemeAndPreference(ColorSplashPlugin.CurrentTheme.Syntax.Strings.BackgroundColor, btnEditorBgColor.BackColor);
            SetThemeAndPreference(ColorSplashPlugin.CurrentTheme.Syntax.Comments.BackgroundColor, btnEditorBgColor.BackColor);
            SetThemeAndPreference(ColorSplashPlugin.CurrentTheme.Syntax.Symbols.BackgroundColor, btnEditorBgColor.BackColor);

        }

        void BtnKeywordsPickerClick(object sender, System.EventArgs e)
        {
            PickColor(btnKeywordsColor, ColorSplashPlugin.CurrentTheme.Syntax.Keywords.FontColor, UpdateKeywords);
        }


        void BtnCommentsPickerClick(object sender, EventArgs e)
        {
            PickColor(btnCommentsColor, ColorSplashPlugin.CurrentTheme.Syntax.Comments.FontColor, UpdateComments);
        }

        void BtnSymbolsPickerClick(object sender, EventArgs e)
        {
            PickColor(btnSymbolsColor, ColorSplashPlugin.CurrentTheme.Syntax.Symbols.FontColor, UpdateSymbols);
        }

        void BtnStringsPickerClick(object sender, EventArgs e)
        {
            PickColor(btnStringsColor, ColorSplashPlugin.CurrentTheme.Syntax.Strings.FontColor, UpdateStrings);
        }

        void BtnNumbersPickerClick(object sender, EventArgs e)
        {
            PickColor(btnNumbersColor, ColorSplashPlugin.CurrentTheme.Syntax.Numbers.FontColor, UpdateNumbers);
        }

        void BtnHlightPickerClick(object sender, EventArgs e)
        {
            PickColor(btnHlightColor, ColorSplashPlugin.CurrentTheme.HighlightColor, null);
            // These are highlighted.
            // Specified at SampleCode.IsHighlighted method.
            UpdateIdentifiers();
            UpdateKeywords();
        }

        void BtnEditorColorClick(object sender, System.EventArgs e)
        {
            ChooseColor(btnEditorColor, ColorSplashPlugin.CurrentTheme.Editor.FontEffect.FontColor, UpdateIdentifiers);
        }

        void BtnEditorPickerClick(object sender, System.EventArgs e)
        {
            PickColor(btnEditorColor, ColorSplashPlugin.CurrentTheme.Editor.FontEffect.FontColor, UpdateIdentifiers);
        }

        private void btnErrorBgPicker_Click(object sender, EventArgs e)
        {
            PickColor(btnErrorBgColor, ColorSplashPlugin.CurrentTheme.ErrorBackgroundColor, null);
        }

        private void btnGridBgColor_Click(object sender, EventArgs e)
        {
            ChooseColor(btnGridBgColor, ColorSplashPlugin.CurrentTheme.Grid.BackgroundColor, null);
        }

        private void btnNullColor_Click(object sender, EventArgs e)
        {
            ChooseColor(btnNullColor, ColorSplashPlugin.CurrentTheme.Grid.NullValueColor, null);
        }

        private void btnAlternateColor_Click(object sender, EventArgs e)
        {
            ChooseColor(btnAlternateColor, ColorSplashPlugin.CurrentTheme.Grid.AlternateRowColor, null);
        }

        private void btnGridBgPicker_Click(object sender, EventArgs e)
        {
            PickColor(btnGridBgColor, ColorSplashPlugin.CurrentTheme.Grid.BackgroundColor, null);
        }

        private void btnNullPicker_Click(object sender, EventArgs e)
        {
            PickColor(btnNullColor, ColorSplashPlugin.CurrentTheme.Grid.NullValueColor, null);
        }

        private void btnAlternatePicker_Click(object sender, EventArgs e)
        {
            PickColor(btnAlternateColor, ColorSplashPlugin.CurrentTheme.Grid.AlternateRowColor, null);
        }

        private void btnBrowserBgPicker_Click(object sender, EventArgs e)
        {
            PickColor(btnBrowserBgColor, ColorSplashPlugin.CurrentTheme.Browser.FontEffect.BackgroundColor, null);
        }

        private void btnBrowserFontPicker_Click(object sender, EventArgs e)
        {
            PickColor(btnBrowserFont, ColorSplashPlugin.CurrentTheme.Browser.FontEffect.FontColor, null);
        }

        private void btnBrowserBgColor_Click(object sender, EventArgs e)
        {
            ChooseColor(btnBrowserBgColor, ColorSplashPlugin.CurrentTheme.Browser.FontEffect.BackgroundColor, null);
        }

        private void btnBrowserFont_Click(object sender, EventArgs e)
        {
            ChooseColor(btnBrowserFont, ColorSplashPlugin.CurrentTheme.Browser.FontEffect.FontColor, null);
        }

        private void btnHlightColor_Click(object sender, EventArgs e)
        {
            ChooseColor(btnHlightColor, ColorSplashPlugin.CurrentTheme.HighlightColor, null);
        }

        private void btnSearchHitColor_Click(object sender, EventArgs e)
        {
            ChooseColor(btnSearchHitColor, ColorSplashPlugin.CurrentTheme.SearchHitColor, null);
        }

        private void btnErrorTxtColor_Click(object sender, EventArgs e)
        {
            ChooseColor(btnErrorTxtColor, ColorSplashPlugin.CurrentTheme.ErrorTextColor, null);
        }

        private void btnErrorBgColor_Click(object sender, EventArgs e)
        {
            ChooseColor(btnErrorBgColor, ColorSplashPlugin.CurrentTheme.ErrorBackgroundColor, null);
        }

        private void btnHlightPicker_Click(object sender, EventArgs e)
        {
            PickColor(btnHlightColor, ColorSplashPlugin.CurrentTheme.HighlightColor, null);
        }

        private void btnSearchHitPicker_Click(object sender, EventArgs e)
        {
            PickColor(btnSearchHitColor, ColorSplashPlugin.CurrentTheme.SearchHitColor, null);
        }

        private void btnErrorTxtPicker_Click(object sender, EventArgs e)
        {
            PickColor(btnErrorTxtColor, ColorSplashPlugin.CurrentTheme.ErrorTextColor, null);
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            //TODO: 'debug
            ThemeSaver s = new ThemeSaver(ColorSplashPlugin.CurrentTheme);
            s.Save();
            return;

            /*saveDialog.Filter = "All files (*.*)|*.*";
            saveDialog.ShowDialog();
            if (!"".Equals(saveDialog.FileName))
            {
                ThemeWriter.SaveToFile(ColorSplashPlugin.CurrentTheme, saveDialog.FileName);
            }*/
        }

        private void SetThemeAndPreference(ColorPreference p, Color val)
        {
            p.Value = val;
            PlsqlDeveloper.Instance.Preferences.SetPreference(p);
        }
        private void SetThemeAndPreference(BoolPreference p, bool val)
        {
            p.Value = val;
            PlsqlDeveloper.Instance.Preferences.SetPreference(p);
        }
        private void SetThemeAndPreference(IntPreference p, int val)
        {
            p.Value = val;
            PlsqlDeveloper.Instance.Preferences.SetPreference(p);
        }
        private void SetThemeAndPreference(StringPreference p, string val)
        {
            p.Value = val;
            PlsqlDeveloper.Instance.Preferences.SetPreference(p);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openDialog.Filter = "Themes (*.theme)|*.theme|All files (*.*)|*.*";
            openDialog.ShowDialog();
            if (!"".Equals(openDialog.FileName))
            {
                ColorSplashPlugin.CurrentTheme = ThemeReader.ReadFromFile(openDialog.FileName);
                InitializeByTheme(ColorSplashPlugin.CurrentTheme);
            }
        }

        private void UpdatePreview()
        {
            UpdateKeywords();
            UpdateComments();
            UpdateNumbers();
            UpdateSymbols();
            UpdateStrings();
            UpdateIdentifiers();
        }

        private void SaveThemeToPreferences(Theme t)
        {
            PreferencesDictionary pref = PlsqlDeveloper.Instance.Preferences;

            pref.SetPreference(t.Syntax.Keywords.BackgroundColor);
            pref.SetPreference(t.Syntax.Keywords.FontColor);
            pref.SetPreference(t.Syntax.Keywords.Bold);
            pref.SetPreference(t.Syntax.Keywords.Italic);

            pref.SetPreference(t.Syntax.Numbers.BackgroundColor);
            pref.SetPreference(t.Syntax.Numbers.FontColor);
            pref.SetPreference(t.Syntax.Numbers.Bold);
            pref.SetPreference(t.Syntax.Numbers.Italic);

            pref.SetPreference(t.Syntax.Comments.BackgroundColor);
            pref.SetPreference(t.Syntax.Comments.FontColor);
            pref.SetPreference(t.Syntax.Comments.Bold);
            pref.SetPreference(t.Syntax.Comments.Italic);

            pref.SetPreference(t.Syntax.Strings.BackgroundColor);
            pref.SetPreference(t.Syntax.Strings.FontColor);
            pref.SetPreference(t.Syntax.Strings.Bold);
            pref.SetPreference(t.Syntax.Strings.Italic);

            pref.SetPreference(t.Syntax.Symbols.BackgroundColor);
            pref.SetPreference(t.Syntax.Symbols.FontColor);
            pref.SetPreference(t.Syntax.Symbols.Bold);
            pref.SetPreference(t.Syntax.Symbols.Italic);

            pref.SetPreference(t.Editor.FontName);
            pref.SetPreference(t.Editor.FontSize);
            pref.SetPreference(t.Editor.FontEffect.BackgroundColor);
            pref.SetPreference(t.Editor.FontEffect.FontColor);
            pref.SetPreference(t.Editor.FontEffect.Bold);
            pref.SetPreference(t.Editor.FontEffect.Italic);

            pref.SetPreference(t.Browser.FontEffect.BackgroundColor);
            pref.SetPreference(t.Browser.FontEffect.FontColor);
            pref.SetPreference(t.Browser.FontEffect.Bold);
            pref.SetPreference(t.Browser.FontEffect.Italic);

            pref.SetPreference(t.Grid.BackgroundColor);
            pref.SetPreference(t.Grid.FontColor);
            pref.SetPreference(t.Grid.AlternateRowColor);
            pref.SetPreference(t.Grid.NullValueColor);

            pref.SetPreference(t.HighlightColor);
            pref.SetPreference(t.SearchHitColor);
            pref.SetPreference(t.ErrorBackgroundColor);
            pref.SetPreference(t.ErrorTextColor);
        }
    }
}
