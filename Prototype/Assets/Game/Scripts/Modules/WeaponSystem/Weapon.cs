using UnityEngine;

using Game.Enums;
using Game.Helpers;

namespace Game.Objects
{
	[CreateAssetMenu(fileName = "Weapon", menuName = "Game/Weapon", order = 0)]
	public class Weapon : ScriptableObject
	{
		[Header("Specifications")]
		public WeaponType weaponType;
		public string weaponName;
		public int maxAmmo;
		public int damage;
		public float range;
		public float impact;
		public float speed;
		public float reloadTime;
		public float fireRate;

		[Header("Visuals")]
		public Bullet bulletPrefab;
		public Transform weaponPrefab;
		public Sprite weaponSprite;
	}
}