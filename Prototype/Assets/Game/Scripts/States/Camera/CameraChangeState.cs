using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;

using Game.Managers;

namespace Game.States
{
	public class CameraChangeState : IState
	{
		private readonly StateManager stateManager;
		private Transform target;
		private CinemachineVirtualCamera virtualCamera;

		//private CinemachineVirtualCamera virtualCamera;

		public CameraChangeState(StateManager stateManager, Transform target, CinemachineVirtualCamera virtualCamera)
		{
			this.stateManager = stateManager;
			this.target = target;
			this.virtualCamera = virtualCamera;
		}

		public void Execute(float delta)
		{
			this.AttachCameraToTarget();
		}

		public void LateExecute()
		{
			
		}

		public void Exit()
		{
			
		}

		public void OnEnter()
		{
			
		}

		public void AttachCameraToTarget()
        {
            virtualCamera.Follow = target;
            virtualCamera.LookAt = target;

			this.stateManager.ChangeState(new CameraIdleState(stateManager));
        }
	}
}