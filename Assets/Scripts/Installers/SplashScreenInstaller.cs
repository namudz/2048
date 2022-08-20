using ApplicationLayer.Services.LoadScene;
using InterfaceAdaptersLayer;
using InterfaceAdaptersLayer.UseCases.LoadGame;

namespace Installers
{
    public class SplashScreenInstaller
    {
        private readonly IEventDispatcher _eventDispatcher;

        public SplashScreenInstaller(IEventDispatcher eventDispatcher)
        {
            _eventDispatcher = eventDispatcher;
        }
        
        public void InitializeGame()
        {
            var initializeGameUseCase = GetLoadGameUseCase();
            initializeGameUseCase.LoadGame();
        }

        private ILoadGameUseCase GetLoadGameUseCase()
        {
            var sceneLoader = new SceneLoader(_eventDispatcher, new SceneManagerAdapter());
            return new LoadGameUseCase(sceneLoader);
        }
    }
}