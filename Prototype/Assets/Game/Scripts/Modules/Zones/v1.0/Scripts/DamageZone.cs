using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Modules
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
