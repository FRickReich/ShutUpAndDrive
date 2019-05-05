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

			foreach(snd.objects.Weapon weapon in weaponManager.weapons)
			{
				if(index == currentWeaponNumber)
				{
					weaponManager.currentWeapon = weapon;

					weaponManager.weaponType = weaponManager.currentWeapon.weaponType;

					weaponManager.weaponName = weaponManager.currentWeapon.weaponName;
					
					weaponManager.maxAmmo = weaponManager.currentWeapon.maxAmmo;
					weaponManager.damage = weaponManager.currentWeapon.damage;
					weaponManager.range = weaponManager.currentWeapon.range;
					weaponManager.impact = weaponManager.currentWeapon.impact;
					weaponManager.speed = weaponManager.currentWeapon.speed;
					weaponManager.reloadTime = weaponManager.currentWeapon.reloadTime;
					weaponManager.fireRate = weaponManager.currentWeapon.fireRate;
					weaponManager.currentAmmo = weaponManager.currentWeapon.maxAmmo;

					weaponManager.bulletPrefab = weaponManager.currentWeapon.bulletPrefab;
					weaponManager.weaponPrefab = weaponManager.currentWeapon.weaponPrefab;
					weaponManager.weaponSprite = weaponManager.currentWeapon.weaponSprite;
				}
				else
				{
					weaponManager.DestroyWeapon();
				}

				index++;
			}

			weaponManager.CreateWeapon(weaponManager.currentWeapon.weaponPrefab.gameObject);
		}

		public void OnEnter()
		{
			
		}

		public void Exit()
		{
			
		}
	}
}
