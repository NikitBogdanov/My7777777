using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложения:");
            string a = Console.ReadLine().Trim(), b = Console.ReadLine().Trim(), c = Console.ReadLine().Trim(), d = Console.ReadLine().Trim(), i = Console.ReadLine().Trim(), f = Console.ReadLine().Trim(), j = Console.ReadLine().Trim();
            string[] str = new string[] { a, b, c, d, i, f, j };
            Console.WriteLine("Выберите способ решения задачи: 1 или 2");
            string change = Console.ReadLine();
            if (change == "1")
            {
                string com = ".com";
                foreach (string find in str)
                {
                    if (find.Contains(com))
                    {
                        Console.WriteLine("Строка содержащая '.com': " + find);
                    }
                }
                int ent = 0;
                int number = 0;
                int ent_Null = str[0].Length - str[0].Replace(" ", "").Length;
                for (int k = 1; k < str.Length; k++)
                {
                    ent = str[k].Length - str[k].Replace(" ", "").Length;
                    if (ent < ent_Null)
                    {
                        ent_Null = ent;
                        number = k + 1;
                    }
                }
                Console.WriteLine("Номер строки с наименьшим количеством пробелов: " + number);
            }
            else if (change == "2")
            {
                string str_Com_Find = "";
                for (int k = 0; k < str.Length; k++)
                {
                    str_Com_Find = str[k];
                    for (int l = 0; l < str[k].Length; l++)
                    {
                        if (str_Com_Find[l] == '.' && str_Com_Find[l + 1] == 'c' && str_Com_Find[l + 2] == 'o' && str_Com_Find[l + 3] == 'm')
                        {
                            Console.WriteLine("Строка содержащая '.com': " + str[k]);
                        }
                    }
                }
                int number = 0;
                int ent = 0;
                int x = 0;
                str_Com_Find = str[0];
                for (int l = 0; l < str_Com_Find.Length; l++)
                {
                    if (str_Com_Find[l] == ' ')
                    {
                        ent++;
                    }
                }
                for (int k = 1; k < str.Length; k++)
                {
                    str_Com_Find = str[k];
                    for (int l = 0; l < str[k].Length; l++)
                    {
                        if (str_Com_Find[l] == ' ')
                        {
                            number++;
                        }
                        if (number < ent)
                        {
                            ent = number;
                            x = k + 1;
                        }
                    }
                }
                Console.WriteLine("Номер строки с наименьшим количеством пробелов: " + x);
            }
        }
    }
}
