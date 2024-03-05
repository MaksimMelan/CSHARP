using System;

namespace _0007_MasteringСycles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string messageRequestInput = "Напишите фразу которую нужно повторить. ";
            string messageRequestCountRepeats = "Напишите количество повторов, цифрой";
            string inputMessag;

            int countRepeats;

            Console.WriteLine(messageRequestInput);
            inputMessag = Console.ReadLine();

            Console.WriteLine(messageRequestCountRepeats);
            countRepeats = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < countRepeats; i++)
            {
                Console.WriteLine(inputMessag);
            }
            Console.ReadKey();
        }
    }
}
