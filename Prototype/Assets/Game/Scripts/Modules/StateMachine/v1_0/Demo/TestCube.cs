using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

using Game.Modules.StateMachine.v1_0;

namespace Game.Test
{	
	public class TestCube : MonoBehaviour
	{
       	private StateMachine stateMachine = new StateMachine();

		public InputMaster controls;

		private void OnEnable()
    	{
        	controls.Enable();
    	}

    	private void OnDisable()
    	{
        	controls.Disable();
    	}
		
		private void Awake()
    	{
			controls.Character.Shoot.performed += context => Action();
		}

		// Start is called before the first frame update
		void Start()
		{
            this.stateMachine.ChangeState(new TestInputState(stateMachine));
		}

		// Update is called once per frame
		void Update()
		{
            this.stateMachine.ExecuteStateUpdate();
		}

		void Action()
    	{
			this.stateMachine.ChangeState(new TestStringState(stateMachine, 5));
    	}
	}
}
