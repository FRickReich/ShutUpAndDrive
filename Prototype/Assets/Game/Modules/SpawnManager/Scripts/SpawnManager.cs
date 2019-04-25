using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace snd
{
	public class SpawnManager : Singleton<SpawnManager>
	{
		public List<SpawnPoint> spawnPoints = new List<SpawnPoint>();
		public List<GameObject> spawnPrefabs = new List<GameObject>();

		private void Awake()
		{
			spawnPoints.AddRange(GameObject.FindObjectsOfType<SpawnPoint>());
		}

		private void Start()
		{
			Spawn(0);
		}

		public void Spawn(int spawnPrefabIndex)
		{
			Spawn(spawnPrefabIndex, 0);
		}

		public void Spawn(int spawnPrefabIndex, int spawnPointIndex)
		{
			GameObject npc = Instantiate(
				spawnPrefabs[spawnPrefabIndex],
				spawnPoints[spawnPointIndex].self.position,
				spawnPoints[spawnPointIndex].self.rotation
			) as GameObject;

			npc.SendMessage("SetDestination", spawnPoints[spawnPointIndex].destination);
		}

		// Temporary
		private void Update()
		{
		}
	}
}
