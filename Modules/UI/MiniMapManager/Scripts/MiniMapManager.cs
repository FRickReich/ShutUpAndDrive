using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Game.Modules;

namespace Game.Modules.MiniMapManager
{
    public class MiniMapManager : MonoBehaviour
    {
        [Range(10, 50)]
        public float zoom = 10f;
        public bool rotate = false;

        public GameObject player;

        private void Awake() 
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
    
        private void LateUpdate()
        {
            Vector3 newPosition = player.transform.position;
            newPosition.y = transform.position.y;
            transform.position = newPosition;

            GetComponent<Camera>().orthographicSize = zoom;

            if(rotate)
            {
                transform.rotation = Quaternion.Euler(90, player.transform.eulerAngles.y, 0f);
            }
        }
    }   
}