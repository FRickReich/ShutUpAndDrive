using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Modules.VehicleAI
{
    public class BreakingSection : MonoBehaviour
    {
        public float maxBreakTorque;
        public float minCarSpeed;
        public bool isBreaking;
        private float ControlcurrentSpeed;

        void OnTriggerStay(Collider other)
        {
            ControlcurrentSpeed = other.transform.root.GetComponent<Driving>().currentSpeed;

            if (other.tag == "AI")
            {
                ControlcurrentSpeed = other.transform.root.GetComponent<Driving>().currentSpeed;
                if (ControlcurrentSpeed >= minCarSpeed)
                {
                    other.transform.root.GetComponent<Driving>().inSector = true;
                    other.transform.root.GetComponent<Driving>().wheelRR.brakeTorque = maxBreakTorque;
                    other.transform.root.GetComponent<Driving>().wheelRL.brakeTorque = maxBreakTorque;
                }
                else
                {

                    other.transform.root.GetComponent<Driving>().wheelRR.brakeTorque = 0;
                    other.transform.root.GetComponent<Driving>().wheelRL.brakeTorque = 0;
                }
                other.transform.root.GetComponent<Driving>().isBreaking = true;
            }
        }

        void OnTriggerExit(Collider other)
        {
            if (other.tag == "AI")
            {
                other.transform.root.GetComponent<Driving>().inSector = false;
                other.transform.root.GetComponent<Driving>().wheelRR.brakeTorque = 0;
                other.transform.root.GetComponent<Driving>().wheelRL.brakeTorque = 0;

                other.transform.root.GetComponent<Driving>().isBreaking = false;
            }
        }
    }
}