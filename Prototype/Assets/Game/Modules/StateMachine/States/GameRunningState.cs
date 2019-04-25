using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace snd
{
	public class GameRunningState : IState
	{
		private StateManager stateManager = new StateManager();

		public GameRunningState(StateManager stateManager)
		{
			this.stateManager = stateManager;
		}

		public void Execute(float delta)
		{
			Debug.Log("Game Running");
		}

		public void OnEnter()
		{
			
		}

		public void Exit()
		{
			
		}
	}
}