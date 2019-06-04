using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Game.Managers;

namespace Game.States
{
	public class FireWeaponState : IState
	{
		private StateManager stateManager;
		private WeaponManager weaponManager;

		private float fireRate;
		private float timer;

		public FireWeaponState(StateManager stateManager, WeaponManager weaponManager, float fireRate)
		{
			this.stateManager = stateManager;
			this.weaponManager = weaponManager;
			this.fireRate = fireRate;
		}

		public void Execute(float delta)
		{
			timer += delta;

			if(timer > fireRate)
			{
				this.stateManager.ChangeState(new IdleWeaponState(stateManager));
			}

		}

		public void LateExecute()
		{
			
		}

		public void OnEnter()
		{
			weaponManager.currentAmmo--;
			weaponManager.SpawnBullet();
			weaponManager.fireing = true;
		}

		public void Exit()
		{
			weaponManager.fireing = false;
		}
	}
}