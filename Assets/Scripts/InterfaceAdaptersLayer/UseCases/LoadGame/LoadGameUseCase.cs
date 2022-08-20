using System;
using System.Threading.Tasks;
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

        public async void LoadGame()
        {
            // TODO: Load leaderboards, etc; then load game scene
            await Task.Run(SimulateLoadingStuff);
            LoadGameScene();
        }

        private async Task SimulateLoadingStuff()
        {
            await Task.Delay(TimeSpan.FromSeconds(1.5f));
        }

        private void LoadGameScene()
        {
            _sceneLoader.LoadScene(SceneConstants.Scene.Game, LoadSceneMode.Single);
        }
    }
}