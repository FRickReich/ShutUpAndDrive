using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Game.Objects;

namespace Game.Modules
{
	public class DialogTrigger : MonoBehaviour
	{
		public Dialog dialog;

		public void TriggerDialog()
		{
			FindObjectOfType<DialogManager>().StartDialog(dialog);
		}
	}
}