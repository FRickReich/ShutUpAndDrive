using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace snd
{
	public class ReloadWeaponState : IState
	{
		private StateManager stateManager;
		private WeaponController weaponController;
		
		private float reloadTime;
		private float timer;

		public ReloadWeaponState(StateManager stateManager, WeaponController weaponController, float reloadTime)
		{
			this.stateManager = stateManager;
			this.weaponController = weaponController;
			this.reloadTime = reloadTime;
		}

		public void Execute(float delta)
		{
			timer += delta;

			if(timer > reloadTime)
			{
				weaponController.currentAmmo = weaponController.maxAmmo;
				this.stateManager.ChangeState(new IdleWeaponState(stateManager));
			}
		}

		public void OnEnter()
		{
			weaponController.reloading = true;
		}

		public void Exit()
		{
			weaponController.reloading = false;
		}
	}
}