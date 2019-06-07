using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Game.Managers;

using Game.V1.FSM;

namespace Game.V1.Test
{
	public class TestInputState : IState
	{
		private FiniteStateMachine stateManager;

		public TestInputState(FiniteStateMachine stateManager)
		{
			this.stateManager = stateManager;
		}

		public void Execute(float delta)
		{
			if(Input.GetKeyDown(KeyCode.Space))
			{
				this.stateManager.ChangeState(new TestStringState(
					stateManager,
					5
				));
			}
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