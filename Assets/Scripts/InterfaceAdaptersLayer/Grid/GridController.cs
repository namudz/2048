using DomainLayer.Grid;

namespace InterfaceAdaptersLayer.Grid
{
    public class GridController : IGridController
    {
        public DomainLayer.Grid.Grid Grid { get; private set; }
        
        private readonly IGridLoader _gridLoader;
        private readonly ITileSpawner _tileSpawner;

        public GridController(
            IGridLoader gridLoader,
            ITileSpawner tileSpawner)
        {
            _gridLoader = gridLoader;
            _tileSpawner = tileSpawner;
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

        private DomainLayer.Grid.Grid CreateGrid()
        {
            // TODO: be able to create different size grids
            var grid = new DomainLayer.Grid.Grid(GridConstants.Rows, GridConstants.Columns);
            SpawnInitialTiles(grid);
            
            return grid;
        }

        private void SpawnInitialTiles(DomainLayer.Grid.Grid grid)
        {
            _tileSpawner.SpawnTile(grid);
            _tileSpawner.SpawnTile(grid);
        }
    }
}