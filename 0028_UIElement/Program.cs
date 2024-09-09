using System;

namespace _0028_UIElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 5;
            int maxHealth = 10;

            int mana = 7;
            int maxMana = 10;

            int satisfied = 8;
            int maxSatisfied = 10;

            int fatigueSun = 4;
            int maxFatigueSun = 10;

            int tiredness = 6;
            int maxTiredness = 10;

            DrawBar(health, maxHealth, ConsoleColor.Green, ConsoleColor.Red, 0, '#');
            DrawBar(mana, maxMana, ConsoleColor.Blue, ConsoleColor.Red, 1, '@');
            DrawBar(satisfied, maxSatisfied, ConsoleColor.Yellow, ConsoleColor.Yellow, 2);
            DrawBar(fatigueSun, maxFatigueSun, ConsoleColor.White, ConsoleColor.White, 3);
            DrawBar(tiredness, maxTiredness, ConsoleColor.Red, ConsoleColor.Green, 4, '#');

            Console.ReadKey();
        }

        static string FillBar(int stringLengh, char simbol)
        {
            string bar = "";

            for (int i = 0; i < stringLengh; i++)
            {
                bar += simbol;
            }

            return bar;
        }

        static void DrawBar(int fillSizeScale, int maxSizeScale, ConsoleColor color, ConsoleColor textСolor, int position, char simbolFill = '#', char simbolVoid = '_')
        {
            int emptySizeScale;

            emptySizeScale = maxSizeScale - fillSizeScale;

            ConsoleColor defaultColor = Console.BackgroundColor;

            Console.SetCursorPosition(0, position);
            Console.ForegroundColor = textСolor;
            Console.Write('[');

            Console.BackgroundColor = color;
            Console.Write(FillBar(fillSizeScale, simbolFill));

            Console.BackgroundColor = defaultColor;
            Console.Write(FillBar(emptySizeScale , simbolVoid) + ']');
        }
    }
}
