using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Modules.WayPointSystem
{
    public enum WayPointType
    {
        NORMAL,
        ENTRY,
        EXIT
    }

    public class WayPoint : MonoBehaviour
    {
        public WayPointType wayPointType;

        // Start is called before the first frame update
        void Start()
        {

        }

        /*public Path CheckForConnection()
        {
            float raycastLength = 1f;
            Collider[] objs;
            List<Path> pathList = new List<Path>();

            objs = Physics.OverlapSphere(waypoints[waypoints.Length - 1].transform.position, raycastLength);

            foreach (Collider c in objs)
            {
                if (c.GetComponent<WayPoint>())
                {
                    if (c.GetComponent<WayPoint>().wayPointType == WayPointType.ENTRY)
                    {
                        pathList.Add(c.GetComponentInParent<Path>());
                    }
                }
            }

            return pathList[Random.Range(0, pathList.Count)];
        }
        */
    }
}