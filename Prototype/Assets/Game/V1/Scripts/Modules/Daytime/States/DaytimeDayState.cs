using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Game.V1.FSM;

namespace Game.V1.State
{
	public class DaytimeDayState : IState
	{
		private FiniteStateMachine stateManager;
		private Light sun;

		public DaytimeDayState(FiniteStateMachine stateManager, Light sun)
		{
			this.stateManager = stateManager;
			this.sun = sun;
		}

		public void Execute(float delta)
		{
			Debug.Log("DAYTIME: DAY");
		}

		public void LateExecute()
		{
			
		}

		public void OnEnter()
		{
			sun.color = new Color(253.0f / 255.0f, 248.0f / 255.0f, 223.0f / 255.0f);
		}

		public void Exit()
		{
			
		}
	}
}