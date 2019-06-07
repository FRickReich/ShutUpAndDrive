using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Game.Managers;
using Game.Enums;

using Game.V1.Helper;
using Game.V1.FSM;
using Game.V1.Manager;

namespace Game.V1.State
{
	public class PlaymodePlayVehicleState : IState
	{
		private FiniteStateMachine stateManager;
		private VehicleBehaviour.WheelVehicle playerCar;
		private Controllers.PlayerCharacterController playerCharacter;

		public PlaymodePlayVehicleState(FiniteStateMachine stateManager, VehicleBehaviour.WheelVehicle playerCar, Controllers.PlayerCharacterController playerCharacter)
		{
			this.stateManager = stateManager;
			this.playerCar = playerCar;
			this.playerCharacter = playerCharacter;
		}

		public void Execute(float delta)
		{			
			playerCharacter.transform.position = playerCar.GetComponentInChildren<VehicleEntryPoint>().transform.position;
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