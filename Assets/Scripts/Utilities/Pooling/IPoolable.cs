using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Utilities.Pooling
{
    public interface IPoolable
    {
        public UnityAction Recycle { get; }

        public void InitPoolable(UnityAction recycleAction);
    }
}
