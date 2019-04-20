using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Modules.Internal {
    public class Home : MonoBehaviour
    {
        public GameManager gm;

        public bool saving = false;

        // Start is called before the first frame update
        void Awake()
        {
            gm = FindObjectOfType<GameManager>();
        }

        // Update is called once per frame
        void Update()
        {
            if(saving)
            {
                if(Input.GetKeyDown(KeyCode.T))
                {
                    gm.SaveGame();
                }
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.tag == "Player" && gm.currentPlayMode == Helpers.PlayerMode.PLAYSCHARACTER)
            {
                saving = true;
            }
        }
        private void OnTriggerExit(Collider other) 
        {
            if(other.gameObject.tag == "Player")
            {
                saving = false;
            }    
        }
    }
}