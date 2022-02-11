using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Utilities;
using Utilities.Pooling;

namespace GameplayElements
{
    [RequireComponent(typeof(Rigidbody2D))]
    public abstract class BulletBase : MonoBehaviour, IBullet
    {
        [Header("Variables")]
        [SerializeField] private float explosionRadius;
        [SerializeField] private float travelSpeed;
        [Header("Global references")]
        [SerializeField] private IntValue playerScore;
        [Header("Self references")]
        [SerializeField] private Rigidbody2D rigidbody2d;

        private float distanceTraveled;
        private UnityAction recycle;

        public abstract IBullet.BulletTypeEnum BulletType { get; }

        public float DistanceTraveled => distanceTraveled;

        public float ExplosionRadius => explosionRadius;

        public float TravelSpeed => travelSpeed;

        public UnityAction Recycle => recycle;

        public virtual void Init()
        {
            if(!rigidbody2d)
            {
                Debug.LogWarning($"Rigidbody2D self-reference unassigned in object {name}");
                rigidbody2d = GetComponent<Rigidbody2D>();
            }
            rigidbody2d.velocity = GetTravelDirection();
        }

        protected virtual Vector2 GetTravelDirection()
        {
            return new Vector2(0, -travelSpeed);
        }

        public virtual void FixedUpdate()
        {
            distanceTraveled += travelSpeed * Time.fixedDeltaTime;
        }

        public virtual void Explode()
        {
            playerScore.ChangeValue(1);
            Recycle?.Invoke();
        }

        public void InitPoolable(UnityAction recycleAction)
        {
            recycle = recycleAction;
        }
    }
}
