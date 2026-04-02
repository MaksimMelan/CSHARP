using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0032_L_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> patients = new Queue<string>();
            patients.Enqueue("Семёнов");
            patients.Enqueue("Анисимов");
            patients.Enqueue("Иванов");
            patients.Enqueue("Ерёмин");
            patients.Enqueue("Васильев");

            Console.WriteLine("Удаляем первый элемент: " + patients.Dequeue());
            Console.WriteLine("Новый первый элемент в очереди: " + patients.Peek());
            Console.WriteLine("Все элементы в очереди:");
            foreach (var patien in patients)
            {
                Console.WriteLine(patien);
            }
            Console.ReadKey();
        }
    }
}
