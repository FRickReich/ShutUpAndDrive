using UnityEngine;

namespace Game.V1.FSM
{
	public interface IState
	{
		void OnEnter();
		void Execute(float delta);
		void LateExecute();
		void Exit();
	}
}
