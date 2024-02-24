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
            bool closeProgram = false;
            bool DeathHero = true;
            bool DeathBoss = true;
            bool Draw = true;

            int healthPointsHero = 1000;
            int healthPointsBoss = 1000;
            int defaultHealthPointsHero = 1000;

            int energyHero = 1000;
            int energyBoss = 1000;
            int defaultEnergyHero = 1000;
            int energyConsumptionByFireball = 100;


            int damageSimplyAttack = 50;
            int damageFireballAttack = 100;
            int damageExplosionAttack = 200;
            int healingAttack = 100;
            int countHealingAttack = 5;
            int damageAttackBoss = 10;

            int inputCommand;
            bool usedFireball = false;
            bool smokeAttackHero = false;
            bool smokeAttackBoss = false;

            string hero = "Герой ";
            string boss = "Босс ";
            string messageHealthHero = "здоровье: " + healthPointsHero + "; энергия: " + energyHero;
            string messagehealthBoss = "здоровье: " + healthPointsBoss + "; энергия: " + energyBoss;
            string playerMenu = "Какие Ваши действия? \nварианты: ";
            string messageSimply = "1 - обычная атака: урон  " + damageSimplyAttack + ";";
            string messageFireball = "2 - фаербол: урон " + damageFireballAttack + ", затраты энергии " + energyConsumptionByFireball + ";";
            string messageExplosion = "3 - взрыв: урон " + damageExplosionAttack + ";";
            string messageHealing = "4 - лечение: востонавливает здоровья " + healingAttack + ", осталось лечений " + countHealingAttack + ";";
            string attackMessage = " выбрал атаку - ";
            string messageSkippingMove = "Пропуск хода!";
            string messageUsedFireball = "Фаербол использован! Повторное использование возможно после Взрыва!";
            string messageinputIrror = "Такой команды не существует!";

            while (closeProgram == false)
            {
                Console.WriteLine(hero, messageHealthHero);
                Console.WriteLine(boss, messagehealthBoss);

                Console.WriteLine(playerMenu, messageSimply, messageFireball, messageExplosion, messageHealing);
                inputCommand = int.Parse(Console.ReadLine());

                switch (inputCommand)
                {
                    case 1:                       
                            healthPointsBoss -= damageSimplyAttack;
                            Console.WriteLine(hero, attackMessage, messageSimply);                            
                        break;

                    case 2:
                        if (usedFireball == false)
                        {
                                energyHero -= energyConsumptionByFireball;
                                healthPointsBoss -= damageFireballAttack;
                                Console.WriteLine(hero, attackMessage, messageFireball);
                                usedFireball = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine(hero, messageSkippingMove, messageUsedFireball);
                        }
                        break;                   

                    case 3:
                        if (usedFireball == true)
                        {
                            healthPointsBoss -= damageExplosionAttack;
                            Console.WriteLine(hero, attackMessage, messageExplosion);
                            usedFireball = false;
                        }
                        break;

                    case 4:
                        energyHero = defaultEnergyHero;
                        healthPointsHero += healingAttack;
                        if (healthPointsHero > 1000)
                        {
                            healthPointsHero = defaultHealthPointsHero;
                            countHealingAttack--;
                        }                       
                        break;

                    default:
                        Console.WriteLine(messageinputIrror, messageSkippingMove);
                        break;
                }
            }
        }
    }
}
