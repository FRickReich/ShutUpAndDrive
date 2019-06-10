using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Game.V1.FSM;

namespace Game.V1.State
{
	public class DaytimeDawnState : IState
	{
		private FiniteStateMachine stateManager;
		private Light sun;

		public DaytimeDawnState(FiniteStateMachine stateManager, Light sun)
		{
			this.stateManager = stateManager;
			this.sun = sun;
		}

		public void Execute(float delta)
		{
			Debug.Log("DAYTIME: DAWN");
		}

		public void LateExecute()
		{
			
		}

		public void OnEnter()
		{
			sun.color = new Color(180.0f / 255.0f, 208.0f / 255.0f, 209.0f / 255.0f);
		}

		public void Exit()
		{
			
		}
	}
}