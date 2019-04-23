using UnityEngine;
 
public class ExplosionForce : MonoBehaviour
{
    [SerializeField] private float m_Radius = 5f;
    [SerializeField] private float m_Power = 25f;
    [SerializeField] private float m_UpwardForce = 0f;
 
    // Automatic destruction delay.
    [SerializeField] private float m_TimeOut = 1.0F;
 
 
    private void Start ()
    {
        Destroy (gameObject, m_TimeOut);
    }
 
 
    private void FixedUpdate ()
    {
        // Applies an explosive force to all nearby rigidbodies.
        Vector3 explosionPos = transform.position;
        Collider [] colliders = Physics.OverlapSphere (explosionPos, m_Radius);
 
        foreach (Collider hit in colliders)
        {
            if (hit == null)
            {
                continue;
            }
 
            if (hit.attachedRigidbody)
            {
                hit.attachedRigidbody.AddExplosionForce (m_Power, explosionPos, m_Radius, m_UpwardForce);
            }
        }
    }
 
 
    // Debug function to visualize explosion radius.
    private void OnDrawGizmos ()
    {
        Gizmos.color = new Color (1, 0, 0, 0.3f);
        Gizmos.DrawSphere (transform.position, m_Radius);
    }
}