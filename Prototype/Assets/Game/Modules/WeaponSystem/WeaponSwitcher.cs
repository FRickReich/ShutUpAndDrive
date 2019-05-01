using System;
using UnityEngine;

namespace snd
{
	public class WeaponSwitcher : MonoBehaviour
	{
		public int selectedWeapon = 0;
		public bool nextWeapon;
		public bool prevWeapon;

		public Weapon currentWeapon;

		private void Start()
		{
			this.SelectWeapon();
		}

		private void Update()
		{
			int previousSelectedWeapon = selectedWeapon;

			if(InputManager.Instance.xboxDPadLeft)
			{
				if(selectedWeapon >= transform.childCount -1)
				{
					selectedWeapon = 0;
				}
				else
				{
					selectedWeapon++;
				}
			}

			if(InputManager.Instance.xboxDPadRight)
			{
				if(selectedWeapon <= 0)
				{
					selectedWeapon = transform.childCount -1;
				}
				else
				{
					selectedWeapon--;
				}
			}

			if(previousSelectedWeapon != selectedWeapon)
			{
				SelectWeapon();
			}
		}

		private void SelectWeapon()
		{
			int index = 0;

			foreach(Transform weapon in transform)
			{
				if(index == this.selectedWeapon)
				{
					weapon.gameObject.SetActive(true);
					currentWeapon = weapon.GetComponent<Weapon>();
				}
				else
				{
					weapon.gameObject.SetActive(false);
				}

				index++;
			}
		}
	}
}
