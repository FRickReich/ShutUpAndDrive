using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Experimental.Input;

using Game.Controllers;
using Game.Enums;
using Game.Helpers;

namespace Game.Managers
{
	public class GameManager : MonoBehaviour
	{
        public PlayerCharacterController playerCharacter;
        public VehicleBehaviour.WheelVehicle playerCar;
		public VehicleBehaviour.WheelVehicle enterableVehicle;
		
		public InputControls inputControls;

		public PlayerMode currentPlayMode = PlayerMode.PLAYSCHARACTER;

		public static event Action<Transform> changeCameraTarget;

		private void OnEnable()
    	{
			InputControls inputControls = new InputControls();

            inputControls.Character.Interact.performed += context => Interact();
			inputControls.Vehicle.Interact.performed += context => Interact();

            inputControls.Enable();

        	VehicleEntryPoint.damageDealtEvent += SetVehicleEnterable;
	    }

    	private void OnDisable()
    	{
        	VehicleEntryPoint.damageDealtEvent -= SetVehicleEnterable;

			inputControls.Disable();
    	}

		public void SetVehicleEnterable(VehicleBehaviour.WheelVehicle currentVehicle)
		{
			enterableVehicle = currentVehicle;
		}

		// Start is called before the first frame update
		void Start()
		{

		}

		public void Interact()
        {
            if(enterableVehicle != null && currentPlayMode == PlayerMode.PLAYSCHARACTER)
            {
                currentPlayMode = PlayerMode.ENTERCAR;
            }
			else if(currentPlayMode == PlayerMode.PLAYSCAR)
			{
				currentPlayMode = PlayerMode.LEAVECAR;
			}
        }

		// Update is called once per frame
		void Update()
		{
			switch (currentPlayMode)
			{
				default:
				case PlayerMode.PLAYSCHARACTER:
					playerCharacter.enabled = true;
					playerCharacter.IsPlayer = true;
					changeCameraTarget(playerCharacter.gameObject.transform);
					break;

				case PlayerMode.ENTERCAR:
					playerCharacter.enabled = false;
					playerCharacter.gameObject.SetActive(false);
					playerCar = enterableVehicle;

					currentPlayMode = PlayerMode.PLAYSCAR;
					break;

				case PlayerMode.LEAVECAR:
					playerCharacter.transform.position = playerCar.GetComponentInChildren<VehicleEntryPoint>().transform.position;
					playerCharacter.gameObject.SetActive(true);
					playerCar.GetComponent<VehicleStateManager>().currentState = VehicleState.PARKED;

					currentPlayMode = PlayerMode.PLAYSCHARACTER;
					break;

				case PlayerMode.PLAYSCAR:
					playerCar.GetComponent<VehicleStateManager>().currentState = VehicleState.PLAYERDRIVEN;
					changeCameraTarget(playerCar.gameObject.transform);
					break;
			}
		}
	}
}

