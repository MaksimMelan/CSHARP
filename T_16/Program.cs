using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHomeworkCycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startInterval = 1;//ххх
            int endInterval = 27;
            int maxRange = 1000;
            int minRange = 100;
            int numberN;
            int counter = 0;

            Random random = new Random();
            numberN = random.Next(startInterval, endInterval + 1);

            for (int i = 0; i < maxRange; i += numberN)
            {
                if (i >= minRange)
                {
                    Console.WriteLine($"картное число {i}\n");
                    counter++;
                }
            }
            Console.WriteLine($"Число N - {numberN}");
            Console.WriteLine($"Трехзначных чисел кратных N - {counter}");
        }
    }
}