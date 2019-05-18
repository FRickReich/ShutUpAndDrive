using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Events
{
	[System.Serializable] public struct Bool 
	{
		public bool boolValue;

		public Bool(bool boolValue)
		{
			this.boolValue = boolValue;
		}
	}
}
