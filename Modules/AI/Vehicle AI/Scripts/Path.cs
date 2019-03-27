using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Modules.VehicleAI
{ 
    public class Path : MonoBehaviour
    {
        public Color rayColor = new Color(255, 169, 0);
        public List<Transform> path = new List<Transform>();
        public Transform[] childs;

        void Start()
        {
            //childs = transform.GetComponentsInChildren<Transform>();
        }

        void OnDrawGizmos()
        {
            Gizmos.color = rayColor;

            for (int i = 0; i < path.Count; i++)
            {
                Vector3 pos = path[i].position;
                if (i > 0)
                {
                    Vector3 prev = path[i - 1].position;
                    Gizmos.DrawLine(prev, pos);
                    Gizmos.DrawWireSphere(pos, 0.3f);
                }
            }

        }
    }
}