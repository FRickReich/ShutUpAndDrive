using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Game.Managers;

namespace Game.States
{
	public class PlaymodeEnterVehicleState : IState
	{
		private StateManager stateManager;
		private Controllers.PlayerCharacterController playerCharacter;
		private VehicleBehaviour.WheelVehicle playerCar;

		public PlaymodeEnterVehicleState(
			StateManager stateManager, 
			Controllers.PlayerCharacterController playerCharacter, 
			VehicleBehaviour.WheelVehicle playerCar
		){
			this.stateManager = stateManager;
			this.playerCharacter = playerCharacter;
			this.playerCar = playerCar;
		}

		public void Execute(float delta)
		{
			playerCar.IsPlayer = true;
			playerCar.Handbrake = false;
            playerCar.transform.Find("Model").tag = "Player";
			playerCar.tag = "Player";

			this.stateManager.ChangeState(new PlaymodePlayVehicleState(stateManager, playerCar, playerCharacter));
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