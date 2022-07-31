using InterfaceAdaptersLayer;
using InterfaceAdaptersLayer.Services.LoadScene;

namespace ApplicationLayer.Services.LoadScene
{
    public class SceneLoadedSignal : ISignal
    {
        public readonly SceneConstants.Scene Scene;

        public SceneLoadedSignal(SceneConstants.Scene scene)
        {
            Scene = scene;
        }
    }
}