using System;
using UnityEngine;

namespace Game.V1.HealthArmor
{
	public class HealthAndArmorManager
	{
		public event EventHandler OnDamagedHealth;
		public event EventHandler OnDamagedArmor;
    	public event EventHandler OnHeal;
		public event EventHandler OnNewArmor;

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
				if(OnDamagedArmor != null)
        		{
            		OnDamagedArmor(this, EventArgs.Empty);
        		}
			}
			if (armor <= 0)
			{
				health -= damageAmount;

				if (health < 0)
				{
					health = 0;
				}
				if(OnDamagedHealth != null)
        		{
            		OnDamagedHealth(this, EventArgs.Empty);
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
			if(OnHeal != null)
        	{
            	OnHeal(this, EventArgs.Empty);
        	}
		}

		public void AddArmor(int armorAmount)
		{
			armor += armorAmount;

			if (armor > armorMax)
			{
				armor = armorMax;
			}
			if(OnNewArmor != null)
        	{
            	OnNewArmor(this, EventArgs.Empty);
        	}
		}
	}
}
