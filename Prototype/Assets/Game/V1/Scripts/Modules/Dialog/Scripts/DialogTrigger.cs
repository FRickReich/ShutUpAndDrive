using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Game.V1.Object;

namespace Game.V1.Dialog
{
	public class DialogTrigger : MonoBehaviour
	{
		public Game.V1.Object.Dialog dialog;

		public void TriggerDialog()
		{
			FindObjectOfType<DialogManager>().StartDialog(dialog);
		}
	}
}