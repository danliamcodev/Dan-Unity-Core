﻿using UnityEngine;

namespace YourProject.Core
{
    [CreateAssetMenu(fileName = "Float Variable", menuName = "Variables/Float Variable")]
    public class FloatVariable : BaseVariable<float>
    {
        public void ApplyChange(float p_amount)
        {
            _value += p_amount;
        }

        public void ApplyChange(FloatVariable p_amount)
        {
            _value += p_amount.value;
        }
    }

}