using UnityEditor;
using UnityEngine;

namespace YourProject.Utilities.EventScripts
{
    [CustomEditor(typeof(EventScriptsGenerator))]
    public class EventScriptsGeneratorEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            if (GUILayout.Button("Generate Scripts"))
            {
                EventScriptsGenerator generator = (EventScriptsGenerator)target;
                generator.GenerateScripts();
            }
        }
    }
}