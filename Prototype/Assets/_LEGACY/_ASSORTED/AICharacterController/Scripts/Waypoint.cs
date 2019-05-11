using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace snd
{
	public class Waypoint : MonoBehaviour
	{
        public Transform destination;

		private void OnTriggerEnter(Collider col) {
            col.SendMessage("SetDestination", destination);
        }
	}
}