using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_3_2 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DinamicArray<int> array_01 = new DinamicArray<int>(new int[]{1,3,5,7,8 });
            Console.WriteLine("=====================================");
            for (int i = 0; i < array_01.Length; i++) {
                Console.WriteLine(array_01[i]);
            }
            Console.WriteLine("-------------------------------------");
            foreach(int ar in array_01) {
                Console.WriteLine(ar+"");
            }
            Console.WriteLine("=====================================");
            CycledDynamicArray<int> array_02 = new CycledDynamicArray<int>(new int[] { 1, 3, 5, 7, 8 });
            Console.WriteLine("=====================================");
            for (int i = 0; i < array_02.Length; i++)
            {
                Console.WriteLine(array_02[i]);
            }
            Console.WriteLine("-------------------------------------");
            foreach (int ar in array_02)
            {
                Console.WriteLine(ar + "");
            }
            Console.WriteLine("=====================================");

            Console.ReadKey();
        }
    }
}