using UnityEngine;

namespace Game.Modules.StateMachine.v1_0
{
	public interface IState
	{
		void OnEnter();
		void Execute(float delta);
		void Exit();
	}
}
