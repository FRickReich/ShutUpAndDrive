using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Game.Modules.AICrowd
{
    public class AgentControl : MonoBehaviour
    {
        public List<Transform> targets = new List<Transform>();
        NavMeshAgent agent;

        public Transform currentTarget;
        public Transform previousTarget;

        private void Awake()
        {
            foreach (GameObject tg in GameObject.FindGameObjectsWithTag("Target"))
            {
                targets.Add(tg.transform);
            }
        }
        // Start is called before the first frame update
        void Start()
        {
            currentTarget = targets[Random.Range(0, targets.Count - 1)];

            agent = this.GetComponent<NavMeshAgent>();
            agent.SetDestination(currentTarget.position);
            agent.speed = Random.Range(2, 6);
            previousTarget = currentTarget;
        }

        private void Update()
        {
            float distanceToTarget = Vector3.Distance(transform.position, currentTarget.position);
            if (distanceToTarget < 2)
            {
                currentTarget = targets[Random.Range(0, targets.Count - 1)];

                if(previousTarget == currentTarget)
                {
                    currentTarget = targets[Random.Range(0, targets.Count - 1)];

                }
                else
                {
                    previousTarget = currentTarget;
                }

                agent.SetDestination(currentTarget.position);
            }
        }
    }
}