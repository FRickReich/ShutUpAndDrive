using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace snd
{
    
public class ChangeScene : MonoBehaviour
{
    public GameObject enterText;
    public string levelToLoad;

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
                SceneManager.LoadScene(levelToLoad);
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