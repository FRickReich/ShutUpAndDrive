using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Game.Modules;

namespace Game.Modules.PlayerController
{
    public class PlayerCharacterController : MonoBehaviour
    {
        private Rigidbody rb;
        public Animator animator;

        public float y;
        public float z;

        public float speed = 5f;
        public float runSpeed = 7.5f;
        public float rotateSpeed = 5f;
    
        Vector3 movementZ;
        Vector3 rotationY;

        //public GunController theGun;
        public HealthManager playerHealth;

        public int randomDying = 0;
        public bool running;
        public bool armed;
        public bool shooting;
        public bool talking;
        public bool dying;

        public float cameraPointPos = 0f;
        public float cameraPointMultiplier = 5f;

        private Transform cameraPointController;

        private Vector3 velocity;
        private Vector3 prevPosition;

        public GameObject enterableCar;
   
        // Start is called before the first frame update
        void Awake()
        {
            rb = GetComponent<Rigidbody>();
            cameraPointController = gameObject.transform.Find("CameraPointController");

            //theGun = GetComponentInChildren<GunController>();
            playerHealth = GetComponent<HealthManager>();
            randomDying = Random.Range(0, 4);
        }

        private void Start()
        {
            animator.SetInteger("randomDying", randomDying);
        }

        // Upda te is called once per frame
        void Update()
        {
            /*if(Input.GetMouseButtonDown(0))
            {
                theGun.owner = this.tag;

                shooting = true;
                theGun.isFiring = true;
            }

            if(Input.GetMouseButtonUp(0))
            {
                shooting = false;
                theGun.isFiring = false;
            }
            */

            animator.SetFloat("speed", z);
            animator.SetBool("run", running);
            animator.SetBool("armed", armed);
            animator.SetBool("shooting", shooting);
            animator.SetBool("talking", talking);
            animator.SetBool("dying", dying);

            float fwdDotProduct = Vector3.Dot(transform.forward, velocity);
            float upDotProduct = Vector3.Dot(transform.up, velocity);
            float rightDotProduct = Vector3.Dot(transform.right, velocity);
   
            Vector3 velocityVector = new Vector3(rightDotProduct, upDotProduct, fwdDotProduct);
   
            cameraPointPos = Mathf.Clamp(velocityVector.magnitude, 0, 20);

            
        }

        void FixedUpdate()
        {
            y = Input.GetAxisRaw("Horizontal");
            z = Input.GetAxisRaw("Vertical");

            velocity = (transform.position - prevPosition)/Time.deltaTime;
            prevPosition = transform.position;

            MoveTank(z);
            RotateTank(y);
        }

        private void LateUpdate()
        {
            //changeCameraPointPosition(cameraPointPos);
        }

        void RotateTank(float y)
        {
            if (y != 0)
            {
                rotationY.Set(0f, y, 0f);
                rotationY = rotationY.normalized * rotateSpeed;
                Quaternion deltaRotation = Quaternion.Euler(rotationY);
                rb.MoveRotation(rb.rotation * deltaRotation);
            }
        }

        void MoveTank(float z)
        {
            if (z > 0)
            {
                movementZ = transform.forward;

                if(Input.GetKey(KeyCode.LeftShift))
                {
                    movementZ = movementZ.normalized * runSpeed * Time.deltaTime;
                }
                else
                {
                    movementZ = movementZ.normalized * speed * Time.deltaTime;
                }
                
                rb.MovePosition(rb.position + movementZ);
            }
            else if (z < 0)
            {
                movementZ = transform.forward * -1;
                movementZ = movementZ.normalized * (speed / 2) * Time.deltaTime;

                rb.MovePosition(rb.position + movementZ);
            }
        }

        public void changeCameraPointPosition(float addToPosition)
        {
            Transform cameraPoint = cameraPointController.Find("CameraPoint").transform;

            cameraPointController.transform.rotation = transform.localRotation;

            cameraPoint.localPosition = new Vector3(0, 0, addToPosition);
        }
    }
}