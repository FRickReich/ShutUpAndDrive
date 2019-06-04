using System.Collections;
using UnityEngine;

using Game.Objects;

namespace Game.Managers
{
	public class CollectableObject : MonoBehaviour
	{
		public int quantity = 0;
		public InvantoryObject objectRefrence;
		private bool justSpawned = false;

		void Start()
		{
			justSpawned = true;
			StartCoroutine(SpawnSleepTimer());
		}

		void OnTriggerEnter(Collider other)
		{
			if (other.tag == "Player" && !justSpawned)
			{
				other.GetComponent<Invantory>().AddItemToInvanntory(this);
				Destroy(gameObject);
			}
		}

		void OnTriggerExit(Collider other)
		{
			if (other.tag == "Player")
			{
				justSpawned = false;
				StopCoroutine(SpawnSleepTimer());
			}
		}

		IEnumerator SpawnSleepTimer()
		{
			yield return new WaitForSeconds(2);
			justSpawned = false;
		}
	}
}
