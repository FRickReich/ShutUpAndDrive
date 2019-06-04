using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Zones
{
    [ExecuteInEditMode]
    public class DamageZone : MonoBehaviour
    {
        private GameObject debugVisual;

        public static event Action<int> damageDealtEvent;

        public string[] collidingTags;
        public int damage;
        public bool debugMode;

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
            if(collidingTags.Any(x => x == col.tag))
            {
                if (damageDealtEvent != null)
                {
                    damageDealtEvent(damage);
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
