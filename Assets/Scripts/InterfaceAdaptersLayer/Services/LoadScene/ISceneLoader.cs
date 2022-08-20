using UnityEngine.SceneManagement;

namespace InterfaceAdaptersLayer.Services.LoadScene
{
    public interface ISceneLoader
    {
        void LoadScene(SceneConstants.Scene scene, LoadSceneMode mode);
    }
}