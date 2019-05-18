using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Modules
{
	public enum CharacterType
	{
		PLAYER,
		ENEMY,
		PEDESTRIAN
	}

	public class GameCharacterManager : MonoBehaviour
	{
        private Animator animator;
        private CharacterController characterController;
        private PlayerCharacterController playerCharacterController;
		private StateMachine stateMachine = new StateMachine();

		public CharacterType controlledBy;
		public HealthAndArmorManager healthAndArmor;
        
		// Start is called before the first frame update
		void Awake()
		{
            animator = GetComponent<Animator>();
            characterController = GetComponent<CharacterController>();
			healthAndArmor = new HealthAndArmorManager(100, 100);
			playerCharacterController = GetComponent<PlayerCharacterController>();
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
		}
	}
}