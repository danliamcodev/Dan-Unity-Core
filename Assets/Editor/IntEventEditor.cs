using UnityEditor;

namespace YourCompany.Events
{
    [CustomEditor(typeof(IntEvent))]
    public class IntEventEditor : BaseEventEditor<int, IntEvent>
    {

    }
}