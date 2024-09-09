using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0028_UIElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 5, maxHealth = 10;
            int mana = 7, maxMana = 10;
            DrawBar(health, maxHealth, ConsoleColor.Green, 0 );
            DrawBar(mana, maxMana, ConsoleColor.Blue, 1);

            Console.ReadKey();

        }
        static void DrawBar(int fillSizeScale,  int maxSizeScale, ConsoleColor color, int position)
        {
            ConsoleColor defaultColor = Console.BackgroundColor;

            string bar = "";

            for(int i = 0; i < fillSizeScale; i++)
            {                
                bar += "_";
            }

            Console.SetCursorPosition(0, position);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.ForegroundColor = defaultColor;

            bar = "";

            for( int i = fillSizeScale; i < maxSizeScale; i++)
            {
                bar += "_";
            }

            Console.Write(bar + ']');
        }
    }
}
