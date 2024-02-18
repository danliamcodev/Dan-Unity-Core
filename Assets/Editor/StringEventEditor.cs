using UnityEditor;

namespace YourCompany.Events
{
    [CustomEditor(typeof(StringEvent))]
    public class StringEventEditor : BaseEventEditor<string, StringEvent>
    {

    }
}