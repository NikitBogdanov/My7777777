using System;
using System.Text.RegularExpressions;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            string text = Console.ReadLine();
            Regex expression = new Regex(@"\d+[:]\d+[:]\d+");
            Match match = expression.Match(text);
            while (match.Success)
            {
                Console.WriteLine("Время: " + match.Value);
                match = match.NextMatch();
            }
        }
    }
}