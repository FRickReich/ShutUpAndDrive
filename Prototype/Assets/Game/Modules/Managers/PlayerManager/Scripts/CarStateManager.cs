using UnityEngine;

namespace Game.Modules.PlayerController
{
	public class CarStateManager : MonoBehaviour 
	{
		public Helpers.VehicleState currentState = Helpers.VehicleState.PARKED;
		
		//private PlayerCarController playerCarController;
		private VehicleBehaviour.WheelVehicle playerCarController;
		private CarLightManager carLights;

		private void Awake()
		{
			playerCarController = GetComponent<VehicleBehaviour.WheelVehicle>();
			carLights = GetComponent<CarLightManager>();
		}

		private void Update()
		{
			switch (currentState)
			{
				default:
				case Helpers.VehicleState.PARKED:
					CarParkedState();
					break;
				case Helpers.VehicleState.PLAYERDRIVEN:
					CarPlayerDrivenState();
					break;
				case Helpers.VehicleState.NPCDRIVEN:
					CarNPCDrivenState();
					break;
			}
		}

		public void CarParkedState()
		{
			playerCarController.IsPlayer = false;
			playerCarController.Handbrake = true;
			carLights.EngineOff();
		}

		public void CarPlayerDrivenState()
		{
			playerCarController.IsPlayer = true;
			playerCarController.Handbrake = false;
			carLights.MainLights(true);
		}

		public void CarNPCDrivenState()
		{
			playerCarController.IsPlayer = false;
		}
	}
}