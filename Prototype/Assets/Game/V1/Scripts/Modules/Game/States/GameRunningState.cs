using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Game.V1.FSM;

namespace Game.V1.State
{
	public class GameRunningState : IState
	{
		private FiniteStateMachine stateManager;

		public GameRunningState(FiniteStateMachine stateManager)
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