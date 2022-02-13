using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_3_2_
{
	public enum TypeWord
	{
		Russian,
		English,
		Number,
		Mixed
	}


	class SubString
	{
		private string str;
		private TypeWord tw = TypeWord.Mixed;
		public SubString(string s) {
			str = s;
		}

		public TypeWord getTypeWord() {
			tw = LangChar(str[0]);
			for (int i = 1; i < str.Length; i++)
			{
				if (LangChar(str[i]) != tw) tw = TypeWord.Mixed;
			}
			return tw;
		}

		private TypeWord LangChar(char c) {
			if (c >= '0' && c <= '9') return TypeWord.Number;
			if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z') return TypeWord.English;
			if (c >= 'а' && c <= 'я' || c >= 'А' && c <= 'Я') return TypeWord.Russian;
			return TypeWord.Mixed;
		}


	}
}
