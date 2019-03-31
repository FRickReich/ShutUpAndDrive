using System.Collections.Generic;
using System.Collections;
using UnityEngine;

namespace Game.Modules
{
	public class VehicleManager : MonoBehaviour
	{
		public Objects.Vehicle vehicle;

		public bool isSpecialVehicle;
		public string vehicleName;
		public Material vehiclePaint;
		public Texture vehicleDecal;

		private Rigidbody rigidbody;

		public List<Renderer> paintableParts = new List<Renderer>();

		public Transform colliderMesh;

		private void Awake()
		{
			rigidbody = GetComponent<Rigidbody>();
		}

		private void Start()
		{
			Transform[] allChildren = vehicle.vehicleModel.GetComponentsInChildren<Transform>();
            foreach (Transform child in allChildren)
            {
				if(child.name.Contains("_paintable"))
				{
					paintableParts.Add(child.gameObject.GetComponent<Renderer>());
				}
            }

			CreateVehicle();

			SpawnWheels();
		}

		public void SpawnWheels()
		{
			WheelCollider[] wheelPositions = GetComponent<VehicleBehaviour.WheelVehicle>().wheels;

			foreach (WheelCollider wheelPosition in wheelPositions)
			{
				GameObject wheel = Instantiate(vehicle.wheelModel, wheelPosition.transform.position, wheelPosition.transform.rotation, wheelPosition.transform);
				wheelPosition.GetComponent<VehicleBehaviour.Suspension>()._wheelModel = wheel;
				wheelPosition.GetComponent<VehicleBehaviour.Trails.TrailEmitter>().parent = wheel.transform;
			}
		}

		public void CreateVehicle()
		{
			vehicleName = vehicle.name;

			rigidbody.mass = vehicle.weight;

			GameObject carModel = Instantiate(vehicle.vehicleModel, transform.position, transform.rotation, gameObject.transform);
			carModel.name = "Car";

			colliderMesh = gameObject.transform.Find("Car/Collider");

			gameObject.GetComponent<MeshCollider>().sharedMesh = null;
			gameObject.GetComponent<MeshCollider>().sharedMesh = colliderMesh.GetComponent<MeshFilter>().mesh;

			if(!isSpecialVehicle)
			{
				vehiclePaint = vehicle.vehiclePaints[Random.RandomRange(0, vehicle.vehiclePaints.Count)];

				if(vehicle.vehicleDecals.Count != null)
				{
					vehicleDecal = (Random.value < 0.5f) ? vehicle.vehicleDecals[Random.RandomRange(0, vehicle.vehicleDecals.Count)] : null;
				}
			}

			foreach (Renderer carPart in paintableParts)
			{
				Debug.Log(carPart.sharedMaterial.name);
				carPart.sharedMaterial = vehiclePaint;

				if(vehicle.vehicleDecals.Count != null)
				{
					carPart.sharedMaterial.SetTexture("_BaseColorMap", vehicleDecal);	
				}
			}
		}
	}
}