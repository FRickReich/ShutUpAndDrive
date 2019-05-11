using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace snd.v1_0.Modules.InputManager
{
	public class InputManager : MonoBehaviour
	{
		public List<ButtonInput> newInputs = new List<ButtonInput>();

		public static event Action<string> InputDownEvent;
		public static event Action<string> InputUpEvent;
		public static event Action<string> InputHoldEvent;

		private void Update()
		{
			/* foreach (ButtonInput newInput in newInputs)
			{
				foreach (KeyboardAction keyboardAction in newInput.keyboardActions)
				{
					if(newInput.actionType == ActionType.DOWN)
					{
						if(Input.GetKeyDown(GetKeycodeForKeyboardInput(keyboardAction)))
						{
							InputDownEvent(newInput.name);
						}
					}
					else if(newInput.actionType == ActionType.UP)
					{
						if(Input.GetKeyUp(GetKeycodeForKeyboardInput(keyboardAction)))
						{
							InputUpEvent(newInput.name);
						}
					}
					else if(newInput.actionType == ActionType.HOLD)
					{
						if(Input.GetKey(GetKeycodeForKeyboardInput(keyboardAction)))
						{
							InputHoldEvent(newInput.name);
						}
					}
				}

				foreach (MouseAction mouseAction in newInput.mouseActions)
				{
					if(newInput.actionType == ActionType.DOWN)
					{
						if(Input.GetMouseButtonDown(GetIntForMouseInput(mouseAction)))
						{
							InputDownEvent(newInput.name);
						}
					}
					else if(newInput.actionType == ActionType.UP)
					{
						if(Input.GetMouseButtonUp(GetIntForMouseInput(mouseAction)))
						{
							InputUpEvent(newInput.name);
						}
					}
					else if(newInput.actionType == ActionType.HOLD)
					{
						if(Input.GetMouseButton(GetIntForMouseInput(mouseAction)))
						{
							InputHoldEvent(newInput.name);
						}
					}
				}
			}*/
		}

		

		public bool InputDownAction(string actionName)
		{
			return true;
		}
	}
}

/*


		private void AddButtonInput()
		{
			if(newInputs != null)
			{
				List<KeyboardAction> keyboardInputs = new List<KeyboardAction>();
									 keyboardInputs.Add(KeyboardAction.RETURN);
									 keyboardInputs.Add(KeyboardAction.SPACE);

				
				List<MouseAction> mouseInputs = new List<MouseAction>();
								  mouseInputs.Add(MouseAction.LEFTMOUSECLICK);

				List<XBOXAction> xBoxInputs = new List<XBOXAction>();
								 xBoxInputs.Add(XBOXAction.A);
								 xBoxInputs.Add(XBOXAction.X);

				ActionType actionType = ActionType.DOWN;

				ButtonInput buttonInput = new ButtonInput(keyboardInputs, mouseInputs, xBoxInputs, actionType);

				newInputs.Add(buttonInput);
			}
		}
		*/
