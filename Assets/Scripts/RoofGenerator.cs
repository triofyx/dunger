using System.Collections.Generic;
using Dunger;
using UnityEngine;

public static class RoofGenerator
{
    public static void CreateRoof(HashSet<Vector2Int> floorPositions, TilemapVisualizer tilemapVisualizer)
    {
        foreach (var position in floorPositions)
        {
            tilemapVisualizer.PaintRoof(position);
        }
    }
}
