using System;

namespace _0010_sumOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int randomNumber = rnd.Next(1, 100);

            while (randomNumber >= 0)
            {
                Console.WriteLine(randomNumber);

                randomNumber += randomNumber--;

                if (randomNumber <= 0)
                {
                    break;
                }

                Console.WriteLine(randomNumber);
            }

            Console.ReadKey();
        }
    }
}
