using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace snd
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

			foreach(WeaponController weapon in weaponManager.weapons)
			{
				weapon.gameObject.SetActive(false);
			}

			weaponManager.currentWeapon = null;
		}

		public void OnEnter()
		{
			
		}

		public void Exit()
		{
			
		}
	}
}