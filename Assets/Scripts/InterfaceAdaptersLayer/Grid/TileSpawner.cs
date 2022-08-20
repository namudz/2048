using DomainLayer.Grid;

namespace InterfaceAdaptersLayer.Grid
{
    public class TileSpawner : ITileSpawner
    {
        private readonly DomainLayer.Grid.Grid _grid;
        private readonly ITileGenerator _tileGenerator;

        public TileSpawner(
            DomainLayer.Grid.Grid grid,
            ITileGenerator tileGenerator)
        {
            _grid = grid;
            _tileGenerator = tileGenerator;
        }
        
        public void SpawnTile()
        {
            var tile = _tileGenerator.GenerateTile();
            var cell = GetEmptyCell();
            
            cell.SetTile(tile);
        }

        private Cell GetEmptyCell()
        {
            // TODO: search the grid for optimum empty cell
            return null;
        }
    }
}