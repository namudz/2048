using DomainLayer.Tiles;

namespace InterfaceAdaptersLayer.Grid
{
    public class TileGenerator : ITileGenerator
    {
        public Tile GenerateTile()
        {
            // TODO: Given some weights configuration, choose tile value
            return new Tile(2);
        }

        public Tile GenerateTile(int value)
        {
            throw new System.NotImplementedException();
        }
    }
}