using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Game.Enums;

namespace Game.Managers
{
    public class QuestTargetIndicatorManager : MonoBehaviour
    {
        public GameObject indicator;
        
        public GameObject player;
        
        // Start is called before the first frame update
        void Start()
        {
    		GetAllQuestIndicators();
        }

        void GetAllQuestIndicators()
        {
            GameObject[] qTargets = GameObject.FindGameObjectsWithTag("Destination");

    		foreach (GameObject target in qTargets)
	    	{
		    	CreateIndicator(target.GetComponent<DestinationManager>());
		    }
        }

        void CreateIndicator(DestinationManager target)
        {
            GameObject newIndicator = Instantiate(indicator, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);

            newIndicator.GetComponent<QuestTargetIndicator>().target = target;
            newIndicator.GetComponent<QuestTargetIndicator>().centerPoint = player.transform;
            newIndicator.transform.parent = gameObject.transform;

            switch (target.questType)
            {
                case QuestType.MAINQUEST:
                //    newIndicator.GetComponentInChildren<SpriteRenderer>().color = Color.yellow;
                    break;
                case QuestType.MAINQUESTTARGET:
                //    newIndicator.GetComponentInChildren<SpriteRenderer>().color = Color.cyan;
                    break;
                case QuestType.SIDEQUEST:
                //    newIndicator.GetComponentInChildren<SpriteRenderer>().color = Color.green;
                    break;
                case QuestType.SIDEQUESTTARGET:
                //    newIndicator.GetComponentInChildren<SpriteRenderer>().color = Color.blue;
                    break;
            }        
        }
    }
}