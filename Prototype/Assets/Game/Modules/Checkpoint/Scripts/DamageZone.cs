using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace snd
{
	public class DamageZone : MonoBehaviour
	{
		public int damage;

		private void OnTriggerEnter(Collider col)
		{
			if (col.tag == "Player")
			{
				col.GetComponent<PlayerCharacterController>().healthAndArmor.TakeDamage(damage);
			}
		}
	}
}