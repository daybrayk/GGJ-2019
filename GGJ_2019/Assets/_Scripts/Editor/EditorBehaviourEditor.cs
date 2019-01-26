using UnityEngine;
using UnityEditor;

public class EditorBehaviourEditor : EditorWindow {

    [MenuItem("Window/Example")]
    public static void ShowWindow ()
    {
        GetWindow<EditorBehaviourEditor>("Example");
    }

    void OnGUI()
    {
        GUILayout.Label("This is a Label", EditorStyles.boldLabel);
    }
}
