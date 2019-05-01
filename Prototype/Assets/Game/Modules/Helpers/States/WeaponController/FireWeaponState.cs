using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace snd
{
	public class FireWeaponState : IState
	{
		private StateManager stateManager;
		private readonly WeaponController weaponController;

		private float fireRate;
		private float timer;

		public FireWeaponState(StateManager stateManager, WeaponController weaponController, float fireRate)
		{
			this.stateManager = stateManager;
			this.weaponController = weaponController;
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

		public void OnEnter()
		{
			weaponController.currentAmmo--;
			weaponController.SpawnBullet();
			weaponController.fireing = true;
		}

		public void Exit()
		{
			weaponController.fireing = false;
		}
	}
}