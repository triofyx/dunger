using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Dunger
{
    public class RandomWalk : Dungeon
    {
        [SerializeField] protected RandomWalkDungeons randomWalkParameters;

        protected override void RunProceduralGeneration()
        {
            HashSet<Vector2Int> floorPositions = RunRandomWalk(randomWalkParameters, startPosition);
            tilemapVisualizer.Clear();
            tilemapVisualizer.PaintFloorTiles(floorPositions);
            WallGenerator.CreateWalls(floorPositions, tilemapVisualizer);
            RoofGenerator.CreateRoof(floorPositions, tilemapVisualizer);
        }

        protected HashSet<Vector2Int> RunRandomWalk(RandomWalkDungeons parameters, Vector2Int position)
        {
            var currentPosition = position;
            HashSet<Vector2Int> floorPositions = new HashSet<Vector2Int>();
            for (int i = 0; i < parameters.iterations; i++)
            {
                var path = ProceduralGenerationAlgorithms.RandomWalk(currentPosition, parameters.walkLength);
                floorPositions.UnionWith(path);
                if (parameters.startRandomlyEachIteration)
                    currentPosition = floorPositions.ElementAt(Random.Range(0, floorPositions.Count));
            }
            return floorPositions;
        }
    }
}
