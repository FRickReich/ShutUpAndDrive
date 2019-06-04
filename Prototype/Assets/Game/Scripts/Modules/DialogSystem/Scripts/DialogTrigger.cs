using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Game.Objects;

namespace Game.Managers
{
	public class DialogTrigger : MonoBehaviour
	{
		public Objects.Dialog dialog;

		public void TriggerDialog()
		{
			FindObjectOfType<DialogManager>().StartDialog(dialog);
		}
	}
}