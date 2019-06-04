using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Game.Managers;

namespace Game.States
{
	public class CameraIdleState : IState
	{
		private readonly StateManager stateManager;

		public CameraIdleState(StateManager stateManager)
		{
			this.stateManager = stateManager;
		}

		public void Execute(float delta)
		{
			
		}

		public void LateExecute()
		{
			
		}

		public void Exit()
		{
			
		}

		public void OnEnter()
		{
			
		}
	}
}