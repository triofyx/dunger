using UnityEngine;

namespace Dunger
{
    [CreateAssetMenu(fileName = "RandomWalkParameters",menuName = "Dungeon Generator/Random Walk Dungeon")]
    public class RandomWalkDungeons : ScriptableObject
    {
        public int iterations = 10, walkLength = 10;
        public bool startRandomlyEachIteration = true;
    }
}
