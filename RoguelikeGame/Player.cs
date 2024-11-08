namespace RogueSharpGame
{
    public class Player : Actor
    {
        public char Symbol { get; set; } = '@';

        public void Move(int dx, int dy, GameMap map)
        {
            int newX = X + dx;
            int newY = Y + dy;
            // Only move if the new cell is walkable
            if (map.IsWalkable(newX, newY))
            {
                X = newX;
                Y = newY;
            }
        }
    }
}
