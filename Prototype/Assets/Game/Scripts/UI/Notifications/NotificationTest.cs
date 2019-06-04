using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Game.Managers;

namespace Game
{
	public class NotificationTest : MonoBehaviour
	{
		//public event Action<String, String> sendNotification;

		public void Notify()
		{
			//if(sendNotification != null)
			//{
			//	sendNotification("TestHeader", "testDescription");
			//}	 

			GameManager.Instance.CreateNotification("TestHeader", "TestDescription");
		}
	}
}
