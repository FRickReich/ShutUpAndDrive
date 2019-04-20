using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody rb;
    public float moveSpeed = 5;

    //public PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //playerController = FindObjectOfType<PlayerController>();
    }

    private void FixedUpdate()
    {
        rb.velocity = (transform.forward * moveSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(new Vector3(playerController.transform.position.x, transform.position.y, playerController.transform.position.z));
    }
}
