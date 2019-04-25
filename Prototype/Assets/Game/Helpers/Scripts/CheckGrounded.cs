using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGrounded : MonoBehaviour
{
    /*
    public virtual bool Grounded()
        {
            RaycastHit hit;
            Vector3 ray;

            float yRay = (meshRenderer.bounds.center.y - meshRenderer.bounds.extents.y) + 3f;
            float centerX = meshRenderer.bounds.center.x;
            float centerZ = meshRenderer.bounds.center.z;
            float extentX = meshRenderer.bounds.extents.x;
            float extentZ = meshRenderer.bounds.extents.z;

            ray = new Vector3(centerX, centerZ);
            Debug.DrawRay(ray, Vector3.down, Color.green);
            if(Physics.Raycast (ray, Vector3.down, out hit, 3.0f))
            {
                return true;
            }
            ray = new Vector3(centerX + extentZ, centerZ + extentZ);
            Debug.DrawRay(ray, Vector3.down, Color.green);
            if(Physics.Raycast (ray, Vector3.down, out hit, 3.0f))
            {
                return true;
            }
            ray = new Vector3(centerX - extentZ, centerZ + extentZ);
            Debug.DrawRay(ray, Vector3.down, Color.green);
            if(Physics.Raycast (ray, Vector3.down, out hit, 3.0f))
            {
                return true;
            }
            ray = new Vector3(centerX - extentZ, centerZ - extentZ);
            Debug.DrawRay(ray, Vector3.down, Color.green);
            if(Physics.Raycast (ray, Vector3.down, out hit, 3.0f))
            {
                return true;
            }
            ray = new Vector3(centerX + extentZ, centerZ - extentZ);
            Debug.DrawRay(ray, Vector3.down, Color.green);
            if(Physics.Raycast (ray, Vector3.down, out hit, 3.0f))
            {
                return true;
            }

            return false;
        }
         */
}
