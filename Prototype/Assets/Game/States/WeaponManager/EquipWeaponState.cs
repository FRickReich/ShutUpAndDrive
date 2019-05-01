using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace snd
{
	public class EquipWeaponState : IState
	{
		private StateManager stateManager;
		private readonly WeaponManager weaponManager;
		private readonly int currentWeaponNumber;

		public EquipWeaponState(StateManager stateManager, WeaponManager weaponManager, int currentWeaponNumber)
		{
			this.stateManager = stateManager;
			this.weaponManager = weaponManager;
			this.currentWeaponNumber = currentWeaponNumber;
		}

		public void Execute(float delta)
		{
			weaponManager.currentWeaponNumber = currentWeaponNumber;

			int index = 0;

			foreach(WeaponController weapon in weaponManager.weapons)
			{
				if(index == currentWeaponNumber)
				{
					weapon.gameObject.SetActive(true);
					weaponManager.currentWeapon = weapon;
				}
				else
				{
					weapon.gameObject.SetActive(false);
				}

				index++;
			}
		}

		public void OnEnter()
		{
			
		}

		public void Exit()
		{
			
		}
	}
}
