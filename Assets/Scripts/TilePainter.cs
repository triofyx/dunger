using UnityEngine;
using UnityEngine.Tilemaps;

namespace Dunger
{
    public class TilePainter : MonoBehaviour
    {
        [SerializeField] RuleTile ruleTile; // Reference to your Rule Tile
        [SerializeField] Tilemap tilemap; // Reference to the Tilemap you want to paint on
        [SerializeField] Vector3Int tilePosition = new Vector3Int(10, 10, 0);

        public void PaintTile(Vector3Int position)
        {
            // Use the SetTile method of the Tilemap to paint the Rule Tile at the specified position
            tilemap.SetTile(position, ruleTile);
        }

        public void Paint()
        {
            for(int i = 0; i < tilePosition.x; i ++)
            {
                for (int j = 0; j < tilePosition.y; j++)
                {
                    //if((i == tilePosition.x - 1 && j < tilePosition.y) || (j == tilePosition.y - 1 && i < tilePosition.x) || (i == 0 && j < tilePosition.y) || (j == 0 && i < tilePosition.x))
                    //{
                        PaintTile(new Vector3Int(i, j, 0));
                    //}
                }
            }
        }

        public void RemoveRoof()
        {
            GameObject[] roofs = GameObject.FindGameObjectsWithTag("Roof");
            foreach(GameObject roof in roofs)
            {
                roof.SetActive(false);
            }
        }
    }
}
