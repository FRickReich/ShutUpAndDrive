using UnityEngine;

namespace Game.Modules
{
	public interface IState
	{
		void OnEnter();
		void Execute(float delta);
		void Exit();
	}
}
