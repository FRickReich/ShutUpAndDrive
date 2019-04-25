using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace snd
{
	public class UIManager : MonoBehaviour
	{
		public TMP_Text healthText;
		public TMP_Text armorText;

		public TMP_Text deathText;

		// Start is called before the first frame update
		void Start()
		{
			deathText.enabled = false;
		}

		// Update is called once per frame
		void Update()
		{
			healthText.text = "Health: " + PlayerManager.Instance.playerHealth;
			armorText.text = "Armor: " + PlayerManager.Instance.playerArmor;

			if (PlayerManager.Instance.playerDead)
			{
				deathText.enabled = true;
			}
		}
	}
}