using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        public static int InterpolationSearch(int[] array, int element)
        {
            int lower = 0;
            int high = array.Length - 1;
            int SearchIndex = -1;
            bool findResult = false;
            while(findResult == false)
            {
                SearchIndex = lower + ((high - lower) / (array[high] - array[lower])) * (element - array[lower]);
                if (element != array[SearchIndex])
                {
                    lower = SearchIndex + 1;
                }
                else
                {
                    findResult = true;
                }
            }
            return SearchIndex;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите искомое число:");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[100];
            string path = @"C:\Users\intre\source\repos\Lab7\ConsoleApp2\sorted.dat";
            using(StreamReader sr = new StreamReader(new FileStream(path, FileMode.OpenOrCreate)))
            {
                for(int i = 0; i < array.Length; i++)
                {
                    array[i] = Convert.ToInt32(sr.ReadLine());
                }
            }
            Console.WriteLine(InterpolationSearch(array, number));
        }
    }
}
