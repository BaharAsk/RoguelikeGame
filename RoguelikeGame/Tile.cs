namespace RogueSharpGame
{
    public class Tile
    {
        public bool IsWalkable { get; set; }
        public bool BlocksVision { get; set; }
        public char Symbol { get; set; }

        public Tile(bool isWalkable, bool blocksVision, char symbol)
        {
            IsWalkable = isWalkable;
            BlocksVision = blocksVision;
            Symbol = symbol;
        }
    }
}

