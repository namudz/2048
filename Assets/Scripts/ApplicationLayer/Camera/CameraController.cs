using InterfaceAdaptersLayer.Grid;
using UnityEngine;

namespace ApplicationLayer.Camera
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private UnityEngine.Camera _camera;
        [SerializeField] private Transform _cameraTransform;

        private const float PositionZ = -100f;

        public void AdjustToGrid(GridDto gridDto)
        {
            // TODO: Set ortographicSize based on max size & adjust taking UI into account
            var position = GetGridCenterPosition(gridDto);
            _cameraTransform.position = position;
        }

        private static Vector3 GetGridCenterPosition(GridDto gridDto)
        {
            return new Vector3(
                gridDto.SizeX / 2f,
                gridDto.SizeY / 2f,
                PositionZ
            );
        }
    }
}