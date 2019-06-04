using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Game.Enums;

namespace Game.Managers
{
	public class UIManager : Game.Base.SingletonPersistent<UIManager>
	{
		[Header("HUD Panel")]
		public GameObject hudPanel;
		public Image hudPlayerArmor;
		public Image hudPlayerHealth;

		[Header("Saving Indicator Panel")]
		public GameObject SavingIndicatorPanel;

		[Header("Notification Message Panel")]
		public GameObject notificationMessagePanel;
		public NotificationManager notificationMessage;

		[Header("Aim Indicator Panel")]
		public Image currentCrosshair;
		public Transform cameraTarget;
    	public Transform cameraPoint;
		public Transform cameraHandler;

    	public Sprite crosshairForbidden;
    	public Sprite crosshairReload;
    	public Sprite crosshairNoTarget;
    	public Sprite CrosshairTarget;
    	public Sprite crosshairIdle;

		private void OnEnable()
    	{
        	GameManager.Instance.sendNotificationEvent += CreateNotification;
	    }

    	private void OnDisable()
    	{
        	GameManager.Instance.sendNotificationEvent -= CreateNotification;
    	}

		// Start is called before the first frame update
		void Start()
		{

		}

		// Update is called once per frame
		void Update()
		{	
			
		}

		void LateUpdate()
    	{
        	currentCrosshair.transform.position = Game.Extensions.VectorExtensions.TransformToScreenPosition(cameraTarget.position);
    	}

		public void UpdateHUDPanel()
		{
			hudPlayerArmor.fillAmount = GameManager.Instance.playerCharacter.healthAndArmor.getArmorInPercent();
			hudPlayerHealth.fillAmount = GameManager.Instance.playerCharacter.healthAndArmor.getHealthInPercent();
		}

		public void ShowSavingIndicatorPanel()
		{
			SavingIndicatorPanel.SetActive(true);
		}

		public void HideSavingIndicatorPanel()
		{
			SavingIndicatorPanel.SetActive(false);
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

		public void SetCrosshair(CrosshairType type)
    	{
        	switch(type)
        	{
            	case CrosshairType.FORBIDDEN:
                	currentCrosshair.sprite = crosshairForbidden;
                	break;
            	case CrosshairType.NOTARGET:
                	currentCrosshair.sprite = crosshairNoTarget;
                	break;
            	case CrosshairType.RELOAD:
                	currentCrosshair.sprite = crosshairReload;
                	break;
            	case CrosshairType.TARGET:
                	currentCrosshair.sprite = CrosshairTarget;
                	break;
            	default:
            	case CrosshairType.IDLE:
                	currentCrosshair.sprite = crosshairIdle;
                	break;
        	}
    	}
	}
}
