using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int numMin = 100;
            int numMax = 999;
            

            Random random = new Random();
            int n = random.Next(1, 27);

            while(numMin <= numMax)
            {
                numMin++;
                while (numMin >= n)
                {
                    numMin -= n;
                    
                    if (numMin == 0);
                    {
                        count++;
                    }
                }
                
            }
            Console.WriteLine($"количество трехзначных натуральных чисел равно - {count}. Число N равно - {n}");
        }
    }
}
