using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace snd
{
	public class GameSavingState : IState
	{
		private StateManager stateManager = new StateManager();

		public GameSavingState(StateManager stateManager)
		{
			this.stateManager = stateManager;
		}

		public void Execute(float delta)
		{
			Debug.Log("Game Saving");
		}

		public void OnEnter()
		{
			
		}

		public void Exit()
		{
			
		}
	}
}