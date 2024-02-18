using UnityEngine;
using UnityEngine.Events;

namespace YourCompany.Events
{
    [CreateAssetMenu(fileName = "New Int Event", menuName = "Events/Int Event")]
    public class IntEvent : BaseGameEvent<int>
    {

    }

    [System.Serializable]
    public class IntUnityEvent : UnityEvent<int>
    {

    }
}