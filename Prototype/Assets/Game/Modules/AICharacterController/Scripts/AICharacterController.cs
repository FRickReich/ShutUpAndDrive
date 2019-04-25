using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace snd
{
    public class AICharacterController : MonoBehaviour
    {
        private Vector3 destination = Vector3.zero;
        private NavMeshAgent naveMeshAgent;

        private void Awake() {
            naveMeshAgent = GetComponent<NavMeshAgent>();
        }

        private void Start() 
        {
            
        }

        private void Update()
        {
            this.naveMeshAgent.SetDestination(destination);
        }

        public void SetDestination(Transform target)
        {
            destination = target.position;
        }

        public Vector3 Direction()
        {
            if(destination == Vector3.zero)
            {
                return destination;
            }

            Vector3 dir = destination - this.transform.position;
            dir.Set(dir.x, 0, dir.z);

            return dir.normalized;
        }
    }
}