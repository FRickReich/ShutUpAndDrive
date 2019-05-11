using System;
using UnityEngine;

namespace Game.Modules
{
	public class HealthAndArmorManager
	{
		public event EventHandler onHealthChanged;

		private int health;
		private int healthMax;
		private int armor;
		private int armorMax;

		public HealthAndArmorManager(int healthMax, int armorMax)
		{
			this.healthMax = healthMax;
			this.health = healthMax;

			this.armorMax = armorMax;
			this.armor = armorMax;
		}

		public int GetHealh()
		{
			return health;
		}

		public int getArmor()
		{
			return armor;
		}

		public float getHealthInPercent()
		{
			return (float)health / healthMax;
		}

		public float getArmorInPercent()
		{
			return (float)armor / armorMax;
		}

		public void TakeDamage(int damageAmount)
		{
			if (armor > 0)
			{
				armor -= damageAmount;

				if (armor < 0)
				{
					armor = 0;
				}
			}
			if (armor == 0)
			{
				health -= damageAmount;

				if (health < 0)
				{
					health = 0;
				}
			}
		}

		public void AddHeal(int healAmount)
		{
			health += healAmount;

			if (health > healthMax)
			{
				health = healthMax;
			}
		}

		public void AddArmor(int armorAmount)
		{
			armor += armorAmount;

			if (armor > armorMax)
			{
				armor = armorMax;
			}
		}
	}
}
