using UnityEngine;

namespace Game.States
{
	public interface IState
	{
		void OnEnter();
		void Execute(float delta);
		void LateExecute();
		void Exit();
	}
}