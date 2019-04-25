using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace snd
{
	public class TestInputState : IState
	{
		private StateManager stateManager;

		public TestInputState(StateManager stateManager)
		{
			this.stateManager = stateManager;
		}

		public void Execute(float delta)
		{
			Debug.Log("Running Input State");

			if(Input.GetKeyDown(KeyCode.Space))
			{
				this.stateManager.ChangeState(new TestStringState(
					stateManager,
					5
				));
			}
		}

		public void OnEnter()
		{
			
		}

		public void Exit()
		{
			
		}
	}
}