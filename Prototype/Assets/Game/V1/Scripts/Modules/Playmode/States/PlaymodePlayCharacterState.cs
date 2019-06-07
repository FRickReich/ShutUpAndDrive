using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Game.Managers;
using Game.Controllers;
using Game.Enums;

using Game.V1.FSM;
using Game.V1.Manager;

namespace Game.V1.State
{
	public class PlaymodePlayCharacterState : IState
	{
		private FiniteStateMachine stateManager;
		private PlayerCharacterController playerCharacter;

		public PlaymodePlayCharacterState(FiniteStateMachine stateManager, PlayerCharacterController playerCharacter)
		{
			this.stateManager = stateManager;
			this.playerCharacter = playerCharacter;
		}

		public void Execute(float delta)
		{
	
		}

		public void LateExecute()
		{
			
		}

		public void OnEnter()
		{
			CameraManager.Instance.aimIndicator.position = playerCharacter.transform.position;
			CameraManager.Instance.aimIndicator.parent = playerCharacter.transform;

			playerCharacter.gameObject.SetActive(true);
			playerCharacter.enabled = true;
			playerCharacter.IsPlayer = true;
		}

		public void Exit()
		{
			playerCharacter.gameObject.SetActive(false);
			playerCharacter.enabled = false;
			playerCharacter.IsPlayer = false;
		}
	}
}