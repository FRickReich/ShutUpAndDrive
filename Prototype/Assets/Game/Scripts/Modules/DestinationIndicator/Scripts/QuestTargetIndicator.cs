using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

using Game.Enums;

namespace Game
{
	public class QuestTargetIndicator : MonoBehaviour
	{
		public DestinationManager target;
		public float hideDistance = 15f;
		public Transform distancePivot;
		public TMP_Text distanceText;
		public float distanceToPlayer;
		public MeasureUnits measureUnit;
		public Transform centerPoint;
		public RectTransform UIImagePrefab;
		private RectTransform UIImage;

		private void Start()
		{
			UIImage = Instantiate(UIImagePrefab, this.transform.position, this.transform.rotation, GameObject.Find("GameUI/").transform);

			distanceText = UIImage.Find("Distance").GetComponent<TMP_Text>();
		}

		private void Update()
		{
			Vector3 dir = target.transform.position - transform.position;

			distanceToPlayer = Vector3.Distance(gameObject.transform.position, target.transform.position);

			if (dir.magnitude < hideDistance || target.active == false)
			{
				SetChildrenActive(false);
			}
			else
			{
				SetChildrenActive(true);
			}

			Vector3 targetPosition = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);

			transform.LookAt(targetPosition, Vector3.up);
			distancePivot.LookAt(centerPoint.transform, Vector3.forward);
		}

		void LateUpdate()
    	{
        	UIImage.position = Game.Extensions.VectorExtensions.TransformToScreenPosition(new Vector3(
            	distancePivot.transform.position.x,
            	distancePivot.transform.position.y,
            	distancePivot.transform.position.z
        	));

			UIImage.Find("ArrowPointer").LookAt(
				Game.Extensions.VectorExtensions.TransformToScreenPosition(
					centerPoint.transform.position
				), 
				Vector3.up
			);
    	}

		private void FixedUpdate()
		{
			distanceText.text = SetDistanceText(distanceToPlayer);
		}

		string SetDistanceText(float distance)
		{
			string distanceText = "m";

			if (measureUnit == MeasureUnits.METRIC)
			{
				if (distance < 100)
				{
					distanceText = string.Format("{0:0}", distance) + "m";
				}
				else
				{
					distanceText = string.Format("{0:N}", (distance / 1000)) + "km";
				}
			}
			else if (measureUnit == MeasureUnits.IMPERIAL)
			{
				float metersInFeet = distance * 100 / 2.54f / 12;
				float metersInMiles = (distance * 0.3048f) * 1000 / 5280;

				if (metersInFeet < 2000)
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
			//UIImage.gameObject.SetActive(value);

			UIImage.GetComponent<QuestTargetController>().HandleNotification(value);
		}
	}
}