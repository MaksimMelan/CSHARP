using System;


namespace _0012_CurrencyConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandRurToUsd = "1";
            const string CommandRurToCnh = "2";
            const string CommandUsdToRur = "3";
            const string CommandUsdToCnh = "4";
            const string CommandCnhToRur = "5";
            const string CommandCnhToUsd = "6";
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
                                 $"\n{CommandRurToUsd} - обменять рубли на доллары.\n{CommandRurToCnh} - обменять рубли на юани." +
                                 $"\n{CommandUsdToRur} - обменять доллраны на рубли.\n{CommandUsdToCnh} - обменять доллары на юани." +
                                 $"\n{CommandCnhToRur} - обмен юани на рубли.\n{CommandCnhToUsd} - обмен юаней на доллары." +
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
                    case CommandRurToUsd:
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

                    case CommandRurToCnh:
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

                    case CommandUsdToRur:
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

                    case CommandUsdToCnh:
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

                    case CommandCnhToRur:
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

                    case CommandCnhToUsd:
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
