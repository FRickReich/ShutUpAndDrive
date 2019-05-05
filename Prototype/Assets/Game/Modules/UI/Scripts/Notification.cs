using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace snd
{
    public class Notification : MonoBehaviour
    {
        private RectTransform rectComponent;
        public float lifeTime;

        private void Start()
        {
            rectComponent = GetComponent<RectTransform>();

            
        }


    }
}