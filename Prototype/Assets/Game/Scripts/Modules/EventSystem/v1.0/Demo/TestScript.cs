using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Game.Events;

namespace Game.Tests
{
	public class TestScript : MonoBehaviour
	{
        [SerializeField] private VoidEvent onTest;

		// Start is called before the first frame update
		void Start()
		{
            onTest.Raise();
		}
	}
}
