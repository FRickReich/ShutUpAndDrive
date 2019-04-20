using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Modules.AICrowd
{
    public class AgentObstacle : MonoBehaviour
    {
        bool open = false;

        // Update is called once per frame
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                if(open)
                {
                    this.transform.Translate(0, -3, 0);
                }
                else
                {
                    this.transform.Translate(0, 3, 0);
                }

                open = !open;
            }
        }
    }
}