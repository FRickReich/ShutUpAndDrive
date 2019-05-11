using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

namespace Game.Modules
{
	public class DialogStartState : IState
	{
        private StateMachine StateMachine;

		public DialogStartState(StateMachine StateMachine)
		{
			this.StateMachine = StateMachine;
		}

		public void Execute(float delta)
		{
			Debug.Log("Running Dialog Start State");
		}

		public void Exit()
		{
			
		}

		public void OnEnter()
		{
			
		}
	}
}
