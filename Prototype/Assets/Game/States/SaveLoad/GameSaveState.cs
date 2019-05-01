using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace snd
{
	public class GameSaveState : IState
	{
		private StateManager stateManager = new StateManager();
		
		private string checkpointName;
		private float gameTime;

		public GameSaveState(
			StateManager stateManager, 
			string checkpointName,
			float gameTime
		){
			this.stateManager = stateManager;
			this.checkpointName = checkpointName;
			this.gameTime = gameTime;
		}

		public void Save()
		{
			PlayerPrefsPro.SetString("currentCheckpoint", checkpointName);
			PlayerPrefsPro.SetFloat("gameTime", gameTime);

			PlayerPrefsPro.Save();
		}

		public void Execute(float delta)
		{
			this.Save();

			GameManager.Instance.RunGame();
		}

		public void OnEnter()
		{
			UIManager.Instance.ShowSavingIndicatorPanel();
		}

		public void Exit()
		{
			UIManager.Instance.HideSavingIndicatorPanel();
		}
	}
}