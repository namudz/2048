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

        public void Start()
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
            _grid = new GridDto
            {
                SizeX = 3,
                SizeY = 4
            };
        }

        private void RenderBoard()
        {
            _boardRenderer.RenderBoard(_grid);
        }
    }
}