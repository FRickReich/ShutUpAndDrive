using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

namespace Game.Modules.PlayerCharacterController.v1_0
{
    public class PlayerCharacterController : MonoBehaviour
    {
        [SerializeField] private InputMaster controls;

        public float moveSpeed = 5f;
        public float runSpeed = 12f;

        public float rotationSpeed = 10f;

        private Vector2 moveAxis;
        private CharacterController characterController;
        
        private void OnEnable()
        {
            controls.Character.Move.performed += context => Move(context.ReadValue<Vector2>());
            controls.Character.Rotate.performed += context => Rotate(context.ReadValue<Vector2>());
            controls.Enable();
        }

        private void OnDisable()
        {
            controls.Character.Move.performed -= context => Move(context.ReadValue<Vector2>());
            controls.Character.Rotate.performed -= context => Rotate(context.ReadValue<Vector2>());
            controls.Disable();
        }

        // Start is called before the first frame update
        void Start()
        {
            characterController = GetComponent<CharacterController>();
        }

        // Update is called once per frame
        void Update()
        {
            if(moveAxis != Vector2.zero || !characterController.isGrounded)
            {
                PlayerMovement();
            }
        }

		private void PlayerMovement()
		{
            float speed = moveSpeed;

			Vector3 movement = Vector3.zero;
            movement += transform.forward * moveAxis.y * speed * Time.deltaTime;
            movement += transform.right * moveAxis.x * speed * Time.deltaTime;
            movement += Physics.gravity;

            characterController.Move(movement);
		}

		void Move(Vector2 direction)
        {
            moveAxis = direction;
        }

        void Rotate(Vector2 rotValue)
        {
            float angle;

            if (rotValue.x != 0f || rotValue.y != 0f)
            {
                angle = Mathf.Atan2(rotValue.x, rotValue.y) * Mathf.Rad2Deg;

                transform.rotation = Quaternion.Euler(0f, angle, 0f);
            }
        }
    }
}