using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

namespace Game.Modules.VehicleAI
{
    public class Driving : MonoBehaviour
    {
        public Transform pathGroup;
        public Transform centerOfMass;

        public PathCreator pathCreator;
        public EndOfPathInstruction endOfPathInstruction;
        public float speed = 5;
        float distanceTravelled;

        public float maxSteer = 15.0f;
        public float maxTorque = 50;
        public float currentSpeed;
        public float topSpeed = 150;
        public float decelerationSpeed = 10;

        public WheelCollider wheelFL;
        public WheelCollider wheelFR;
        public WheelCollider wheelRL;
        public WheelCollider wheelRR;

        public int currentPathObj;
        public float distFromPath;

        private List<Transform> path; //we use a list so that it can have a dynamic size, meaning the size can change when we need it to
        private Rigidbody rb;

        public bool isBreaking;
        public bool inSector;

        public Color sensorColor = Color.magenta;
        public float sensorLength = 5;
        public float frontSensorStartPoint = 5;
        public float frontSensorSideDistance = 2;
        public float frontSensorsAngle = 30;
        public float sidewaySensorLength = 5;
        public float avoidSpeed = 10;

        public bool reversing = false;
        public float reverseCounter = 0.0f;
        public float waitToReverse = 2.0f;
        public float reverseFor = 1.5f;

        public float respawnWait = 5.0f;
        public float respawnCounter = 0.0f;

        private int flag = 0;

        void Start()
        {
            path = new List<Transform>();
            GetPath();

            rb = GetComponent<Rigidbody>();
            rb.centerOfMass = centerOfMass.position;
        }

        void Update()
        {
            if (flag == 0)
            {
                GetSteer();
            }

            GetMovement();
            BreakingEffect();
            Sensors();
            Respawn();
        }

        void GetPath()
        {
            Transform[] childObejects = pathGroup.GetComponentsInChildren<Transform>();

            for (int i = 0; i < childObejects.Length; i++)
            {
                Transform temp = childObejects[i];
                if (temp.gameObject.GetInstanceID() != GetInstanceID())
                    path.Add(temp);
            }
        }

        void GetSteer()
        {
            Vector3 steerVector = transform.InverseTransformPoint(new Vector3(path[currentPathObj].position.x, transform.position.y, path[currentPathObj].position.z));
            float newSteer = maxSteer * (steerVector.x / steerVector.magnitude);

            wheelFL.steerAngle = newSteer;
            wheelFR.steerAngle = newSteer;

            if (steerVector.magnitude <= distFromPath)
            {
                currentPathObj++;
            }

            if (currentPathObj >= path.Count)
            {
                currentPathObj = 0;
            }
        }

        private void GetMovement()
        {
            currentSpeed = 2 * (22 / 7) * wheelRL.radius * wheelRL.rpm * 60 / 1000;
            currentSpeed = Mathf.Round(currentSpeed);

            if (currentSpeed <= topSpeed && !inSector)
            {
                if(!reversing)
                {
                    wheelRL.motorTorque = maxTorque;
                    wheelRR.motorTorque = maxTorque;
                }
                else
                {
                    wheelRL.motorTorque = -maxTorque;
                    wheelRR.motorTorque = -maxTorque;
                }

                wheelRL.brakeTorque = 0;
                wheelRR.brakeTorque = 0;
            }
            else if(!inSector)
            {
                wheelRL.motorTorque = 0;
                wheelRR.motorTorque = 0;

                wheelRL.brakeTorque = decelerationSpeed;
                wheelRR.brakeTorque = decelerationSpeed;
            }
        }

        void BreakingEffect()
        {
            if(isBreaking)
            {
                // Activate Brakelights
            }
            else
            {
                // deactivate Brakelights
            }
        }

        void Sensors()
        {
            Vector3 pos;
            RaycastHit hit;

            flag = 0;
            float avoidSensitivity = 0;

            Vector3 rightAngle = Quaternion.AngleAxis(frontSensorsAngle, transform.up) * transform.forward;
            Vector3 leftAngle = Quaternion.AngleAxis(-frontSensorsAngle, transform.up) * transform.forward;

            pos = transform.position;
            pos += transform.forward * frontSensorStartPoint;

            // brakingsensor
            if (Physics.Raycast(pos, transform.forward, out hit, sensorLength))
            {
                if (hit.transform.tag != "Terrain" || hit.transform.tag != "Tile")
                {
                    flag++;
                    
                wheelRL.brakeTorque = decelerationSpeed;
                wheelRR.brakeTorque = decelerationSpeed;
                Debug.DrawLine(pos, hit.point, Color.red);
                }
            }
            else
            {
                wheelRL.brakeTorque = 0;
                wheelRR.brakeTorque = 0;
            }

            // front right sensor
            pos += transform.right * frontSensorSideDistance;

            if (Physics.Raycast(pos, transform.forward, out hit, sensorLength))
            {
                if (hit.transform.tag != "Terrain" || hit.transform.tag != "Tile")
                {
                    flag++;
                    avoidSensitivity -= 1f;
                    Debug.DrawLine(pos, hit.point, sensorColor);
                }
            }
            else if (Physics.Raycast(pos, rightAngle, out hit, sensorLength))
            {
                if (hit.transform.tag != "Terrain" || hit.transform.tag != "Tile")
                {
                    flag++;
                    avoidSensitivity -= 1f;
                    Debug.DrawLine(pos, hit.point, sensorColor);
                }
            }

            // front straight left sensor
            pos = transform.position;

            pos += transform.forward * frontSensorStartPoint;
            pos -= transform.right * frontSensorSideDistance;

            if (Physics.Raycast(pos, transform.forward, out hit, sensorLength))
            {
                if (hit.transform.tag != "Terrain" || hit.transform.tag != "Tile")
                {
                    flag++;
                    avoidSensitivity += 1f;
                    Debug.DrawLine(pos, hit.point, sensorColor);
                }
            }
            else if(Physics.Raycast(pos, leftAngle, out hit, sensorLength))
            {
                if(hit.transform.tag != "Terrain" || hit.transform.tag != "Tile")
                { 
                    flag++;
                    avoidSensitivity += 1f;
                    Debug.DrawLine(pos, hit.point, sensorColor);
                }
            }

            // RIGHT SIDE SENSOR
            if (Physics.Raycast(transform.position, transform.right, out hit, sidewaySensorLength))
            {
                if (hit.transform.tag != "Terrain" || hit.transform.tag != "Tile")
                {
                    flag++;
                    avoidSensitivity -= 0.5f;
                    Debug.DrawLine(transform.position, hit.point, sensorColor);
                }
            }

            // LEFT SIDEWAYS SENSOR
            if (Physics.Raycast(transform.position, -transform.right, out hit, sidewaySensorLength))
            {
                if (hit.transform.tag != "Terrain" || hit.transform.tag != "Tile")
                {
                    flag++;
                    avoidSensitivity += 0.5f;
                    Debug.DrawLine(transform.position, hit.point, sensorColor);
                }
            }

            pos = transform.position;
            pos += transform.forward * frontSensorStartPoint;

            // front mid sensor
            if (System.Math.Abs(avoidSensitivity) < 0)
            {
                if (Physics.Raycast(pos, transform.forward, out hit, sensorLength))
                {
                    if (hit.transform.tag != "Terrain" || hit.transform.tag != "Tile")
                    {
                        if (hit.normal.x < 0)
                        {
                            avoidSensitivity = -1;
                        }
                        else
                        {
                            avoidSensitivity = 1;
                        }
                        Debug.DrawLine(pos, hit.point, sensorColor);
                    }
                }
            }

            if(rb.velocity.magnitude < 2 && !reversing)
            {
                reverseCounter += Time.deltaTime;

                if(reverseCounter >= waitToReverse)
                {
                    reverseCounter = 0;
                    reversing = true;
                }
            }
            else if(!reversing)
            {
                reverseCounter = 0;
            }

            if(reversing)
            {
                // reverselights active

                avoidSensitivity *= -1;

                reverseCounter += Time.deltaTime;

                if(reverseCounter >= reverseFor)
                {
                    reverseCounter = 0;
                    reversing = false;
                }
            }

            if (flag != 0)
            {
                AvoidSteer(avoidSensitivity);
            }
        }

        void AvoidSteer(float sensitivity)
        {
            wheelFL.steerAngle = avoidSpeed * sensitivity;
            wheelFR.steerAngle = avoidSpeed * sensitivity;
        }

        void Respawn()
        {
            if(rb.velocity.magnitude < 2)
            {
                respawnCounter += Time.deltaTime;

                if(respawnCounter >= respawnWait)
                {
                    if(currentPathObj == 0)
                    {
                        transform.position = path[path.Count].position;
                    }
                    else
                    {
                        transform.position = path[currentPathObj - 1].position;
                    }
                    respawnCounter = 0;
                }
            }
        }
    }
}