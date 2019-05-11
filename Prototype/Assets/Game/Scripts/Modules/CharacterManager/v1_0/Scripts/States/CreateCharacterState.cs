using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input;

namespace Game.Modules.CharacterManager.v1_0
{
	public class CreateCharacterState : StateMachine.v1_0.IState
	{
        private StateMachine.v1_0.StateMachine StateMachine;
		private CharacterManager characterManager;
		private int initialHealth;
		private int initialArmor;

		public CreateCharacterState(
			StateMachine.v1_0.StateMachine StateMachine, 
			CharacterManager characterManager, 
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
			this.characterManager.healthAndArmor = new HealthAndArmorManager.v1_0.HealthAndArmorManager(this.initialHealth, this.initialArmor);
		}

		public void Exit()
		{

		}

		public void OnEnter()
		{
			
		}
	}
}
