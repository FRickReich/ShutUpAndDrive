using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

namespace Game.Managers
{
	public class CameraManager : MonoBehaviour
	{
        public GameObject SceneCamera;
        public Transform targetObject;

        private CinemachineVirtualCamera virtualCamera;

		// Start is called before the first frame update
		void Start()
		{
            virtualCamera = SceneCamera.GetComponent<CinemachineVirtualCamera>();
		}

		// Update is called once per frame
		void Update()
		{

		}

        private void OnEnable()
        {
            GameManager.changeCameraTarget += SetCameraTarget;
        }

        private void OnDisable()
        {
            GameManager.changeCameraTarget -= SetCameraTarget;
        }

        public void AttachCameraToTarget()
        {
            virtualCamera.Follow = targetObject;
            virtualCamera.LookAt = targetObject;
        }

        public void SetCameraTarget(Transform target)
        {
            targetObject = target;

            AttachCameraToTarget();
        }
	}
}
