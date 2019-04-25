using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Game.Modules;

namespace Game.Modules
{
    public class QuestTargetIndicatorManager : MonoBehaviour
    {
        public GameObject indicator;
        
        // Start is called before the first frame update
        void Start()
        {
    		GetAllQuestIndicators();
        }

        void GetAllQuestIndicators()
        {
            GameObject[] qTargets = GameObject.FindGameObjectsWithTag("QuestTarget");

    		foreach (GameObject target in qTargets)
	    	{
		    	CreateIndicator(target);
		    }
        }

        void CreateIndicator(GameObject target)
        {
            GameObject newIndicator = Instantiate(indicator, new Vector3(transform.position.x, transform.position.y + 5f, transform.position.z), transform.rotation);

            newIndicator.GetComponent<QuestTargetIndicator>().target = target.transform;
            newIndicator.transform.parent = gameObject.transform;

            switch (target.GetComponent<QuestTarget>().questType)
            {
                case Helpers.QuestType.MAINQUEST:
                    newIndicator.GetComponentInChildren<SpriteRenderer>().color = Color.yellow;
                    break;
                case Helpers.QuestType.MAINQUESTTARGET:
                    newIndicator.GetComponentInChildren<SpriteRenderer>().color = Color.cyan;
                    break;
                case Helpers.QuestType.SIDEQUEST:
                    newIndicator.GetComponentInChildren<SpriteRenderer>().color = Color.green;
                    break;
                case Helpers.QuestType.SIDEQUESTTARGET:
                    newIndicator.GetComponentInChildren<SpriteRenderer>().color = Color.blue;
                    break;
            }        
        }
    }
}