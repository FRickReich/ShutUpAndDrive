using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace snd.v1_0.Modules.InputManager
{
	public class InputActionTest : MonoBehaviour
	{
		public string testString;

        private void OnEnable()
    	{
			
	    }

    	private void OnDisable()
    	{
			
    	}

		// Start is called before the first frame update
		void Start()
		{
            
		}

		// Update is called once per frame
		void Update()
		{
			Debug.Log(testString);
		}
	}
}