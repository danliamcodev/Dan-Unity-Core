
using UnityEngine;
using UnityEngine.Events;
using YourCompany.Events;

namespace YourCompany.Utilities.EventScripts
{
    [CreateAssetMenu(fileName = "New GameObject Event", menuName = "Events/GameObject Event")]
    public class GameObjectEvent : BaseGameEvent<GameObject>
    {

    }

    [System.Serializable]
    public class GameObjectUnityEvent : UnityEvent<GameObject>
    {

    }
}
