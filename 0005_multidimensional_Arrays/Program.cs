using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0005_multidimensional_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[,] array;
            int[,] array2 = new int[2, 3];

            int[,] array3 = { 
              { 2, 3, 4 }, 
              { 4, 5, 4 }, 
              { 7, 8, 9 }                 
            };

            int[,] array4 = new int[2, 3] { 
                { 9, 8, 7 }, 
                { 6, 5, 4 } 
            };

            //Console.WriteLine( array4[1,2]);

            //Console.WriteLine(array3.Length);

            for (int i = 0; i < array3.GetLength(0); i++)
            {
                for (int j = 0; j < array3.GetLength(1); j++)
                {
                    Console.Write(array3[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            */

            int[,] array5 = new int[14, 24];

            Random random = new Random();


            for (int i = 0; i < array5.GetLength(0); i++)
            {
                for (int j = 0; j < array5.GetLength(1); j++)
                {
                    array5[i, j] = random.Next(0, 10);
                    Console.Write(array5[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
