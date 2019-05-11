using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievements : MonoBehaviour
{
    private void OnEnable()
    {
        FindObjectOfType<Player>().deathEvent += OnPlayerDeath;
    }

    private void OnDisable()
    {
        FindObjectOfType<Player>().deathEvent -= OnPlayerDeath;
    }
    
    public void OnPlayerDeath(string headerText, string descriptionText)
    {
        Debug.Log(headerText + "/" + descriptionText);
    }
}
