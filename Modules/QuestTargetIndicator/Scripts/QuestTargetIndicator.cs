using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestTargetIndicator : MonoBehaviour 
{
	public Transform target;
	public float hideDistance = 5f;

	private void Update()
	{

		Vector3 dir = target.position - transform.position;

		if(dir.magnitude < hideDistance)
		{
			SetChildrenActive(false);
		}
		else
		{
			SetChildrenActive(true);
		}

		Vector3 targetPosition = new Vector3(target.position.x, transform.position.y, target.position.z);

		transform.LookAt(targetPosition, Vector3.up);
	}

	void SetChildrenActive(bool value)
	{
		foreach (Transform child in transform)
			{
				child.gameObject.SetActive(value);
			}
	}
}