using UnityEditor;

namespace YourProject.Core.Events
{
    [CustomEditor(typeof(StringEvent))]
    public class StringEventEditor : BaseEventEditor<string, StringEvent>
    {

    }
}