using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetCrossingManager : MonoBehaviour
{
    public GameObject verticalStopper;
    public GameObject horizontalStopper;

    public GameObject horizontalRed;
    public GameObject horizontalYellow;
    public GameObject horizontalGreen;
    public GameObject horizontalPedestrianRed;
    public GameObject horizontalPedestrianGreen;

    public GameObject verticalRed;
    public GameObject verticalYellow;
    public GameObject verticalGreen;
    public GameObject verticalPedestrianRed;
    public GameObject verticalPedestrianGreen;

    // horizontal
    // red 79 seconds
    // green 38 seconds
    // yellow 3 seconds

    // vertical:
    // red: 3 seconds
    // green: 71 seconds
    // yellow: 3 seconds
    // red: 43 seconds

    public float timingState1 = 3f;
    public float timingState2 = 71f;
    public float timingState3 = 3f;
    public float timingState4 = 2f;
    public float timingState5 = 38f;
    public float timingState6 = 3f;


    // Start is called before the first frame update
    void Start()
    {
        StartTrafficLights();
    }

    public void StartTrafficLights()
    {
        StartCoroutine("TrafficLightSwitcher", 0);
    }

    private IEnumerator TrafficLightSwitcher(float waitTime)
    {
        while (true)
        {
                // initial: H: RED      V: RED
                yield return new WaitForSeconds(waitTime);
                Debug.Log("H: RED - V: RED");
                horizontalRed.SetActive(true);
                horizontalYellow.SetActive(false);
                horizontalGreen.SetActive(false);
                verticalRed.SetActive(true);
                verticalYellow.SetActive(false);
                verticalGreen.SetActive(false);

                horizontalPedestrianRed.SetActive(false);
                horizontalPedestrianGreen.SetActive(true);
                verticalPedestrianRed.SetActive(false);
                verticalPedestrianGreen.SetActive(true);

                horizontalStopper.SetActive(true);
                verticalStopper.SetActive(true);
    
                // 3 secs:  H: RED      V: GREEN
                yield return new WaitForSeconds(timingState1);
                Debug.Log("H: RED - V: GREEN");
                horizontalRed.SetActive(true);
                horizontalYellow.SetActive(false);
                horizontalGreen.SetActive(false);
                verticalRed.SetActive(false);
                verticalYellow.SetActive(false);
                verticalGreen.SetActive(true);
    
                horizontalPedestrianRed.SetActive(false);
                horizontalPedestrianGreen.SetActive(true);
                verticalPedestrianRed.SetActive(true);
                verticalPedestrianGreen.SetActive(false);

                horizontalStopper.SetActive(true);
                verticalStopper.SetActive(false);

                // 71 secs: H: RED      V: YELLOW
                yield return new WaitForSeconds(timingState2);
                Debug.Log("H: RED - V: YELLOW");
                horizontalRed.SetActive(true);
                horizontalYellow.SetActive(false);
                horizontalGreen.SetActive(false);
                verticalRed.SetActive(false);
                verticalYellow.SetActive(true);
                verticalGreen.SetActive(false);

                horizontalPedestrianRed.SetActive(false);
                horizontalPedestrianGreen.SetActive(true);
                verticalPedestrianRed.SetActive(true);
                verticalPedestrianGreen.SetActive(false);

                horizontalStopper.SetActive(true);
                verticalStopper.SetActive(false);

                // 3 secs:  H: RED      V: RED
                yield return new WaitForSeconds(timingState3);
                Debug.Log("H: RED - V: RED");
                horizontalRed.SetActive(true);
                horizontalYellow.SetActive(false);
                horizontalGreen.SetActive(false);
                verticalRed.SetActive(true);
                verticalYellow.SetActive(false);
                verticalGreen.SetActive(false);

                horizontalPedestrianRed.SetActive(false);
                horizontalPedestrianGreen.SetActive(true);
                verticalPedestrianRed.SetActive(false);
                verticalPedestrianGreen.SetActive(true);

                horizontalStopper.SetActive(true);
                verticalStopper.SetActive(true);

                // 2 secs:  H: GREEN    V: RED
                yield return new WaitForSeconds(timingState4);
                Debug.Log("H: GREEN - V: RED");
                horizontalRed.SetActive(false);
                horizontalYellow.SetActive(false);
                horizontalGreen.SetActive(true);
                verticalRed.SetActive(true);
                verticalYellow.SetActive(false);
                verticalGreen.SetActive(false);

                horizontalPedestrianRed.SetActive(true);
                horizontalPedestrianGreen.SetActive(false);
                verticalPedestrianRed.SetActive(false);
                verticalPedestrianGreen.SetActive(true);

                horizontalStopper.SetActive(false);
                verticalStopper.SetActive(true);

                // 38 secs: H: YELLOW   V: RED
                yield return new WaitForSeconds(timingState5);
                Debug.Log("H: yellow - V: RED");
                horizontalRed.SetActive(false);
                horizontalYellow.SetActive(true);
                horizontalGreen.SetActive(false);
                verticalRed.SetActive(true);
                verticalYellow.SetActive(false);
                verticalGreen.SetActive(false);

                horizontalPedestrianRed.SetActive(true);
                horizontalPedestrianGreen.SetActive(false);
                verticalPedestrianRed.SetActive(false);
                verticalPedestrianGreen.SetActive(true);

                horizontalStopper.SetActive(false);
                verticalStopper.SetActive(true);

                // 3 secs:  H: RED      V: RED
                yield return new WaitForSeconds(timingState6);
            
        }
    }
}