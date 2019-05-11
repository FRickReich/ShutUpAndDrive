using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace snd.v1_0.Modules.InputManager
{
	public enum KeyboardAction
	{
		ESCAPE,
		F1,
		F2,
		F3,
		F4,
		F5,
		F6,
		F7,
		F8,
		F9,
		F10,
		F11,
		F12,
		TAB,
		CAPS,
		LEFTSHIFT,
		LEFTCTRL,
		LEFTALT,
		RIGHTSHIFT,
		RIGHTCTRL,
		RIGHTALT,
		SPACE,
		UP,
		DOWN,
		LEFT,
		RIGHT,
		BACKSPACE,
		DELETE,
		RETURN,
		PRINT,
		PAUSE,
		BREAK,
		INSERT,
		HOME,
		PAGEUP,
		PAGEDOWN,
		END,
		MINUS,
		PLUS,
		STAR,
		SLASH,
		COMMA,
		PERIOD,
		NULL,
		ONE,
		TWO,
		THREE,
		FOUR,
		FIVE,
		SIX,
		SEVEN,
		EIGHT,
		NINE,
		A,
		B,
		C,
		D,
		E,
		F,
		G,
		H,
		I,
		J,
		K,
		L,
		M,
		N,
		O,
		P,
		Q,
		R,
		S,
		T,
		U,
		V,
		W,
		X,
		Y,
		Z
	}

	public enum MouseAction
	{
		LEFTMOUSECLICK,
		RIGHTMOUSECLICK,
		MIDDLEMOUSECLICK,
		MOUSEX,
		MOUSEY
	}

	public enum XBOXAction
	{
		A,
        B,
        X,
        Y,
        LB,
        RB,
		LT,
		RT,
        L,
        R,
		LHORIZONTAL,
		LVERTICAL,
		RHORIZONTAL,
		RVERTICAL,
        SELECT,
        START,
        DPADUP,
        DPADDOWN,
        DPADLEFT,
        DPADRIGHT
	}

	public enum ActionType
	{
		DOWN,
		UP,
		HOLD
	}

	[System.Serializable]
    public class ButtonInput
    {
		[Header("Info")]
		[SerializeField] public string name;

		[Header("Actions")]
        [SerializeField] public List<KeyboardAction> keyboardActions = new List<KeyboardAction>();
        [SerializeField] public List<MouseAction> mouseActions = new List<MouseAction>();
        [SerializeField] public List<XBOXAction> xboxActions = new List<XBOXAction>();

		[Header("Type")]
		[SerializeField] public ActionType actionType;

		public ButtonInput(
			List<KeyboardAction> keyboardActions, 
			List<MouseAction> mouseActions, 
			List<XBOXAction> xboxActions,
			ActionType actionType, 
			string name
		)
		{
			this.keyboardActions = keyboardActions;
			this.mouseActions = mouseActions;
			this.xboxActions = xboxActions;

			this.actionType = actionType;
			this.name = name;
		}

		private void Update()
		{
			Debug.Log("test");
		}

		public void ButtonCallback()
		{
			
		}
    }
}