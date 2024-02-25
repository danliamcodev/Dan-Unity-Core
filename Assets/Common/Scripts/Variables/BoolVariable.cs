using UnityEngine;

namespace YourCompany.Variables
{
    [CreateAssetMenu(fileName = "New Bool Variable", menuName = "Variables/Bool Variable")]
    public class BoolVariable : BaseVariable<bool>
    {

    }

    [System.Serializable]
    public class BoolReference : BaseReference<bool, BoolVariable>
    {
        public BoolReference(bool value) : base(value)
        {
        }

        public static implicit operator BoolReference(bool value)
        {
            return new BoolReference(value);
        }
    }
}