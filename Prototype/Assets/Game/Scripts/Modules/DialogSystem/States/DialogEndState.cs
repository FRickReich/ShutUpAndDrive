using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

using Game.Managers;

namespace Game.States
{
	public class DialogEndState : IState
	{
        private StateManager StateMachine;

		public DialogEndState(StateManager StateMachine)
		{
			this.StateMachine = StateMachine;
		}

		public void Execute(float delta)
		{
			Debug.Log("Running Dialog End State");
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
	}
}
