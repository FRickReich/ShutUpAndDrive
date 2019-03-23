using UnityEngine;

namespace Game.Modules.PlayerController
{
	public class CarStateManager : MonoBehaviour 
	{
		public Helpers.VehicleState currentState = Helpers.VehicleState.PARKED;
		
		private PlayerCarController playerCarController;
		private CarLightManager carLights;

		private void Awake()
		{
			playerCarController = GetComponent<PlayerCarController>();
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
			playerCarController.enabled = false;
			carLights.EngineOff();
		}

		public void CarPlayerDrivenState()
		{
			playerCarController.enabled = true;
			carLights.MainLights(true);
		}

		public void CarNPCDrivenState()
		{
			playerCarController.enabled = false;
		}
	}
}