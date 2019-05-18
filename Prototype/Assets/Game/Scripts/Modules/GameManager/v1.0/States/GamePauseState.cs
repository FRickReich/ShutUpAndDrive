using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Game.Base;
using Game.Modules;

namespace Game.States
{
	public class GamePauseState : IState
	{
        private StateMachine stateMachine;

		public GamePauseState(StateMachine stateMachine)
		{
			this.stateMachine = stateMachine;
		}

		public void Execute(float delta)
		{
			Debug.Log("Running PAUSE STATE...");

			if(GameManager.Instance.gamePaused == false)
			{
				GameManager.Instance.RunGame();
			}
		}

		public void OnEnter()
		{
			GameManager.Instance.slowDown = true;
			GameManager.Instance.timer.Stop();
		}

		public void Exit()
		{
			GameManager.Instance.slowDown = false;
			GameManager.Instance.timer.Resume();
		}
	}
}
