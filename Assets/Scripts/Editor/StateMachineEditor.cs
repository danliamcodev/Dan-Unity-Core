using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(GlobalStateMachine))]
public class StateMachineEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUI.enabled = Application.isPlaying;

        GlobalStateMachine gameEvent = target as GlobalStateMachine;
        if (GUILayout.Button("Set State"))
            gameEvent.SetState(gameEvent.testState);
    }
}
