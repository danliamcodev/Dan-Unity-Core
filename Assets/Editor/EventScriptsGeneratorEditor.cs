using UnityEditor;
using UnityEngine;

namespace YourCompany.Utilities.EventScripts
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
