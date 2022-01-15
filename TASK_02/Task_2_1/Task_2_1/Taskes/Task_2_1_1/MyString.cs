using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2_1
{
	internal class MyString
	{
		private char[] stroka;

		// - конструкторы
		public MyString() { stroka = new char[0]; }
		public MyString(IEnumerable<char> ch) { setMyString(ch); }
		public MyString(string str) { setMyString(str); }

		public void setMyString(string str) {
			stroka = str.ToCharArray();
		}
		public void setMyString(IEnumerable<char> ch) {
			stroka = new char[ch.Count()];
			for (int i = 0; i < ch.Count(); stroka[i] = ch.ElementAt(i), i++) ;
		}
		public char[] getMyString() => this.stroka;
		public override string ToString() => new string(this.stroka);
		public int getLenght() => this.stroka.Length;

		// - проверка на пустоту
		public bool isEmpty() => (stroka == null || stroka.Length == 0);

		// - сравнения
		public override bool Equals(object ch)
		{
			if (ch == null) return false;
			if (ch.GetType() != typeof(string) && !typeof(IEnumerable<char>).IsAssignableFrom(ch.GetType())) return false;
			else {
				bool flag = true;
				if (ch.GetType() == typeof(string))
				{
					if (((string)ch).Length != stroka.Length) return false;
					for (int i = 0; i < ((string)ch).Length; i++)
					{
						if (stroka[i] != ((string)ch)[i])
						{
							flag = false;
							break;
						}
					}

				}
				else
				{
					if (((IEnumerable<char>)ch).Count() != stroka.Length) return false;
					for (int i = 0; i < ((IEnumerable<char>)ch).Count(); i++)
					{
						if (stroka[i] != ((IEnumerable<char>)ch).ElementAt(i))
						{
							flag = false;
							break;
						}
					}
				}
				return flag;
			}
		}

		// - сравнивалки операторки
		public static bool operator ==(MyString l, string r) => l.Equals(r);
		public static bool operator !=(MyString l, string r) => !l.Equals(r);
		public static bool operator ==(string l, MyString r) => r.Equals(l);
		public static bool operator !=(string l, MyString r) => !r.Equals(l);
		public static bool operator ==(MyString l, MyString r) => l.Equals(r.ToString());
		public static bool operator !=(MyString l, MyString r) => !l.Equals(r.ToString());
		public static bool operator ==(MyString l, IEnumerable<char> r) => l.Equals(r);
		public static bool operator !=(MyString l, IEnumerable<char> r) => !l.Equals(r);
		public static bool operator ==(IEnumerable<char> l, MyString r) => r.Equals(l);
		public static bool operator !=(IEnumerable<char> l, MyString r) => !r.Equals(l);

		// - массивские операторы
		public char this[int index] => this.stroka[index];

		// - плюсы там всякие и минусы с равношкой (только без минусов)
		public static MyString operator +(MyString l, MyString r) {
			char[] ch = new char[r.getLenght() + l.getLenght()];
			for (int i = 0; i < l.getLenght(); ch[i] = l[i], i++) ;
			for (int i = 0; i < r.getLenght(); ch[i + l.getLenght()] = r[i], i++) ;
			return new MyString(ch);
		}
		public static MyString operator +(MyString l, string r)
		{
			char[] ch = new char[l.getLenght() + r.Length];
			for (int i = 0; i < l.getLenght(); ch[i] = l[i], i++) ;
			for (int i = 0; i < r.Length; ch[i + l.getLenght()] = r[i], i++) ;
			return new MyString(ch);
		}
		public static MyString operator +(string l, MyString r)
		{
			char[] ch = new char[r.getLenght() + l.Length];
			for (int i = 0; i < l.Length; ch[i] = l[i], i++) ;
			for (int i = 0; i < r.getLenght(); ch[i + l.Length] = r[i], i++) ;
			return new MyString(ch);
		}
		public static MyString operator +(MyString l, IEnumerable<char> r)
		{
			char[] ch = new char[l.getLenght() + r.Count()];
			for (int i = 0; i < l.getLenght(); ch[i] = l[i], i++) ;
			for (int i = 0; i < r.Count(); ch[i + l.getLenght()] = r.ElementAt(i), i++) ;
			return new MyString(ch);
		}
		public static MyString operator +(IEnumerable<char> l, MyString r)
		{
			char[] ch = new char[r.getLenght() + l.Count()];
			for (int i = 0; i < l.Count(); ch[i] = l.ElementAt(i), i++) ;
			for (int i = 0; i < r.getLenght(); ch[i + l.Count()] = r[i], i++) ;
			return new MyString(ch);
		}

		// - строчковые операции
		private void addAcc(ref List<char> ch, ref MyString[] str) {
			Array.Resize(ref str, str.Length + 1);
			str[str.Length - 1] = new MyString(ch);
			ch.Clear();
		}
		public MyString[] Split(IEnumerable<char> separators) {
			MyString[] fres = new MyString[0];
			List<char> acc = new List<char>();
			for (int i = 0; i < this.stroka.Length; i++)
			{
				if (separators.Contains(this.stroka[i]))
				{
					addAcc(ref acc, ref fres);
				}
				else
				{
					acc.Add(this.stroka[i]);
				}
			}
			if (acc.Count() > 0)
			{
				addAcc(ref acc, ref fres);
			}
			return fres;
		}
		public MyString[] Split(char separator)
		{
			MyString[] res = new MyString[0];
			List<char> acc = new List<char>();
			for (int i = 0; i < this.stroka.Length; i++)
			{
				if (this.stroka[i] == separator)
				{
					addAcc(ref acc, ref res);
				}
				else
				{
					acc.Add(this.stroka[i]);
				}
			}
			if (acc.Count() > 0) {
				addAcc(ref acc, ref res);
			}
			return res;
		}

		public bool isContaint(char symbol) => (countContaint(symbol) > 0);
		public int countContaint(char symbol) {
			int res = 0;
			for (int i = 0; i < this.stroka.Length; res += (stroka[i] == symbol) ? 1 : 0, i++) ;
			return res;
		}

		public void toUpper() {
			for (int i = 0; i < stroka.Length; stroka[i] = char.ToUpper(stroka[i]), i++) ;
		}
		public void toLower() {
			for (int i = 0; i < stroka.Length; stroka[i] = char.ToLower(stroka[i]), i++) ;
		}
		public void toRealUpLow() {
			this.toLower();
			stroka[0] = char.ToUpper(stroka[0]);
			for (int i = 1; i < stroka.Length; i++) {
				if (i == 1)
				{
					if (stroka[0] == ' ') stroka[1] = char.ToUpper(stroka[1]);
				}
				else {
					if ((stroka[i - 2] == '.' || stroka[i - 2] == '!' || stroka[i - 2] == '?') && stroka[i - 1] == ' ') {
						stroka[i] = char.ToUpper(stroka[i]);
					}
				}
			}
		}
	}
}
