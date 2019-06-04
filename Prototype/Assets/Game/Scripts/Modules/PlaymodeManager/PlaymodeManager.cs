using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Experimental.Input;

using Game.Controllers;
using Game.Enums;
using Game.Base;
using Game.Helpers;
using Game.States;

namespace Game.Managers
{
	public class PlaymodeManager : Game.Base.SingletonPersistent<PlaymodeManager>
	{
		public PlayerCharacterController playerCharacter;
		public VehicleBehaviour.WheelVehicle playerCar;
		public VehicleBehaviour.WheelVehicle enterableVehicle;

		private StateManager stateManager = new StateManager();

		public InputControls inputControls;

		public PlayerMode currentPlayMode = PlayerMode.PLAYSCHARACTER;

		public static event Action<Transform> changeCameraTarget;

		private void OnEnable()
		{
			InputControls inputControls = new InputControls();

			inputControls.Character.Interact.performed += context => Interact();
			inputControls.Vehicle.Interact.performed += context => Interact();

			inputControls.Enable();

			VehicleEntryPoint.damageDealtEvent += SetVehicleEnterable;
		}

		private void OnDisable()
		{
			VehicleEntryPoint.damageDealtEvent -= SetVehicleEnterable;
		}

		public void SetVehicleEnterable(VehicleBehaviour.WheelVehicle currentVehicle)
		{
			enterableVehicle = currentVehicle;
		}

		public void SetPlayerCar(VehicleBehaviour.WheelVehicle selectedVehicle)
		{
			playerCar = selectedVehicle;
		}

		public void Initialize()
		{
			//changeCameraTarget(playerCharacter.gameObject.transform);
			changeCameraTarget(UIManager.Instance.cameraPoint);
			this.stateManager.ChangeState(new PlaymodePlayCharacterState(
				stateManager,
				playerCharacter
			));
		}

		public void Interact()
		{
			if (enterableVehicle && playerCharacter.IsPlayer)
			{
				SetPlayerCar(enterableVehicle);

				this.stateManager.ChangeState(new PlaymodeEnterVehicleState(
					stateManager,
					playerCharacter,
					playerCar
				));
				changeCameraTarget(UIManager.Instance.cameraPoint);
			}

			if (playerCar && playerCar.IsPlayer)
			{
				this.stateManager.ChangeState(new PlaymodeLeaveVehicleState(
					stateManager,
					playerCar,
					playerCharacter
				));
				changeCameraTarget(UIManager.Instance.cameraPoint);
			}
		}

		// Update is called once per frame
		void Update()
		{
			this.stateManager.ExecuteStateUpdate();
		}

		private void LateUpdate()
		{
			this.stateManager.ExecuteLateStateUpdate();
		}
	}
}

