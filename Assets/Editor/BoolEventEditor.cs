
using UnityEngine;
using UnityEditor;
using YourCompany.Events;

namespace YourCompany.Utilities.EventScripts
{
    [CustomEditor(typeof(BoolEvent))]
    public class BoolEventEditor : BaseEventEditor<bool, BoolEvent>
    {

    }
}
