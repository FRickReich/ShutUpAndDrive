using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

using Game.Controllers;

namespace Game.Helpers
{
	public class VehicleEntryPoint : MonoBehaviour
	{
        public InputControls inputControls;

		public Transform closestCharacter = null;

        public static event Action<VehicleBehaviour.WheelVehicle> damageDealtEvent;

        /*
        private void OnEnable()
        {
            InputControls inputControls = new InputControls();

            inputControls.Character.Interact.performed += context => CharacterInteract();

            inputControls.Enable();
        }

        private void OnDisable() => inputControls.Disable();

        private void Update() {}

        public void CharacterInteract()
        {
            if(closestCharacter != null)
            {
                gameObject.transform.GetComponentInParent<VehicleBehaviour.WheelVehicle>().IsPlayer = true;
                closestCharacter.GetComponent<PlayerCharacterController>().IsPlayer = false;
            }    
        }
        */

		private void OnTriggerStay(Collider other)
        {
            if(other.tag == "Player")
            {
                damageDealtEvent(gameObject.transform.GetComponentInParent<VehicleBehaviour.WheelVehicle>());
            }  
        }
	}
}
