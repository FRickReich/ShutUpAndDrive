using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Game.Enums;
using Game.Managers;

using Game.V1.Helper;
using Game.V1.FSM;

namespace Game.V1.State
{
	public class PlaymodeLeaveVehicleState : IState
	{
		private FiniteStateMachine stateManager;
		private VehicleBehaviour.WheelVehicle playerCar;
		private Controllers.PlayerCharacterController playerCharacter;

		public PlaymodeLeaveVehicleState(FiniteStateMachine stateManager, VehicleBehaviour.WheelVehicle playerCar, Controllers.PlayerCharacterController playerCharacter)
		{
			this.stateManager = stateManager;
			this.playerCar = playerCar;
			this.playerCharacter = playerCharacter;
		}

		public void Execute(float delta)
		{
			playerCar.IsPlayer = false;
			playerCar.Handbrake = true;
			playerCar.transform.Find("Model").tag = "Traffic";
			playerCar.tag = "Traffic";

			this.stateManager.ChangeState(new PlaymodePlayCharacterState(
				stateManager,
				playerCharacter
			));
		}

		public void LateExecute()
		{
			
		}

		public void Exit()
		{
			
		}

		public void OnEnter()
		{
			
		}
	}
}