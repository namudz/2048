using DomainLayer.Tiles;

namespace InterfaceAdaptersLayer.Grid
{
    public interface ITileGenerator
    {
        Tile GenerateTile();
        Tile GenerateTile(int value);
    }
}