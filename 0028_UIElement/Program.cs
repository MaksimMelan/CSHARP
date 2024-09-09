using System;

namespace _0028_UIElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 5, maxHealth = 10;
            int mana = 7, maxMana = 10;
            int satisfied = 8, maxSatisfied = 10;
            int fatigueSun = 4, maxFatigueSun = 10;
            int tiredness = 6, maxTiredness = 10;

            DrawBar(health, maxHealth, ConsoleColor.Green, ConsoleColor.Red, 0, '#' );
            DrawBar(mana, maxMana, ConsoleColor.Blue, ConsoleColor.Red, 1, '@');
            DrawBar(satisfied, maxSatisfied, ConsoleColor.Yellow, ConsoleColor.Yellow, 2);
            DrawBar(fatigueSun, maxFatigueSun, ConsoleColor.White, ConsoleColor.White, 3);
            DrawBar(tiredness, maxTiredness, ConsoleColor.Red, ConsoleColor.Green, 4, '#');

            Console.ReadKey();

        }
        static void DrawBar(int fillSizeScale, int maxSizeScale, ConsoleColor color, ConsoleColor textСolor, int position, char simbol = '_')
        {
            ConsoleColor defaultColor = Console.BackgroundColor;

            string bar = "";

            for(int i = 0; i < fillSizeScale; i++)
            {                
                bar += simbol;
            }

            Console.SetCursorPosition(0, position);
            Console.ForegroundColor = textСolor;
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;

            bar = "";

            for( int i = fillSizeScale; i < maxSizeScale; i++)
            {
                bar += "_";
            }

            Console.Write(bar + ']');
        }
    }
}
