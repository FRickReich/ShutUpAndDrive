using UnityEngine;
 
public class Flashlight : MonoBehaviour
{
	public Light FlashLightObject;
	private bool LightEnabled = false;
 
	void Update ()
	{
		if(Input.GetButtonDown("Flashlight"))
		{
			LightEnabled = !LightEnabled;
			FlashLightObject.enabled = LightEnabled;
		}
	}
}