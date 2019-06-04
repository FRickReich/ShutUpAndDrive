using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Game.States;

namespace Game.Managers
{
	public class StateManager : MonoBehaviour
	{
		private IState currentState;
		private IState defaultState;
		private bool showDebugInfo;

		private void Update()
		{
			if (currentState != null)
			{
				currentState.Execute(Time.deltaTime);
			}
		}

		private void LateUpdate()
		{
			if(currentState != null)
			{
				currentState.LateExecute();
			}
		}

		public void ExecuteStateUpdate()
		{
			this.currentState.Execute(Time.deltaTime);

			if (GameManager.Instance.debugMode) Debug.Log("Running State -> " + currentState.GetType().Name);
		}

		public void ExecuteLateStateUpdate()
		{
			this.currentState.LateExecute();
		}

		public void ShowDebugInfo(bool showInfo)
		{
			showDebugInfo = showInfo;
		}

		public void ChangeState(IState targetState)
		{
			if (currentState != null)
			{
				currentState.Exit();
			}

			currentState = targetState;

			if (currentState != null)
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