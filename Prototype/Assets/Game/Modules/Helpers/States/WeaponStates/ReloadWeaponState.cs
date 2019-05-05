using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace snd
{
	public class ReloadWeaponState : IState
	{
		private StateManager stateManager;
		private WeaponManager weaponManager;
		
		private float reloadTime;
		private float timer;

		public ReloadWeaponState(StateManager stateManager, WeaponManager weaponManager, float reloadTime)
		{
			this.stateManager = stateManager;
			this.weaponManager = weaponManager;
			this.reloadTime = reloadTime;
		}

		public void Execute(float delta)
		{
			timer += delta;

			if(timer > reloadTime)
			{
				weaponManager.currentAmmo = weaponManager.maxAmmo;
				this.stateManager.ChangeState(new IdleWeaponState(stateManager));
			}
		}

		public void OnEnter()
		{
			weaponManager.reloading = true;
		}

		public void Exit()
		{
			if(weaponManager.weaponType == enums.weaponType.SMALL)
			{
				weaponManager.currentSmallAmmo -= weaponManager.maxAmmo;
			}
			else if(weaponManager.weaponType == enums.weaponType.MEDIUM)
			{
				weaponManager.currentMediumAmmo -= weaponManager.maxAmmo;
			}
			else if(weaponManager.weaponType == enums.weaponType.LARGE)
			{
				weaponManager.currentLargeAmmo -= weaponManager.maxAmmo;
			}

			weaponManager.reloading = false;
		}
	}
}