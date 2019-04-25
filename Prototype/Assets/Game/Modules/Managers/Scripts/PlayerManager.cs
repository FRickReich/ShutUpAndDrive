using UnityEngine;

namespace snd
{
	public class PlayerManager : SingletonPersistent<PlayerManager>
	{
		public int playerHealth = 100;
		public int playerArmor = 100;
		public int playerCredits = 0;
		public bool playerDead;
		public GameObject playerCharacterPrefab;

		private GameObject playerCharacter;

		public void TakeDamage(int damage)
		{
			if(playerArmor > 0)
			{
				playerArmor -= damage;
				
				if(playerArmor <= 0)
				{
					playerArmor = 0;
				}
			}
			if(playerArmor == 0)
			{
				playerHealth -= damage;

				if(playerHealth <= 0)
				{
					playerHealth = 0;
					this.KillPlayer();
				}
			}
		}

		public void SpawnPlayerCharacter()
		{
			if(!GameObject.FindGameObjectWithTag("Player"))
			{
				playerCharacter = Instantiate(
					playerCharacterPrefab, 
					GameManager.Instance.currentCheckpoint.transform.position,
					GameManager.Instance.currentCheckpoint.transform.rotation
				);
			}
		}

		public void KillPlayer()
		{
			Debug.Log("Player died");
			playerDead = true;
		}

		public void AddCredits(int amount)
		{
			playerCredits += amount;
		}
	}
}
