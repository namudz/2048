using DomainLayer.Grid;

namespace InterfaceAdaptersLayer.Grid
{
    public interface IGridHelper
    {
        Cell GetRandomEmptyCell(DomainLayer.Grid.Grid grid);
    }
}