using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.V1.Helper
{
	public class RotateObject : MonoBehaviour
	{
		public float rotateX;
        public float rotateY;
        public float rotateZ;

        public bool active = false;

		// Update is called once per frame
		void Update()
		{
            if(active)
            {
                Rotate(rotateX, rotateY, rotateZ);
            }
		}

        public void Rotate(float rotX, float rotY, float rotZ)
        {   
            gameObject.transform.Rotate(rotX * Time.deltaTime, rotY * Time.deltaTime, rotZ * Time.deltaTime, Space.Self);
        }
	}
}
