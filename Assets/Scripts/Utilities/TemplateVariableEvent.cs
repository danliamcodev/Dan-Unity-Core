using UnityEngine;
using UnityEngine.Events;
using YourProject.Core.Events;

namespace YourProject.Utilities.EventScripts
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