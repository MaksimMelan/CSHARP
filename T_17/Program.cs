using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startInterval = 1;
            int endInterval = 100;
            int givenNumber;
            int power = 2;
            int powerMin = power;

            Random random = new Random();
            givenNumber = random.Next(startInterval, endInterval + 1);

            while (powerMin <= givenNumber)
            {
                powerMin *= power;
                Console.WriteLine(powerMin);
            }

            Console.WriteLine($"Минимальную степень {power} , превосходящую заданное число {givenNumber}, равна - {powerMin}");
        }
    }
}
