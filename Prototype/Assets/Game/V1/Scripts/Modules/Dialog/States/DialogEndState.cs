using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

using Game.V1.FSM;

namespace Game.V1.State
{
	public class DialogEndState : IState
	{
        private FiniteStateMachine StateMachine;

		public DialogEndState(FiniteStateMachine StateMachine)
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
