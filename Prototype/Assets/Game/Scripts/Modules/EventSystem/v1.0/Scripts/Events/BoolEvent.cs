using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Events
{
    [CreateAssetMenu(fileName = "BoolEvent", menuName = "Game/Events/Bool", order = 0)]
	public class BoolEvent : BaseGameEvent<Bool>
	{
		public void Raise(bool boolValue) => Raise(new Bool(boolValue));
	}
}
