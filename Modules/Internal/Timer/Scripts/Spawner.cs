using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Game.Modules;

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