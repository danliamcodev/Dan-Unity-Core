using UnityEngine;

namespace YourCompany.Variables
{
    [CreateAssetMenu(fileName = "Int Variable", menuName = "Variables/Int Variable")]
    public class IntVariable : BaseVariable<int>
    {
        public void ApplyChange(int p_amount)
        {
            _value += p_amount;
        }

        public void ApplyChange(IntVariable p_amount)
        {
            _value += p_amount.value;
        }
    }

    [System.Serializable]
    public class IntReference : BaseReference<int, IntVariable>
    {
        public IntReference(int value) : base(value)
        {
        }

        public static implicit operator IntReference(int value)
        {
            return new IntReference(value);
        }
    }
}