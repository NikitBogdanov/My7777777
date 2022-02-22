using System;
using System.Text;

namespace task3
{
    class Program
    {
        public static string Array(string text)
        {
            string ansver = "";
            string[] text_Split = text.Replace("!", "").Split(' ');
            for (int i = text_Split.Length - 1; i >= 0; i--)
            {
                ansver += $"{text_Split[i]} ";
            }
            return ansver;
        }
        public static string StrBuild(string text)
        {
            string ansver = "";
            string[] text_Split = text.Replace(".", "").Replace("!", "").Split(' ');
            StringBuilder stringBuilder = new StringBuilder(100);
            for (int i = text_Split.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(text_Split[i] + " ");
            }
            ansver = stringBuilder.ToString();
            return ansver;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение и завершите точкой:");
            string text = Console.ReadLine();
            Console.WriteLine($"Строка, как массив символов: {Array(text)}");
            Console.WriteLine($"C помощью методов классов string и StringBuilder: {StrBuild(text)}");
        }
    }
}
