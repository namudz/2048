using System;
using System.Collections;
using System.Collections.Generic;

namespace DomainLayer.Grid
{
    public class Grid
    {
        public readonly int Rows;
        public readonly int Columns;
        public readonly int CellsCount;
        public List<Cell> Cells { get; }

        public Grid(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            
            CellsCount = Rows * Columns;
            Cells = new List<Cell>(CellsCount);

            InitializeCells();
        }

        public Cell GetCell(int row, int column)
        {
            if (row < 0 || row >= Rows)
            {
                throw new ArgumentNullException($"Row {row} not valid");
            }
            
            if (column < 0 || column >= Columns)
            {
                throw new ArgumentNullException($"Column {column} not valid");
            }

            return Cells.Find(c => c.Coordinates.X == row && c.Coordinates.Y == column);
        }

        private void InitializeCells()
        {
            for (var row = 0; row < CellsCount; row++)
            {
                for (var column = 0; column < Columns; column++)
                {
                    var coordinates = new Coordinates(row, column);
                    Cells.Add(new Cell(coordinates));
                }
            }
        }
    }
}