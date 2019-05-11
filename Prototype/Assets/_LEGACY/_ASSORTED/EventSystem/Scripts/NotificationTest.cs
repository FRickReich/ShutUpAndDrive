using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace snd
{
public class NotificationTest : MonoBehaviour
{
    public event Action<String, String> sendNotification;

	public void Notify()
	{
		if(sendNotification != null)
		{
			sendNotification("TestHeader", "testDescription");
		}	 
	}
}
}