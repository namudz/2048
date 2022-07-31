using InterfaceAdaptersLayer.Services.LoadScene;
using UnityEngine.SceneManagement;

namespace InterfaceAdaptersLayer.UseCases.LoadGame
{
    public class LoadGameUseCase : ILoadGameUseCase
    {
        private readonly ISceneLoader _sceneLoader;

        public LoadGameUseCase(ISceneLoader sceneLoader)
        {
            _sceneLoader = sceneLoader;
        }

        public void LoadGame()
        {
            // TODO: Load leaderboards, etc
            _sceneLoader.LoadScene(SceneConstants.Scene.Game, LoadSceneMode.Single);
        }
    }
}