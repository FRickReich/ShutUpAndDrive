using UnityEngine;

using Game.Modules;
namespace Game.Modules.PlayerController
{

	public class PlayerCarController : MonoBehaviour 
	{
		[Tooltip("Maximum steering angle of the wheels")]
		public float maxAngle = 30f;

		[Tooltip("Maximum torque applied to the driving wheels")]
		public float maxTorque = 300f;
		
		[Tooltip("Maximum brake torque applied to the driving wheels")]
		public float brakeTorque = 30000f;
		
		[Tooltip("If you need the visual wheels to be attached automatically, drag the wheel shape here.")]
		public GameObject wheelShape;

		[Tooltip("The vehicle's speed when the physics engine can use different amount of sub-steps (in m/s).")]
		public float criticalSpeed = 5f;
		
		[Tooltip("Simulation sub-steps when the speed is above critical.")]
		public int stepsBelow = 5;
	
		[Tooltip("Simulation sub-steps when the speed is below critical.")]
		public int stepsAbove = 1;

		[Tooltip("The vehicle's drive type: rear-wheels drive, front-wheels drive or all-wheels drive.")]
		public Helpers.DriveType driveType;

    	public string kmhspeed;
    	public GameObject brakeLights;

        public Transform carEnterPoint;

    	private WheelCollider[] m_Wheels;

		public float cameraPointPos = 0f;
        public float cameraPointMultiplier = 5f;

		private Vector3 velocity;
        private Vector3 prevPosition;
		
		private Transform cameraPointController;
		private CarLightManager carLightManager;

		private void Awake() {
			
            carEnterPoint = gameObject.transform.Find("DriverEnterPoint");
			cameraPointController = gameObject.transform.Find("CameraPointController");
			carLightManager = GetComponent<CarLightManager>();
		}

    	// Find all the WheelColliders down in the hierarchy.
		void Start()
		{
			m_Wheels = GetComponentsInChildren<WheelCollider>();

			for(int i = 0; i < m_Wheels.Length; ++i) 
			{
				// Create wheel shapes only when needed.
				if (wheelShape != null)
				{
					GameObject wheel = Instantiate(wheelShape, Vector3.zero, Quaternion.identity, m_Wheels[i].transform);
					
					if(m_Wheels[i].name.Contains("Right"))
					{
						wheel.transform.localScale = new Vector3(-1, 1, 1);
					}
				}
			}
		}

		// This is a really simple approach to updating wheels.
		// We simulate a rear wheel drive car and assume that the car is perfectly symmetric at local zero.
		// This helps us to figure our which wheels are front ones and which are rear.
		void Update()
		{
			float fwdDotProduct = Vector3.Dot(transform.forward, velocity);
            float upDotProduct = Vector3.Dot(transform.up, velocity);
            float rightDotProduct = Vector3.Dot(transform.right, velocity);
   
            Vector3 velocityVector = new Vector3(rightDotProduct, upDotProduct, fwdDotProduct);
   
            cameraPointPos = Mathf.Clamp(velocityVector.magnitude, 0, 40);

			m_Wheels[0].ConfigureVehicleSubsteps(criticalSpeed, stepsBelow, stepsAbove);

			float angle = maxAngle * Input.GetAxis("Horizontal");
			float torque = maxTorque * Input.GetAxis("Vertical");

			float handBrake = Input.GetKey(KeyCode.X) ? brakeTorque : 0;

			carLightManager.Brake(Input.GetKey(KeyCode.X) ? true : false);

        	kmhspeed = string.Format("Speed: {0:0.00} m/s", this.GetComponent<Rigidbody>().velocity.magnitude);

        	foreach (WheelCollider wheel in m_Wheels)
			{
				// A simple car where front wheels steer while rear ones drive.
				if (wheel.transform.localPosition.z > 0)
					wheel.steerAngle = angle;

				if (wheel.transform.localPosition.z < 0)
				{
					wheel.brakeTorque = handBrake;
				}

				if (wheel.transform.localPosition.z < 0 && driveType != Helpers.DriveType.FRONTWHEEL)
				{
					wheel.motorTorque = torque;
				}

				if (wheel.transform.localPosition.z >= 0 && driveType != Helpers.DriveType.REARWHEEL)
				{
					wheel.motorTorque = torque;
				}

				// Update visual wheels if any.
				if (wheelShape) 
				{
					Quaternion q;
					Vector3 p;
					wheel.GetWorldPose (out p, out q);

					// Assume that the only child of the wheelcollider is the wheel shape.
					Transform shapeTransform = wheel.transform.GetChild (0);
					shapeTransform.position = p;
					shapeTransform.rotation = q;
				}
			}
		}

		private void FixedUpdate() 
		{
			velocity = (transform.position - prevPosition)/Time.deltaTime;
            prevPosition = transform.position;	
		}
	}
}