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

			GameManager.Instance.timer = new SimpleTimer();
		}

		public void Execute(float delta)
		{

			if(PlayerPrefsPro.HasKey("currentCheckpoint"))
			{
				GameManager.Instance.ChangeCheckpoint(GameObject.Find(PlayerPrefsPro.GetString("currentCheckpoint")).GetComponent<Checkpoint>());
			}

			if(PlayerPrefsPro.HasKey("gameTime"))
			{
				GameManager.Instance.timer.AddTime(PlayerPrefsPro.GetFloat("gameTime"));
			}
			
			if(GameManager.Instance.currentCheckpoint)
			{
				PlayerManager.Instance.SpawnPlayerCharacter();
			}

			GameManager.Instance.RunGame();
		}

		public void OnEnter()
		{
			
		}

		public void Exit()
		{
			
		}
	}
}
