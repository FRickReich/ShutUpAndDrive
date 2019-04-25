using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

// namespace
[RequireComponent(typeof(NavMeshAgent))]
public class Cube : MonoBehaviour 
{
					 private StateMachine stateMachine = new StateMachine();
	[SerializeField] private LayerMask foodItemsLayer;
	[SerializeField] private float viewRange;
	[SerializeField] private string foodItemsTag;
					 private NavMeshAgent navMeshAgent;
	[SerializeField] private List<Collider> targets;
	[SerializeField] private Collider currentTargetObject;
					 private int currentWaypoint = 0;

					 private bool firstStateFinished;

					 public float distanceToTarget;

	private void Start()
	{
		this.navMeshAgent = this.GetComponent<NavMeshAgent>();

		this.stateMachine.ChangeState(new SearchFor(
			this.foodItemsLayer, 
			this.gameObject, 
			this.viewRange, 
			this.foodItemsTag,
			this.FoodFound
		));
	}

	private void Update()
	{
		this.stateMachine.ExecuteStateUpdate();

		distanceToTarget = Vector3.Distance(currentTargetObject.transform.position, this.gameObject.transform.position);

		if(targets.Count != 0)
		{
			this.stateMachine.ChangeState(new MoveToTarget(
				"HelloGoodBye",
				this.targets[currentWaypoint],
				this.navMeshAgent
			));
		}
	}

	public void FoodFound(SearchResults searchResults)
	{
		targets = searchResults.AllObjectsWithTag;

		this.currentTargetObject = targets[0];
	}
}
