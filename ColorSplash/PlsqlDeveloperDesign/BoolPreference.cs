using System;

namespace ColorSplash.PlsqlDeveloperDesign
{
    /// <summary>
    /// Represents boolean preference of PL/SQL Developer.
    /// </summary>
    public class BoolPreference : GenericPreference<bool>
    {
        public BoolPreference(string name, bool value) : base(name, value)
        {
        }

        public BoolPreference(string name, string value) : base(name, false)
        {
            Value = ValueFromString(value);
        }

        public static bool ValueFromString(string text)
        {
            return ("True".Equals(text)) ? true : false;
        }

        public override bool IsEmpty()
        {
            // Value types cannot be null.
            return false;
        }

        public override string ToString()
        {
            return Value ? "True" : "False";
        }
    }
}
