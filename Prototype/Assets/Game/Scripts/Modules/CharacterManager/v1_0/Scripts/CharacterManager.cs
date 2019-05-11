using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using ModuleHealthManager = Game.Modules.HealthAndArmorManager.v1_0;
using ModulePCController = Game.Modules.PlayerCharacterController.v1_0;
using ModuleStateMachine = Game.Modules.StateMachine.v1_0;

namespace Game.Modules.CharacterManager.v1_0
{
	public enum CharacterType
	{
		PLAYER,
		ENEMY,
		PEDESTRIAN
	}
	
	public enum CharacterSex
	{
		MALE,
		FEMALE
	}

	public class CharacterManager : MonoBehaviour
	{
        private Animator animator;
        private CharacterController characterController;
        private ModulePCController.PlayerCharacterController playerCharacterController;
		private ModuleStateMachine.StateMachine stateMachine = new ModuleStateMachine.StateMachine();

		public CharacterType controlledBy;
		public CharacterSex sex;
		public ModuleHealthManager.HealthAndArmorManager healthAndArmor;
        
		// Start is called before the first frame update
		void Awake()
		{
            animator = GetComponent<Animator>();
            characterController = GetComponent<CharacterController>();
			healthAndArmor = new ModuleHealthManager.HealthAndArmorManager(100, 100);
			playerCharacterController = GetComponent<ModulePCController.PlayerCharacterController>();
		}

		void Start()
		{
			int initialHealth = 0;
			int initialArmor = 0;

			if(controlledBy == CharacterType.PLAYER)
			{
				initialHealth = 100;
				initialArmor = 100;
			}
			else if(controlledBy == CharacterType.ENEMY)
			{
				initialHealth = 100;
				initialArmor = 0;
			}
			else if(controlledBy == CharacterType.PEDESTRIAN)
			{
				initialHealth = 1;
				initialArmor = 0;
			}

			this.stateMachine.ChangeState(new CreateCharacterState(
					stateMachine,
					this,
					initialHealth,
					initialArmor
				));
		}

		// Update is called once per frame
		void Update()
		{
            this.stateMachine.ExecuteStateUpdate();

			Debug.Log(healthAndArmor.GetHealh());
		}
	}
}