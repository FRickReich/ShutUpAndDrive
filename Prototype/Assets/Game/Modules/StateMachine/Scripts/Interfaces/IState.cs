using UnityEngine;

namespace snd
{
	public interface IState
	{
		void OnEnter();
		void Execute(float delta);
		void Exit();
	}
}