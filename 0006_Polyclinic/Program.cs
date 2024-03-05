using System;

namespace _0006_Polyclinic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MinutesInHour = 60;

            string messageInputCountPeople = "Введите колличестов людей в очереди: ";
            string messageWaitingTime = "Время ожидания вашей очереди - ";

            int countPeople = 0;
            int timeOnePersonInMinutes = 10;
            int waitingTimeMinutes = 0;
            int waitingTimeHours = 0;
            int waitingTimeMinutesStat = 0; 

            Console.WriteLine(messageInputCountPeople);

            countPeople = int.Parse(Console.ReadLine());

            waitingTimeMinutes = countPeople * timeOnePersonInMinutes;
            waitingTimeHours = waitingTimeMinutes / MinutesInHour;
            waitingTimeMinutesStat = waitingTimeMinutes % MinutesInHour;

            Console.WriteLine(messageWaitingTime + waitingTimeHours + " часа " + waitingTimeMinutesStat + " минут.");

            Console.ReadKey();
        }
    }
}
