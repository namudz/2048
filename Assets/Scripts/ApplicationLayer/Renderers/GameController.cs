using ApplicationLayer.Camera;
using InterfaceAdaptersLayer.Grid;
using UnityEngine;

namespace ApplicationLayer.Renderers
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] private BoardRenderer _boardRenderer;
        [SerializeField] private CameraController _cameraController;
        
        private GridDto _grid;
        private IGridController _gridController;

        public void InjectDependencies(IGridController gridController)
        {
            _gridController = gridController;
        }

        public void StartGame()
        {
            LoadGame();
            _cameraController.AdjustToGrid(_grid);
        }

        private void LoadGame()
        {
            LoadGrid();
            RenderBoard();
        }

        private void LoadGrid()
        {
            // TODO: Must call some service that will create/load the grid, cached it and return a GridDto
            _grid = _gridController.InitializeGrid();
        }

        private void RenderBoard()
        {
            _boardRenderer.RenderBoard(_grid);
        }
    }
}