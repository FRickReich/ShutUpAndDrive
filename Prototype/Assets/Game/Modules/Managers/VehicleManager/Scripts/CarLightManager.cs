using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Game.Modules
{
	public class CarLightManager : MonoBehaviour
	{
		private Transform lightObject;

		private Transform headLights;
		private Transform tailLights;
		private Transform BrakeLights;
		private Transform LeftIndicators;
		private Transform RightIndicators;

		private Coroutine indicatorBlink = null;

		private void Awake()
		{
			lightObject = gameObject.transform.Find("Lights").transform;

			headLights = lightObject.transform.Find("Front");
			tailLights = lightObject.transform.Find("Rear");
			BrakeLights = lightObject.transform.Find("Brake");
			LeftIndicators = lightObject.transform.Find("LeftIndicators");
			RightIndicators = lightObject.transform.Find("RightIndicators");	
		}

		public void MainLights(bool lightState)
		{
			HandleLightState(headLights, lightState);
			HandleLightState(tailLights, lightState);
		}

		public void TurnLeft(bool isTurning)
		{
			if(isTurning)
			{
				HandleIndicatorLightChanges(LeftIndicators, true);
			}
			else
			{
				HandleIndicatorLightChanges(LeftIndicators, false);
			}
		}

		public void TurnRight(bool isTurning)
		{
			if(isTurning)
			{
				HandleIndicatorLightChanges(LeftIndicators, true);
			}
			else
			{
				HandleIndicatorLightChanges(LeftIndicators, false);
			}
		}

		public void Brake(bool isBreaking)
		{
			if(isBreaking)
			{
				HandleLightState(BrakeLights, true);
			}
			else
			{
				HandleLightState(BrakeLights, false);
			}
		}

		public void EmergencyLight(bool isPoweredUp)
		{
			
		}

		public void EngineOff()
		{
			HandleLightState(headLights, false);
			HandleLightState(tailLights, false);
			HandleLightState(BrakeLights, false);
			HandleIndicatorLightChanges(LeftIndicators, false);
			HandleIndicatorLightChanges(RightIndicators, false);
		}

		public void HandleLightState(Transform lightGroup, bool isPoweredUp)
		{
			if(isPoweredUp)
			{
				lightGroup.gameObject.SetActive(true);
			}
			else
			{
				lightGroup.gameObject.SetActive(false);
			}
		}

		public void HandleIndicatorLightChanges(Transform lightGroup, bool isPoweredUp)
		{
			if(isPoweredUp)
			{
				indicatorBlink = StartCoroutine(Indicate(1f, lightGroup));
			}
			else
			{
				if(indicatorBlink != null)
				{
					StopCoroutine(indicatorBlink);
				}
			}
		}

		private IEnumerator Indicate(float waitTime, Transform lightGroup)
		{
			lightGroup.gameObject.SetActive(true);
			yield return new WaitForSeconds(waitTime);
			lightGroup.gameObject.SetActive(false);
			yield return new WaitForSeconds(waitTime);
		}
	}	
}