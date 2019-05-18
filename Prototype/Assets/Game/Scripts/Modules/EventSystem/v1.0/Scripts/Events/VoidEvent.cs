using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Events
{
    [CreateAssetMenu(fileName = "VoidEvent", menuName = "Game/Events/Void", order = 0)]
	public class VoidEvent : BaseGameEvent<Void>
	{
		public void Raise() => Raise(new Void());
	}
}
