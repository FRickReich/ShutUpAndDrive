using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using Game.Modules;

namespace Game.Test
{
	public class CallDialogUI : MonoBehaviour
	{
		public TMP_Text speaker;
		public TMP_Text dialog;

		public GameObject nextButton;
		public GameObject exitButton;

		public DialogManager dialogManager;

		// Start is called before the first frame update
		void Start()
		{
			nextButton.SetActive(true);
			exitButton.SetActive(false);
		}

		// Update is called once per frame
		void Update()
		{
			speaker.text = dialogManager.GetCurrent().speaker;
			dialog.text = dialogManager.GetCurrent().sentence;
			if (dialogManager.dialogEnded == true)
			{
				exitButton.SetActive(true);
				nextButton.SetActive(false);
			}
		}
	}
}
