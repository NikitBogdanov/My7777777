using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        public static string Arrey(string text)
        {
            string ansver = "";
            string str = "";
            string[] black_book = { "string", "int", "bool", "float", "char", "short", "double", "long", "byte" };
            char[] black_list = { '$', '#', '?', ',', '.', '-', '+', '=', '!', '%', '^', ';', ':', '&', '*', '/', '@', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '(', ')', '|', '№' };
            int k = 0; int j = 0;
            string[] text_Split = text.Split(" ");
            for (int i = 0; i < black_list.Length;)
            {
                if (j < text_Split.Length)
                {
                    if (k < text_Split[j].Length)
                    {
                        if (black_list[i] != text_Split[j][k])
                        {
                            i++;
                            if (i >= black_list.Length)
                            {
                                k++;
                                i = 0;
                                if (k >= text_Split[j].Length)
                                {
                                    str += $"{text_Split[j]} ";
                                    j++;
                                    k = 0;
                                    if (j == text_Split.Length)
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            j++;
                            k = 0;
                            i = 0;
                            if (j == text_Split.Length)
                            {
                                break;
                            }
                        }
                    }
                }
            }
            string[] str_Split = str.Split(" ");
            int l = 0;
            for (int i = 0; i < str_Split.Length;)
            {
                if (l < black_book.Length)
                {
                    if (str_Split[i] != black_book[l])
                    {
                        l++;
                        if (l >= black_book.Length)
                        {
                            ansver += $"{str_Split[i]} ";
                            i++;
                            l = 0;
                        }
                    }
                    else
                    {
                        i++;
                        l = 0;
                    }
                }
            }
            return ansver;
        }
        public static string Metod(string text)
        {
            string str = "";
            string ansver = "";
            int j = 0;
            string[] black_book = { "string", "int", "bool", "float", "char", "short", "double", "long", "byte" };
            string black_list = "$#?,.-+=!%^;:&*/@1234567890()|№";
            string[] text_Split = text.Split(" ");
            for (int i = 0; i < text_Split.Length;)
            {
                if (j < black_list.Length)
                {
                    if (black_list.Contains(text_Split[i][j]) == false)
                    {
                        j++;
                        if (j == text_Split[i].Length)
                        {
                            j = 0;
                            str += string.Concat(text_Split[i] + " ");
                            i++;
                        }
                    }
                    else
                    {
                        j = 0;
                        i++;
                    }
                }
            }
            string[] str_Split = str.Split(" ");
            foreach (string f in str_Split)
            {
                if (black_book.Contains(f) == false)
                {
                    ansver += string.Concat(f + " ");
                }
            }
            return ansver;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string text = Console.ReadLine();
            Console.WriteLine("Выберите способ решения задачи: " + "1 - Массив символов." + "2 - Методы класса string");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"Слова, которые можно использовать в качестве переменных: {Arrey(text)}");
                    break;
                case "2":
                    Console.WriteLine($"Слова, которые можно использовать в качестве переменных: {Metod(text)}");
                    break;
            }
        }
    }
}
