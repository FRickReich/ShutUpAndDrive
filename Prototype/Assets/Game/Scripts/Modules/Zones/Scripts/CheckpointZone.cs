using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Game.Managers;

namespace Game.Zones
{
	[ExecuteInEditMode]
	public class CheckpointZone : MonoBehaviour
	{
		private GameObject debugVisual;

        public static event Action<Vector3> checkpointChangeEvent;
		
        public bool initializer;

		private void Awake()
		{
			debugVisual = this.transform.Find("DebugVisual").gameObject;
		}

		private void Start()
		{
			if(initializer)
			{
				SetCheckpoint();
			}
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
				if (checkpointChangeEvent != null)
				{
					SetCheckpoint();
				}
			}
		}

		public void SetCheckpoint()
		{
			checkpointChangeEvent(
				new Vector3(
					gameObject.transform.position.x,
					gameObject.transform.position.y,
					gameObject.transform.position.z
				)
				);
		}

		public void SetDebugVisual(bool setActive)
		{
			debugVisual.SetActive(setActive);	
		}
	}
}
