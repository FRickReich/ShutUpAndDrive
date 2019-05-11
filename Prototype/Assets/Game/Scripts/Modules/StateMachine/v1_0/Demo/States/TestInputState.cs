using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

using Game.Modules.StateMachine.v1_0;

namespace Game.Test
{
	public class TestInputState : IState
	{
        private StateMachine StateMachine;

		public TestInputState(StateMachine StateMachine)
		{
			this.StateMachine = StateMachine;
		}

		public void Execute(float delta)
		{
			Debug.Log("Running Input State");
		}

		public void Exit()
		{
			
		}

		public void OnEnter()
		{
			
		}
	}
}
