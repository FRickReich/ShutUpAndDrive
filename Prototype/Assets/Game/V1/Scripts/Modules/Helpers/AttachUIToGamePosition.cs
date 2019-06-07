using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game.V1.Helper
{
	[ExecuteInEditMode]
	public class AttachUIToGamePosition : MonoBehaviour
	{
		public Image crosshair;
		public Transform cameraPoint;
		public Transform target;

		// Update is called once per frame
		void LateUpdate()
		{
			crosshair.transform.position = Game.V1.Extension.VectorExtensions.TransformToScreenPosition(target.position);
		}
	}
}
