using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Game.Managers;
using Game.States;

namespace Game.Test
{
	public class TestStringState : IState
	{
		public float timerMax;
		
		public float timer;

		private StateManager stateManager;

		public InputControls controls;

		public TestStringState(StateManager stateManager, float timerMax)
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