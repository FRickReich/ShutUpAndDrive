using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Game.Modules;
using Game.Modules.Internal;
using Game.Modules.PlayerController;

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

        public float destroyDistance;

        public PopulationManager populationManager;
        public GameManager gameManager;

        public bool active = true;
        public bool creator = false;

        public BoxCollider tileTrigger;

        void Awake()
        {
            populationManager = FindObjectOfType<PopulationManager>();
            gameManager = FindObjectOfType<GameManager>();

            destroyDistance = populationManager.destroyDistance;
        }

        // Start is called before the first frame update
        void Start()
        {
            DecideCreator();
        }

        // Update is called once per frame
        void Update()
        {
            tileTrigger.enabled = active;

            if(Vector3.Distance(populationManager.transform.position, transform.position) > destroyDistance)
            {
                active = true;
                DecideCreator();
            }
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

                if(gameManager.currentArea.text != currentArea)
                {
                    gameManager.SetPlayerArea(currentArea);
                }

                if(gameManager.currentLocation.text != currentLocation)
                {
                    gameManager.SetPlayerLocation(currentLocation);
                }
            }
        }

        public void DecideCreator()
        {
            creator = GetRandomBool();
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag == "PopulationManager")
            {

            }
        }
    }
}