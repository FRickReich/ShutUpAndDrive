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
		// INGAME HUD
		[Header("HUD Panel")]
		public GameObject hudPanel;
		public Image hudPlayerHealth;
		public Image hudPlayerArmor;
		public TMP_Text hudPlayerAmmo;
		
		// INGAME MENU
		[Header("Ingame Menu Panel")]
		public GameObject GameMenuPanel;

		// DEATH SCREEN
		// public TMP_Text deathText;

		[Header("Saving Indicator Panel")]
		public GameObject SavingIndicatorPanel;

		[Header("Notification Message Panel")]
		public GameObject notificationMessagePanel;

		public NotificationManager notificationMessage;

		private void OnEnable()
    	{
        	GameManager.Instance.sendNotificationEvent += CreateNotification;
	    }

    	private void OnDisable()
    	{
        	GameManager.Instance.sendNotificationEvent -= CreateNotification;
    	}

		// Update is called once per frame
		void Update()
		{
			//UpdateDebugPanel();
			UpdateHUDPanel();
		}

		private void UpdateHUDPanel()
		{
			hudPlayerHealth.fillAmount = PlayerManager.Instance.playerHealthInPercent / 2;
			hudPlayerArmor.fillAmount = PlayerManager.Instance.playerArmorInPercent / 2;
		}

		string formatTime(float timeInput)
		{
			float seconds = timeInput % 60;
			float minutes = timeInput / 60;

			return string.Format("{0:00}:{1:00}", minutes, seconds);
		}

		public void UpdateHUDAmmo(int currentAmmo, int completeAmmo, bool infinite = false)
		{
			hudPlayerAmmo.text = infinite ? $"{currentAmmo}/∞" : $"{currentAmmo}/{completeAmmo}";
		}

		public void ShowHudAmmo()
		{
			hudPlayerAmmo.gameObject.SetActive(true);
		}

		public void HideHudAmmo()
		{
			hudPlayerAmmo.gameObject.SetActive(false);
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

		public void CreateNotification(string header, string description)
		{
			NotificationManager nm = Instantiate(
				notificationMessage, 
				notificationMessagePanel.transform.position, 
				notificationMessagePanel.transform.rotation,
				notificationMessagePanel.transform
			);

        	nm.notificationHeaderInput = header;
        	nm.notificationDescriptionInput = description;
		}
	}
}