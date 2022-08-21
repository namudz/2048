using System.Collections.Generic;
using DomainLayer.Grid;
using UnityEngine;
using Random = System.Random;

namespace InterfaceAdaptersLayer.Grid
{
    public class GridHelper : IGridHelper
    {
        private readonly Random _random;

        public GridHelper(Random random)
        {
            // TODO: use deterministic random
            _random = random;
        }
        
        public Cell GetRandomEmptyCell(DomainLayer.Grid.Grid grid)
        {
            ICollection<Coordinates> excludedCoordinates = new List<Coordinates>(grid.CellsCount);
            
            while (excludedCoordinates.Count < grid.CellsCount)
            {
                var coordinate = new Coordinates(
                    _random.Next(0, grid.Rows),
                    _random.Next(0, grid.Columns)
                );

                var cell = grid.GetCell(coordinate.X, coordinate.Y);
                if (cell.Tile == null)
                {
                    return cell;
                }
                
                excludedCoordinates.Add(coordinate);
            }
            
            Debug.LogError("GridHelper - No empty cells found");
            return null;
        }
    }
}