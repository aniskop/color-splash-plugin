using ColorSplash.PlsqlDeveloperDesign;

namespace ColorSplash.UITheme
{
    public class GridTheme
    {

        public GridTheme()
        {
            BackgroundColor = new ColorPreference(Preference.GRID_BG_COLOR, null);
            FontColor = new ColorPreference(Preference.GRID_COLOR, null);
            NullValueColor = new ColorPreference(Preference.NULL_VALUE_COLOR, null);
            AlternateRowColor = new ColorPreference(Preference.ALTERNATE_ROW_COLOR, null);
        }

        public ColorPreference BackgroundColor
        {
            get; set;
        }

        public ColorPreference NullValueColor
        {
            get; set;
        }

        public ColorPreference AlternateRowColor
        {
            get; set;
        }
        public ColorPreference FontColor
        {
            get; set;
        }

    }
}
