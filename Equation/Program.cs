using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equation
{
	static class Program
	{

		public static Dictionary<string, string> greekLetters = new Dictionary<string, string>()
		{
			{"alpha", "\u03b1"},
			{"beta", "\u03b2"},
			{"gamma", "\u03b3"},
			{"delta", "\u03b4"},
			{"epsilon", "\u03b5"},
			{"zeta", "\u03b6"},
			{"eta", "\u03b7"},
			{"theta", "\u03b8"},
			{"iota", "\u03b9"},
			{"kappa", "\u03ba"},
			{"lambda", "\u03bb"},
			{"mu", "\u03bc"},
			{"nu", "\u03bd"},
			{"xi", "\u03be"},
			{"omicron", "\u03bf"},
			{"pi", "\u03c0"},
			{"rho", "\u03c1"},
			{"sigma", "\u03c3"},
			{"tau", "\u03c4"},
			{"upsilon", "\u03c5"},
			{"phi", "\u03c6"},
			{"chi", "\u03c7"},
			{"psi", "\u03c8"},
			{"omega", "\u03C9"}
		};

		public static Dictionary<string, string> superSub = new Dictionary<string, string>() {
			{"^0","\u2070"},
			{"^1","\u2071"},
			{"^2","\u00b2"},
			{"^3","\u00b3"},
			{"^4","\u2074"},
			{"^5","\u2075"},
			{"^6","\u2076"},
			{"^7","\u2077"},
			{"^8","\u2078"},
			{"^9","\u2079"},
			{"^+","\u207a"},
			{"^-","\u207b"},
			{"^=","\u207c"},
			{"^(","\u207d"},
			{"^)","\u207e"},
			{"$0","\u2080"},
			{"$1","\u2081"},
			{"$2","\u2082"},
			{"$3","\u2083"},
			{"$4","\u2084"},
			{"$5","\u2085"},
			{"$6","\u2086"},
			{"$7","\u2087"},
			{"$8","\u2088"},
			{"$9","\u2089"}
		};

		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
			
		}

		public static string ReplaceCharacters(string r)
		{
			StringBuilder appended = new StringBuilder();
			StringBuilder retString = new StringBuilder(r);
			int currentPosition = 0;
			int strLen = 0;
			for (int i = 0; i < retString.Length; i++)
			{
				if (retString[i] == ' ')
				{
					appended.Clear();
					currentPosition = i + 1;
					strLen = 0;
				}
				else {
					appended.Append(retString[i]);
					strLen++;
				}

				if (greekLetters.ContainsKey(appended.ToString()))
				{
					retString.Remove(currentPosition, strLen);
					retString.Insert(currentPosition, greekLetters[appended.ToString()]);
					appended.Clear();
					strLen = 0;
					i = 0;
				}
			}

			return retString.ToString();
		}
	}
}
