using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace snd
{
    public class PlayerCharacterController : MonoBehaviour
    {
        public WeaponSwitcher weaponSwitcher;
        public HealthAndArmor healthAndArmor;
        public float moveSpeed = 5f;
        public float runSpeed = 12f;
        public float rotationSpeed = 30f;
        
        private CharacterController characterController;
        private float angle;
        private Rigidbody rigidBody;

        public Animator animator;
		public float inputX;
		public float inputZ;
        public bool pistolEquip;
        public bool rifleEquip;
        public bool shoot;

        private void Awake()
        {
            characterController = GetComponent<CharacterController>();
            rigidBody = GetComponent<Rigidbody>();
            healthAndArmor = new HealthAndArmor(100, 100);
            animator = this.gameObject.GetComponent<Animator>();
        }

        private void Update()
        {
            Vector3 forward;
            float speed;

            if(weaponSwitcher.currentWeapon.smallWeapon)
            {
                pistolEquip = true;
                rifleEquip = false;
            }
            else if(weaponSwitcher.currentWeapon.bigWeapon)
            {
                pistolEquip = false;
                rifleEquip = true;
            }
            else if(weaponSwitcher.currentWeapon.noWeapon)
            {
                pistolEquip = false;
                rifleEquip = false;
            }

            if(weaponSwitcher.currentWeapon.shooting)
            {
                shoot = true;
            }
            else
            {
                shoot = false;
            }

            float horizontalInput = -InputManager.Instance.xboxLHorizontal;
            float verticalInput = InputManager.Instance.xboxLVertical;
            float horizontalLook = InputManager.Instance.xboxRHorizontal;
            float verticalLook = -InputManager.Instance.xboxRVertical;

            animator.SetFloat("InputX", -horizontalInput);
            animator.SetFloat("InputZ", verticalInput);
            animator.SetBool("Pistol", pistolEquip);
            animator.SetBool("Rifle", rifleEquip);
            animator.SetBool("Shoot", shoot);

            if(InputManager.Instance.xboxButtonLB)
            {
                speed = runSpeed;    
            }
            else
            {
                speed = moveSpeed;    
            }

            forward = verticalInput * transform.TransformDirection(Vector3.forward) * speed;
            Vector3 strafe = horizontalInput * transform.TransformDirection(Vector3.left) * speed;

            if (horizontalLook != 0f || verticalLook != 0f) {
                angle = Mathf.Atan2(horizontalLook, verticalLook) * Mathf.Rad2Deg;

                transform.rotation = Quaternion.Euler( 0f, angle, 0f);
            }

            characterController.Move(forward * Time.deltaTime);
            characterController.Move(strafe * Time.deltaTime);
            characterController.SimpleMove(Physics.gravity);
        }
    }
}


/*
        public float moveSpeed;
        public float runSpeed = 12f;
        public float angle;

        
        private Vector3 moveInput;
        private Vector3 lookInput;
        private Vector3 moveVelocity;
        

        private StateManager stateManager = new StateManager();
        
        // Start is called before the first frame update
        void Awake()
        {
            rigidBody = GetComponent<Rigidbody>();
            healthAndArmor = new HealthAndArmor(100, 100);

        }
        
        // Update is called once per frame
        void Update()
        {
            float horizontalInput = InputManager.Instance.xboxLHorizontal;
            float verticalInput = InputManager.Instance.xboxLVertical;

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
         */