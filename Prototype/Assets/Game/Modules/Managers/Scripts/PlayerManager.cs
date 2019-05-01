using UnityEngine;

namespace snd
{
	public class PlayerManager : SingletonPersistent<PlayerManager>
	{
		public int playerHealth;
		public int playerArmor;
		public float playerHealthInPercent;
		public float playerArmorInPercent;
		public int playerCredits = 0;
		public bool playerDead;
		public GameObject playerCharacterPrefab;

		public int mediumAmmo = 200;
		public int bigAmmo = 200;

		private GameObject playerCharacter;

		private void Awake() {
			 
		}

		private void Update() {

			if(playerCharacter != null)
			{	
				playerHealth = playerCharacter.GetComponent<PlayerCharacterController>().healthAndArmor.GetHealh();
				playerArmor = playerCharacter.GetComponent<PlayerCharacterController>().healthAndArmor.getArmor();
				playerHealthInPercent = playerCharacter.GetComponent<PlayerCharacterController>().healthAndArmor.getHealthInPercent();
				playerArmorInPercent = playerCharacter.GetComponent<PlayerCharacterController>().healthAndArmor.getArmorInPercent();
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
