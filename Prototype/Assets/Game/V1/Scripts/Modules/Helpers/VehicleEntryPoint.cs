using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

using Game.Controllers;

namespace Game.V1.Helper
{
	public class VehicleEntryPoint : MonoBehaviour
	{
        public InputControls inputControls;

		public Transform closestCharacter = null;

        public static event Action<VehicleBehaviour.WheelVehicle> damageDealtEvent;

		private void OnTriggerStay(Collider other)
        {
            if(other.tag == "Player")
            {
                damageDealtEvent(gameObject.transform.GetComponentInParent<VehicleBehaviour.WheelVehicle>());
            }  
        }

        private void OnTriggerExit(Collider other)
        {
            if(other.tag == "Player")
            {
                damageDealtEvent(null);
            }  
        }
	}
}
