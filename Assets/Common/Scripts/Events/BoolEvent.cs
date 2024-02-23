
using UnityEngine;
using UnityEngine.Events;
using YourCompany.Events;

namespace YourCompany.Utilities.EventScripts
{
    [CreateAssetMenu(fileName = "New bool Event", menuName = "Events/bool Event")]
    public class BoolEvent : BaseGameEvent<bool>
    {

    }

    [System.Serializable]
    public class BoolUnityEvent : UnityEvent<bool>
    {

    }
}
