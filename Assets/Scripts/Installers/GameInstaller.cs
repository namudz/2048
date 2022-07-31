using InterfaceAdaptersLayer;
using UnityEngine;

namespace Installers
{
    public class GameInstaller : MonoBehaviour
    {
        private SplashScreenInstaller _splashInstaller;
        private IEventDispatcher _eventDispatcher;

        private void Awake()
        {
            DontDestroyOnLoad(this);
            
            // TODO: Initialize Ads, Analytics, etc
            InitializeDependencies();
        }

        private void InitializeDependencies()
        {
            _eventDispatcher = new EventDispatcher();
            _splashInstaller = new SplashScreenInstaller(_eventDispatcher);
        }

        private void Start()
        {
            _splashInstaller.InitializeGame();
        }
    }
}