using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0034_L_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> countriesCapitals = new Dictionary<string, string>();

            //if (true)
            //{
            //    countriesCapitals.Add("Австралия", "Канберра"); 
            //}

            //if (countriesCapitals.ContainsKey("Австралия"))
            //{
            //    Console.WriteLine(countriesCapitals["Австралия"]);
            //}
            //else
            //{
            //    Console.WriteLine("Такой страны не существует.");
            //}
            {
                countriesCapitals.Add("Австралия", "Канберра");
                countriesCapitals.Add("Турция", "Анкара");
                countriesCapitals.Add("Швейцария", "Берн");
            }

            //foreach( var item in countriesCapitals)
            //{
            //    Console.WriteLine($"Страна - {item.Key} столица {item.Value}");
            //}

            countriesCapitals.Remove("Турция");

            foreach (var value in countriesCapitals.Values)
            {
                Console.WriteLine($"Страна -  столица {value}");
            }


            Console.ReadKey();
        }
    }
}
