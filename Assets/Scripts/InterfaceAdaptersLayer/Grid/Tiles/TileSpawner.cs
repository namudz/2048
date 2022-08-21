using DomainLayer.Grid;

namespace InterfaceAdaptersLayer.Grid
{
    public class TileSpawner : ITileSpawner
    {
        private readonly ITileGenerator _tileGenerator;
        private readonly IGridHelper _gridHelper;

        public TileSpawner(
            ITileGenerator tileGenerator,
            IGridHelper gridHelper)
        {
            _tileGenerator = tileGenerator;
            _gridHelper = gridHelper;
        }
        
        public void SpawnTile(DomainLayer.Grid.Grid grid)
        {
            var tile = _tileGenerator.GenerateTile();
            var cell = GetEmptyCell(grid);
            
            cell.SetTile(tile);
        }

        private Cell GetEmptyCell(DomainLayer.Grid.Grid grid)
        {
            return _gridHelper.GetRandomEmptyCell(grid);
        }
    }
}