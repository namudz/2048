namespace InterfaceAdaptersLayer.Grid
{
    public interface IGridController
    {
        DomainLayer.Grid.Grid Grid { get; }

        GridDto InitializeGrid();
    }
}