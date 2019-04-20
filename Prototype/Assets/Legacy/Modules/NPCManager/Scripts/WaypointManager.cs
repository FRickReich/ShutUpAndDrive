using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.NPC
{
    public class WaypointManager : MonoBehaviour
    {
        public GameObject[] waypoints;

        public GameObject NextWaypoint(GameObject current)
        {
            GameObject currentWaypoint = null;

            if (waypoints.Length < 1)
            {
                Debug.LogError("WaypointManager:: ERROR - no waypoints havebeen added to array!");
            }
            else
            {
                int currentIndex = Array.IndexOf(waypoints, current);
                int nextIndex = ((currentIndex + 1) % waypoints.Length);

                currentWaypoint = waypoints[nextIndex];
            }

            return currentWaypoint;
        }
    }
}