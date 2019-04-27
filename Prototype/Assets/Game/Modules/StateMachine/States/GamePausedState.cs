using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace snd
{
	public class GamePausedState : MonoBehaviour, IState
	{
		private StateManager stateManager;
		private bool isRunning;

		public GamePausedState(StateManager stateManager)
		{
			this.stateManager = stateManager;
		}

		public void Execute(float delta)
		{
			if(GameManager.Instance.gamePaused == false)
			{
				GameManager.Instance.RunGame();
			}
		}

		public void OnEnter()
		{
			TimeManager.Instance.slowDown = true;

			UIManager.Instance.ShowGameMenu();
			GameManager.Instance.timer.Stop();
		}

		public void Exit()
		{
			TimeManager.Instance.slowDown = false;

			UIManager.Instance.HideGameMenu();
			GameManager.Instance.timer.Resume();
		}
	}
}