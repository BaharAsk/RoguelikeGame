using System;

namespace RogueSharpGame
{
    public class Game
    {
        private GameMap map;
        private Player player;
        private bool isRunning;

        public void Run()
        {
            Initialize();
            isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                map.Render();
                ProcessInput();
            }
        }

        private void Initialize()
        {
            map = new GameMap(80, 25); // Create map of width 80, height 25
            player = new Player { X = 10, Y = 10, Symbol = '@' }; // Initialize player position and symbol
            map.AddPlayer(player);
        }

        private void ProcessInput()
        {
            ConsoleKey key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.UpArrow: player.Move(0, -1, map); break;
                case ConsoleKey.DownArrow: player.Move(0, 1, map); break;
                case ConsoleKey.LeftArrow: player.Move(-1, 0, map); break;
                case ConsoleKey.RightArrow: player.Move(1, 0, map); break;
                case ConsoleKey.Escape: isRunning = false; break;
            }
        }
    }
}
