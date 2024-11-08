namespace RogueSharpGame
{
    public class Monster : Actor
    {
        public char Symbol { get; set; } = 'M';

        public void MoveTowardsPlayer(Player player, GameMap map)
        {
            // Basic AI for moving towards the player
            if (player.X > X && map.IsWalkable(X + 1, Y)) X++;
            else if (player.X < X && map.IsWalkable(X - 1, Y)) X--;
            else if (player.Y > Y && map.IsWalkable(X, Y + 1)) Y++;
            else if (player.Y < Y && map.IsWalkable(X, Y - 1)) Y--;
        }
    }
}
