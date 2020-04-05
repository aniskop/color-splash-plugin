using System;

namespace ColorSplash.PlsqlDeveloperDesign
{
    public class IntPreference : GenericPreference<int>
    {
        public IntPreference(string name, int value) : base(name, value) { }

        public IntPreference(string name, string value) : base(name, 0)
        {
            Value = ValueFromString(value);
        }

        public static int ValueFromString(string text)
        {
            return int.Parse(text);
        }

        public override bool IsEmpty()
        {
            // Value types cannot be null.
            return false;
        }

        public override string ToString()
        {
            return Convert.ToString(Value);
        }
    }
}
