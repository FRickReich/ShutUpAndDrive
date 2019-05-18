using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Game.Modules;
using Game.Base;

namespace Game.States
{
	public class GameLoadingState : IState
	{
        private StateMachine stateMachine;

		public GameLoadingState(StateMachine stateMachine)
		{
			this.stateMachine = stateMachine;
		}

		public void Execute(float delta)
		{
			Debug.Log("GAME LOADING STATE...");

			InitializeGame();
		}

		public void Exit()
		{
			
		}

		public void OnEnter()
		{
			
		}

		private void InitializeGame()
		{
			this.stateMachine.ChangeState(new GameInitializeState(stateMachine));
		}
	}
}
