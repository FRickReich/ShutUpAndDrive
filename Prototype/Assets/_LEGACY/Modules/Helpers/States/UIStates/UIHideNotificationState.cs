using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace snd
{
	public class UIHideNotificationState : IState
	{
		private StateManager stateManager;
		private NotificationManager notificationManager;

		public UIHideNotificationState(StateManager stateManager, NotificationManager notificationManager)
		{
			this.stateManager = stateManager;
			this.notificationManager = notificationManager;
		}

		public void Execute(float delta)
		{
			
		}

		public void OnEnter()
		{
			notificationManager.HideNotification();
		}

		public void Exit()
		{
			
		}
	}
}