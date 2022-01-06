using System;
using System.Collections.Generic;
using System.Linq;

namespace SCh_Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            List<int> list1 = new List<int>(5) { 4, 3, 7, 8, 1 };
            Console.Write("list1 = ");
            foreach (int i in list1) Console.Write(i + " ");
            Console.WriteLine();
            list1.Add(2);
            Console.Write("list1 = ");
            foreach (int i in list1) Console.Write(i + " ");
            Console.WriteLine();

            //Задание 2
            List<int> list2 = new List<int>(5) { 1, 2, 3 };
            Console.Write("list2 = ");
            foreach (int i in list2) Console.Write(i + " ");
            Console.WriteLine();

            //Задание 3
            list1.InsertRange(3, list2);
            Console.Write("list1 = ");
            foreach (int i in list1) Console.Write(i + " ");
            Console.WriteLine();

            //Задание 4
            Console.WriteLine("In list1 {0} elements.", list1.Count);

            //Задание 5
            Console.WriteLine("Max = " + list1.Max());

            //Задание 6
            Console.WriteLine("Max = " + list1.Min());

            //Задание 7
            int[] array = list2.ToArray();
            Console.Write("array = ");
            foreach (int i in array) Console.Write(i + " ");
            Console.WriteLine();

            //Задание 8
            list2.RemoveAt(2);
            Console.Write("list2 = ");
            foreach (int i in list2) Console.Write(i + " ");
            Console.WriteLine();

        }
    }
}

