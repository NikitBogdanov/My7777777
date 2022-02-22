using System;
using System.Text.RegularExpressions;

namespace Tast5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст: ");
            string text = Console.ReadLine();
            Console.WriteLine("Каким способом решить задчу? " + "1 - Как массив символов " + "2 - Регулярные выражения");
            string change = Console.ReadLine();
            if (change == "2")
            {
                Console.WriteLine("Второй способ: ");
                Regex regex = new Regex(@"[A-Z]{1}\w+\d+");
                Match match = regex.Match(text);
                while (match.Success)
                {
                    Console.WriteLine(match.Value);
                    match = match.NextMatch();
                }
            }
            else if (change == "1")
            {
                Console.WriteLine("Первый способ: ");
                string ansver = "";
                string[] str = text.Replace(",", "").Replace(".", "").Split(' ');
                foreach (string f in str)
                {
                    if (Char.IsUpper(f[0]))
                    {
                        if (Char.IsNumber(f[f.Length - 1]) && Char.IsNumber(f[f.Length - 2]))
                        {
                            ansver += f + " ";
                        }
                    }
                }
                Console.WriteLine(ansver);
            }

        }
    }
}
