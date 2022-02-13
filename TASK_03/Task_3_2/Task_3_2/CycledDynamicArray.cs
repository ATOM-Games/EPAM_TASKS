using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_2
{
	class CycledDynamicArray<T> : DinamicArray<T>
	{
        public CycledDynamicArray() : base() { }
        public CycledDynamicArray(int size) : base(size) { }
        public CycledDynamicArray(IEnumerable<T> input) : base(input) { }
       
        public override bool MoveNext() {
            if (_position < Length-1)
                _position++;
            else
                _position = 0;
            return true;
        }




    }
}
