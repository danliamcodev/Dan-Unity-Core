using UnityEngine;
using UnityEngine.Events;
using YourCompany.Events;

namespace YourCompany.Utilities.EventScripts
{
    [CreateAssetMenu(fileName = "New TemplateVariable Event", menuName = "Events/TemplateVariable Event")]
    public class TemplateVariableEvent : BaseGameEvent<TemplateVariable>
    {

    }

    [System.Serializable]
    public class TemplateVariableUnityEvent : UnityEvent<TemplateVariable>
    {

    }
}