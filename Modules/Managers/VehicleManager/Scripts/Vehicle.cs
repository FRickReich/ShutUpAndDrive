using System.Collections.Generic;
using System.Collections;
using UnityEngine;

using Game.Modules;

namespace Game.Modules.Objects
{
	[CreateAssetMenu(fileName = "Vehicle", menuName = "Game/Vehicle", order = 0)]
	public class Vehicle : ScriptableObject
	{
		[Header("Specifications")]
		public new string name;
		public Helpers.VehicleType vehicleType;
		public Helpers.DriveType driveType;

		[Header("Model")]
		public GameObject wheelModel;
		public GameObject vehicleModel;
		public GameObject vehicleCollider;

		[Header("Paint")]
		public List<Material> vehiclePaints;
		public List<Texture> vehicleDecals;
		
		[Header("Physics")]
		public int weight;
		public int torque;
		public int brakepower;
	}
}
