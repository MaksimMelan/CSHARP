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
            int startInterval = 1;
            int endInterval = 27;
            int maxNumberToCheck = 1000;
            int minNumberToCheck = 100;
            int numberN;
            Random random = new Random();
            int counter = 0;

            numberN = random.Next(startInterval, endInterval);

            for (int i = 0; i < maxNumberToCheck; i += numberN)
            {
                if (i >= minNumberToCheck)
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