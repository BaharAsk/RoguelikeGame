using RogueSharp;
using System;

namespace RogueSharpGame
{
    public class GameMap : Map
    {
        private readonly int width;
        private readonly int height;
        private Player player;

        public GameMap(int width, int height)
        {
            this.width = width;
            this.height = height;
            Initialize(width, height);
            GenerateMap();
        }

        public void AddPlayer(Player player)
        {
            this.player = player;
            SetCellProperties(player.X, player.Y, true, true, true);
        }

        public void Render()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    // Check if the player is at the current position
                    if (player != null && player.X == x && player.Y == y)
                    {
                        Console.Write(player.Symbol);
                    }
                    else
                    {
                        var cell = GetCell(x, y);
                        Console.Write(cell.IsWalkable ? '.' : '#');
                    }
                }
                Console.WriteLine();
            }
        }

        private void GenerateMap()
        {
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    SetCellProperties(x, y, true, true, true); // Walkable floor
                }
            }
            for (int x = 0; x < width; x++) // Border walls
            {
                SetCellProperties(x, 0, false, true, false);
                SetCellProperties(x, height - 1, false, true, false);
            }
            for (int y = 0; y < height; y++)
            {
                SetCellProperties(0, y, false, true, false);
                SetCellProperties(width - 1, y, false, true, false);
            }
        }
    }
}
