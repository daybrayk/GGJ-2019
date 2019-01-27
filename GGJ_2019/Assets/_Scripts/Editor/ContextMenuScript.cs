using UnityEngine;
using UnityEditor;

public class ContextMenuScript : EditorWindow {

[ContextMenu("Do Something")]

    void DoSomething ()
        {
            Debug.Log("Hello");
        }
}
