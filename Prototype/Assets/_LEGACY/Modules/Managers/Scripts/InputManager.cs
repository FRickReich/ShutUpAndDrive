using System;
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

		public bool xboxDPadUp;
		public bool xboxDPadDown;
		public bool xboxDPadLeft;
		public bool xboxDPadRight;

		public float xboxLHorizontal;
		public float xboxLVertical;
		public float xboxRHorizontal;
		public float xboxRVertical;
		public float xboxLeftTrigger;
		public float xboxRightTrigger;
        
        private bool X_isAxisInUse = false;
        private bool Y_isAxisInUse = false;

		public static event Action<bool> xboxButtonGuideEvent;
		public static event Action<bool> xboxButtonAEvent;
		public static event Action<bool> xboxButtonBEvent;
		public static event Action<bool> xboxButtonXEvent;
		public static event Action<bool> xboxButtonYEvent;
		public static event Action<bool> xboxButtonLBEvent;
		public static event Action<bool> xboxButtonRBEvent;
		public static event Action<bool> xboxButtonStartEvent;
		public static event Action<bool> xboxButtonSelectEvent;
		public static event Action<bool> xboxButtonLEvent;
		public static event Action<bool> xboxButtonREvent;

		

		// Update is called once per frame
		void Update()
		{
			if (Input.GetButtonDown("xboxButtonGuide"))
			{
				xboxButtonGuide = true;
			}
			else
			{
				xboxButtonGuide = false;
			}

			if (Input.GetButtonDown("xboxButtonA"))
			{
				xboxButtonA = true;
			}
			else
			{
				xboxButtonA = false;
			}

			if (Input.GetButtonDown("xboxButtonB"))
			{
				xboxButtonB = true;
			}
			else
			{
				xboxButtonB = false;
			}

			if (Input.GetButtonDown("xboxButtonX"))
			{
				xboxButtonX = true;
			}
			else
			{
				xboxButtonX = false;
			}

			if (Input.GetButtonDown("xboxButtonY"))
			{
				xboxButtonY = true;
			}
			else
			{
				xboxButtonY = false;
			}

			if (Input.GetButtonDown("xboxButtonLB"))
			{
				xboxButtonLB = true;
			}
			else if (Input.GetButtonUp("xboxButtonLB"))
			{
				xboxButtonLB = false;
			}

			if (Input.GetButtonDown("xboxButtonRB"))
			{
				xboxButtonRB = true;
			}
			else
			{
				xboxButtonRB = false;
			}

			if (Input.GetButtonDown("xboxButtonStart"))
			{
				xboxButtonStart = true;
			}
			else
			{
				xboxButtonStart = false;
			}

			if (Input.GetButtonDown("xboxButtonL"))
			{
				xboxButtonL = true;
			}
			else
			{
				xboxButtonL = false;
			}

			if (Input.GetButtonDown("xboxButtonR"))
			{
				xboxButtonR = true;
			}
			else
			{
				xboxButtonR = false;
			}

			if (Input.GetButtonDown("xboxButtonSelect"))
			{
				xboxButtonSelect = true;
			}
			else
			{
				xboxButtonSelect = false;
			}

            if( Input.GetAxisRaw("xboxDPadHorizontal") != 0)
            {
                xboxDPadLeft = false;
                xboxDPadRight = false;

                if(X_isAxisInUse == false)
                {
                    if(Input.GetAxisRaw("xboxDPadHorizontal")==+1)
                    {
                        xboxDPadRight = true;
                    }
                    else if(Input.GetAxisRaw("xboxDPadHorizontal")==-1)
                    {
                        xboxDPadLeft = true;
                    }

                    X_isAxisInUse = true;
                }
            }
            if( Input.GetAxisRaw("xboxDPadHorizontal") == 0)
            {
                X_isAxisInUse = false;
            }    

            if( Input.GetAxisRaw("xboxDPadVertical") != 0)
            {
                xboxDPadUp = false;
                xboxDPadDown = false;

                if(Y_isAxisInUse == false)
                {
                    if(Input.GetAxisRaw("xboxDPadVertical")==+1)
                    {
                        xboxDPadUp = true;
                    }
                    else if(Input.GetAxisRaw("xboxDPadVertical")==-1)
                    {
                        xboxDPadDown = true;
                    }
                    
                    Y_isAxisInUse = true;
                }
            }
            if( Input.GetAxisRaw("xboxDPadVertical") == 0)
            {
                Y_isAxisInUse = false;
            }

			xboxLHorizontal = Input.GetAxis("xboxLHorizontal");
			xboxLVertical = -Input.GetAxis("xboxLVertical");
			xboxRHorizontal = Input.GetAxis("xboxRHorizontal");
			xboxRVertical = Input.GetAxis("xboxRVertical");

			CheckControllerEvents();
		}

		public void CheckControllerEvents()
		{
			if (xboxButtonGuideEvent != null) xboxButtonGuideEvent(xboxButtonGuide);
			if (xboxButtonAEvent != null) xboxButtonAEvent(xboxButtonA);
			if (xboxButtonBEvent != null) xboxButtonBEvent(xboxButtonB);
			if (xboxButtonXEvent != null) xboxButtonXEvent(xboxButtonX);
			if (xboxButtonYEvent != null) xboxButtonYEvent(xboxButtonY);
			if (xboxButtonLBEvent != null) xboxButtonLBEvent(xboxButtonLB);
			if (xboxButtonRBEvent != null) xboxButtonRBEvent(xboxButtonRB);
			if (xboxButtonStartEvent != null) xboxButtonStartEvent(xboxButtonStart);
			if (xboxButtonSelectEvent != null) xboxButtonSelectEvent(xboxButtonSelect);
			if (xboxButtonLEvent != null) xboxButtonLEvent(xboxButtonL);
			if (xboxButtonREvent != null) xboxButtonREvent(xboxButtonR);
		}
	}
}
