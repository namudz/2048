using System;

namespace DomainLayer.Tiles
{
    public class Tile
    {
        public Guid Id;
        public readonly int Value;

        public Tile(int value)
        {
            Id = Guid.NewGuid();
            Value = value;
        }
    }
}