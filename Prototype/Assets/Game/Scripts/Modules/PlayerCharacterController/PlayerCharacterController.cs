using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

namespace Game.Controllers
{
    public class PlayerCharacterController : MonoBehaviour
    {
        [SerializeField] bool isPlayer = true;
        public bool IsPlayer { get{ return isPlayer; } set{ isPlayer = value; } }

        public InputControls controls;

        public float moveSpeed = 5f;
        public float runSpeed = 12f;
        public float rotationSpeed = 10f;
        public bool running;

        private Vector2 moveAxis;
        private Vector2 rotationAxis;
        private Vector3 movement;
        private Vector3 rotation;

        private CharacterController characterController;

        private void OnEnable()
        {
            InputControls controls = new InputControls();

            controls.Character.Move.performed += context => Move(context.ReadValue<Vector2>());
            controls.Character.Rotate.performed += context => Rotate(context.ReadValue<Vector2>());
            controls.Character.Run.performed += context => PlayerRun();

            controls.Enable();
        }

		private void OnDisable()
        {

        }

        // Start is called before the first frame update
        void Start()
        {
            characterController = GetComponent<CharacterController>();
        }

        // Update is called once per frame
        void Update()
        {
            if(isPlayer && moveAxis != Vector2.zero || !characterController.isGrounded)
            {
                PlayerMovement();
            }

            if(isPlayer && rotationAxis != Vector2.zero)
            {
                PlayerAiming();
            }
        }

		private void PlayerMovement()
		{
			movement = Vector3.zero;
            float speed;

            if(running)
            {
                speed = runSpeed;
            }
            else
            {
                speed = moveSpeed;    
            }

            movement = (Vector3.forward * moveAxis.y * speed * Time.deltaTime) + (Vector3.right * moveAxis.x * speed * Time.deltaTime);

            if ( movement != Vector3.zero )
            {
                this.transform.rotation = Quaternion.LookRotation(movement);
            }

            characterController.Move(movement);
            characterController.SimpleMove(Physics.gravity);
		}

        private void PlayerAiming()
        {
            rotation = (Vector3.forward * rotationAxis.y * 1 * Time.deltaTime) + (Vector3.right * rotationAxis.x * 1 * Time.deltaTime);
            //this.transform.rotation = Quaternion.LookRotation(rotation);
        }

        private void PlayerRun()
        {
            running = !running;
        }

		void Move(Vector2 direction)
        {
            moveAxis = direction;
        }

        void Rotate(Vector2 rotValue)
        {
            rotationAxis = rotValue;
        }
	}
}