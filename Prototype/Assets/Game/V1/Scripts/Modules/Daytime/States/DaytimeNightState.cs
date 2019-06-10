using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Game.V1.FSM;

namespace Game.V1.State
{
	public class DaytimeNightState : IState
	{
		private FiniteStateMachine stateManager;
		private Light sun;

		public DaytimeNightState(FiniteStateMachine stateManager, Light sun)
		{
			this.stateManager = stateManager;
			this.sun = sun;
		}

		public void Execute(float delta)
		{
			Debug.Log("DAYTIME: NIGHT");
		}

		public void LateExecute()
		{
			
		}

		public void OnEnter()
		{
			sun.color = new Color(32.0f / 255.0f, 28.0f / 255.0f, 46.0f / 255.0f);
		}

		public void Exit()
		{
			
		}
	}
}