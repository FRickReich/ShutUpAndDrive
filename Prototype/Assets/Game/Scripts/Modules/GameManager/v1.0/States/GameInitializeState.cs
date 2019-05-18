using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Game.Modules;
using Game.Base;

namespace Game.States
{
	public class GameInitializeState : IState
	{
        private StateMachine stateMachine;

		public GameInitializeState(StateMachine stateMachine)
		{
			this.stateMachine = stateMachine;
		}

		public void Execute(float delta)
		{
			Debug.Log("GAME INITIALIZING STATE...");

			Initialize();
		}

		public void Exit()
		{
			
		}

		public void OnEnter()
		{
			
		}
		
		private void Initialize()
		{
			GameManager.Instance.SpawnPlayer();



			this.stateMachine.ChangeState(new GameInitializeState(stateMachine));
		}
	}
}
