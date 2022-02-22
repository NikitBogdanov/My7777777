using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string str = Console.ReadLine();
            //Первый способ
            string ansver = "";
            char[] arrey = str.ToCharArray();
            for (int i = 0, j = 1; i < arrey.Length; i++)
            {
                if (arrey[i] == ' ' | arrey[i] == '.')
                {
                    ansver += "(" + j + ")";
                    ansver += arrey[i];
                    j++;
                }
                else if (arrey[i] == ',')
                {
                    ansver += "(" + j + ")";
                    ansver += arrey[i] + " ";
                    j++; i++;
                }
                else if (arrey[i] == '-')
                {
                    ansver += arrey[i] + " ";
                    i++;
                }
                else
                {
                    ansver += arrey[i];
                }
            }
            Console.WriteLine("Первый способ: ");
            for (int i = 0; i < ansver.Length; i++)
            {
                Console.Write(ansver[i]);
            }
            Console.WriteLine();
            //Второй способ
            string new_Str = "";
            char[] sign = { ' ', '.' };
            char[] blackList = { '-', '—', '–' };
            for (int i = 0, index = 1; i < str.Length; i++)
            {
                if (sign.Contains(str[i]))
                {
                    new_Str += "(" + index + ")" + str[i] + " ";
                    index++;
                }
                else if (str[i] == ',')
                {
                    new_Str += "(" + index + ")" + str[i] + " ";
                    index++; i++;
                }
                else if (blackList.Contains(str[i]))
                {
                    new_Str += str[i] + " ";
                    i++;
                }
                else
                {
                    new_Str += str[i];
                }
            }
            Console.WriteLine("Второй способ: ");
            Console.WriteLine(new_Str);
        }
    }
}
