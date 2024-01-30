using UnityEditor;
using YourProject.Core.Events;

namespace YourProject.Utilities.EventScripts
{
    [CustomEditor(typeof(TemplateVariableEvent))]
    public class TemplateVariableEventEditor : BaseEventEditor<TemplateVariable, TemplateVariableEvent>
    {

    }
}