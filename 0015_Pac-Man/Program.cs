using System;
using System.IO;
using System.Threading;//подключение многопоточности
using System.Threading.Tasks;

namespace _0015_Pac_Man
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            char[,] map = ReadMap("map.txt");

            ConsoleKeyInfo pressedKey =  new ConsoleKeyInfo('w', ConsoleKey.W, false, false, false);

            Task.Run(() =>
            {
                while (true)
                {
                    pressedKey = Console.ReadKey();
                }
            });

            int pacmanX = 1;
            int pacmanY = 1;
            int score = 0;

            while (true)
            {

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Blue;
                DrawMap(map);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(pacmanX, pacmanY);
                Console.Write("@");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(39, 0);
                Console.Write(pressedKey.KeyChar);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(29, 11);
                Console.Write($"Score:{score}|");

                //pressedKey = Console.ReadKey();//Thread.Sleep(1000);

                HandleInput(pressedKey, ref pacmanX, ref pacmanY, map, ref score);

                Thread.Sleep(1000);

            }
        }

        private static char[,] ReadMap(string path)
        {
            string[] file = File.ReadAllLines("map.txt");

            char[,] map = new char[GetMaxLenthOfLine(file), file.Length];// 28, 11 ( а в фале показано 11, 28)

            for (int x = 0; x < map.GetLength(0); x++)  //file[0][0]
                for (int y = 0; y < map.GetLength(1); y++)
                    map[x, y] = file[y][x];

            return map;
        }

        private static void DrawMap(char[,] map)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                for (int x = 0; x < map.GetLength(0); x++)
                {
                    Console.Write(map[x, y]);
                }

                Console.Write("\n");
            }

        }

        private static void HandleInput(ConsoleKeyInfo pressedKey, ref int pacmanX, ref int pacmanY, char[,] map, ref int score)
        {
            int[] derection = GetDirection(pressedKey);

            int nextPacmanPositionX = pacmanX + derection[0];
            int nextPacmanPositionY = pacmanY + derection[1];

            char nextCell = map[nextPacmanPositionX, nextPacmanPositionY];

            if(nextCell == ' ' || nextCell == '.')
            {
                pacmanX = nextPacmanPositionX;
                pacmanY = nextPacmanPositionY;

                if(nextCell == '.')
                {
                    score++;
                    map[nextPacmanPositionX, nextPacmanPositionY] = ' ';
                }
            }

            /*
            if (map[nextPacmanPositionX, nextPacmanPositionY] == ' ')
            {
                pacmanX = nextPacmanPositionX;
                pacmanY = nextPacmanPositionY;
            }
            */

            /*
             if (pressedKey.Key == ConsoleKey.UpArrow)
                pacmanY -= 1;
            else if (pressedKey.Key == ConsoleKey.DownArrow)
                pacmanY += 1;
            else if (pressedKey.Key == ConsoleKey.LeftArrow)
                pacmanX -= 1;
            else if (pressedKey.Key == ConsoleKey.RightArrow)
                pacmanX += 1;
*/
            /*
            if(pacmanX < 0) pacmanX = 0;   
            if(pacmanX > 429) { }
            */
        }

        private static int[] GetDirection(ConsoleKeyInfo pressedKey) // направление берём от нажатой клавиши.
        {
            int[] direction = { 0, 0 };

            if (pressedKey.Key == ConsoleKey.UpArrow)
                direction[1] = -1;
            else if (pressedKey.Key == ConsoleKey.DownArrow)
                direction[1] = 1;
            else if (pressedKey.Key == ConsoleKey.LeftArrow)
                direction[0] = -1;
            else if (pressedKey.Key == ConsoleKey.RightArrow)
                direction[0] = 1;

            return direction;
        }
        private static int GetMaxLenthOfLine(string[] lines)
        {
            int maxLength = lines[0].Length;

            foreach (var line in lines)
                if(line.Length > maxLength)
                    maxLength = line.Length;

            return maxLength;
        }
    }
}
