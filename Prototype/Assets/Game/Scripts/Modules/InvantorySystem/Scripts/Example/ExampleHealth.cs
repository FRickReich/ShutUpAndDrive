using UnityEngine;

public class ExampleHealth : MonoBehaviour {

    
    public float maxHealth = 100;
    public float Health { get; set; }


	// Use this for initialization
	void Start () {
        Health = maxHealth;
	}
	

    void Update()
    {
        Health -= 5 * Time.deltaTime;
    }
}


