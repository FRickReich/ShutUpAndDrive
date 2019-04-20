using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Game.Modules.FieldOfView
{
    [CustomEditor(typeof(FieldOfViewManager))]
    public class FieldOfViewEditor : Editor
    {
        void OnSceneGUI()
        {
            FieldOfViewManager fow = (FieldOfViewManager)target;

            Handles.color = Color.white;
            Vector3 viewAngleA = fow.DirFromAngle(-fow.viewAngle / 2, false);
            Vector3 viewAngleB = fow.DirFromAngle(fow.viewAngle / 2, false);
            Handles.DrawWireArc(fow.transform.position, Vector3.up, viewAngleA, fow.viewAngle, fow.viewRadius);
            Handles.DrawLine(fow.transform.position, fow.transform.position + viewAngleA * fow.viewRadius);
            Handles.DrawLine(fow.transform.position, fow.transform.position + viewAngleB * fow.viewRadius);

            Handles.color = Color.red;
            foreach (Transform visibleTarget in fow.visibleTargets)
            {
                Handles.DrawLine(fow.transform.position, visibleTarget.position);
            }
        }
    }
}