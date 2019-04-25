using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace snd
{
	public class TestCubeScript : MonoBehaviour
	{
		private StateManager stateManager = new StateManager();

		// Start is called before the first frame update
		void Start()
		{
			this.stateManager.ChangeState(new TestInputState(stateManager));			
		}

		private void Update()
		{
			this.stateManager.ExecuteStateUpdate();
		}
	}
}