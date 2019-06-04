using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using Game.Managers;

namespace Game.States
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

		public void LateExecute()
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