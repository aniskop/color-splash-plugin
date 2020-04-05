using System;

namespace ColorSplash.PlsqlDeveloperDesign
{
    public class StringPreference : GenericPreference<string>
    {
        public StringPreference(string name, string value) : base(name, value) { }

        public static string ValueFromString(string text)
        {
            return text;
        }

        public override bool IsEmpty()
        {
            return (Value == null || "".Equals(Value));
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
