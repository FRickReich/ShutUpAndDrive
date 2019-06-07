using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Game.V1.FSM;

namespace Game.V1.Test
{
	public class TestStringState : IState
	{
		public float timerMax;
		
		public float timer;

		private FiniteStateMachine stateManager;

		public InputControls controls;

		public TestStringState(FiniteStateMachine stateManager, float timerMax)
		{
			this.stateManager = stateManager;
			this.timerMax = timerMax;
		}

		public void Execute(float delta)
		{
			timer += delta;

			if(timer > timerMax)
			{
				Debug.Log("Running String State @ " + timerMax);
				timer = 0;
			}

			if (Input.GetKeyDown(KeyCode.Space))
			{
				this.stateManager.ChangeState(new TestInputState(stateManager));
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