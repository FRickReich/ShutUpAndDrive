using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Game.Managers;
using Game.Enums;

namespace Game.States
{
	public class PlaymodePlayVehicleState : IState
	{
		private StateManager stateManager;
		private VehicleBehaviour.WheelVehicle playerCar;
		private Controllers.PlayerCharacterController playerCharacter;

		public PlaymodePlayVehicleState(StateManager stateManager, VehicleBehaviour.WheelVehicle playerCar, Controllers.PlayerCharacterController playerCharacter)
		{
			this.stateManager = stateManager;
			this.playerCar = playerCar;
			this.playerCharacter = playerCharacter;
		}

		public void Execute(float delta)
		{			
			playerCharacter.transform.position = playerCar.GetComponentInChildren<Helpers.VehicleEntryPoint>().transform.position;
		}

		public void LateExecute()
		{
		}

		public void Exit()
		{
			
		}

		public void OnEnter()
		{
			CameraManager.Instance.aimIndicator.position = playerCar.transform.position;
			CameraManager.Instance.aimIndicator.parent = playerCar.transform;
		}
	}
}