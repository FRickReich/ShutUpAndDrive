using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Game.V1.Manager;
using Game.V1.FSM;

namespace Game.V1.State
{
	public class CameraIdleState : IState
	{
		private readonly FiniteStateMachine stateManager;

		public CameraIdleState(FiniteStateMachine stateManager)
		{
			this.stateManager = stateManager;
		}

		public void Execute(float delta)
		{
			
		}

		public void LateExecute()
		{
			
		}

		public void Exit()
		{
			
		}

		public void OnEnter()
		{
			
		}
	}
}