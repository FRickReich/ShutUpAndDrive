using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

using Game.Managers;

namespace Game.States
{
	public class DialogStartState : IState
	{
        private StateManager StateMachine;

		public DialogStartState(StateManager StateMachine)
		{
			this.StateMachine = StateMachine;
		}

		public void Execute(float delta)
		{
			Debug.Log("Running Dialog Start State");
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
