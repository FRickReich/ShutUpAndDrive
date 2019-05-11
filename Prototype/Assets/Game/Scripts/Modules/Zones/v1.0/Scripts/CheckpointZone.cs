using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Modules
{
	[ExecuteInEditMode]
	public class CheckpointZone : MonoBehaviour
	{
		private GameObject debugVisual;

        public static event Action<CheckpointZone> checkpointChangeEvent;
		
		public bool debugMode;
        public bool initializer;

		private void Awake()
		{
			debugVisual = this.transform.Find("DebugVisual").gameObject;

			if(initializer)
			{
				checkpointChangeEvent(this);
			}
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

		private void OnTriggerEnter(Collider col)
		{
			if (col.tag == "Player")
			{
				if (checkpointChangeEvent != null)
				{
					checkpointChangeEvent(this);
				}
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
