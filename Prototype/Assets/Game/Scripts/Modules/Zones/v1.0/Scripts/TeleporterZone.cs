using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Modules
{
	[ExecuteInEditMode]
	public class TeleporterZone : MonoBehaviour
	{
		private GameObject debugVisual;

        public static event Action<TeleporterZone> TeleporterEvent;
		
		public bool debugMode;
		public TeleporterZone targetZone;
		public string targetScene;

		private void Awake()
		{
			debugVisual = this.transform.Find("DebugVisual").gameObject;
		}

		private void Update()
        {
            if(debugMode)
            {
				ShowDebugVisual();
            }
            else
            {
				HideDebugVisual();
            }
        }

		private void OnTriggerStay(Collider col)
		{
			if(col.tag == "Player")
        	{
				
			}
		}

		private void OnTriggerExit(Collider col)
		{
			if(col.tag == "Player")
        	{
				
			}
		}

		public void ShowDebugVisual()
		{
			debugVisual.SetActive(true);
		}

		public void HideDebugVisual()
		{
			debugVisual.SetActive(false);
		}
	}
}
