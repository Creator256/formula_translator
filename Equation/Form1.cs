using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equation
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		/*
		private void equationEnter_TextChanged(object sender, EventArgs e)
		{
			int offset = 10;
			Font smallFont = new Font(equationOutput.Font.Name, (float)((equationOutput.Font.Size) / 1.5));
			string tempString = Equation.Program.ReplaceCharacters(equationEnter.Text.ToString());
			changeSuperSub(tempString, offset, smallFont);
			fixOutput();
		}
		*/

		private void equationEnter_TextChanged(object sender, EventArgs e) { }

		private void convert_Click(object sender, EventArgs e) {
			//Console.WriteLine("Clicked!");
			equationOutput.Clear();
			Font smallFont = new Font(equationOutput.Font.Name, (float)fontSize.Value);
			equationOutput.Text = Equation.Program.ReplaceCharacters(equationEnter.Text.ToString());
			equationOutput.Text += "  ";
			changeSuperSub((int)offset.Value, smallFont);

			//fixOutput();
		}

		private void changeSuperSub(int offset, Font smallFont) {
			string x = equationOutput.Text;
			List<Tuple<int,int>> sup = new List<Tuple<int,int>>();
			List<Tuple<int, int>> sub = new List<Tuple<int, int>>();
			int supStart = 0; int supEnd = 0;
			int subStart = 0; int subEnd = 0;
			for (int i = 0; i < x.Length; i++) {
				if (x[i] == '^') {
					equationOutput.Text = equationOutput.Text.Remove(i, 1);
					x = x.Remove(i, 1);
					supStart = i;
					for (int j = i; j < x.Length; j++) {
						if (x[j] == ' ' || j == x.Length-1) {
							supEnd = j-1;
							break;
						}
					}
					sup.Add(Tuple.Create(supStart, supEnd));
					supStart = 0;
					supEnd = 0;
				}

				if (x[i] == '$'){
					equationOutput.Text = equationOutput.Text.Remove(i, 1);
					x = x.Remove(i, 1);
					subStart = i;
					for (int j = i; j < x.Length; j++){
						if (x[j] == ' ' || j == x.Length-1) {
							subEnd = j-1;
							break;
						}
					}
					sub.Add(Tuple.Create(subStart, subEnd));
					subStart = 0;
					subEnd = 0;
				}

			}
			foreach (Tuple<int,int> t in sup) {
				equationOutput.Select(t.Item1, t.Item2);
				equationOutput.SelectionCharOffset = offset;
				equationOutput.SelectionFont = smallFont;
			}

			foreach (Tuple<int, int> t in sub){
				equationOutput.Select(t.Item1, t.Item2);
				equationOutput.SelectionCharOffset = -offset;
				equationOutput.SelectionFont = smallFont;
			}
			equationOutput.Select(equationOutput.Text.Length - 2, equationOutput.Text.Length - 1);
			equationOutput.SelectionCharOffset = 0;
			equationOutput.SelectionFont = equationOutput.Font;
		}

		private void fixOutput(){
			StringBuilder x = new StringBuilder(equationOutput.Text);
			for (int i = 0; i < x.Length; i++) {
				if (x[i] == '^') {
					x.Replace("^", "");
				}
				else if(x[i] == '$') {
					x.Replace("$", "");
				}
			}
			equationOutput.Text = x.ToString();
		}

	}
}
