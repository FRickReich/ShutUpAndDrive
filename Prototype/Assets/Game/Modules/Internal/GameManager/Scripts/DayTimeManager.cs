using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Modules.Internal {
    public class DayTimeManager : MonoBehaviour
    {
        public GameObject dayLight;
	    public GameObject nightLight;

        public void SetDayTime()
        {
            dayLight.SetActive(true);
            nightLight.SetActive(false);
        }

        public void SetNightTime()
        {
            dayLight.SetActive(false);
            nightLight.SetActive(true);
        }
    }
}