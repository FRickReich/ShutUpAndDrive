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

        private Managers.GameManager gameManager;

        private GameObject target;
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
            gameManager = FindObjectOfType<Managers.GameManager>();
        }

        void SetCameraFollowObject(Transform followObject)
        {
            virtualCamera.Follow = followObject;
            virtualCamera.LookAt = followObject;
        }

        private void FixedUpdate()
        {
            //zoomAmount = target.GetComponent<PlayerController.PlayerCharacterController>().cameraPointPos;

            SetCameraZoom(zoomAmount);
        }

        void SetCameraZoom(float zoomAmount)
        {
            virtualCameraZoom.m_Width = Mathf.Clamp(initialZoom + (zoomAmount / 2), initialZoom, maxZoom);
            virtualCameraZoom.m_Damping = dampingRate;
        }

        public void AttachCameraToCar()
        {
            target = gameManager.playerCar.gameObject;
            cameraPoint = target.transform.Find("CameraPointController/CameraPoint");
            SetCameraFollowObject(cameraPoint);
        }

        public void AttachCameraToPlayer()
        {
            target = gameManager.playerCharacter.gameObject;
            cameraPoint = target.transform.Find("CameraPointController/CameraPoint");
            SetCameraFollowObject(cameraPoint);
        }
    }
}