using System;

namespace _0016_DegreeOfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomNumber;
            int degree = 2;
            int startInterval = 1;
            int endInterval = 100;
            int minimumSuperiorNumber = 0;
            int degreeValue = 0;

            Random random = new Random();

            randomNumber = random.Next(startInterval, endInterval + 1);

            for (int i = degree; i <= randomNumber; i *= degree)
            {
                minimumSuperiorNumber = i * degree;
                degreeValue++;             
            }

            Console.WriteLine($"Минимальную степень - {degree} , превосходящую заданное число - {randomNumber}," +
                $" равна - {degreeValue},\nСамо число в найденой степени - {minimumSuperiorNumber}");
            Console.ReadKey();
        }
    }
}
