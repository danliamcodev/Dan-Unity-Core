using UnityEngine;
using UnityEngine.Events;

namespace YourProject.Core.Events
{
    [CreateAssetMenu(fileName = "New Float Event", menuName = "Events/Float Event")]
    public class FloatEvent : BaseGameEvent<float>
    {

    }

    [System.Serializable]
    public class FloatUnityEvent : UnityEvent<float>
    {

    }
}