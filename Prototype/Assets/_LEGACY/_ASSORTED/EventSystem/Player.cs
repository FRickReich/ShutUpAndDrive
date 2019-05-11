using UnityEngine;
using System;

public class Player : MonoBehaviour
{
	/* public event Func<RETURN TYPE> Action<...>
		Func<int, string, bool> myDelgate;
		=
		delgate bool MyDelgate(int a, string b);
		MyDelegate myDelegate;
	*/
	public event Action<String, String> deathEvent;

	public void Die()
	{
		if(deathEvent != null)
		{
			deathEvent("TestHeader", "testDescription");
		}	 
	}







	/*#region Singleton
	private static Player _instance;
	public static Player Instance { get; set; }
	#endregion

	public delegate void ChangeEnemyColor(Color color);
	public static event ChangeEnemyColor onEnemyHit;

	public delegate void ChangeEnemyText(string text);
	public static event ChangeEnemyText onEnemyText;

	void Awake()
	{
		_instance = this;
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			if(onEnemyHit != null)
			{
				onEnemyHit(Color.red);
				onEnemyText("Hello world!");
			}
		}
	} */
}