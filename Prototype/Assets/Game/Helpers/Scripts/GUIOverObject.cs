using UnityEngine;
using System.Collections;
 
[ExecuteInEditMode]
public class GUIOverObject : MonoBehaviour
{
 
	// Use this for initialization
	void Start ()
	{
 
	}
 
	// Update is called once per frame
	void Update ()
	{
		var parent = transform.parent;
 
		if (parent == null) {
			Debug.LogError ("No parent");
			return;
		}
		var screenpoint = Camera.main.WorldToViewportPoint (parent.transform.position);
		this.transform.position = screenpoint;
	}
}