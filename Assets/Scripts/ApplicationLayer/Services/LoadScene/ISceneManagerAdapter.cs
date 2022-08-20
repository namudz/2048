using System;
using UnityEngine.SceneManagement;

namespace ApplicationLayer.Services.LoadScene
{
    public interface ISceneManagerAdapter
    {
        void LoadSceneAsync(string sceneName, Action onSceneLoadedCallback, LoadSceneMode mode);
    }
}