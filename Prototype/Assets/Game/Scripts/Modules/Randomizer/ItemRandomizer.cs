using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BNWPrototype
{
    public class ItemRandomizer : MonoBehaviour
    {
        public int chancesUnique = 1;
        public int chancesRare = 5;
        public int chancesUncommon = 25;
        public int chancesCommon = 75;

        private int uniqueFreqency;
        private int rareFrequency;
        private int uncommonFrequency;
        private int commonFrequency;

        private int iterations = 100;

        // Use this for initialization
        void Start()
        {
            //EvaluateChances();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public Vector4 EvaluateChances(int amount)
        {

            commonFrequency = 0;
            uncommonFrequency = 0;
            rareFrequency = 0;
            uniqueFreqency = 0;

            for (int i = 0; i < amount; i++)
            {
                int value = Random.Range(0, 100);

                if (value > chancesUncommon)
                {
                    commonFrequency++;
                }
                else if (value > chancesRare)
                {
                    uncommonFrequency++;
                }
                else if (value > chancesUnique)
                {
                    rareFrequency++;
                }
                else
                {
                    uniqueFreqency++;
                }

            }


            DebugOutput();

            return new Vector4(commonFrequency, uncommonFrequency, rareFrequency, uniqueFreqency);
        }

        void DebugOutput()
        {
            Debug.Log("Iterations: " + iterations);
            Debug.Log("Unique: " + uniqueFreqency);
            Debug.Log("Rare: " + rareFrequency);
            Debug.Log("Uncommon: " + uncommonFrequency);
            Debug.Log("Common: " + commonFrequency);
        }
    }
}