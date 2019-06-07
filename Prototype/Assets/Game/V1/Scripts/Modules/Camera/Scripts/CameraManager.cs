using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

using Game.V1.State;
using Game.V1.FSM;
using Game.V1.Playmode;

namespace Game.V1.Manager
{
	public class CameraManager : Game.V1.Base.SingletonPersistent<CameraManager>
	{
		public GameObject SceneCamera;

        public InputControls inputControls;

		private FiniteStateMachine stateManager = new FiniteStateMachine();
		private CinemachineVirtualCamera virtualCamera;

        public Transform aimIndicator;
        public float aimDistance = 5f;
		public float magnitude = 8f;
		public float substractor = 10f;
		public float substractor2 = 3;
        public Vector3 rotation;
        public Vector2 rotationAxis;

		public Transform player;

		void Awake()
		{
			SceneCamera = GameObject.Find("Scene Camera");
		}

		// Start is called before the first frame update
		void Start()
		{
			virtualCamera = SceneCamera.GetComponent<CinemachineVirtualCamera>();

			this.stateManager.ChangeState(new CameraIdleState(stateManager));
		}

		// Update is called once per frame
		void Update()
		{
			this.stateManager.ExecuteStateUpdate();

            if(rotationAxis != Vector2.zero)
            {
                PlayerAim();
            }
		}

		private void LateUpdate()
		{
            Vector3 xvs = new Vector3(0, 0, (Mathf.Lerp(0, 1, rotation.magnitude) * aimDistance + Time.deltaTime));
            Transform child = UIManager.Instance.cameraTarget;
            Transform cameraPoint = UIManager.Instance.cameraPoint;

            float distance = Vector3.Distance(aimIndicator.position, child.position) / substractor;

            child.localPosition = Vector3.ClampMagnitude(xvs, substractor);
            cameraPoint.localPosition = Vector3.ClampMagnitude(xvs / substractor2, magnitude/2);

			Color visibility;
			visibility = new Color (1f, 1f, 1f, distance);

			UIManager.Instance.currentCrosshair.color = visibility;

			aimIndicator.rotation = Quaternion.LookRotation(rotation);
		}

		private void OnEnable()
		{
			PlaymodeManager.changeCameraTarget += SetCameraTarget;

            InputControls inputControls = new InputControls();

            inputControls.Camera.Rotate.performed += context => Rotate(context.ReadValue<Vector2>());

			inputControls.Enable();
		}

		private void OnDisable()
		{
			PlaymodeManager.changeCameraTarget -= SetCameraTarget;
		}

		public void SetCameraTarget(Transform target)
		{
			this.stateManager.ChangeState(new CameraChangeState(
				stateManager,
				target,
				virtualCamera
			));
		}

        private void PlayerAim()
        {
            rotation = (Vector3.forward * rotationAxis.y * 1 * Time.deltaTime) + (Vector3.right * rotationAxis.x * 1 * Time.deltaTime);

            
        }

        void Rotate(Vector2 rotValue)
        {
            rotationAxis = rotValue;
        }
	}
}
