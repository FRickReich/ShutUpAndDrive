using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace snd
{
    public class PlayerCharacterController : MonoBehaviour
    {
        private StateMachine stateMachine = new StateMachine();

        public float moveSpeed;
        public float runSpeed = 12f;
        public float angle;

        private Rigidbody rigidBody;
        private Vector3 moveInput;
        private Vector3 lookInput;
        private Vector3 moveVelocity;
        
        // Start is called before the first frame update
        void Awake()
        {
            rigidBody = GetComponent<Rigidbody>();
        }

        private void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            float horizontalInput = InputManager.Instance.xboxLHorizontal;
            float verticalInput = -InputManager.Instance.xboxLVertical;

            float horizontalLook = InputManager.Instance.xboxRHorizontal;
            float verticalLook = -InputManager.Instance.xboxRVertical;

            moveInput = new Vector3(horizontalInput, 0f, verticalInput);

            if(InputManager.Instance.xboxButtonLB)
            {
                moveVelocity = moveInput * runSpeed;    
            }
            else
            {
                moveVelocity = moveInput * moveSpeed;    
            }

            if (horizontalLook != 0f || verticalLook != 0f) {
                angle = Mathf.Atan2(horizontalLook, verticalLook) * Mathf.Rad2Deg;

                transform.rotation = Quaternion.Euler( 0f, angle, 0f);
            }
        }

        private void FixedUpdate()
        {
            rigidBody.velocity = moveVelocity;
        }
    }
}