using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Modules.WayPointSystem
{ 
    public class WayPointTester : MonoBehaviour
    {
        public Path startPath;

        public List<WayPoint> waypointList = new List<WayPoint>();

        public WayPoint currentWayPoint;
        public int currentWayPointNumber = 0;

        // Start is called before the first frame update
        void Start()
        {
            startPath.debug = true;
            //waypointList.Add(startPath.CheckForConnection());

            foreach(WayPoint wp in startPath.GetComponentsInChildren<WayPoint>())
            {
                waypointList.Add(wp);
            }
        }

        // Update is called once per frame
        void Update()
        {
            currentWayPoint = waypointList[currentWayPointNumber];

            //foreach (Path path in pathList)
            //{
            //    path.debug = true;
            //}
        }

        void GetNextWayPoint(int currentWayPoint)
        {

        }
    }

}