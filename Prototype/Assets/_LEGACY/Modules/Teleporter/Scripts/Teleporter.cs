using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace snd
{
public class Teleporter : MonoBehaviour
{
    public GameObject enterText;
    public string levelToLoad;

    public static event Action<string> SceneChangeEvent;

    // Start is called before the first frame update
    void Start()
    {
        //enterText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider col) {
        if(col.gameObject.tag == "Player")
        {
            enterText.SetActive(true);

            if(InputManager.Instance.xboxButtonX)
            {
                SceneChangeEvent(levelToLoad);
            }
        }
    }

    private void OnTriggerExit(Collider col) {
        if(col.gameObject.tag == "Player")
        {
            enterText.SetActive(false);
        }
    }
}
}