using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace snd
{
	public class Weapon : MonoBehaviour
	{
		public int damage = 10;
		public float range = 100f;
        public float fireRate = 1.5f;
        public float impactForce = 30f;
        public float speed = 20f;

        public int maxAmmo = 10;
        public float reloadTime = 1f;
        
        public int currentAmmo;

        public Bullet bulletPrefab;
        public Transform bulletSpawner;

        private float nextTimeToFire = 0f;
        private bool isReloading;

        public bool noWeapon;
        public bool smallWeapon;
        public bool bigWeapon;
        public bool shooting;

        private void Start() {
            if(!noWeapon)
            {
                if(currentAmmo == -1)
                {
                    currentAmmo = maxAmmo;
                }
            }
        }

        private void OnEnable() {
            isReloading = false;
            // reload animation false
        }

		// Update is called once per frame
		void Update()
		{
            if(!noWeapon)
            {
                if(isReloading)
                {
                    return;
                }

                if(currentAmmo <= 0)
                {
                    StartCoroutine(Reload());
                    return;
                }

			    if (InputManager.Instance.xboxButtonA && Time.time >= nextTimeToFire)
			    {
                    nextTimeToFire = Time.time + 1f / fireRate;
				    StartCoroutine(Shoot());
			    }
            }
		}

		IEnumerator Shoot()
		{
            // muzzle flash animation
            // shooting animation
            shooting = true;
            
            currentAmmo--;

            Bullet newBullet = Instantiate(bulletPrefab, bulletSpawner.position, bulletSpawner.rotation) as Bullet;
            newBullet.speed = this.speed;
            newBullet.range = this.range;
            newBullet.damage = this.damage;
            newBullet.impactForce = this.impactForce;

            yield return new WaitForSeconds(.25f);
            
            shooting = false;
		}

		IEnumerator Reload()
		{
            isReloading = true;

            // reload animation true
            yield return new WaitForSeconds(reloadTime - .25f);
            // reload animation false
            yield return new WaitForSeconds(.25f);

			currentAmmo = maxAmmo;
            isReloading = false;
		}
	}
}
