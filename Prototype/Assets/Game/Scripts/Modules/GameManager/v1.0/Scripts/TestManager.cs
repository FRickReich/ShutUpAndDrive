using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Game.Test;

namespace Game.Modules
{
	public class TestManager : MonoBehaviour
	{
        private StateMachine stateManager = new StateMachine();

		// Start is called before the first frame update
		void Start()
		{
            this.stateManager.ChangeState(new TestInputState(stateManager));
		}

		// Update is called once per frame
		void Update()
		{
            this.stateManager.ExecuteStateUpdate();
		}
	}
}
