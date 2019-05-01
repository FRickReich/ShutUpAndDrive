using UnityEngine;

namespace snd.objects
{
	[CreateAssetMenu(fileName = "Weapon", menuName = "Game/Assets", order = 0)]
	public class Weapon : ScriptableObject
	{
		[Header("Specifications")]
		public string weaponName;
		public int maxAmmo;
		public int damage;
		public float range;
		public float impact;
		public float speed;
		public float reloadTime;
		public float fireRate;

		[Header("Visuals")]
		public Transform bulletPrefab;
		public Transform weaponPrefab;
	}
}