using UnityEditor;

namespace YourCompany.Events
{
    [CustomEditor(typeof(VoidEvent))]
    public class VoidEventEditor : BaseEventEditor<Void, VoidEvent>
    {

    }
}