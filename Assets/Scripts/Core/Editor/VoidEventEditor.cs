using UnityEditor;

namespace YourProject.Core.Events
{
    [CustomEditor(typeof(VoidEvent))]
    public class VoidEventEditor : BaseEventEditor<Void, VoidEvent>
    {

    }
}