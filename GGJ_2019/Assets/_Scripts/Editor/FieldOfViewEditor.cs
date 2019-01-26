using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class FieldOfViewEditor : Editor {

    private void OnSceneGUI()
    {
        EnemyView pw = (EnemyView)target;
        Handles.color = Color.white;
        Handles.DrawWireArc(pw.transform.position, Vector3.up, Vector3.forward, 360, pw.viewRadius);
        Vector3 viewAngleA = (pw.DirFromAngle(-pw.viewAngle / 2, false));
        Vector3 viewAngleB = (pw.DirFromAngle(pw.viewAngle / 2, false));

        Handles.color = Color.blue;

        Handles.DrawLine(pw.transform.position, pw.transform.position + viewAngleA * pw.viewRadius);//Left Line
        Handles.DrawLine(pw.transform.position, pw.transform.position + viewAngleB * pw.viewRadius);//Right Line

        Handles.color = Color.red;
        foreach (Transform visibleTarget in pw.visibleTargets)
        {
            Handles.DrawLine(pw.transform.position, visibleTarget.position);
        }

    }
}
