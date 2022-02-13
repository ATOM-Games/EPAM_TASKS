using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_2
{
    public class DinamicArray<T> : IEnumerable, IEnumerable<T>, IEnumerator, ICloneable
    {
		protected T[] array;
        protected int _position = -1;
        public int Length { get; private set; }
        public int Capacity { get; private set; }

		public T this[int input]
        {
            get
            {
                if (input >= 0)
                {
                    if (input < Length)
                    {
                        return array[input];
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
                else {
                    if (Math.Abs(input) < Length)
                    {
                        return array[Length + input];
                    }
                    else {
                        throw new ArgumentOutOfRangeException();
                    }
                }
            }
            set
            {
                if (input < Length)
                {
                    array[input] = value;
                }
            }
        }
        public DinamicArray()
        {
            Length = 0;
            Capacity = 8;
            array = new T[Capacity];
        }
        public DinamicArray(int size)
        {
            Length = 0;
            Capacity = 8 * (int)Math.Pow(2, CapacityCount(size));
            array = new T[Capacity];
        }
        public DinamicArray(IEnumerable<T> input)
        {
            int size = 0;
            foreach (T i in input)
            {
                size++;
            }
            Capacity = 8 * (int)Math.Pow(2, CapacityCount(size));
            array = new T[Capacity];
            foreach (T i in input)
            {
                array[Length] = i;
                Length++;
            }
        }

        public void Add(T input)
        {
            if (Length + 1 > Capacity)
            {
                Capacity *= 2;
            }
            array[Length] = input;
            Length++;
        }
        public void AddRange(IEnumerable<T> input)
        {
            int size = 0;
            foreach (T i in input)
            {
                size++;
            }
            if (size + Length > Capacity)
            {
                Capacity = 8 * (int)Math.Pow(2, CapacityCount(size + Length));
                T[] a = array;
                array = new T[Capacity];
                for (int i = 0; i < Length; i++)
                {
                    array[i] = a[i];
                }
            }
            foreach (T i in input)
            {
                array[Length] = i;
                Length++;
            }
        }
        public bool Remove(T input)
        {
            int number = Array.IndexOf<T>(array, input);
            if (number >= 0 && number < Length)
            {
                for (int i = number; i < Length - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                Length--;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Insert(T input, int number)
        {
            if (number >= 0 && number < Length)
            {
                if (Length + 1 > Capacity)
                {
                    Capacity *= 2;
                }
                T item1 = array[number];
                T item2;
                for (int i = number; i < Length; i++)
                {
                    item2 = array[i + 1];
                    array[i + 1] = item1;
                    item1 = item2;
                }
                array[number] = input;
                Length++;
                return true;
            }
            else
            {
                return false;
            }
        }
        private int CapacityCount(int size)
        {
            int output = 0;
            while (8 * Math.Pow(2, output) < size)
            {
                output++;
            }
            return output;
        }
        public IEnumerator GetEnumerator() => (IEnumerator)GetEnumeratr();
        public DinamicArray<T> GetEnumeratr()
        {
            return this;
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator() => ((IEnumerable<T>)array).GetEnumerator();
        public void setCapcity(int newCap) {
            if (newCap < 0) throw new ArgumentException("Размер капасити должен быть больше 0");
            if (newCap < Length) {
                Array.Resize(ref array, newCap);
                Length = newCap;
            }
            Capacity = newCap;
        }
		public object Clone()
		{
            DinamicArray<T> da = new DinamicArray<T>(this.array);
            da.setCapcity(this.Capacity);
            return da;
		}
        public T[] ToArray() {
            T[] newar = new T[Length];
            for (int i = 0; i < Length; i++) {
                newar[i] = this.array[i];
            }
            return newar;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public T Current
        {
            get
            {
                try
                {
                    return array[_position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
        public virtual bool MoveNext()
        {
            _position++;
            return (_position < Length);
        }
        public void Reset()
        {
            _position = -1;
        }
    }

    
}