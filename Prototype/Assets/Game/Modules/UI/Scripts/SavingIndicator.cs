using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace snd
{
    public class SavingIndicator : MonoBehaviour
    {
        private RectTransform rectComponent;
        public float rotateSpeed = 200f;
        public bool counterClockwise = false;

        private void Start()
        {
            rectComponent = GetComponent<RectTransform>();
        }

        private void Update()
        {
            if (counterClockwise)
            {
                rectComponent.Rotate(0f, 0f, rotateSpeed * Time.deltaTime);
            }
            else
            {
                rectComponent.Rotate(0f, 0f, -rotateSpeed * Time.deltaTime);
            }
        }
    }
}