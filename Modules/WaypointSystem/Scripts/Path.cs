using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Modules.WayPointSystem
{
    public enum PathMode
    {
        CHASE,
        TRAFFIC
    }

    public class Path : MonoBehaviour
    {
        public WayPoint[] waypoints;
        public PathMode pathMode;

        public bool debug;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnDrawGizmos()
        {
            if(pathMode == PathMode.TRAFFIC)
            {
                Gizmos.color = Color.cyan;
            }
            else if(pathMode == PathMode.CHASE)
            {
                Gizmos.color = Color.yellow;
            }

            if(debug == true)
            {
                Gizmos.color = Color.red;
            }

            for (int i = 0; i < waypoints.Length; i++)
            {
                Vector3 pos = waypoints[i].transform.position;
                if (i > 0)
                {
                    Vector3 prev = waypoints[i - 1].transform.position;
                    Gizmos.DrawLine(prev, pos);
                    Gizmos.DrawWireSphere(pos, 0.3f);
                }
            }
        }
    }
}