using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace snd
{
	public class UIPopulateNotificationState : IState
	{
		private StateManager stateManager;
		private NotificationManager notificationManager;

		public UIPopulateNotificationState(StateManager stateManager, NotificationManager notificationManager)
		{
			this.stateManager = stateManager;
			this.notificationManager = notificationManager;
		}

		public void Execute(float delta)
		{
			notificationManager.PopulateNotification();
		}

		public void OnEnter()
		{
			
		}

		public void Exit()
		{
			
		}
	}
}