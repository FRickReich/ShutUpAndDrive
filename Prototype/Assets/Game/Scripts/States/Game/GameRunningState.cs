using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Game.Managers;

namespace Game.States
{
	public class GameRunningState : IState
	{
		private StateManager stateManager;

		public GameRunningState(StateManager stateManager)
		{
			this.stateManager = stateManager;
		}

		public void Execute(float delta)
		{
			
		}

		public void LateExecute()
		{
			
		}

		public void OnEnter()
		{
			
		}

		public void Exit()
		{
			
		}
	}
}