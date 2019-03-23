using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Modules
{
    public enum CarHingePosition
	{
		HOOD,
		TRUNK,
		LEFTFRONTDOOR,
        RIGHTFRONTDOOR,
        LEFTREARDOOR,
        RIGHTREARDOOR
	}

    public class CarEnterPoint : MonoBehaviour
    {
        public CarHingePosition position;
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