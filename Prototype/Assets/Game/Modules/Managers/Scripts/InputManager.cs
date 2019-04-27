using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace snd
{
    public class InputManager : SingletonPersistent<InputManager>
    {
        public bool xboxButtonGuide;
        public bool xboxButtonA;
        public bool xboxButtonB;
        public bool xboxButtonX;
        public bool xboxButtonY;
        public bool xboxButtonLB;
        public bool xboxButtonRB;
        public bool xboxButtonStart;
        public bool xboxButtonSelect;
        public bool xboxButtonL;
        public bool xboxButtonR;

        public float xboxLHorizontal;
        public float xboxLVertical;
        public float xboxRHorizontal;
        public float xboxRVertical;
        public float xboxDPadVertical;
        public float xboxDPadHorizontal;

        public float xboxLeftTrigger;
        public float xboxRightTrigger;

        public int currentWeapon = 0;
        
        private int currentWeaponAmount = 3;

        private void Awake()
        {

        }

        // Update is called once per frame
        void Update()
        {   
            if(Input.GetButtonDown("xboxButtonGuide"))
            {
                xboxButtonGuide = true;
            }
            else
            {
                xboxButtonGuide = false;
            }

            if(Input.GetButtonDown("xboxButtonA"))
            {
                xboxButtonA = true;
            }
            else
            {
                xboxButtonA = false;
            }

            if(Input.GetButtonDown("xboxButtonB"))
            {
                xboxButtonB = true;
            }
            else
            {
                xboxButtonB = false;
            }

            if(Input.GetButtonDown("xboxButtonX"))
            {
                xboxButtonX = true;
            }
            else
            {
                xboxButtonX = false;
            }

            if(Input.GetButtonDown("xboxButtonY"))
            {
                xboxButtonY = true;
            }
            else
            {
                xboxButtonY = false;
            }

            if(Input.GetButtonDown("xboxButtonLB"))
            {
                xboxButtonLB = true;
            }
            else if(Input.GetButtonUp("xboxButtonLB"))
            {
                xboxButtonLB = false;
            }

            if(Input.GetButtonDown("xboxButtonRB"))
            {
                xboxButtonRB = true;
            }
            else
            {
                xboxButtonRB = false;
            }

            if(Input.GetButtonDown("xboxButtonStart"))
            {
                xboxButtonStart = true;
            }
            else
            {
                xboxButtonStart = false;
            }

            if(Input.GetButtonDown("xboxButtonL"))
            {
                xboxButtonL = true;
            }
            else
            {
                xboxButtonL = false;
            }

            if(Input.GetButtonDown("xboxButtonR"))
            {
                xboxButtonR = true;
            }
            else
            {
                xboxButtonR = false;
            }

            if(Input.GetButtonDown("xboxButtonSelect"))
            {
                xboxButtonSelect = true;
            }
            else
            {
                xboxButtonSelect = false;
            }

            xboxLHorizontal = Input.GetAxis("xboxLHorizontal");
            xboxLVertical = -Input.GetAxis("xboxLVertical");
            xboxRHorizontal = Input.GetAxis("xboxRHorizontal");
            xboxRVertical = Input.GetAxis("xboxRVertical");
            xboxDPadHorizontal = Input.GetAxisRaw("xboxDPadHorizontal");
            xboxDPadVertical = Input.GetAxisRaw("xboxDPadVertical");

            if(xboxDPadHorizontal == 1)
            {
                this.NextWeapon();
            }
            else if(xboxDPadHorizontal == -1)
            {
                this.PreWeapon();
            }
        }

        public void NextWeapon()
        {
            if(currentWeapon <= currentWeaponAmount - 1)
            {
                this.currentWeapon++;
            }
            else
            {
                this.currentWeapon = 0;
            }
            
        }

        public void PreWeapon()
        {
            if(currentWeapon >= 0)
            {
                this.currentWeapon--;
            }
            else
            {
                this.currentWeapon = currentWeaponAmount;
            }
        }
    }   
}
