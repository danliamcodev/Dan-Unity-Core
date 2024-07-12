using UnityEngine;

namespace YourCompany.Variables
{
    [CreateAssetMenu(fileName = "Float Variable", menuName = "Variables/Float Variable")]
    public class FloatVariable : BaseVariable<float>
    {
        public void ApplyChange(float p_amount)
        {
            _value += p_amount;
            ValueUpdated?.Invoke();
        }

        public void ApplyChange(FloatVariable p_amount)
        {
            ApplyChange(p_amount.value);
        }
    }

    [System.Serializable]
    public class FloatReference: BaseReference<float, FloatVariable>
    {
        public FloatReference(float value) : base(value)
        {
        }

        public static implicit operator FloatReference(float value)
        {
            return new FloatReference(value);
        }
    }
}