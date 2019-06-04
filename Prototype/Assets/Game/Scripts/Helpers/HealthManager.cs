using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public int initialHealth;
    public int initialArmor;

    public int currentHealth;
    public int currentArmor;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = initialHealth;
        currentArmor = initialArmor;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }
}
