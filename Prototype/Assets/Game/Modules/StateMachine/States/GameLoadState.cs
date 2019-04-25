using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace snd
{
	public class GameLoadState : IState
	{
		private StateManager stateManager = new StateManager();

		public GameLoadState(StateManager stateManager)
		{
			this.stateManager = stateManager;
		}

		public void Execute(float delta)
		{
			Debug.Log("Game Loading");
			
			//GameManager.Instance.currentCheckpoint = GameObject.Find(PlayerPrefs.GetString("currentCheckpoint")).GetComponent<Checkpoint>();

			GameManager.Instance.ChangeCheckpoint(GameObject.Find(PlayerPrefs.GetString("currentCheckpoint")).GetComponent<Checkpoint>());

			if(GameManager.Instance.currentCheckpoint)
			{
				PlayerManager.Instance.SpawnPlayerCharacter();
			}

			this.stateManager.ChangeState(new GameRunningState(stateManager));
		}

		public void OnEnter()
		{
			
		}

		public void Exit()
		{
			
		}
	}
}
