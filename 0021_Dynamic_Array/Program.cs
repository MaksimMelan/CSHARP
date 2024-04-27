using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0022_Under_an_array_of_repetitions_of_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int numberOfColumns = 30;

            int minNumberRandomness = 1;
            int maxNumberRandomness = 10;

            int[] arrayNumbers = {1, 2, 2, 3, 3, 3, 4};

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                //arrayNumbers[i] = random.Next(minNumberRandomness, maxNumberRandomness);

                Console.WriteLine($"№{i + 1} {arrayNumbers[i]}  ");
            }

            int currentNum = arrayNumbers[0];
            int repeatingNumber = 1;
            int maxNum = arrayNumbers[0];
            int amountOfRepetitions = 1;


            for (int i = 1; i < arrayNumbers.Length; i++)
            {
                if (arrayNumbers[i] == currentNum)
                {
                    repeatingNumber++;
                }
                else
                {
                    if (repeatingNumber > amountOfRepetitions)
                    {
                        amountOfRepetitions = repeatingNumber;
                        maxNum = currentNum;
                    }
                    currentNum = arrayNumbers[i];
                    repeatingNumber = 1;
                }
            }

            Console.WriteLine("Массив: " + string.Join(", ", arrayNumbers));
            Console.WriteLine("Число: " + maxNum);
            Console.WriteLine("Количество повторений: " + repeatingNumber);
            Console.ReadKey();
        }
    }
}