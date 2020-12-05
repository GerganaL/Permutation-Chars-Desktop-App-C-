using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PermZadanie5
{
   public class Permutation
    {
		public TextBox textBoxResult;

		public StringBuilder input;
		public int n;



		public void permute(string str, int start, int end)
		{
			if (start == end)
			{
				//принтираме резултат
				textBoxResult.AppendText(str);
				textBoxResult.AppendText(Environment.NewLine);
			}
			else
			{
				for (int i = start; i < end; i++)
				{
					str = swap(str, start, i);
					permute(str, start + 1, end);
					str = swap(str, start, i);
				}
			}
		}

		public virtual string swap(string @string, int firstElement, int secondElement)
		{
			char temp;
			char[] charArray = @string.ToCharArray();
			temp = charArray[firstElement];
			charArray[firstElement] = charArray[secondElement];
			charArray[secondElement] = temp;
			return new string(charArray);
		}

	}
}
