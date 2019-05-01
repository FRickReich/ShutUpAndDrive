using UnityEngine;

namespace snd.objects
{
	[CreateAssetMenu(fileName = "Weapon", menuName = "Game/Assets/Weapon", order = 0)]
	public class Weapon : ScriptableObject
	{
		[Header("Specifications")]
		public wepaonType type;
		public string weaponName;
		public int maxAmmo;
		public int damage;
		public float range;
		public float impact;
		public float speed;
		public float reloadTime;
		public float fireRate;

		[Header("Visuals")]
		public Sprite weaponSprite;
		public Transform bulletPrefab;
		public Transform weaponPrefab;
	}
}