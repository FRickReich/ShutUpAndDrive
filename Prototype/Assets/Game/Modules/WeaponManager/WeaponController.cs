using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace snd
{
	public class WeaponController : MonoBehaviour
	{
		public int maxAmmo = 10;
		public int currentAmmo;

		public int damage = 10;
		public float range = 100f;
		public float impactForce = 30f;
		public float speed = 20f;

		public float reloadTime = 2f;
		public float fireRate = 15f;

		public bool reloading;
		public bool fireing;

		public Bullet bulletPrefab;
        public Transform bulletSpawner;

		private StateManager stateManager = new StateManager();

		void Start()
		{
			this.stateManager.ChangeState(new IdleWeaponState(stateManager));

			currentAmmo = maxAmmo;
		}

		// Update is called once per frame
		void Update()
		{
            this.stateManager.ExecuteStateUpdate();
		}

		public void FireWeapon()
		{
			if(currentAmmo <= 0)
			{
				this.ReloadWeapon();
			}
			else
			{
				if(!reloading && !fireing)
				{
					this.stateManager.ChangeState(new FireWeaponState(stateManager, this, fireRate));
				}
			}
		}

		public void ReloadWeapon()
		{
			this.stateManager.ChangeState(new ReloadWeaponState(stateManager, this, reloadTime));
		}

		internal void SpawnBullet()
		{
			Bullet newBullet = Instantiate(bulletPrefab, bulletSpawner.position, bulletSpawner.rotation) as Bullet;
            newBullet.speed = this.speed;
            newBullet.range = this.range;
            newBullet.damage = this.damage;
            newBullet.impactForce = this.impactForce;
		}
	}
}