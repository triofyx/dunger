using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Dunger
{
    public class TilemapVisualizer : MonoBehaviour
    {
        [SerializeField] Tilemap floorTilemap, wallTilemap, roofTilemap;

        [SerializeField] TileBase floorTile, wallTile, roofTile;

        public void PaintFloorTiles(IEnumerable<Vector2Int> floorPositions)
        {
            PaintTiles(floorPositions, floorTilemap, floorTile);
        }

        public void PaintBasicWall(Vector2Int position)
        {
            PaintTile(position, wallTilemap, wallTile);
        }

        public void PaintRoof(Vector2Int position)
        {
            PaintTile(position, roofTilemap, roofTile);
        }

        void PaintTiles(IEnumerable<Vector2Int> positions, Tilemap tilemap, TileBase tile)
        {
            foreach (var position in positions)
            {
                PaintTile(position, tilemap, tile);
            }
        }

        private void PaintTile(Vector2Int position, Tilemap tilemap, TileBase tile)
        {
            var tilePosition = new Vector3Int(position.x, position.y, 0);
            tilemap.SetTile(tilePosition, tile);
        }

        public void Clear()
        {
            floorTilemap.ClearAllTiles();
            wallTilemap.ClearAllTiles();
            roofTilemap.ClearAllTiles();
        }

        public void RemoveRoof()
        {
            roofTilemap.ClearAllTiles();
        }

    }
}
