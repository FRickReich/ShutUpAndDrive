using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Game.Managers;

namespace Game.States
{
	public class IdleWeaponState : IState
	{
		private StateManager stateManager;

		public IdleWeaponState(StateManager stateManager)
		{
			this.stateManager = stateManager;
		}

		public void Execute(float delta)
		{
			Debug.Log("IDLE WEAPON STATE");
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