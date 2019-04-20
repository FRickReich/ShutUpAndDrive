using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Game.Modules
{
    public class PopulationManager : MonoBehaviour
    {
        public PopulationItem testCharacterPrefab;
        public PopulationItem testVehiclePrefab;

        public List<Transform> currentTiles = new List<Transform>();

        public int size = 4;

        public float destroyDistance = 30f;

        public int randomX;
        public int randomZ;

        public float raycastLength = 30;

        // Start is called before the first frame update
        void Start()
        {

        }

        Vector3 RandomPosition(Vector3 tilePosition)
        {
            randomX = Random.Range(-size / 2, size / 2);
            randomZ = Random.Range(-size / 2, size / 2);

            return new Vector3(
                (tilePosition.x + 1.5f) + randomX, 
                tilePosition.y,
                (tilePosition.z + 1.5f) + randomZ
            );
        }

        public void CreateObject(Vector3 tilePosition, Transform currentTile)
        {
            TileManager.TileManager tile = currentTile.GetComponent<TileManager.TileManager>();

            if(tile.active == true && tile.creator == true)
            {
                if (tile.tileType == TileType.GROUND && tile.CharacterSpawnable == true)
                {
                    tile.active = false;
                    PopulationItem newObject = Instantiate(testCharacterPrefab, RandomPosition(tilePosition), Quaternion.identity);
                    newObject.destroyDistance = destroyDistance;
                    newObject.populationManager = this;
                }
                if (tile.tileType == TileType.GROUND && tile.VehicleSpawnable == true)
                {
                    tile.active = false;
                    PopulationItem newObject = Instantiate(testVehiclePrefab, RandomPosition(tilePosition), Quaternion.identity);
                    newObject.destroyDistance = destroyDistance;
                    newObject.populationManager = this;
                }
            }

        }

        // Update is called once per frame
        void Update()
        {
            Collider[] objs;

            objs = Physics.OverlapSphere(transform.position + Vector3.up, raycastLength);

            currentTiles = new List<Transform>();

            foreach(Collider c in objs)
            {
                if(c.GetComponent<TileManager.TileManager>())
                {
                    CreateObject(c.transform.position, c.transform);
                }
            }
        }
    }
}
