using System;

namespace _0010_sumOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int randomNumber = rnd.Next(1, 101);

            int sum = 0;
            int multiplicityOfNumberOne = 3;
            int multiplicityOfNumberTwo = 5;  

            for (int i = 0; i <= randomNumber; i++)
            {
              
                if (i % multiplicityOfNumberOne == 0 || i % multiplicityOfNumberTwo == 0)
                {
                    sum += i;                       
                }
            }

            Console.WriteLine($"Сгенерированно число {randomNumber}");
            Console.WriteLine($"Сумма всех положительных чисел, меньших или равных {randomNumber}, кратных {multiplicityOfNumberOne} или {multiplicityOfNumberTwo}: {sum}");
            Console.ReadKey();
        }
    }
}
