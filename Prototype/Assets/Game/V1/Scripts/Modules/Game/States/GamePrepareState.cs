using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Game.Controllers;

using Game.V1.Manager;
using Game.V1.FSM;
using Game.V1.Playmode;

namespace Game.V1.State
{
	public class GamePrepareState : IState
	{
		private FiniteStateMachine stateManager;

		public GamePrepareState(FiniteStateMachine stateManager)
		{
			this.stateManager = stateManager;
		}

		public void Execute(float delta)
		{
			//MonoBehaviour.Instantiate(Resources.Load("Managers/CameraManager"));
			this.stateManager.ChangeState(new GameRunningState(stateManager));
		}

		public void LateExecute()
		{
			
		}

		public void OnEnter()
		{
			UIManager.Instance.ShowSavingIndicatorPanel();

			GameManager.Instance.SpawnPlayer();
			
			PlaymodeManager.Instance.playerCharacter = GameManager.Instance.playerCharacter.GetComponent<PlayerCharacterController>();
			
			PlaymodeManager.Instance.Initialize();
		}

		public void Exit()
		{
			UIManager.Instance.HideSavingIndicatorPanel();
		}
	}
}