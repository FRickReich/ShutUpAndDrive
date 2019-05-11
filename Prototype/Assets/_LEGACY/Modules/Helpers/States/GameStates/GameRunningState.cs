using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace snd
{
	public class GameRunningState : IState
	{
		private StateManager stateManager = new StateManager();

		private bool isPause;

		public GameRunningState(StateManager stateManager)
		{
			this.stateManager = stateManager;
		}

		public void Execute(float delta)
		{
			if(GameManager.Instance.gamePaused == true)
			{
				GameManager.Instance.PauseGame();
			}

			
		}

		public void OnEnter()
		{
			
		}

		public void Exit()
		{
			
		}
	}
}