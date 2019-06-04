using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Game.Enums;

public class CameraHandler : MonoBehaviour
{
    public Image crosshair;

    public Transform target;
    public Transform cameraPoint;

    public Sprite crosshairForbidden;
    public Sprite crosshairReload;
    public Sprite crosshairNoTarget;
    public Sprite CrosshairTarget;
    public Sprite crosshairIdle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetCrosshair(CrosshairType type)
    {
        switch(type)
        {
            case CrosshairType.FORBIDDEN:
                crosshair.sprite = crosshairForbidden;
                break;
            case CrosshairType.NOTARGET:
                crosshair.sprite = crosshairNoTarget;
                break;
            case CrosshairType.RELOAD:
                crosshair.sprite = crosshairReload;
                break;
            case CrosshairType.TARGET:
                crosshair.sprite = CrosshairTarget;
                break;
            default:
            case CrosshairType.IDLE:
                crosshair.sprite = crosshairIdle;
                break;
        }
    }

    void LateUpdate()
    {
        crosshair.transform.position = Game.Extensions.VectorExtensions.TransformToScreenPosition(target.position);
    }
}
