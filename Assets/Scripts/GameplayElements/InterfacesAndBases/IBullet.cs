using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilities.Pooling;

namespace GameplayElements
{
    public interface IBullet : IExplodable, IInitializable, IPoolable
    {
        public BulletTypeEnum BulletType { get; }
        public float DistanceTraveled { get; }
        public float TravelSpeed { get; }


        public enum BulletTypeEnum
        {
            Normal,
            Shrapnel,
            Smart
        }
    }
}
