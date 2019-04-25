using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace snd
{
    public class InputManager : SingletonPersistent<InputManager>
    {
        public bool gamePaused;

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
            else if(Input.GetButtonUp("xboxButtonGuide"))
            {
                xboxButtonGuide = false;
            }

            if(Input.GetButtonDown("xboxButtonA"))
            {
                xboxButtonA = true;
            }
            else if(Input.GetButtonUp("xboxButtonA"))
            {
                xboxButtonA = false;
            }

            if(Input.GetButtonDown("xboxButtonB"))
            {
                xboxButtonB = true;
            }
            else if(Input.GetButtonUp("xboxButtonB"))
            {
                xboxButtonB = false;
            }

            if(Input.GetButtonDown("xboxButtonX"))
            {
                xboxButtonX = true;
            }
            else if(Input.GetButtonUp("xboxButtonX"))
            {
                xboxButtonX = false;
            }

            if(Input.GetButtonDown("xboxButtonY"))
            {
                xboxButtonY = true;
            }
            else if(Input.GetButtonUp("xboxButtonY"))
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
            else if(Input.GetButtonUp("xboxButtonRB"))
            {
                xboxButtonRB = false;
            }

            if(Input.GetButtonDown("xboxButtonStart"))
            {
                xboxButtonStart = true;
            }
            else if(Input.GetButtonUp("xboxButtonStart"))
            {
                xboxButtonStart = false;
            }

            if(Input.GetButtonDown("xboxButtonL"))
            {
                xboxButtonL = true;
            }
            else if(Input.GetButtonUp("xboxButtonL"))
            {
                xboxButtonL = false;
            }

            if(Input.GetButtonDown("xboxButtonR"))
            {
                xboxButtonR = true;
            }
            else if(Input.GetButtonUp("xboxButtonR"))
            {
                xboxButtonR = false;
            }

            if(Input.GetButtonDown("xboxButtonSelect"))
            {
                xboxButtonSelect = true;

                if(!gamePaused)
                {
                    gamePaused = true;
                }
                else if(gamePaused)
                {
                    gamePaused = false;
                }
                
            }
            else if(Input.GetButtonUp("xboxButtonSelect"))
            {
                xboxButtonSelect = false;
            }

            xboxLHorizontal = Input.GetAxis("xboxLHorizontal");
            xboxLVertical = Input.GetAxis("xboxLVertical");
            xboxRHorizontal = Input.GetAxis("xboxRHorizontal");
            xboxRVertical = Input.GetAxis("xboxRVertical");
            xboxDPadHorizontal = Input.GetAxisRaw("xboxDPadHorizontal");
            xboxDPadVertical = Input.GetAxisRaw("xboxDPadVertical");
            
            GameManager.Instance.PauseGame(gamePaused ? true : false);

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
