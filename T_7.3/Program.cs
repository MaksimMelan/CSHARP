using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "1 dfadf asdf";

            int a;

            bool result = int.TryParse(str, out a); // ПРОБУЕТ  распарсить, елси получилось, то будет ТРу

            if (result == false)
            {
                Console.WriteLine("Оперция успешна, значение = " + a);
            }
            else 
            {
                Console.WriteLine("Не удалось конвертировать!");
            }
            Console.ReadKey();
        }
    }
}
