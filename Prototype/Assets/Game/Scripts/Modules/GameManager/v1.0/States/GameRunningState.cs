using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Game.Modules;

namespace Game.States
{
	public class GameRunningState : IState
	{
        private StateMachine stateMachine;

		public GameRunningState(StateMachine stateMachine)
		{
			this.stateMachine = stateMachine;
		}

		public void Execute(float delta)
		{
			Debug.Log("Running GAME RUNNING STATE...");

			if(GameManager.Instance.gamePaused == true)
			{
				GameManager.Instance.PauseGame();
			}
		}

		public void Exit()
		{
			
		}

		public void OnEnter()
		{
			
		}

		public void isPaused(bool tx)
		{
			Debug.Log("test");
		}
	}
}
