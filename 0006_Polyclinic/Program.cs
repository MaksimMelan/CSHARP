using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _0006_Polyclinic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string messageInputCountPeople = "Введите колличестов людей в очереди: ";
            string messageWaitingTime = "Время ожидания вашей очереди - ";

            int countPeople = 0;
            int timeOnePerson = 10;
            int waitingTime = 0;

            Console.WriteLine(messageInputCountPeople);

            countPeople = int.Parse(messageWaitingTime);

            waitingTime = countPeople * timeOnePerson;

            Console.WriteLine(messageWaitingTime + waitingTime);

            Console.ReadKey();
        }
    }
}
