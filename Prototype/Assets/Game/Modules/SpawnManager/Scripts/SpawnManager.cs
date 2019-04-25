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

        public void Spawn(int spawnPrefabIndex)
        {
            Spawn(spawnPrefabIndex, 0);
        }

        public void Spawn(int spawnPrefabIndex, int spawnPointIndex)
        {
            Instantiate(spawnPrefabs[spawnPrefabIndex], spawnPoints[spawnPointIndex].transform);
        }

        // Temporary
        private void Update()
        {
            if(InputManager.Instance.xboxButtonA)
            {
                Spawn(0);
            }
            if(InputManager.Instance.xboxButtonB)
            {
                Spawn(1);
            }
            if(InputManager.Instance.xboxButtonX)
            {
                Spawn(0, 1);
            }
            if(InputManager.Instance.xboxButtonY)
            {
                Spawn(0, 2);
            }
        }
    }
}
