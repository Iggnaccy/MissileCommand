using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameplayElements
{
    public interface IExplodable
    {
        public float ExplosionRadius { get; }
        public void Explode();
    }
}
