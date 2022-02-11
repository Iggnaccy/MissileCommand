using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Levels;

namespace GameplayElements
{
    public class BulletSpawner : MonoBehaviour
    {
        [Header("Global References")]
        [SerializeField] private LevelSO levelData;
        [SerializeField] private BulletBase[] bulletPrefabs;


    }
}
