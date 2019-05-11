using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace snd
{
	public class WeaponManager : MonoBehaviour
	{
		public snd.objects.Weapon[] weapons;
        public snd.objects.Weapon currentWeapon;
		
		public Transform attachmentPoint;
		public Vector3 attachmentPointPositionTuning;
		public Vector3 attachmentPointRotationTuning;
        
		public int currentSmallAmmo;
		public int currentMediumAmmo;
		public int currentLargeAmmo;
		
		public int currentAmmo;

		public int currentWeaponNumber = -1;
		
		public bool reloading;
		public bool fireing;

		[Header("Current Weapon")]
		public enums.weaponType weaponType;
		public string weaponName;
		public int maxAmmo;
		public int damage;
		public float range;
		public float impact;
		public float speed;
		public float reloadTime;
		public float fireRate;
		public float impactForce;		

		[Header("Current Weapon Objects")]
		public Transform weaponPrefab;
		public Bullet bulletPrefab;
		public Sprite weaponSprite;
        public GameObject currentWeaponObject;
		public Transform bulletSpawner;	
		
		private StateManager stateManager = new StateManager();

		// Start is called before the first frame update
		void Start()
		{
			if(currentWeaponNumber != -1)
			{
				this.stateManager.ChangeState(new EquipWeaponState(stateManager, this, currentWeaponNumber));
			}
			else
			{
				this.stateManager.ChangeState(new UnequipWeaponState(stateManager, this, currentWeaponNumber));
			}
		}

		// Update is called once per frame
		void Update()
		{
            this.stateManager.ExecuteStateUpdate();

			if(currentWeaponObject)
			{
				currentWeaponObject.transform.position = attachmentPoint.transform.position;
				currentWeaponObject.transform.rotation = attachmentPoint.transform.rotation;
			}

            if(InputManager.Instance.xboxDPadLeft)
			{
                this.PrevWeapon();
			}

            if(InputManager.Instance.xboxDPadRight)
			{
                this.NextWeapon();
			}

			if (currentWeaponNumber != -1 && InputManager.Instance.xboxButtonA)
			{
				this.FireWeapon();
			}

			if (currentWeaponNumber != -1 && currentAmmo < currentWeapon.maxAmmo && InputManager.Instance.xboxButtonX)
			{
				this.ReloadWeapon();
			}
		}

		public void NextWeapon()
		{
			this.stateManager.ChangeState(new PrevWeaponState(stateManager, this, currentWeaponNumber));
		}

		public void PrevWeapon()
		{
			this.stateManager.ChangeState(new NextWeaponState(stateManager, this, currentWeaponNumber));
		}

		public void FireWeapon()
		{
			if(!reloading && currentAmmo <= 0)
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

		public void IdleWeapon()
		{
			this.stateManager.ChangeState(new IdleWeaponState(stateManager));
		}

		public void ReloadWeapon()
		{
			if(
				this.weaponType == enums.weaponType.SMALL && this.currentSmallAmmo >= this.maxAmmo ||
				this.weaponType == enums.weaponType.MEDIUM && this.currentMediumAmmo >= this.maxAmmo || 
				this.weaponType == enums.weaponType.LARGE && this.currentLargeAmmo >= this.maxAmmo
			)
			{
				this.stateManager.ChangeState(new ReloadWeaponState(stateManager, this, reloadTime));
			}
			else
			{
				Debug.Log("Not reloading");
			}
		}

		public void CreateWeapon(GameObject weaponModel)
		{
			currentWeaponObject = Instantiate(weaponModel, this.transform.position, this.transform.rotation, this.transform);
			bulletSpawner = currentWeaponObject.transform.Find("BulletSpawn");

			this.IdleWeapon();
		}

		public void DestroyWeapon()
		{
			Destroy(currentWeaponObject);
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
