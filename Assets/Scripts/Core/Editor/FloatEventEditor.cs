using UnityEditor;

namespace YourProject.Core.Events
{
    [CustomEditor(typeof(FloatEvent))]
    public class FloatEventEditor : BaseEventEditor<float, FloatEvent>
    {

    }
}