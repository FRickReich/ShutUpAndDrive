using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Game.Managers;
using Game.Controllers;

namespace Game.States
{
	public class GamePrepareState : IState
	{
		private StateManager stateManager;

		public GamePrepareState(StateManager stateManager)
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