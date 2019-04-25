using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class SearchFor : IState
{
	private LayerMask searchLayer;
	private GameObject ownerGameObject;
	private float searchRadius;
	private string tagToLookFor;
	private System.Action<SearchResults> searchResultsCallback;

	public bool searchCompleted;

	public SearchFor(LayerMask searchLayer, GameObject ownerGameObject, float searchRadius, string tagToLookFor, System.Action<SearchResults> searchResultsCallback)
	{
		this.searchLayer = searchLayer;
		this.ownerGameObject = ownerGameObject;
		this.searchRadius = searchRadius;
		this.tagToLookFor = tagToLookFor;
		this.searchResultsCallback = searchResultsCallback;
	}

	public void Enter()
	{

	}

	public void Execute()
	{
		if(!searchCompleted)
		{
			var HitObjects = Physics.OverlapSphere(
				this.ownerGameObject.transform.position, 
				this.searchRadius
			);

			var allObjectsWithTag = new List<Collider>();

			for (int i = 0; i < HitObjects.Length; i++)
			{
				if(HitObjects[i].CompareTag(this.tagToLookFor))
				{
					allObjectsWithTag.Add(HitObjects[i]);
				}
			}
			
			var SearchResults = new SearchResults(HitObjects, allObjectsWithTag);

			this.searchResultsCallback(SearchResults);

			this.searchCompleted = true;
		}
	}

	public void Exit()
	{
		
	}
}

public class SearchResults
{
	public Collider[] ObjectsInRadius;
	public List<Collider> AllObjectsWithTag;

	public SearchResults(Collider[] objectsInRadius, List<Collider> allObjectsWithTag)
	{
		this.ObjectsInRadius = objectsInRadius;
		this.AllObjectsWithTag = allObjectsWithTag;

		// Methods to further process data.
	}
}