using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Modules
{
    public class PopulationItem : MonoBehaviour
    {
        public bool destroysOnDistance = true;
        public float destroyDistance;
        public PopulationManager populationManager;
        
        // Start is called before the first frame update
        void Awake()
        {
            populationManager = GetComponent<PopulationManager>();
        }

        // Update is called once per frame
        void Update()
        {
            if(destroysOnDistance)
            {
                if(Vector3.Distance(populationManager.transform.position, transform.position) > destroyDistance)
                {
                    Destroy(gameObject);
                }

            }
        }
    }
}