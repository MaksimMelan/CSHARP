using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0017_Boss_Fight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandSimplyAttack = "1";
            const string CommandFireball = "2";
            const string CommandExplosion = "3";
            const string CommandHealing = "4";

            Random random = new Random();

            int healthPointsHero = 1000;
            int healthPointsBoss = 1000;
            int defaultHealthPointsHero = 1000;

            int energyHero = 1000;
            int energyDefaultHero = 1000;
            int energyConsumptionByFireball = 100;

            int damageSimplyAttack = 50;
            int damageFireballAttack = 100;
            int damageExplosionAttack = 200;
            int healingAttack = 200;
            int countHealingAttack = 5;
            int damageAttackBoss = 0;

            bool isUsedFireball = false;

            string inputСommand = "";

            string bossName = "Босс ";
            string heroName = "Герой ";
            string messageHealth = " здоровье - ";
            string messageEnergyHero = "; энергия - ";
            string playerMenu = "Какие Ваши действия? \nварианты: ";
            string attackMessage = " атаковал ";
            string messageUsedFireball = "Фаербол использован! ";
            string messageNotUsedFireball = "Фаербол не использован";
            string messageNoEnergyUsedFireball = "Нет энергии! ";
            string messageInputIrror = "Такой команды не существует!";
            string messageDeathHero = "Герой умер. Вы проиграли!";
            string messageDeathBoss = "Босс умер. ВЫ выиграли!";
            string messageDraw = "Ничья";
            string messageSimply = " - обычная атака: урон - ";
            string messageFireball = " - фаербол: урон - ";
            string messageEnergyConsumptionByFireball = " затраты энергии - ";
            string messageExplosion = " - взрыв: урон - ";
            string messageHealing = " - лечение: востонавливает здоровья - ";
            string messageCountHealingAttack = " осталось лечений - ";
            string messageSkippingMove = "Пропуск хода!";
            string messagePlayer = "Готов к бою ";
            string messageBoss = "Готов к бою  ";
            string messageNotHealingAttack = "Лечение невозможно";
            string messageСonditionFireball = " Можно вызывать, только если был использован огненный шар.\n    Для повторного применения надо повторно использовать огненный шар. ";
            string messageСonditionFireballUsed = "Фаербол не использован ";

            while (healthPointsHero > 0 && healthPointsBoss > 0)
            {
                Console.WriteLine(playerMenu +
                    "\n" + CommandSimplyAttack + messageSimply + damageSimplyAttack +
                    "\n" + CommandFireball + messageFireball + damageFireballAttack + messageEnergyConsumptionByFireball + energyConsumptionByFireball +
                    "\n" + CommandExplosion + messageExplosion + damageExplosionAttack + messageСonditionFireball + messageСonditionFireballUsed +
                    "\n" + CommandHealing + messageHealing + healingAttack + messageCountHealingAttack + countHealingAttack);
                Console.WriteLine();
                Console.WriteLine(heroName + messageHealth + healthPointsHero + messageEnergyHero + energyHero);
                Console.WriteLine(bossName + messageHealth + healthPointsBoss);
                Console.WriteLine();
                Console.WriteLine(messagePlayer);
                Console.WriteLine(messageBoss);
                Console.Write("Введите номер атаки - ");

                inputСommand = Console.ReadLine();

                Console.WriteLine();

                switch (inputСommand)
                {
                    case CommandSimplyAttack:
                        healthPointsBoss -= damageSimplyAttack;
                        messagePlayer = heroName + attackMessage + CommandSimplyAttack + messageSimply + damageSimplyAttack;
                        break;

                    case CommandFireball:

                        if (energyHero >= energyConsumptionByFireball)
                        {
                            energyHero -= energyConsumptionByFireball;
                            healthPointsBoss -= damageFireballAttack;
                            messagePlayer = heroName + attackMessage + CommandFireball + messageFireball + damageFireballAttack + messageEnergyHero + energyConsumptionByFireball;
                            isUsedFireball = true;
                            messageСonditionFireballUsed = messageUsedFireball;
                            break;
                        }
                        else
                        {
                            messagePlayer = heroName + messageSkippingMove + messageNoEnergyUsedFireball;
                        }
                        break;

                    case CommandExplosion:

                        if (isUsedFireball == true)
                        {
                            healthPointsBoss -= damageExplosionAttack;
                            messagePlayer = heroName + attackMessage + CommandExplosion + messageExplosion + damageExplosionAttack;
                            isUsedFireball = false;
                            messageСonditionFireballUsed = messageNotUsedFireball;
                        }
                        else
                        {
                            messagePlayer = heroName + messageSkippingMove + messageUsedFireball;
                        }
                        break;

                    case CommandHealing:

                        if (countHealingAttack > 0)
                        {
                            messagePlayer = heroName + attackMessage + CommandHealing + messageHealing + healingAttack;
                            energyHero = energyDefaultHero;
                            healthPointsHero += healingAttack;

                            if (healthPointsHero > 1000)
                            {
                                healthPointsHero = defaultHealthPointsHero;
                            }
                            countHealingAttack--;
                        }
                        else
                        {
                            messagePlayer = messageNotHealingAttack + messageCountHealingAttack + countHealingAttack;
                        }
                        break;

                    default:
                        messagePlayer = messageInputIrror + messageSkippingMove;
                        break;
                }

                damageAttackBoss = (int)random.Next(50, 150);
                healthPointsHero -= damageAttackBoss;
                messageBoss = bossName + attackMessage + damageAttackBoss;
                Console.Clear();
            }

            if (healthPointsHero > 0 && healthPointsBoss > 0)
            {
                Console.WriteLine(messageDraw);
            }
            else if (healthPointsBoss > 0)
            {
                Console.WriteLine(messageDeathHero);
            }
            else
            {
                Console.WriteLine(messageDeathBoss);
            }

            Console.ReadKey();
        }
    }
}
