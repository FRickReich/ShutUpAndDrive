using UnityEngine;

namespace Game.Helpers
{
	public class VehicleEntryPoint : MonoBehaviour
	{
		public Transform closestCharacter = null;

		private void OnTriggerEnter(Collider other)
        {
            if(other.tag == "Player")
            {
                closestCharacter = other.transform;
            }  
        }

        private void OnTriggerExit(Collider other)
        {
            closestCharacter = null;
        }
	}
}
