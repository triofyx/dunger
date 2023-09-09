using UnityEngine;

namespace Dunger
{
    public abstract class Dungeon : MonoBehaviour
    {
        [SerializeField] protected TilemapVisualizer tilemapVisualizer = null;
        [SerializeField] protected Vector2Int startPosition = Vector2Int.zero;
    
        public void GenerateDungeon()
        {
            tilemapVisualizer.Clear();
            RunProceduralGeneration();
        }

        public void RemoveRoof()
        {
            tilemapVisualizer.RemoveRoof();
        }

        protected abstract void RunProceduralGeneration();
    }
}
