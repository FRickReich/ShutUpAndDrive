using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Game.V1.FSM;

namespace Game.V1.State
{
	public class DaytimeDuskState : IState
	{
		private FiniteStateMachine stateManager;
		private Light sun;

		public DaytimeDuskState(FiniteStateMachine stateManager, Light sun)
		{
			this.stateManager = stateManager;
			this.sun = sun;
		}

		public void Execute(float delta)
		{
			Debug.Log("DAYTIME: DUSK");
		}

		public void LateExecute()
		{
			
		}

		public void OnEnter()
		{
			sun.color = new Color(133.0f / 255.0f, 124.0f / 255.0f, 102.0f / 255.0f);
		}

		public void Exit()
		{
			
		}
	}
}