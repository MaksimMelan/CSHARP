using System;  
using System.IO;
using System.Reflection.Metadata;

namespace _0031_Brave_new_world
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey exitKey = ConsoleKey.Escape;

            ConsoleKey moveUpKeys = ConsoleKey.UpArrow;
            ConsoleKey moveDownKeys = ConsoleKey.DownArrow;
            ConsoleKey moveLeftKeys = ConsoleKey.LeftArrow;
            ConsoleKey moveRightKeys = ConsoleKey.RightArrow;

            bool isWork = true;

            string mesageExit = "Выход - нажмите любую клавишу!";
            string mapFileName = "map.txt";

            char[,] map = ReadMap(mapFileName);
            ConsoleKeyInfo pressedKey = new ConsoleKeyInfo('W', ConsoleKey.W, false, false, false);

            int pacmanX = 1;
            int pacmanY = 1;

            while (isWork)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                DrawMap(map);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(pacmanX, pacmanY);
                Console.WriteLine("@");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(38, 0);
                Console.Write(pressedKey.KeyChar);

                pressedKey = Console.ReadKey();

                if (pressedKey.Key == exitKey)
                {
                    isWork = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(5, 4);
                    Console.WriteLine(mesageExit);

                    Console.ReadKey();
                }
                    

                GetMovingUnit(pressedKey, ref pacmanX, ref pacmanY, map, ref  moveUpKeys, ref  moveDownKeys, ref  moveLeftKeys, ref  moveRightKeys);


            }
        }

        private static char[,] ReadMap(string path)
        {
            string[] file = File.ReadAllLines(path);

            char[,] map = new char[GetMaxLengthOfLine(file), file.Length]; 
            
            for(int x = 0; x < map.GetLength(0); x++) 
                for(int y = 0; y < map.GetLength(1); y++)
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

        private static void GetMovingUnit(ConsoleKeyInfo pressedKey, ref int pacmanX, ref int pacmanY, char[,] map, ref ConsoleKey moveUpKeys, ref ConsoleKey moveDownKeys, ref ConsoleKey moveLeftKeys, ref ConsoleKey moveRightKeys)
        {
            int[] direction = GetDirection(pressedKey, ref  moveUpKeys, ref moveDownKeys, ref  moveLeftKeys, ref  moveRightKeys);

            int nextPacmanPositionX = pacmanX + direction[0];
            int nextPacmanPositionY = pacmanY + direction[1];

            if (map[nextPacmanPositionX, nextPacmanPositionY] ==  ' ')
            {
                pacmanX = nextPacmanPositionX;
                pacmanY = nextPacmanPositionY;
            }
        }

        private static int[] GetDirection(ConsoleKeyInfo pressedKey, ref ConsoleKey moveUpKeys, ref ConsoleKey moveDownKeys, ref ConsoleKey moveLeftKeys, ref ConsoleKey moveRightKeys)
        {
            int[] direction = {0, 0};

            if (pressedKey.Key == moveUpKeys)
                direction[1] -= 1;
            else if (pressedKey.Key == moveDownKeys)
                direction[1] += 1;
            else if (pressedKey.Key == moveLeftKeys)
                direction[0] -= 1;
            else if (pressedKey.Key == moveRightKeys)
                direction[0] += 1;

            return direction;
        }

        private static int GetMaxLengthOfLine(string[] lines)
        {
            int maxLength = lines[0].Length;

            foreach (var line in lines)
                if (line.Length > maxLength)
                    maxLength = line.Length;

            return maxLength;
        }
    }
}
