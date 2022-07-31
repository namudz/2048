using InterfaceAdaptersLayer.Grid;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace ApplicationLayer.Renderers
{
    public class BoardRenderer : MonoBehaviour
    {
        [SerializeField] private Tilemap _tilemap;
        [SerializeField] private TileBase _cellTile;

        public void RenderBoard(GridDto grid)
        {
            for (var i = 0; i < grid.SizeX; ++i)
            {
                for (var j = 0; j < grid.SizeY; ++j)
                {
                    _tilemap.SetTile(
                        new Vector3Int(i, j, 0),
                        _cellTile
                    );
                }
            }
        }
    }
}