using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.V1.Extension
{
	public class DeleteAllPlayerPrefsPro : MonoBehaviour
	{
		// Start is called before the first frame update
		void Awake()
		{
			PlayerPrefsPro.DeleteAll();
		}
	}
}
