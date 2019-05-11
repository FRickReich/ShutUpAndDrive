using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace snd
{
	public class StateManager : MonoBehaviour
	{
		private IState currentState;
		private IState defaultState;

		private void Update()
		{
			if (currentState != null)
			{
				currentState.Execute(Time.deltaTime);
			}
		}

		public void ExecuteStateUpdate()
		{
			this.currentState.Execute(Time.deltaTime);
		}

		public void ChangeState(IState targetState)
		{
			if(currentState != null)
			{
				currentState.Exit();
			}

			currentState = targetState;

			if(currentState != null)
			{
				currentState.OnEnter();
			}
		}

		public void BackToDefaultState()
		{
			ChangeState(defaultState);
		}
	}
}