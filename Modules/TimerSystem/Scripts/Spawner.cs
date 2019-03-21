using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Modules.TimerSystem
{
	public class Spawner : MonoBehaviour
	{
		public GameObject prefab;

		public void Spawn()
		{
			Instantiate(prefab, transform.position, Quaternion.identity, transform);
		}
	}
}