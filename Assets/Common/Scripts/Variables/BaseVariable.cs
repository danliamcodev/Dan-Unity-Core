using UnityEngine;

namespace YourCompany.Variables
{
    public abstract class BaseVariable<T> : ScriptableObject
    {
        [SerializeField] protected T _value;

        public System.Action ValueUpdated;

        public T value { get { return _value; } }

        public void SetValue(T p_value)
        {
            _value = p_value;
            ValueUpdated?.Invoke();
        }

        public void SetValue(BaseVariable<T> p_value)
        {
            SetValue(p_value.value);
        }
    }

    public class BaseReference<Type, Variable> where Variable : BaseVariable<Type>
    {
        [SerializeField] bool _useConstant = true;
        [SerializeField] Type _constantValue;
        [SerializeField] Variable _variable;

        public BaseReference()
        { }

        public BaseReference(Type value)
        {
            _useConstant = true;
            _constantValue = value;
        }

        public Type value
        {
            get { return _useConstant ? _constantValue : _variable.value; }
        }

        public static implicit operator Type(BaseReference<Type, Variable> p_reference)
        {
            return p_reference.value;
        }
    }
}