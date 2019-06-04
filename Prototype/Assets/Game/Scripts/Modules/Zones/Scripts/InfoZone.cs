using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Game.Managers;

namespace Game.Zones
{
	[ExecuteInEditMode]
	public class InfoZone : MonoBehaviour
	{
		private GameObject debugVisual;

		public Sprite notificationIcon;
		public string nofitifationHeader;
		public string nofitifationDescription;

		private void Awake()
		{
			debugVisual = this.transform.Find("DebugVisual").gameObject;
		}

		private void OnEnable() 
		{
			//GameManager.setDebugModeEvent -= SetDebugVisual;	
		}

		private void OnDisable() 
		{
			//GameManager.setDebugModeEvent -= SetDebugVisual;	
		}

		private void OnTriggerEnter(Collider col)
		{
			if (col.tag == "Player")
			{
				CreateNotification(nofitifationHeader, nofitifationDescription);
			}
		}

		private void CreateNotification(string headerText, string descriptionText)
		{
			GameManager.Instance.CreateNotification(headerText, descriptionText);
		}

		public void SetDebugVisual(bool setActive)
		{
			debugVisual.SetActive(setActive);	
		}
	}
}
