using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace snd
{
	public class UIShowNotificationState : IState
	{
		private StateManager stateManager;
		private NotificationManager notificationManager;
		
		private float lifeTime;
		private float timer;

		public UIShowNotificationState(StateManager stateManager, float lifeTime, NotificationManager notificationManager)
		{
			this.stateManager = stateManager;
			this.lifeTime = lifeTime;
			this.notificationManager = notificationManager;
		}

		public void Execute(float delta)
		{
			timer += delta;

			if(timer > lifeTime)
			{
				this.stateManager.ChangeState(new UIHideNotificationState(stateManager, notificationManager));
			}
		}

		public void OnEnter()
		{
			notificationManager.ShowNotification();
		}

		public void Exit()
		{
			
		}
	}
}