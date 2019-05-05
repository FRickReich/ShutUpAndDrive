using UnityEngine;

namespace snd
{
	public class PlayerManager : SingletonPersistent<PlayerManager>
	{
		public int playerHealth;
		public int playerArmor;
		public float playerHealthInPercent;
		public float playerArmorInPercent;
		public int playerAmmo;
		public int playerCredits = 0;
		public bool playerDead;
		public GameObject playerCharacterPrefab;

		public int currentSmallAmmo = 250;
		public int currentMediumAmmo = 250;
		public int currentLargeAmmo = 250;

		public GameObject playerCharacter;
		public WeaponManager weaponManager;

		private int completeAmmo;

		private void Update() {

			if(playerCharacter != null)
			{	
				playerHealth = playerCharacter.GetComponent<PlayerCharacterController>().healthAndArmor.GetHealh();
				playerArmor = playerCharacter.GetComponent<PlayerCharacterController>().healthAndArmor.getArmor();
				playerHealthInPercent = playerCharacter.GetComponent<PlayerCharacterController>().healthAndArmor.getHealthInPercent();
				playerArmorInPercent = playerCharacter.GetComponent<PlayerCharacterController>().healthAndArmor.getArmorInPercent();

				bool isInfiniteAmmo = false;
				playerAmmo = playerCharacter.GetComponent<WeaponManager>().currentAmmo;


				if(playerCharacter.GetComponent<WeaponManager>().currentWeapon == null)
				{
					UIManager.Instance.HideHudAmmo();
				}
				else if(playerCharacter.GetComponent<WeaponManager>().currentWeapon != null)
				{
					UIManager.Instance.ShowHudAmmo();

					if(playerCharacter.GetComponent<WeaponManager>().weaponType == snd.enums.weaponType.SMALL)
					{
						isInfiniteAmmo = true;
						completeAmmo = playerCharacter.GetComponent<WeaponManager>().currentSmallAmmo;
					}
					else if(playerCharacter.GetComponent<WeaponManager>().weaponType == snd.enums.weaponType.MEDIUM)
					{
						completeAmmo = playerCharacter.GetComponent<WeaponManager>().currentMediumAmmo;
					}
					else if(playerCharacter.GetComponent<WeaponManager>().weaponType == snd.enums.weaponType.LARGE)
					{
						completeAmmo = playerCharacter.GetComponent<WeaponManager>().currentLargeAmmo;
					}

					UIManager.Instance.UpdateHUDAmmo(playerAmmo, completeAmmo, isInfiniteAmmo);
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

				weaponManager = playerCharacter.GetComponent<WeaponManager>();

				weaponManager.currentSmallAmmo = this.currentMediumAmmo;
				weaponManager.currentMediumAmmo = this.currentMediumAmmo;
				weaponManager.currentLargeAmmo = this.currentLargeAmmo;
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
