using System.Collections.Generic;
using System.Collections;
using UnityEngine;

using Game.Modules;

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
		private BoxCollider boxCollider;

		private void Awake()
		{
			rigidbody = GetComponent<Rigidbody>();
			boxCollider = GetComponent<BoxCollider>();
		}

		private void Start()
		{
			CreateVehicle();
		}

		public void CreateVehicle()
		{
			vehicleName = vehicle.name;

			Mesh vehicleMesh = vehicle.vehicleCollider.sharedMesh;

			rigidbody.mass = vehicle.weight;
			boxCollider.size = new Vector3(vehicleMesh.bounds.size.x, vehicleMesh.bounds.size.y, vehicleMesh.bounds.size.z);
			boxCollider.center = vehicleMesh.bounds.center;

			GameObject carModel = Instantiate(vehicle.vehicleModel, transform.position, transform.rotation, gameObject.transform);

			if(!isSpecialVehicle)
			{
				vehiclePaint = vehicle.vehiclePaints[Random.RandomRange(0, vehicle.vehiclePaints.Count)];

				vehicleDecal = (Random.value < 0.5f) ? vehicle.vehicleDecals[Random.RandomRange(0, vehicle.vehicleDecals.Count)] : null;
			}

			carModel.GetComponent<Renderer>().material = vehiclePaint;
			carModel.GetComponent<Renderer>().material.SetTexture("_BaseColorMap", vehicleDecal);
		}
	}
}