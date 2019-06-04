using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Game.Helpers
{
	public class InteractionManager : MonoBehaviour
	{
		public event Action<String> interactionShowEvent;
		public event Action interactionHideEvent;

		private void OnTriggerEnter(Collider col)
		{
			if (col.gameObject.tag == "Player")
			{
				interactionShowEvent("test");
			}
		}

		private void OnTriggerExit(Collider col)
		{
			if (col.gameObject.tag == "Player")
			{
				interactionHideEvent();
			}
		}
	}
}
