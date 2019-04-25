using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class MoveToTarget : IState
{
	private string testString;
	private readonly Collider currentTarget;
	private NavMeshAgent naveMeshAgent;
	private bool stateCompleted;

	public MoveToTarget(string testString, Collider currentTarget, NavMeshAgent naveMeshAgent)
	{
		this.testString = testString;
		this.currentTarget = currentTarget;
		this.naveMeshAgent = naveMeshAgent;
	}

	public void Enter()
	{
		Debug.Log("Enter");
	}

	public void Execute()
	{
		this.naveMeshAgent.SetDestination(currentTarget.transform.position);
	}

	public void Exit()
	{
		Debug.Log("Exit");
	}
}