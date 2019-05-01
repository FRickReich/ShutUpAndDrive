using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace snd
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

		public void OnEnter()
		{
			
		}

		public void Exit()
		{
			
		}
	}
}