using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_3_2_
{
	class SubArray
	{
		private int[] _array;
		public SubArray(int[] ar) {
			this._array = ar;
		}

		public void operation(Delegate method, params object[] args) {
			method.DynamicInvoke(args);
		}
		public int summ() {
			int s = 0;
			for (int i = 0; i < _array.Length; i++) {
				s += _array[i];
			}
			return s;
		}
		public int middle() => summ() / _array.Length;
		
		public int maxVisArray() {
			int s = 0, d = 0, j;
			for (int i = 0; i < _array.Length; i++) {
				j = visArray(_array[i]);
				if (d < j) {
					s = _array[i];
					j = d;
				}
			}
			return s;
		}
		private int visArray(int d) {
			int s=0;
			for (int i = 0; i < _array.Length; i++) {
				if (_array[i] == d) s++;
			}
			return s;
		}


	}
}
