using UnityEngine;

namespace snd
{
	public class Player : MonoBehaviour
	{
		public string credits;
		public float speed = 10.0f;
		public float rotationSpeed = 100.0f;

		private float hInput;
		private float vInput;

		private Vector3 startPos;

		private void Start() 
		{
			startPos = this.transform.position;
		}

		private void FixedUpdate()
		{
			credits = "Credits: " + GameStateManager.Instance.credits + "$";

			float h = InputManager.Instance.xboxLHorizontal;
			float v = InputManager.Instance.xboxLVertical;
		}
	}	
}


			

			/*
			Vector3 movement = new Vector3(InputManager.Instance.xboxLHorizontal, 0f, -InputManager.Instance.xboxLVertical);

			transform.position = transform.position + movement * Time.deltaTime * 4f;
			*/

			/*
			Vector3 inputDirection = Vector3.zero;

			inputDirection.x = InputManager.Instance.xboxLHorizontal;
			inputDirection.z = -InputManager.Instance.xboxLVertical;

			transform.position = startPos + inputDirection;
			*/

			/*
			float translation = -InputManager.Instance.xboxLVertical * speed;
			float rotation = InputManager.Instance.xboxLHorizontal * rotationSpeed;

			translation *= Time.deltaTime;
			rotation *= Time.deltaTime;

			transform.Translate(0, 0, translation);
			transform.Rotate(0, rotation, 0);

			if(InputManager.Instance.xboxButtonA)
			{
				Debug.Log("Jump!");
				
				this.GetComponent<Rigidbody>().AddForce(0, 10, 0);
			}
			*/