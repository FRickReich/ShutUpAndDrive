using UnityEngine;

namespace Game.Modules.PlayerController
{
	public enum CurrentCarState
	{
		PARKED,
		PLAYERDRIVEN,
		NPCDRIVEN
	}

	public class CarStateManager : MonoBehaviour 
	{
		public CurrentCarState currentState = CurrentCarState.PARKED;
		
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
				case CurrentCarState.PARKED:
					CarParkedState();
					break;
				case CurrentCarState.PLAYERDRIVEN:
					CarPlayerDrivenState();
					break;
				case CurrentCarState.NPCDRIVEN:
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