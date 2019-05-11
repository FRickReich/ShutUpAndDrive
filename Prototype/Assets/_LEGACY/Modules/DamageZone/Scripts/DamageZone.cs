using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace snd
{
	public class DamageZone : MonoBehaviour
	{
		public int damage;

		public static event Action<int> damageDealtEvent;

		private void OnTriggerEnter(Collider col)
		{
			if (col.tag == "Player")
			{
				if (damageDealtEvent != null)
				{
					damageDealtEvent(damage);
				}
			}
		}
	}
}