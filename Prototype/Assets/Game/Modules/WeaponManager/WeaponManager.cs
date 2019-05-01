using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace snd
{
	public class WeaponManager : MonoBehaviour
	{
		private StateManager stateManager = new StateManager();

        public WeaponController[] weapons;

        public int currentWeaponNumber = -1;
        public WeaponController currentWeapon;

		// Start is called before the first frame update
		void Start()
		{
			if(currentWeaponNumber != -1)
			{
				this.stateManager.ChangeState(new EquipWeaponState(stateManager, this, currentWeaponNumber));
			}
			else
			{
				this.stateManager.ChangeState(new UnequipWeaponState(stateManager, this, currentWeaponNumber));
			}
		}

		// Update is called once per frame
		void Update()
		{
            this.stateManager.ExecuteStateUpdate();

            if(InputManager.Instance.xboxDPadLeft)
			{
                this.stateManager.ChangeState(new PrevWeaponState(stateManager, this, currentWeaponNumber));
			}

            if(InputManager.Instance.xboxDPadRight)
			{
                this.stateManager.ChangeState(new NextWeaponState(stateManager, this, currentWeaponNumber));
			}

			if (currentWeaponNumber != -1 && InputManager.Instance.xboxButtonA)
			{
				this.currentWeapon.FireWeapon();
			}

			if (currentWeaponNumber != -1 && currentWeapon.currentAmmo < currentWeapon.maxAmmo && InputManager.Instance.xboxButtonX)
			{
				this.currentWeapon.ReloadWeapon();
			}
		}
	}
}
