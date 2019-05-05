using UnityEngine;

namespace snd {
public class CreateNotification : MonoBehaviour
{
	#region Singleton
	private static CreateNotification _instance;
	public static CreateNotification Instance { get; set; }
	#endregion

	public Sprite icon;
	public string header;
	public string description;

	public delegate void CreateNotificationMessage(string header, string description);
	public static event CreateNotificationMessage newNotification;

	void Awake()
	{
		_instance = this;
	}

	public void Create(string header, string description)
	{

		newNotification(header, description);
	}
}}