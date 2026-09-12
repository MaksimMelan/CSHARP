using System;

class PacManGame
{
    static void Main()
    {
        int width = 20;
        int height = 20;
        int playerX = 5;
        int playerY = 5;
        bool[,] maze = new bool[width, height];

        // Initialize the maze with walls
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                maze[x, y] = (x == 0 || x == width - 1 || y == 0 || y == height - 1);
            }
        }

        while (true)
        {
            Console.Clear();
            // Draw the maze
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (maze[x, y])
                        Console.Write("#");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

            // Draw the player
            Console.SetCursorPosition(playerX, playerY);
            Console.Write("@");

            // Get user input
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.RightArrow:
                    playerX++;
                    break;
                case ConsoleKey.LeftArrow:
                    playerX--;
                    break;
            }

            // Add a small delay to control speed
            System.Threading.Thread.Sleep(100);
        }
    }
}