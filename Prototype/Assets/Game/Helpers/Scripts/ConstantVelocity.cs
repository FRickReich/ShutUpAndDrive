using UnityEngine;
 
[RequireComponent (typeof (Rigidbody))]
public class ConstantVelocity : MonoBehaviour
{
    public Vector3 direction = Vector3.forward;
 
    private Rigidbody m_Rigidbody;
    private Transform m_Transform;
 
 
    private void Awake ()
    {
        // Optimization - Cache component references.
        m_Transform = GetComponent<Transform> ();
        m_Rigidbody = GetComponent<Rigidbody> ();
    }
 
 
    private void FixedUpdate ()
    {
        m_Rigidbody.velocity = m_Transform.rotation * direction;
    }
}