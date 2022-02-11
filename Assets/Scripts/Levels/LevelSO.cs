using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Levels
{
    [Serializable]
    [CreateAssetMenu(fileName = "Level", menuName = "SO/Level")]
    public class LevelSO : ScriptableObject, ILevel
    {
        [SerializeField] private float spawnFrequency;
        [SerializeField] private int[] enemyBulletCounts;
        [SerializeField] private int[] enemyPlaneCounts;
        [SerializeField] private int[] playerBulletCounts;

        public float SpawnFrequency => spawnFrequency;

        public int[] EnemyBulletCounts => enemyBulletCounts;

        public int[] EnemyPlaneCounts => enemyPlaneCounts;

        public int[] PlayerBulletCounts => playerBulletCounts;
    }
}
