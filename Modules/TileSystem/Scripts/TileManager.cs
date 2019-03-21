using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TileType
{
    GROUND,
    WATER,
    INSIDE,
    UNWALKABLE
}

public enum TileArea
{
    TESTAREA1,
    TESTAREA2
}

public enum TilePlace
{
    STREET,
    PARK,
    GARAGE,
    BUILDINGFirstFloor,
    BUILDINGSecondFloor
}

namespace Game.TileManager 
{
    public class TileManager : MonoBehaviour
    {
        [Header("TileInfo")]
        public TileType tileType;
        public TileArea tileArea;
        public TilePlace tileLocation;
        public bool VehicleSpawnable = false;
        public bool CharacterSpawnable = false;

        public bool active = true;
        public bool creator = false;

        public BoxCollider tileTrigger;

        // Start is called before the first frame update
        void Start()
        {
            creator = GetRandomBool();
        }

        // Update is called once per frame
        void Update()
        {
            tileTrigger.enabled = active;
        }

        bool GetRandomBool()
        {
            int randomNumber = Random.Range(0, 100);
            return (randomNumber % 2 == 0) ? true : false;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                string currentArea = tileArea.ToString();
                string currentLocation = tileLocation.ToString();
                Debug.Log(currentArea + " - " + currentLocation);

                if (other.GetComponent<PlayerController>().currentArea.text != currentArea)
                {
                    other.GetComponent<PlayerController>().ChangeArea(currentArea);
                }

                if (other.GetComponent<PlayerController>().currentLocation.text != currentLocation)
                {
                    other.GetComponent<PlayerController>().ChangeLocation(currentLocation);
                }
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "PopulationManager")
            {

            }
        }
    }
}