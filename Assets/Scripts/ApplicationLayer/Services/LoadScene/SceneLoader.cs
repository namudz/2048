using System.Collections.Generic;
using InterfaceAdaptersLayer;
using InterfaceAdaptersLayer.Services.LoadScene;
using UnityEngine.SceneManagement;

namespace ApplicationLayer.Services.LoadScene
{
    public class SceneLoader : ISceneLoader
    {
        private readonly Dictionary<SceneConstants.Scene, string> _scenes = new Dictionary<SceneConstants.Scene,string>
        {
            { SceneConstants.Scene.Splash, "0_SplashScene" },
            { SceneConstants.Scene.Game, "1_GameScene" }
        };

        private readonly IEventDispatcher _eventDispatcher;
        private readonly ISceneManagerAdapter _sceneManagerAdapter;
        private SceneConstants.Scene _sceneLoaded;

        public SceneLoader(IEventDispatcher eventDispatcher, ISceneManagerAdapter sceneManagerAdapter)
        {
            _eventDispatcher = eventDispatcher;
            _sceneManagerAdapter = sceneManagerAdapter;
        }

        public void LoadScene(SceneConstants.Scene scene, LoadSceneMode mode)
        {
            _sceneLoaded = scene;
            _sceneManagerAdapter.LoadSceneAsync(_scenes[scene], DispatchSceneLoadedEvent, mode);
        }
        
        private void DispatchSceneLoadedEvent()
        {
            _eventDispatcher.Dispatch(new SceneLoadedSignal(_sceneLoaded));
        }
    }
}