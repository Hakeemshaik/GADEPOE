using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public RacerFactory racerFactory;

    void Start()
    {
        GameObject racer1 = racerFactory.CreateRacer("Type1");
        GameObject racer2 = racerFactory.CreateRacer("Type2");
        GameObject racer3 = racerFactory.CreateRacer("Type3");
        GameObject racer4 = racerFactory.CreateRacer("Type3");
        GameObject racer5 = racerFactory.CreateRacer("Type3");

        if (racer1 != null)
        {
            AIRacer aiRacer1 = racer1.GetComponent<AIRacer>();
            aiRacer1.appearance = "Red Car";
            aiRacer1.speed = 200;
            aiRacer1.Race();
        }

        if (racer2 != null)
        {
            AIRacer aiRacer1 = racer1.GetComponent<AIRacer>();
            aiRacer1.appearance = "Red Car";
            aiRacer1.speed = 200;
            aiRacer1.Race();
        }
        if (racer3 != null)
        {
            AIRacer aiRacer1 = racer1.GetComponent<AIRacer>();
            aiRacer1.appearance = "Red Car";
            aiRacer1.speed = 200;
            aiRacer1.Race();
        }
        if (racer4 != null)
        {
            AIRacer aiRacer1 = racer1.GetComponent<AIRacer>();
            aiRacer1.appearance = "Red Car";
            aiRacer1.speed = 200;
            aiRacer1.Race();
        }
        if (racer5 != null)
        {
            AIRacer aiRacer1 = racer1.GetComponent<AIRacer>();
            aiRacer1.appearance = "Red Car";
            aiRacer1.speed = 200;
            aiRacer1.Race();
        }
    }
}
