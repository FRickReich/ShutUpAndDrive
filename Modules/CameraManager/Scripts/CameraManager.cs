using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

using Game.Modules;

namespace Game.Modules.CameraManager
{
    public class CameraManager : MonoBehaviour
    {
        private CinemachineVirtualCamera virtualCamera;
        private CinemachineFollowZoom virtualCameraZoom;

        private GameObject player;
        private Transform cameraPoint;
        private float zoomAmount;
        private float initialZoom = 15f;
        private float maxZoom = 60f;
        private float dampingRate = 2f;

        // Start is called before the first frame update
        void Awake()
        {
            virtualCamera = GetComponentInChildren<CinemachineVirtualCamera>();
            virtualCameraZoom = GetComponentInChildren<CinemachineFollowZoom>();
            player = GameObject.FindGameObjectWithTag("Player");
            cameraPoint = player.gameObject.transform.Find("CameraPointController/CameraPoint");

            SetCameraFollowObject(cameraPoint);
        }

        void SetCameraFollowObject(Transform followObject)
        {
            virtualCamera.Follow = followObject;
            virtualCamera.LookAt = followObject;
        }

        private void FixedUpdate()
        {
            zoomAmount = player.GetComponent<PlayerController.PlayerController>().cameraPointPos;

            SetCameraZoom(zoomAmount);
        }

        void SetCameraZoom(float zoomAmount)
        {
            virtualCameraZoom.m_Width = Mathf.Clamp(initialZoom + (zoomAmount / 2), initialZoom, maxZoom);
            virtualCameraZoom.m_Damping = dampingRate;
        }
    }
}