using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _0002_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string age;
            string cityResidence;
            string profession;

            Console.WriteLine("Как Вас зовут?");
            name = Console.ReadLine();

            Console.WriteLine("Сколько вам лет?");
            age = Console.ReadLine();

            Console.WriteLine("Место проживания? ");
            cityResidence = Console.ReadLine();

            Console.WriteLine("Кем вы работаете?");
            profession = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"Вас зовут {name}. Вам {age} лет. Ваше место проживания {cityResidence} . Вы работате {profession}. ");

            Console.ReadKey();
        }   
    }
}
