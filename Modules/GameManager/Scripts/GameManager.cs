using System.Collections.Generic;
using System.Collections;
using UnityEngine;

using Game.Modules.Internal;

namespace Game.Modules.Managers
{
	public class GameManager : MonoBehaviour
	{
		public PlayerController.PlayerCharacterController playerCharacter;
		public GameObject playerCar;

		public GameObject enterableVehicle;

		public Helpers.PlayerMode currentPlayMode = Helpers.PlayerMode.PLAYSCHARACTER;
		
		private CameraManager.CameraManager cameraManager;

		private void Awake() 
		{
			cameraManager = FindObjectOfType<CameraManager.CameraManager>();	
		}

		void Update()
		{

			if(playerCharacter)
			{
				if(currentPlayMode == Helpers.PlayerMode.PLAYSCHARACTER)
				{
					gameObject.transform.position = playerCharacter.gameObject.transform.position;

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
					currentPlayMode = Helpers.PlayerMode.PLAYSCAR;
					break;
				case Helpers.PlayerMode.LEAVECAR:
					playerCar.GetComponent<PlayerController.CarStateManager>().currentState = Helpers.VehicleState.PARKED;
					playerCharacter.transform.position = playerCar.GetComponent<PlayerController.PlayerCarController>().carEnterPoint.position;
					playerCharacter.gameObject.SetActive(true);
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
	}
}