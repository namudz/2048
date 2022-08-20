using System;

namespace DomainLayer.Grid
{
    public class Grid
    {
        public int Rows;
        public int Columns;
        public Cell[,] Cells { get; }

        public Grid(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Cells = new Cell[rows, columns];
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
            
            return Cells[row, column];
        }
    }
}