using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

using Game.Modules.StateMachine.v1_0;

namespace Game.Test
{
	public class TestStringState : IState
	{
        private StateMachine StateMachine;
		private float timerMax;
		public InputMaster controls;

        public float timer;

		public TestStringState(StateMachine StateMachine, float timerMax)
		{
			this.StateMachine = StateMachine;
			this.timerMax = timerMax;
		}

		public void Execute(float delta)
		{
			timer += delta;

            if(timer > timerMax)
			{
				Debug.Log("Running String State @ " + timerMax);
				timer = 0;
				ChangeState();
			}
		}

        public void ChangeState()
        {
            this.StateMachine.ChangeState(new TestInputState(StateMachine));
        }

		public void Exit()
		{
			
		}

		public void OnEnter()
		{
			
		}
	}
}
