using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

using Game.Modules;

namespace Game.Modules.Internal
{
	public class GameManager : MonoBehaviour
	{
		public PlayerController.PlayerCharacterController playerCharacter;
		public GameObject playerCar;

		public GameObject enterableVehicle;

		public Helpers.PlayerMode currentPlayMode = Helpers.PlayerMode.PLAYSCHARACTER;
		
		private CameraManager.CameraManager cameraManager;
		private DayTimeManager dayTimeManager;

		public Helpers.DayTime currentTimeOfDay;

        public int currentPlayerMoney;

		public Text currentArea;
        public Text currentLocation;
        public Text currentCar;
        public Text currentHealth;
        public Text currentArmor;
        public Text currentMoney;

		private void Awake() 
		{
			cameraManager = FindObjectOfType<CameraManager.CameraManager>();
			dayTimeManager = GetComponent<DayTimeManager>();
		}

		private void Start() 
		{
			SetPlayerHealth(playerCharacter.playerHealth.currentHealth);
			SetPlayerArmor(playerCharacter.playerHealth.currentArmor);
			SetPlayerMoney(currentPlayerMoney);
		}

		void Update()
		{
			if(currentTimeOfDay == Helpers.DayTime.DAY)
			{
				dayTimeManager.SetDayTime();
			}
			else if(currentTimeOfDay == Helpers.DayTime.NIGHT)
			{
				dayTimeManager.SetNightTime();
			}

			if(playerCharacter)
			{
				if(currentPlayMode == Helpers.PlayerMode.PLAYSCHARACTER)
				{
					gameObject.transform.position = playerCharacter.gameObject.transform.position;

					if(playerCar)
					{
						playerCar.transform.Find("MiniMapIndicator").gameObject.SetActive(false);
					}
					
					playerCharacter.transform.Find("MiniMapIndicator").gameObject.SetActive(true);
					
					enterableVehicle = playerCharacter.enterableCar;

					if(enterableVehicle != null)
					{
						if(Input.GetKeyDown(KeyCode.Return))
						{
							playerCar = enterableVehicle;
							currentPlayMode = Helpers.PlayerMode.ENTERCAR;
						}
					}
				}
			}
			
			if(currentPlayMode == Helpers.PlayerMode.PLAYSCAR)
			{
				gameObject.transform.position = playerCar.gameObject.transform.position;

					if(playerCharacter)
					{
						playerCharacter.transform.Find("MiniMapIndicator").gameObject.SetActive(false);
					}

					playerCar.transform.Find("MiniMapIndicator").gameObject.SetActive(true);

				if(Input.GetKeyDown(KeyCode.Return))
				{
					currentPlayMode = Helpers.PlayerMode.LEAVECAR;
				}
			}

			switch (currentPlayMode)
			{
				default:
				case Helpers.PlayerMode.PLAYSCHARACTER:
					playerCharacter.enabled = true;
					cameraManager.AttachCameraToPlayer();
					break;
				case Helpers.PlayerMode.ENTERCAR:
					playerCharacter.enabled = false;
					playerCharacter.gameObject.SetActive(false);
					playerCar.tag = "Player";
					SetPlayerVehicle(true, playerCar.GetComponent<VehicleManager>().vehicleCompanyName, playerCar.GetComponent<VehicleManager>().vehicleName);
					currentPlayMode = Helpers.PlayerMode.PLAYSCAR;
					break;
				case Helpers.PlayerMode.LEAVECAR:
					playerCar.GetComponent<PlayerController.CarStateManager>().currentState = Helpers.VehicleState.PARKED;
					playerCharacter.transform.position = playerCar.GetComponent<VehicleBehaviour.WheelVehicle>().carEntryPoint.position;
					playerCharacter.gameObject.SetActive(true);
					playerCar.tag = "Traffic";
					SetPlayerVehicle(false);
					currentPlayMode = Helpers.PlayerMode.PLAYSCHARACTER;
					break;
				case Helpers.PlayerMode.PLAYSCAR:
					cameraManager.AttachCameraToCar();
					playerCar.GetComponent<PlayerController.CarStateManager>().currentState = Helpers.VehicleState.PLAYERDRIVEN;
					break;
				case Helpers.PlayerMode.DYING:
					break;
			}
		}

		public void SaveGame()
		{
			SaveSystem.SaveCurrent(this);

			if(currentTimeOfDay == Helpers.DayTime.DAY)
			{
				currentTimeOfDay = Helpers.DayTime.NIGHT;
			}
			else if(currentTimeOfDay == Helpers.DayTime.NIGHT)
			{
				currentTimeOfDay = Helpers.DayTime.DAY;
			}
		}

		public void LoadGame()
		{
			GameData data = SaveSystem.LoadPlayer();

			// level = data.level;
			// health = data.health;

			// Vector3 position;
			// position.x = data.position[0];
			// position.y = data.position[1];
			// position.z = data.position[2];

			// transform.position = position;
		}

        public void SetPlayerArea(string name)
        {
            currentArea.text = "Current Area: " + name;
        }

        public void SetPlayerLocation(string name)
        {
            currentLocation.text = "Current Location: " + name;
        }

		public void SetPlayerVehicle(bool isDriving, string companyName = "", string vehicleName = "")
		{
			currentCar.text = "Current Vehicle: " + (isDriving ? companyName + " " + vehicleName : "NULL");
		}

		public void SetPlayerHealth(int amount)
		{
			currentHealth.text = "Current Health: " + amount.ToString();
		}

		public void SetPlayerArmor(int amount)
		{
			currentArmor.text = "Current Armor: " +  amount.ToString();
		}

		public void SetPlayerMoney(int amount)
		{
            currentMoney.text = "Current Money: " + amount.ToString();
		}
	}
}