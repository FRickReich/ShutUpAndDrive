using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Toolkit.Events
{
	public interface IGameEventListener<T>
	{
		void OnEventRaised(T item);
	}
}
