using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Utilities
{
    [CreateAssetMenu(fileName = "Int Value", menuName = "SO/Int")]
    public class IntValue : ScriptableObject
    {
        [SerializeField] private int value;
        [SerializeField] private UnityEvent<int> onValueChanged;

        public int Value
        {
            get => value;
            set
            {
                if (value != this.value)
                {
                    this.value = value;
                    onValueChanged?.Invoke(value);
                }
            }
        }

        public UnityEvent<int> OnValueChanged => onValueChanged;

        public void SetValue(int newValue)
        {
            Value = newValue;
        }

        public void ChangeValue(int change)
        {
            Value += change;
        }

        public static implicit operator int(IntValue value)
        {
            return value.Value;
        }
    }
}
