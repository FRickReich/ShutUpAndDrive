using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float speed;
    public bool x;
    public bool y;
    public bool z;

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(
            x ? speed * Time.deltaTime : 0,
            y ? speed * Time.deltaTime : 0,
            z ? speed * Time.deltaTime : 0,
            Space.Self
        );
    }
}
