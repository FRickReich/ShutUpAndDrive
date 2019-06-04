using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour {

	public Light[] lightPrefabs;

	public float minWaitTime = 0.1f;
	public float maxWaitTime = 0.5f;

	public bool isVolumetric;

	public Material EmissiveOn;
	public Material EmissiveOff;

	public GameObject[] FlickeringObject;

	//private float[] smoothing = new float[20];

	// Use this for initialization
	void Start() {

		StartCoroutine(Flashing());

		//for (int i = 0; i < smoothing.Length; i++) {
		//	smoothing[i] = .0f;
		//}

	}

	// Update is called once per frame
	void Update() {

		//float sum = .0f;

		//for (int i = 1; i < smoothing.Length; i++) {

		//	smoothing[i - 1] = smoothing[i];
		//	sum += smoothing[i - 1];

		//}

		//smoothing[smoothing.Length - 1] = Random.value;
		//sum += smoothing[smoothing.Length - 1];

		//lightPrefab.intensity = sum / smoothing.Length;

	}

	IEnumerator Flashing() {

		while (true) {

			yield return new WaitForSeconds(Random.Range(minWaitTime, maxWaitTime));

			for (int i = 0; i < lightPrefabs.Length; i++) {

				lightPrefabs[i].enabled = !lightPrefabs[i].enabled;
                
				//if (lightPrefabs[i].GetComponent<LightShafts>() != null) {
				//	lightPrefabs[i].GetComponent<LightShafts>().enabled = !lightPrefabs[i].GetComponent<LightShafts>().enabled;
                //}

				if (FlickeringObject != null) {

                for (int j = 0; j < FlickeringObject.Length; j++) {

                    if (lightPrefabs[i].enabled == true) {

                        FlickeringObject[j].GetComponent<Renderer>().material = EmissiveOn;
                            
                    } else if (lightPrefabs[i].enabled == false) {

                        FlickeringObject[j].GetComponent<Renderer>().material = EmissiveOff;

                    }               
                }
            }     

			}         
			    
		}      
	}
}
