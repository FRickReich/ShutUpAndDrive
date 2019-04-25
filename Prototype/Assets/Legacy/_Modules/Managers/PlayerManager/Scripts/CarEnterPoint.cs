using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Modules
{
    public class CarEnterPoint : MonoBehaviour
    {
        public Helpers.CarHingePosition position;
        public Transform closestCharacter = null;
        
        private void OnTriggerEnter(Collider other)
        {
            if(other.tag == "Player")
            {
                closestCharacter = other.transform;
                closestCharacter.GetComponent<PlayerController.PlayerCharacterController>().enterableCar = this.gameObject.transform.parent.gameObject;
            }  
        }

        private void OnTriggerExit(Collider other)
        {
            closestCharacter.GetComponent<PlayerController.PlayerCharacterController>().enterableCar = null;
            closestCharacter = null;
        }
    }
}