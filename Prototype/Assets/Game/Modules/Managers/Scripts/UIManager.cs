using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

namespace snd
{
	public class UIManager : SingletonPersistent<UIManager>
	{
		[Header("Debug Panel")]
		public GameObject DebugPanel;

		public TMP_Text DebugPlayerHealth;
		public TMP_Text DebugPlayerArmor;
		public TMP_Text DebugPlayerCredits;
		public TMP_Text DebugPlayerVehicle;
		public TMP_Text DebugPlayerCostume;

		public TMP_Text DebugGameSpeed;
		public TMP_Text DebugGamePaused;
		public TMP_Text DebugGameTime;
		public TMP_Text DebugGameCheckpoint;

		// INGAME HUD
		[Header("HUD Panel")]
		public GameObject HUDPanel;
		public Image HUDPlayerHealth;
		public Image HUDPlayerArmor;

		// INGAME MENU

		// INGAME MENU
		[Header("Ingame Menu Panel")]
		public GameObject GameMenuPanel;

		// DEATH SCREEN
		// public TMP_Text deathText;

		[Header("Saving Indicator Panel")]
		public GameObject SavingIndicatorPanel;

		// Update is called once per frame
		void Update()
		{
			UpdateDebugPanel();
			UpdateHUDPanel();
		}

		void UpdateDebugPanel()
		{
			DebugPlayerHealth.text  = "PlayerHealth: " + PlayerManager.Instance.playerHealth;
			DebugPlayerArmor.text   = "PlayerArmor: " + PlayerManager.Instance.playerArmor;
			DebugPlayerCredits.text = "PlayerCredits: " + PlayerManager.Instance.playerCredits;

			DebugGameSpeed.text = "GameSpeed: " + GameManager.Instance.gameSpeed;
			DebugGamePaused.text = "GamePaused: " + GameManager.Instance.gamePaused;
			DebugGameTime.text = "GameTime: " + this.formatTime(GameManager.Instance.gameTime);
			DebugGameCheckpoint.text = "GameCheckpoint: " + GameManager.Instance.currentCheckpoint;
		}

		private void UpdateHUDPanel()
		{
			HUDPlayerHealth.fillAmount = PlayerManager.Instance.playerHealthInPercent / 2;
			HUDPlayerArmor.fillAmount = PlayerManager.Instance.playerArmorInPercent / 2;
		}

		string formatTime(float timeInput)
		{
			float seconds = timeInput % 60;
			float minutes = timeInput / 60;

			return string.Format("{0:00}:{1:00}", minutes, seconds);
		}

		public void ShowSavingIndicatorPanel()
		{
			SavingIndicatorPanel.SetActive(true);
		}

		public void HideSavingIndicatorPanel()
		{
			SavingIndicatorPanel.SetActive(false);
		}

		public void ShowGameMenu()
		{
			if(!GameMenuPanel.activeInHierarchy)
			{
				GameMenuPanel.SetActive(true);
			}
			GameMenuPanel.GetComponent<Animator>().Play("FadeIn");
		}

		public void HideGameMenu()
		{
			GameMenuPanel.GetComponent<Animator>().Play("FadeOut");
		}
	}
}