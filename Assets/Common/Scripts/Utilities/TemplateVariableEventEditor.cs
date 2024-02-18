using UnityEditor;
using YourCompany.Events;

namespace YourCompany.Utilities.EventScripts
{
    [CustomEditor(typeof(TemplateVariableEvent))]
    public class TemplateVariableEventEditor : BaseEventEditor<TemplateVariable, TemplateVariableEvent>
    {

    }
}