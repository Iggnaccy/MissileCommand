using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Utilities.Pooling
{
    public interface IPool<T> where T : IPoolable
    {
        public int PoolSize { get; }

        public T Get();
        public void CleanUp();
        public void IncreasePoolSize(int count);
    }
}
