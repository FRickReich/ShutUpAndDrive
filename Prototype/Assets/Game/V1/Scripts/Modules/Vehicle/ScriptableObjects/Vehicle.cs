using System.Collections.Generic;
using System.Collections;
using UnityEngine;

using Game.Managers;

using Game.V1.Enum;

namespace Game.Objects
{
	[CreateAssetMenu(fileName = "Vehicle", menuName = "Game/Vehicle", order = 0)]
	public class Vehicle : ScriptableObject
	{
		[Header("Specifications")]
		public VehicleBrand vehicleBrand;
		public string vehicleName;
		public VehicleType vehicleType;
		public VehicleCategory vehicleCategory;

		public VehicleDriveType driveType;
		[SerializeField] AnimationCurve motorTorque;
		public int brakeTorque;
		
		public int weight;
		public float steerAngle;


		/*
		public Helpers.DriveType driveType;

		[Header("Model")]
		public GameObject wheelModel;
		public GameObject vehicleModel;

		[Header("Paint")]
		public List<Material> vehiclePaints;
		public List<Texture> vehicleDecals;

		[Header("Physics")]
		public int weight;
		public int torque;
		public int brakepower;
		 */
	}
}
