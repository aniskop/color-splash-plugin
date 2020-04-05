namespace ColorSplash.PlsqlDeveloperDesign
{
    /// <summary>
    /// Represents PL/SQL Developer preference.
    /// </summary>
    /// <typeparam name="T">There are several types of preferences, each one represented by its own class:
    /// <list type="bullet">
    /// <item><term>Color, represented by <see cref="ColorPreference/>;</term></item>
    /// </list></typeparam>
    public abstract class GenericPreference<T>
    {
        private T val;

        public string Name
        {
            get;
        }

        public T Value
        {
            get
            {
                return val;
            }
            set
            {
                val = value;
            }
        }

        protected GenericPreference(string name, T val)
        {
            Name = name;
            Value = val;
        }

        /// <summary>
        /// Checks if preference value is null or empty.
        /// </summary>
        /// <returns></returns>
        public abstract bool IsEmpty();

        public string ToFileString()
        {
            return string.Format("{0}={1}", Name, ToString());
        }

    }
}
