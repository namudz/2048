using DomainLayer.Tiles;
using UnityEngine.Assertions;

namespace DomainLayer.Grid
{
    public class Cell
    {
        public readonly Coordinates Coordinates;
        public Tile Tile { get; private set; }

        public Cell(Coordinates coordinates)
        {
            Coordinates = coordinates;
        }

        public void Clear()
        {
            Tile = null;
        }

        public void SetTile(Tile tile)
        {
            Assert.IsNotNull(tile, "Tile value can't be null");
            Tile = tile;
        }
    }
}