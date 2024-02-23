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

            int energyHero = 1000;
            int energyBoss = 1000;
            int energySimplyAttack = 10;
            int energyConsumptionByFireball = 100;
            int energyConsumptionByExplosion = 100;
            int energyConsumptionByHealing = 50;
            int energySimplySmoke = 10;

            int damageSimplyAttack = 50;
            int damageFireballAttack = 100;
            int damageExplosionAttack = 200;
            int healingAttack = 100;
            int smokeAttack = 300;

            int inputСommands;
            bool usedFireball = false;
            bool smokeAttackHero = false;
            bool smokeAttackBoss = false;

            string hero = "Герой ";
            string boss = "Босс ";
            string messageHealthHero = "здоровье: " + healthPointsHero + "; энергия: " + energyHero;
            string messagehealthBoss = "здоровье: " + healthPointsBoss + "; энергия: " + energyBoss;
            string playerMenu = "Какие Ваши действия? \nварианты: ";
            string messageSimply = "1 - обычная атака: урон  " + damageSimplyAttack + ", затраты энергии " + energySimplyAttack + ";";
            string messageFireball = "2 - фаербол: урон " + damageFireballAttack + ", затраты энергии " + energyConsumptionByFireball + ";";
            string messageExplosion = "3 - взрыв: урон " + damageExplosionAttack + ", затраты энергии;" + energyConsumptionByExplosion + ";";
            string messageHealing = "4 - лечение: востонавливает здоровья " + healingAttack + ", затраты энергии " + energyConsumptionByHealing + ";";
            string messageSmoke = "5 - дым: затраты энергии " + energySimplySmoke + " востановление энергии: " + smokeAttack + ";";
            string attackMessage = " выбрал атаку - ";
            string skippingMove = "Пропуск хода!";


            while (closeProgram == false)
            {
                Console.WriteLine(hero, messageHealthHero);
                Console.WriteLine(boss, messagehealthBoss);
                Console.WriteLine(playerMenu, messageSimply, messageFireball, messageExplosion, messageHealing, messageSmoke);
                inputСommands = int.Parse(Console.ReadLine());

                switch (inputСommands)
                {
                    case 1:
                        if (smokeAttackBoss != false)
                        {
                            energyHero -= energySimplyAttack;
                            healthPointsBoss -= damageSimplyAttack;
                            Console.WriteLine(hero, attackMessage, messageSimply);
                            usedFireball = false;
                        }
                        else
                        {
                            Console.WriteLine(hero, skippingMove, boss, attackMessage, messageSmoke);
                        }
                        break;

                    case 2:
                        if (usedFireball != true)
                        {
                            if (smokeAttackBoss != false)
                            {
                                energyHero -= energyConsumptionByFireball;
                                healthPointsBoss -= damageFireballAttack;
                                Console.WriteLine(hero, attackMessage, messageFireball);
                                usedFireball = true;
                            }
                            else
                            {
                                Console.WriteLine(hero, skippingMove, boss, attackMessage, messageSmoke);
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine(hero, skippingMove, hero, attackMessage, messageSmoke);
                        }
                        break;
                        break;

                    case 3:
                        if (smokeAttackBoss != false)
                        {
                            energyHero -= energyConsumptionByExplosion;
                            healthPointsBoss -= damageExplosionAttack;
                            Console.WriteLine(hero, attackMessage, messageExplosion);
                            usedFireball = false;
                        }
                        else
                        {
                            Console.WriteLine(hero, skippingMove, hero, attackMessage, messageSmoke);
                        }
                        break;

                    case 4:
                        energyHero -= energyConsumptionByHealing;
                        healthPointsHero += healingAttack;
                        Console.WriteLine(hero,  attackMessage, messageHealing);
                        usedFireball = false;
                        break;

                    case 5:
                        energyHero -= energySimplySmoke;
                        energyHero += smokeAttack;
                        Console.WriteLine(hero, attackMessage, messageSmoke);
                        smokeAttackHero = true;
                        break;

                    default:

                        break;


                }
            }
        }
    }
}
