using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace snd
{
	public class GameOverState : IState
	{
		private StateManager stateManager = new StateManager();

		public GameOverState(StateManager stateManager)
		{
			this.stateManager = stateManager;
		}

		public void Execute(float delta)
		{
			Debug.Log("GAME OVER");
		}

		public void OnEnter()
		{
			
		}

		public void Exit()
		{
			
		}
	}
}
