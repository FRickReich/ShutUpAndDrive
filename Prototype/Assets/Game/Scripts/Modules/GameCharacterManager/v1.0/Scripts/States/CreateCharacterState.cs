using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

namespace Game.Modules
{
	public class CreateCharacterState : IState
	{
        private StateMachine StateMachine;
		private GameCharacterManager characterManager;
		private int initialHealth;
		private int initialArmor;

		public CreateCharacterState(
			StateMachine StateMachine, 
			GameCharacterManager characterManager, 
			int initialHealth, 
			int initialArmor
		)
		{
			this.StateMachine = StateMachine;
			this.characterManager = characterManager;
			this.initialHealth = initialHealth;
			this.initialArmor = initialArmor;
		}

		public void Execute(float delta)
		{
			this.characterManager.healthAndArmor = new HealthAndArmorManager(this.initialHealth, this.initialArmor);
		}

		public void Exit()
		{

		}

		public void OnEnter()
		{
			
		}
	}
}
