using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace S_0020_Boss_Fight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int usedFireball = 0;

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

            string boss = "Босс ";
            string hero = "Герой ";
            string messageHealth = "здоровье - ";
            string messageEnergyHero = "; энергия - " ;
            string playerMenu = "Какие Ваши действия? \nварианты: ";
            string attackMessage = " атаковал ";
            string messageUsedFireball = "Фаербол использован! Повторное использование возможно после Взрыва!";
            string messageNoEnergyUsedFireball = "Нет энергии! ";
            string messageInputIrror = "Такой команды не существует!";
            string messageDeathHero = "Герой умер. Вы проиграли!";
            string messageDeathBoss = "Босс умер. ВЫ выиграли!";
            string messageDraw = "Ничья";
            string messageSimply = "1 - обычная атака: урон - ";
            string messageFireball = "2 - фаербол: урон - ";
            string messageEnergyConsumptionByFireball  =  "затраты энергии - ";
            string messageExplosion = "3 - взрыв: урон - ";
            string messageСonditionFireball = " Можно вызывать, только если был использован огненный шар.\n    Для повторного применения надо повторно использовать огненный шар.";
            string messageHealing = "4 - лечение: востонавливает здоровья - ";
            string messageCountHealingAttack  =  " осталось лечений - ";
            string messageSkippingMove = "Пропуск хода!";
            string messagePlayer = "Готов к бою ";
            string messageBoss = "Готов к бою  ";
            string messageNotHealingAttack = "Лечение невозможно";

            while (healthPointsHero > 0 && healthPointsBoss > 0)
            {
                Console.WriteLine(playerMenu +
                    "\n" + messageSimply + damageSimplyAttack +
                    "\n" + messageFireball + damageFireballAttack + messageEnergyConsumptionByFireball + energyConsumptionByFireball + 
                    "\n" + messageExplosion + damageExplosionAttack + messageСonditionFireball + usedFireball +
                    "\n" + messageHealing + healingAttack + messageCountHealingAttack + countHealingAttack);
                 Console.WriteLine();
                Console.WriteLine(hero + messageHealth + healthPointsHero + messageEnergyHero + energyHero);
                Console.WriteLine(boss + messageHealth + healthPointsBoss);
                Console.WriteLine();
                Console.WriteLine(messagePlayer);
                Console.WriteLine(messageBoss);
                Console.Write("Введите номер атаки - ");
                int.TryParse(Console.ReadLine(),out int result);               
                Console.WriteLine();

                switch (result)
                {
                    case 1:
                        healthPointsBoss -= damageSimplyAttack;
                        messagePlayer = hero + attackMessage + messageSimply + damageSimplyAttack;

                        break;

                    case 2:
                        if (energyConsumptionByFireball > 0)
                        {
                            energyHero -= energyConsumptionByFireball;
                            healthPointsBoss -= damageFireballAttack;
                            messagePlayer = hero + attackMessage + messageFireball + damageFireballAttack + messageEnergyHero + energyConsumptionByFireball;
                            usedFireball = 1;
                            break;
                        }
                        else
                        {
                            messagePlayer = hero + messageSkippingMove + messageNoEnergyUsedFireball;
                        }
                        break;

                    case 3:
                        if (usedFireball == 1)
                        {
                            healthPointsBoss -= damageExplosionAttack;
                            messagePlayer = hero + attackMessage + messageExplosion + damageExplosionAttack;
                            usedFireball = 0;
                        }
                        else
                        {
                            messagePlayer = hero + messageSkippingMove + messageUsedFireball;
                        }                      
                        break;

                    case 4:
                        if(countHealingAttack > 0)
                        {
                            messagePlayer = hero + attackMessage + messageHealing + healingAttack;
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
                damageAttackBoss = (int)rand.Next(50, 150);
                healthPointsHero -= damageAttackBoss;
                messageBoss =boss + attackMessage +damageAttackBoss;
                Console.Clear();

            }
            if (healthPointsHero > 0 && healthPointsBoss > 0)
            {
                Console.WriteLine(messageDraw);
                Console.ReadKey();
            }
            else if (healthPointsBoss > 0)
            {
                Console.WriteLine(messageDeathHero);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(messageDeathBoss);
                Console.ReadKey();
            }
        }
    }        
}
