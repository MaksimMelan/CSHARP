using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_023_Trainer_Operator
{
    internal class Program
    {
            /*
             * Тренарный оператор
             * 
             * [ первый операнд - условие ] ? [ второй операнд if_true ] : [ третий операнд if_false ] 
             */

        static void Main(string[] args)
        {
            /*
            if(storedPassword == enteredPassword)
            {
                accessAllowed = true;
            }
            else
            {
                accessAllowed = false;
            }
            */
            /*
            bool accessAllowed;

            string storedPassword = "qwerty";
            string enteredPassword = Console.ReadLine();
            accessAllowed = storedPassword == enteredPassword ? true : false;

            Console.WriteLine(accessAllowed);

            Console.ReadKey();
            */

            int inputDate = int.Parse(Console.ReadLine());

            int outputData = (inputDate < 0) ? 0 : inputDate;

            Console.WriteLine(outputData);

            Console.ReadKey();

        }
    }
}
