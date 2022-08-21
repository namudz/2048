using ApplicationLayer.Renderers;
using InterfaceAdaptersLayer.Grid;
using UnityEngine;

namespace Installers
{
    public class GameScreenInstaller : MonoBehaviour
    {
        [SerializeField] private GameController _gameController;
        
        private IGridController _gridController;

        private void Awake()
        {
            InitializeDependencies();
            
            _gameController.InjectDependencies(_gridController);
        }

        private void Start()
        {
            _gameController.StartGame();
        }

        private void InitializeDependencies()
        {
            var gridLoader = new GridLoader();
            var tileSpawner = new TileSpawner(new TileGenerator(), new GridHelper(new System.Random()));
            
            _gridController = new GridController(gridLoader, tileSpawner);
        }
    }
}