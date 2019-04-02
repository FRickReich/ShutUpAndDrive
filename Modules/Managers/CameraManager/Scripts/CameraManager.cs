using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

using Game.Modules;
using Game.Modules.Internal;

namespace Game.Modules.CameraManager
{
    public class CameraManager : MonoBehaviour
    {
        private CinemachineVirtualCamera virtualCamera;
        private CinemachineFollowZoom virtualCameraZoom;

        GameManager gameManager;

        private GameObject target;
        private Transform cameraPoint;
        private float zoomAmount;
        public float initialCharacterZoom = 15f;
        public float initialCarZoom = 40f;
        public float maxCharacterZoom = 60f;
        public float maxCarZoom = 100f;
        public float characterDampingRate = 2f;
        public float carDampingRate = 0f;

        // Start is called before the first frame update
        void Awake()
        {
            virtualCamera = GetComponentInChildren<CinemachineVirtualCamera>();
            virtualCameraZoom = GetComponentInChildren<CinemachineFollowZoom>();
            gameManager = FindObjectOfType<GameManager>();
        }

        void SetCameraFollowObject(Transform followObject)
        {
            virtualCamera.Follow = followObject;
            virtualCamera.LookAt = followObject;
        }

        private void FixedUpdate()
        {
            if(gameManager.currentPlayMode == Helpers.PlayerMode.PLAYSCHARACTER)
            {
                zoomAmount = gameManager.playerCharacter.GetComponent<PlayerController.PlayerCharacterController>().cameraPointPos;
                SetCameraZoom(initialCharacterZoom, zoomAmount, maxCharacterZoom, characterDampingRate);
            }

            if(gameManager.currentPlayMode == Helpers.PlayerMode.PLAYSCAR)
            {
                zoomAmount = gameManager.playerCar.GetComponent<VehicleBehaviour.WheelVehicle>().cameraPointPos;
                SetCameraZoom(initialCarZoom, zoomAmount, maxCarZoom, carDampingRate);
            }
        }

        void SetCameraZoom(float startZoom, float zoomAmount, float maxZoom, float dampingRate)
        {
            virtualCameraZoom.m_Width = Mathf.Clamp(startZoom + (zoomAmount / 2), startZoom, maxZoom);
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