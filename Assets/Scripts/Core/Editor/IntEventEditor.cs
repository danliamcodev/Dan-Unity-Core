﻿using UnityEditor;

namespace YourProject.Core.Events
{
    [CustomEditor(typeof(IntEvent))]
    public class IntEventEditor : BaseEventEditor<int, IntEvent>
    {

    }
}