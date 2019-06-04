using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Game.Managers;
using Game.Objects;

namespace Game.States
{
	public class UnequipWeaponState : IState
	{
		private StateManager stateManager;
		private WeaponManager weaponManager;
		private int currentWeaponNumber;

		public UnequipWeaponState(StateManager stateManager, WeaponManager weaponManager, int currentWeaponNumber)
		{
			this.stateManager = stateManager;
			this.weaponManager = weaponManager;
			this.currentWeaponNumber = currentWeaponNumber;
		}

		public void Execute(float delta)
		{
			weaponManager.currentWeaponNumber = -1;

			foreach(Weapon weapon in weaponManager.weapons)
			{
				weaponManager.DestroyWeapon();
			}

			weaponManager.currentWeapon = null;
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