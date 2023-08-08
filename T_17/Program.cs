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
            int givenNumber;
            int power = 2;
            int powerMin = power;
            Random rnd = new Random();
            givenNumber = rnd.Next(10, 100);

            while (powerMin < givenNumber)
            {
                powerMin *= power;
                Console.WriteLine(powerMin);
            }

            Console.WriteLine($"Минимальную степень {power} , превосходящую заданное число {givenNumber}, равна - {powerMin}");
        }
    }
}
