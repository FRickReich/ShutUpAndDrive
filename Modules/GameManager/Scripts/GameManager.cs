using System.Collections.Generic;
using System.Collections;
using UnityEngine;

using Game.Modules;

namespace Game.Modules.Managers
{
	public enum PlayerMode
	{
		PLAYSCHARACTER,
		ENTERCAR,
		LEAVECAR,
		PLAYSCAR,
		DYING
	}
	public class GameManager : MonoBehaviour
	{
		public PlayerController.PlayerCharacterController playerCharacter;
		public GameObject playerCar;

		public GameObject enterableVehicle;

		public PlayerMode currentPlayMode = PlayerMode.PLAYSCHARACTER;
		
		private CameraManager.CameraManager cameraManager;

		private void Awake() 
		{
			cameraManager = FindObjectOfType<CameraManager.CameraManager>();	
		}

		void Update()
		{

			if(playerCharacter)
			{
				if(currentPlayMode == PlayerMode.PLAYSCHARACTER)
				{
					gameObject.transform.position = playerCharacter.gameObject.transform.position;

					enterableVehicle = playerCharacter.enterableCar;

					if(enterableVehicle != null)
					{
						if(Input.GetKeyDown(KeyCode.Return))
						{
							playerCar = enterableVehicle;
							currentPlayMode = PlayerMode.ENTERCAR;
						}
					}
				}
			}
			
			if(currentPlayMode == PlayerMode.PLAYSCAR)
			{
				gameObject.transform.position = playerCar.gameObject.transform.position;

				if(Input.GetKeyDown(KeyCode.Return))
				{
					currentPlayMode = PlayerMode.LEAVECAR;
				}
			}

			switch (currentPlayMode)
			{
				default:
				case PlayerMode.PLAYSCHARACTER:
					playerCharacter.enabled = true;
					cameraManager.AttachCameraToPlayer();
					break;
				case PlayerMode.ENTERCAR:
					playerCharacter.enabled = false;
					playerCharacter.gameObject.SetActive(false);
					currentPlayMode = PlayerMode.PLAYSCAR;
					break;
				case PlayerMode.LEAVECAR:
					playerCar.GetComponent<PlayerController.CarStateManager>().currentState = PlayerController.CurrentCarState.PARKED;
					playerCharacter.transform.position = playerCar.GetComponent<PlayerController.PlayerCarController>().carEnterPoint.position;
					playerCharacter.gameObject.SetActive(true);
					currentPlayMode = PlayerMode.PLAYSCHARACTER;
					break;
				case PlayerMode.PLAYSCAR:
					cameraManager.AttachCameraToCar();
					playerCar.GetComponent<PlayerController.CarStateManager>().currentState = PlayerController.CurrentCarState.PLAYERDRIVEN;
					break;
				case PlayerMode.DYING:
					break;
			}
		}
	}
}