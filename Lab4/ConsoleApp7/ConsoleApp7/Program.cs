using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp7
{
    class Program
    {
        public static int MaxTime(double[] music_Time)
        {
            double x = music_Time[0];
            int y = 0;
            for (int i = 0; i < music_Time.Length; i++)
            {
                if (music_Time[i] > x)
                {
                    x = music_Time[i];
                    y = i;
                }
            }
            return y;
        }
        public static int MinTime(double[] music_Time)
        {
            double x = music_Time[0];
            int y = 0;
            for (int i = 0; i < music_Time.Length; i++)
            {
                if (music_Time[i] < x)
                {
                    x = music_Time[i];
                    y = i;
                }
            }
            return y;
        }
        public static int[] OneTimeTwoMusic(double[] music_Time)
        {
            double x = Math.Abs(music_Time[0] - music_Time[1]);
            int[] index = new int[2];
            for (int i = 2, j = 0; i < music_Time.Length;)
            {
                if (j < music_Time.Length)
                {
                    if (i != j)
                    {
                        double dif = Math.Abs(music_Time[j] - music_Time[i]);
                        if (dif < x)
                        {
                            x = dif;
                            index[0] = j; index[1] = i;
                            i++;
                            if (i == music_Time.Length)
                            {
                                i = 0;
                                j++;
                            }
                        }
                        else
                        {
                            i++;
                            if (i == music_Time.Length)
                            {
                                i = 0;
                                j++;
                            }
                        }
                    }
                    else
                    {
                        i++;
                        if (i >= music_Time.Length)
                        {
                            i = 0;
                            j++;
                        }
                    }
                }
                else
                {
                    break;
                }
            }
            return index;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Треклист: ");
            string[] traklist =
            {
                "1.Gentle Giant – Free Hand[6:15]",
                "2.Supertramp – Child Of Vision[07:27]",
                "3.Camel – Lawrence[10:46]",
                "4.Yes – Don’t Kill The Whale[3:55]",
                "5.10CC – Notell Hotel[04:58]",
                "6.Nektar – King Of Twilight[4:16]",
                "7.The Flower Kings – Monsters & Men[21:19]",
                "8.Focus – Le Clochard[1:59]",
                "9.Pendragon – Fallen Dream And Angel[5:23]",
                "10.Kaipa – Remains Of The Day(08:02)"
            };
            foreach (string f in traklist)
            {
                Console.WriteLine(f);
            }
            Console.WriteLine();
            int sek = 0; 
            int min = 0;
            double[] sekund = new double[traklist.Length];
            double[] minut = new double[traklist.Length];
            Regex regex = new Regex(@"(\d+)[:](\d+)");
            for (int i = 0; i < traklist.Length; i++)
            {
                Match match = regex.Match(traklist[i]);
                while (match.Success)
                {
                    sek += Convert.ToInt32(match.Groups[2].Value);
                    min += Convert.ToInt32(match.Groups[1].Value);
                    sekund[i] = Convert.ToDouble(match.Groups[2].Value) / 60;
                    minut[i] = Convert.ToDouble(match.Groups[1].Value);
                    match = match.NextMatch();
                }
            }
            int sek_Final = 0;
            double min_Final = 0;
            int Hour = 0;
            if (sek > 60)
            {
                sek_Final = sek - (int)(sek / 60) * 60;
                min += (int)(sek / 60);
            }
            if (min > 60)
            {
                min_Final = (min % 60);
                Hour = (int)(min / 60);
            }
            Console.WriteLine();
            Console.WriteLine($"Общая длительность песен: {Hour}:{min_Final}:{sek_Final}");
            double[] music_Time = new double[traklist.Length];
            for (int i = 0; i < traklist.Length; i++)
            {
                music_Time[i] = minut[i] + sekund[i];
            }
            Console.WriteLine();
            Console.WriteLine($"Песня с максимальной длительностью: {traklist[MaxTime(music_Time)]}");
            Console.WriteLine($"Песня с минимальной длительностью:  {traklist[MinTime(music_Time)]}");
            Console.WriteLine("Две песни с минимальной разницей в длительности:");
            foreach (int f in OneTimeTwoMusic(music_Time)) Console.WriteLine(traklist[f]);
        }
    }
}
