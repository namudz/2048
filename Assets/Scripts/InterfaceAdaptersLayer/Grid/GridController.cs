using DomainLayer.Grid;

namespace InterfaceAdaptersLayer.Grid
{
    public class GridController : IGridController
    {
        public DomainLayer.Grid.Grid Grid { get; private set; }
        
        private readonly IGridLoader _gridLoader;
        
        public GridController(IGridLoader gridLoader)
        {
            _gridLoader = gridLoader;
        }
        
        public GridDto InitializeGrid()
        {
            // TODO: try to load it from persistence. If null, create it
            Grid = _gridLoader.LoadGrid() ?? CreateGrid();

            return new GridDto
            {
                SizeX = Grid.Rows,
                SizeY = Grid.Columns
            };
        }

        private static DomainLayer.Grid.Grid CreateGrid()
        {
            // TODO: be able to create different size grids
            return new DomainLayer.Grid.Grid(GridConstants.Rows, GridConstants.Columns);
        }
    }
}