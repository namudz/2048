namespace InterfaceAdaptersLayer.Grid
{
    public struct GridDto
    {
        public int SizeX;
        public int SizeY;

        public GridDto(DomainLayer.Grid.Grid grid)
        {
            SizeX = grid.Rows;
            SizeY = grid.Columns;
        }
    }
}