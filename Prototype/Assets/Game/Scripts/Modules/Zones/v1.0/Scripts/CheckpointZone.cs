using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Game.Managers;

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
		}

		private void Start()
		{
			if(initializer)
			{
				SetCheckpointActive();
			}
		}

		private void OnEnable() 
		{
			GameManager.setDebugModeEvent -= SetDebugVisual;	
		}

		private void OnDisable() 
		{
			GameManager.setDebugModeEvent -= SetDebugVisual;	
		}

		private void OnTriggerEnter(Collider col)
		{
			if (col.tag == "Player")
			{
				if (checkpointChangeEvent != null)
				{
					SetCheckpointActive();
				}
			}
		}

		public void SetCheckpointActive()
		{
			checkpointChangeEvent(this);
		}

		public void SetDebugVisual(bool setActive)
		{
			debugVisual.SetActive(setActive);	
		}
	}
}
