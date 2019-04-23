using UnityEngine;
 
public class Teleporter : MonoBehaviour
{
    Transform teleportTo;
 
    void OnCollisionEnter (Collision col)
    {
        col.transform.position = teleportTo.position;	
    }
}