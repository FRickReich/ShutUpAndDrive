using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace snd
{
public class Checkpoint : MonoBehaviour
{
    public bool initializer; 
    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void SetCurrentCheckPoint()
	{
		GameManager.Instance.ChangeCheckpoint(this);
	}

    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            SetCurrentCheckPoint();
        }
    }
}
}