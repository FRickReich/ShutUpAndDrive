using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace snd
{
	public class GamePausedState : IState
	{
		private StateManager stateManager;

		public GamePausedState(StateManager stateManager)
		{
			this.stateManager = stateManager;
		}

		public void Execute(float delta)
		{
			Debug.Log("Game Paused");
		}

		public void OnEnter()
		{
			
		}

		public void Exit()
		{
			
		}
	}
}