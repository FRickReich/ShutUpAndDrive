using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class FurtherTestStateMachine : IState
{
	private bool stateCompleted;

	public void Enter()
	{
		Debug.Log("Enter");
	}

	public void Execute()
	{
		if(!stateCompleted)
		{
			Debug.Log("Run #2");

			stateCompleted = true;
		}
	}

	public void Exit()
	{
		Debug.Log("Exit");
	}
}