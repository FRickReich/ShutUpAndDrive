using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class AttachUIToGamePosition : MonoBehaviour
{
    public Image crosshair;
    public Transform cameraPoint;
    public Transform target;

    // Update is called once per frame
    void LateUpdate()
    {
        crosshair.transform.position = Game.Extensions.VectorExtensions.TransformToScreenPosition(target.position);
    }
}
