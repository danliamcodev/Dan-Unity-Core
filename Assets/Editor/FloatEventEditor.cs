using UnityEditor;

namespace YourCompany.Events
{
    [CustomEditor(typeof(FloatEvent))]
    public class FloatEventEditor : BaseEventEditor<float, FloatEvent>
    {

    }
}