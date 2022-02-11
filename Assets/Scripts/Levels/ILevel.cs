using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameplayElements;

namespace Levels
{
    public interface ILevel
    {
        public float SpawnFrequency { get; }

        public int[] EnemyBulletCounts { get; }
        public int[] EnemyPlaneCounts { get; }
        public int[] PlayerBulletCounts { get; }
    }
}
