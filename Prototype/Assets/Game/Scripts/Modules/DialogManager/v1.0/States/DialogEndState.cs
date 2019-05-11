using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

namespace Game.Modules
{
	public class DialogEndState : IState
	{
        private StateMachine StateMachine;

		public DialogEndState(StateMachine StateMachine)
		{
			this.StateMachine = StateMachine;
		}

		public void Execute(float delta)
		{
			Debug.Log("Running Dialog End State");
		}

		public void Exit()
		{
			
		}

		public void OnEnter()
		{
			
		}
	}
}
