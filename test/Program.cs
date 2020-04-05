using System;
using ColorSplash;
using ColorSplash.PlsqlDeveloperDesign;

namespace test
{
	class Program
	{
		public static void Main(string[] args)
		{

			SampleCode s = SampleCode.Instance;
			
			Console.WriteLine("key="+s.Keywords.Count);
			Console.WriteLine("ide="+s.Identifiers.Count);
			Console.WriteLine("com="+s.Comments.Count);
			Console.WriteLine("str="+s.Strings.Count);
			Console.WriteLine("num="+s.Numbers.Count);
			Console.WriteLine("del="+s.Delimiters.Count);
			
			//Console.WriteLine(PlsqlDeveloper.Instance.GetPreferencesFilePath());
			Console.WriteLine(PlsqlDeveloper.Instance.Preferences.GetPreference(Preference.KEYWORDS_COLOR));
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}