using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        public static string One(string text)
        {
            char[] arrey = text.ToCharArray();
            string str1 = "";
            string str2 = "";
            int j = 0;
            for (int i = 1; i < arrey.Length; i++)
            {
                if (arrey[j] == arrey[i])
                {
                    str1 += arrey[j];
                }
                if (arrey[i] == '.')
                {
                    i = j + 1;
                    j++;
                }
            }
            int k = 0;
            for (int i = 0; i < arrey.Length & arrey[i] != '.';)
            {
                if (arrey[i] != str1[k])
                {
                    k++;
                }
                else
                {
                    k = 0;
                    i++;
                }
                if (k >= str1.Length)
                {
                    str2 += arrey[i];
                    i++;
                    k = 0;
                }
            }
            Console.WriteLine("Текст без повторяющихся символов: ");
            return str2;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение и завершите точкой: ");
            string text = Console.ReadLine().ToUpper().Trim();
            Console.WriteLine("Каким способом удалять повторяющиеся элементы? " + "1 или 2");
            string number = Console.ReadLine();
            if (number == "1")
            {
                try
                {
                    Console.WriteLine(One(text));
                }
                catch
                {
                    Console.WriteLine("В данном тексте отсутствуют одинаковые символы.");
                }
            }
            if (number == "2")
            {
                try
                {
                    string ansver = "";
                    for (int i = 0; i < text.Length & text[i] != '.'; i++)
                    {
                        if (text.IndexOf(text[i]) == text.LastIndexOf(text[i]))
                        {
                            ansver += text[i];
                        }
                    }
                    Console.WriteLine(ansver);
                }
                catch
                {
                    Console.WriteLine("Закончите предложение точкой!");
                }
            }
        }
    }
}
