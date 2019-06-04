using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Game.Managers;

namespace Game.States
{
	public class PrevWeaponState : IState
	{
		private StateManager stateManager;
		private WeaponManager weaponManager;
		private int currentWeaponNumber;

		public PrevWeaponState(StateManager stateManager, WeaponManager weaponManager, int currentWeaponNumber)
		{
			this.stateManager = stateManager;
			this.weaponManager = weaponManager;
			this.currentWeaponNumber = currentWeaponNumber;
		}

		public void Execute(float delta)
		{
			if(currentWeaponNumber <= -1)
			{
					currentWeaponNumber = weaponManager.weapons.Length -1;
			}
			else
			{
				currentWeaponNumber--;
			}
			
			if(currentWeaponNumber != -1)
			{
				this.stateManager.ChangeState(new EquipWeaponState(stateManager, weaponManager, currentWeaponNumber));
			}
			else
			{
				this.stateManager.ChangeState(new UnequipWeaponState(stateManager, weaponManager, currentWeaponNumber));
			}
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
