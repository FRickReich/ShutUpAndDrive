using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using Game.Modules;
using Game.Modules.Helpers;

namespace Game.Modules
{
	public class QuestTargetIndicator : MonoBehaviour 
	{
		public Transform target;
		public float hideDistance = 15f;
		public Transform distancePivot;
		public TextMeshProUGUI distanceText;
		public float distanceToPlayer;
		public MeasureUnits measureUnit;

		private void Update()
		{
			Vector3 dir = target.position - transform.position;

			distanceToPlayer = Vector3.Distance(gameObject.transform.position, target.position);

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
			distancePivot.LookAt(Camera.main.transform, Vector3.forward);
		}

		private void FixedUpdate() 
		{
			distanceText.text = SetDistanceText(distanceToPlayer);
		}

		string SetDistanceText(float distance)
		{
			string distanceText = "m";

			if(measureUnit == MeasureUnits.METRIC)
			{
				if(distance < 100)
				{
					distanceText = string.Format("{0:0}", distance) + "m";
				}
				else
				{
					distanceText = string.Format("{0:N}", (distance / 1000)) + "km";
				}
			}
			else if(measureUnit == MeasureUnits.IMPERIAL)
			{
				float metersInFeet = distance * 100 / 2.54f / 12;
				float metersInMiles = (distance * 0.3048f) * 1000 / 5280;

				if(metersInFeet < 2000)
				{
					distanceText = string.Format("{0:0}", metersInFeet) + "ft";
				}
				else
				{
					distanceText = string.Format("{0:N}", metersInMiles) + "mi";
				}
			}

			return distanceText;
		}

		void SetChildrenActive(bool value)
		{
			foreach (Transform child in transform)
			{
				child.gameObject.SetActive(value);
			}
		}
	}
}