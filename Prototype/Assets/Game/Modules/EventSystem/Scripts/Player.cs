using UnityEngine;

public class Player : MonoBehaviour
{
	#region Singleton
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
	}
}