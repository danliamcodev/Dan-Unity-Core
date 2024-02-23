
using UnityEngine;
using UnityEditor;
using YourCompany.Events;

namespace YourCompany.Utilities.EventScripts
{
    [CustomEditor(typeof(GameObjectEvent))]
    public class GameObjectEventEditor : BaseEventEditor<GameObject, GameObjectEvent>
    {

    }
}
