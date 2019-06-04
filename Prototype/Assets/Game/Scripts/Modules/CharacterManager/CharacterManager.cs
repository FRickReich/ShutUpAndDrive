using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Game.Controllers;
using Game.Enums;
using Game.Zones;

namespace Game.Managers
{
	public class CharacterManager : MonoBehaviour
	{
        private CharacterController characterController;
        private PlayerCharacterController playerCharacterController;

        public CharacterType  controlledBy;
        public HealthAndArmorManager healthAndArmor;

        private void Awake() {
            characterController = GetComponent<CharacterController>();
            healthAndArmor = new HealthAndArmorManager(100, 100);
            playerCharacterController = GetComponent<PlayerCharacterController>();
        }

		private void OnEnable()
    	{
        	DamageZone.damageDealtEvent += TakeDamage;
	    }

    	private void OnDisable()
    	{
        	DamageZone.damageDealtEvent -= TakeDamage;
    	}

		public void TakeDamage(int damage)
		{
			healthAndArmor.TakeDamage(damage);

			if(controlledBy == CharacterType.PLAYER)
			{
				UIManager.Instance.UpdateHUDPanel();
			}
		}

		public void Heal()
		{

		}

		// Start is called before the first frame update
		void Start()
		{
			if(controlledBy == CharacterType.PLAYER)
			{
                new HealthAndArmorManager(100, 100);
			}
			else if(controlledBy == CharacterType.ENEMY)
			{
                new HealthAndArmorManager(100, 0);
			}
			else if(controlledBy == CharacterType.PEDESTRIAN)
			{
                new HealthAndArmorManager(1, 0);
			}
		}

		// Update is called once per frame
		void Update()
		{
            
		}
	}
}
