using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Game.Enums;
using System;

namespace Game.Managers
{
	public class VehicleStateManager : MonoBehaviour
	{
        public VehicleState currentState = VehicleState.PARKED;
        private VehicleBehaviour.WheelVehicle playerCarController;

        private void Awake()
		{
			playerCarController = GetComponent<VehicleBehaviour.WheelVehicle>();
		}

		// Start is called before the first frame update
		void Start()
		{

		}

		// Update is called once per frame
		void Update()
		{
            switch (currentState)
			{
				default:
				case VehicleState.PARKED:
					VehicleParkedState();
					break;
				case VehicleState.PLAYERDRIVEN:
					VehiclePlayerDrivenState();
					break;
				case VehicleState.AIDRIVEN:
					VehicleAIrivenState();
					break;
			}
		}

		private void VehicleParkedState()
		{
			playerCarController.IsPlayer = false;
			playerCarController.Handbrake = true;
            playerCarController.tag = "Traffic";
		}

		private void VehiclePlayerDrivenState()
		{
			playerCarController.IsPlayer = true;
			playerCarController.Handbrake = false;
            playerCarController.tag = "Player";
		}

		private void VehicleAIrivenState()
		{
			playerCarController.IsPlayer = false;
            playerCarController.tag = "Traffic";
		}
	}
}
