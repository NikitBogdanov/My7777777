using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>(); 
            Console.WriteLine("Введите текст формата: '15 + 36 = 51'");
            string text = Console.ReadLine();
            int a, b, c;
            Regex reg = new Regex(@"(\d+)\s+[+]\s+(\d+)\s+[=]\s+(\d+)");
            Match match = reg.Match(text);
            while (match.Success)
            {
                Console.WriteLine(a = Convert.ToInt32(match.Groups[1].Value)); list.Add(a);
                Console.WriteLine(b = Convert.ToInt32(match.Groups[2].Value)); list.Add(b);
                Console.WriteLine(c = Convert.ToInt32(match.Groups[3].Value)); list.Add(c);
                match = match.NextMatch();
            }
            if (list.Count == 0)
            {
                Console.WriteLine("Совпадений не найдено.");
            }
        }
    }
}