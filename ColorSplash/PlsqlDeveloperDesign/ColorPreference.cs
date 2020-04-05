using System;
using System.Drawing;

namespace ColorSplash.PlsqlDeveloperDesign
{
    /// <summary>
    /// Represents color preference of PL/SQL Developer.
    /// </summary>
    public class ColorPreference : GenericPreference<Color>
    {
        public ColorPreference(string name, Color value) : base(name, value)
        {
        }

        public ColorPreference(string name, string value) : base(name, Color.Empty)
        {
            Value = ValueFromString(value);
        }

        /// <summary>
        /// Converts string value from PL/SQL Developer preferences to a <see cref="Color"/>.
        /// String is actually a 32-bit integer storing color as RGB with no alpha value.
        /// Byte order of integer in little-endian and big-endian architecture matters.
        /// </summary>
        /// <param name="text">32-bit integer as string</param>
        public static Color ValueFromString(string text)
        {
            int val = Convert.ToInt32(text);
            byte[] bytes = BitConverter.GetBytes(val);
            if (BitConverter.IsLittleEndian)
            {
                return Color.FromArgb(0xff, bytes[0], bytes[1], bytes[2]);
            }
            else
            {
                return Color.FromArgb(0xff, bytes[3], bytes[2], bytes[1]);
            }
        }

        public override bool IsEmpty()
        {
            return (Value == null || Color.Empty.Equals(Value));
        }

        public override string ToString()
        {
            int c = 0;
            /* 
              PL/SQL Developer needs string which actually is 32-bit integer: 0x00 blue green red.
              To produce correct value:
              * In little-endian systems we need integer: 0x00 blue green red.
              * In big-endian systems we need integer: red green blue 0x00.
            */
            if (BitConverter.IsLittleEndian)
            {
                c = Value.B;
                c = c << 8;
                c |= Value.G;
                c = c << 8;
                c |= Value.R;
            }
            else
            {
                c = Value.R;
                c = c << 8;
                c |= Value.G;
                c = c << 8;
                c |= Value.B;
            }
            return Convert.ToString(c);

        }
    }
}
