using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

namespace Game.Modules
{
    public class PlayerCharacterController : MonoBehaviour
    {  
        public InputMaster controls;

        public float moveSpeed = 5f;
        public float runSpeed = 12f;

        public Transform aimIndicator;

        public float rotationSpeed = 10f;
        public float aimDistance;

        public bool running;

        private Vector2 moveAxis;
        private Vector2 rotationAxis;
        private Vector3 movement;
        private Vector3 rotation;

        private CharacterController characterController;
        
        private void OnEnable()
        {
            InputMaster controls = new InputMaster();

            controls.Character.Move.performed += context => Move(context.ReadValue<Vector2>());
            controls.Character.Rotate.performed += context => Rotate(context.ReadValue<Vector2>());
            controls.Character.Run.performed += context => PlayerRun();

            controls.Enable();
        }

        private void OnDisable()
        {
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

            if(rotationAxis != Vector2.zero)
            {
                PlayerAim();
            }
        }

        private void LateUpdate()
        {
            Vector3 xvs = new Vector3(0, 0, (Mathf.Lerp(0, 1, rotation.magnitude) * aimDistance + Time.deltaTime));
            Transform child = aimIndicator.GetComponent<AttachUIToGamePosition>().target;
            Transform cameraPoint = aimIndicator.GetComponent<AttachUIToGamePosition>().cameraPoint;

            aimIndicator.transform.position = this.transform.position;
            
            float distance = Vector3.Distance(aimIndicator.position, child.position) / 10;

            Color visibility;

            visibility = new Color (1f, 1f, 1f, distance);
            child.localPosition = Vector3.ClampMagnitude(xvs, 8);
            cameraPoint.localPosition = Vector3.ClampMagnitude(xvs / 3, 4);
            
            aimIndicator.GetComponent<AttachUIToGamePosition>().crosshair.color = visibility;
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
		}

        private void PlayerAim()
        {
            rotation = (Vector3.forward * rotationAxis.y * 1 * Time.deltaTime) + (Vector3.right * rotationAxis.x * 1 * Time.deltaTime);

            aimIndicator.localRotation = Quaternion.LookRotation(rotation);
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

/*


            /*
            float directionHorz = Input.GetAxis("Horizontal");
float directionVert = Input.GetAxis("Vertical");
		
// Calculating direction
movementDirection = (forward * directionVert) + (right * directionHorz);
movementDirection.Normalize();
		
// Rotate towards direction
if ( movementDirection != Vector3.zero ) 
    myTransform.rotation = Quaternion.LookRotation( movementDirection );

// move bitch
moveController.Move(movementDirection * playerStats.RunSpeed * Time.deltaTime);
 */

            //Vector3 rotationDirection = Vector3.RotateTowards(transform.forward, new Vector3(moveAxis.x, 0, moveAxis.y), 2f * Time.deltaTime, 0);

            //if(characterController.isGrounded)
            //{
            //    movement += new Vector3(moveAxis.x, 0, moveAxis.y);
            //    movement *= speed;
            //    movement += Physics.gravity;
            //}

            //characterController.Move(movement * Time.deltaTime);

			//Vector3 movement = Vector3.zero;
            //movement += transform.forward * moveAxis.y * 1 * Time.deltaTime;
            //movement += transform.right * moveAxis.x * 1 * Time.deltaTime;

            //if(characterController.isGrounded)
            //{ */

            /*
            //float angle;

            //if (rotValue.x != 0f || rotValue.y != 0f)
            //{
            //    angle = Mathf.Atan2(rotValue.x, rotValue.y) * Mathf.Rad2Deg;
            //               transform.rotation = Quaternion.Euler(0f, angle, 0f);
            //         }#
             */