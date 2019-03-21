using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Game.NPC
{
    public class NPCController : MonoBehaviour
    {
        public float speed;
        public float startWaitTime;

        private float waitTime;
        public Transform[] moveSpots;
        private int randomSpot;

        NavMeshAgent navAgent;

        private void Start()
        {
            navAgent = GetComponent<NavMeshAgent>();
            waitTime = startWaitTime;
            randomSpot = Random.Range(0, moveSpots.Length);
        }

        void Update()
        {
            navAgent.SetDestination(moveSpots[randomSpot].position);
            navAgent.speed = speed;

            if (Vector3.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
            {
                if (waitTime <= 0)
                {
                    randomSpot = Random.Range(0, moveSpots.Length);
                    waitTime = startWaitTime;
                }
                else
                {
                    waitTime -= Time.deltaTime;
                }
            }
        }

        /*
        private GameObject wayPoint = null;
        NavMeshAgent navAgent;
        public WaypointManager waypointManager;

        private float runAwayMultiplier = 0.2f;
        private float runAwayDistance;

        void Start()
        {
            navAgent = GetComponent<NavMeshAgent>();
            waypointManager = GetComponent<WaypointManager>();

            HeadForNextWayPoint();

            runAwayDistance = navAgent.stoppingDistance * runAwayMultiplier;
        }

        private void SetDestination(Vector3 destinationPosition)
        {
            navAgent.SetDestination(destinationPosition);
        }

        // Update is called once per frame
        void Update()
        {
            float closeToDestinaton = navAgent.stoppingDistance * 2;

            if (navAgent.remainingDistance < closeToDestinaton)
            {
                HeadForNextWayPoint();
            }

            //Vector3 enemyPosition = currentTarget.transform.position;
            //float distanceFromEnemy = Vector3.Distance(transform.position, enemyPosition);
            //FleeFromTarget(enemyPosition);
        }
        private void FleeFromTarget(Vector3 enemyPosition)
        {
            Vector3 fleeToPosition = Vector3.Normalize(transform.position - enemyPosition) * runAwayDistance;
            SetDestination(fleeToPosition);
        }

        private void HeadForNextWayPoint()
        {
            wayPoint = waypointManager.NextWaypoint(wayPoint);
            navAgent.SetDestination(wayPoint.transform.position);
        }

        //nav.enabled = false;
        */
    }
}