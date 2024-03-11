using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0012_CurrencyConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string RurToUsd = "1";
            const string RurToCnh = "2";
            const string UsdToRur = "3";
            const string UsdToCnh = "4";
            const string CnhToRur = "5";
            const string CnhToUsd = "6";
            const string CommandExit = "7";

            double rurCount = 1000;
            double usdCount = 1000;
            double cnhCount = 1000;

            double usdToRur = 76.82;
            double rurToUsd = 1 / usdToRur;
            double usdToCnh = 6.91;
            double cnhToUsd = 1 / usdToCnh;
            double cnhToRur = 11.12;
            double rurToCnh = 1 / cnhToRur;
            double purchaseVolume;

            bool isExit = false;

            string userInput;
            string messegeExitProgram = "Завершение работы программы.\nДо свидания!";
            string wrongOption = "Такого варианта нет";
            string requestPurchaseVolume = $"Какой обобъём меняете?";
            string notEnoughMoneys = "Недостаточно денег на вашем счету.";
            string programMenu = $"\nКурс валют USD/RUR: {usdToRur}, USD/CNH: {usdToCnh}, CNH/RUR: {cnhToRur}." +
                                 $"\n "+
                                 $"\nОперации на выбор:" +
                                 $"\n{RurToUsd} - обменять рубли на доллары.\n{RurToCnh} - обменять рубли на юани." +
                                 $"\n{UsdToRur} - обменять доллраны на рубли.\n{UsdToCnh} - обменять доллары на юани." +
                                 $"\n{CnhToRur} - обмен юани на рубли.\n{CnhToUsd} - обмен юаней на доллары." +
                                 $"\n{CommandExit} - закрыть программу";

            while (isExit == false)
            {
                string messegeUserMoney = $"На вашем счету {Math.Round(rurCount, 2)} рублей, {Math.Round(usdCount, 2)} долларов, {Math.Round(cnhCount, 2)} юаней.";

                Console.WriteLine(programMenu);
                Console.WriteLine();
                Console.WriteLine(messegeUserMoney);
                Console.WriteLine();

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case RurToUsd:
                        Console.WriteLine(requestPurchaseVolume);
                        purchaseVolume = Convert.ToDouble(Console.ReadLine());

                        if (purchaseVolume <= rurCount)
                        {
                            rurCount -= purchaseVolume;
                            usdCount += purchaseVolume * rurToUsd;
                        }
                        else
                        {
                            Console.WriteLine(notEnoughMoneys);
                        }

                        break;

                    case RurToCnh:
                        Console.WriteLine(requestPurchaseVolume);
                        purchaseVolume = Convert.ToDouble(Console.ReadLine());

                        if (purchaseVolume <= rurCount)
                        {
                            rurCount -= purchaseVolume;
                            cnhCount += purchaseVolume * rurToCnh;
                        }
                        else
                        {
                            Console.WriteLine(notEnoughMoneys);
                        }

                        break;

                    case UsdToRur:
                        Console.WriteLine(requestPurchaseVolume);
                        purchaseVolume = Convert.ToDouble(Console.ReadLine());

                        if (purchaseVolume <= usdCount)
                        {
                            usdCount -= purchaseVolume;
                            rurCount += purchaseVolume * usdToRur;
                        }
                        else
                        {
                            Console.WriteLine(notEnoughMoneys);
                        }

                        break;

                    case UsdToCnh:
                        Console.WriteLine(requestPurchaseVolume);
                        purchaseVolume = Convert.ToDouble(Console.ReadLine());

                        if (purchaseVolume <= usdCount)
                        {
                            usdCount -= purchaseVolume;
                            cnhCount += purchaseVolume * usdToCnh;
                        }
                        else
                        {
                            Console.WriteLine(notEnoughMoneys);
                        }

                        break;

                    case CnhToRur:
                        Console.WriteLine(requestPurchaseVolume);
                        purchaseVolume = Convert.ToDouble(Console.ReadLine());

                        if (purchaseVolume <= cnhCount)
                        {
                            cnhCount -= purchaseVolume;
                            rurCount += purchaseVolume * cnhToRur;
                        }
                        else
                        {
                            Console.WriteLine(notEnoughMoneys);
                        }

                        break;

                    case CnhToUsd:
                        Console.WriteLine(requestPurchaseVolume);
                        purchaseVolume = Convert.ToDouble(Console.ReadLine());

                        if (purchaseVolume <= cnhCount)
                        {
                            cnhCount -= purchaseVolume;
                            usdCount += purchaseVolume * cnhToUsd;
                        }
                        else
                        {
                            Console.WriteLine(notEnoughMoneys);
                        }

                        break;

                    case CommandExit:
                        Console.WriteLine(messegeExitProgram);
                        isExit = true;
                        break;

                    default:
                        Console.WriteLine(wrongOption);
                        break;
                }

                Console.Clear();
            }
        }
    }
}
