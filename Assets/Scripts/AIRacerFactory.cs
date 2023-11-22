using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIRacerFactory : RacerFactory
{
    public GameObject type1RacerPrefab;
    public GameObject type2RacerPrefab;
    public GameObject type3RacerPrefab;
    public GameObject type4RacerPrefab;
    public GameObject type5RacerPrefab;

    public override GameObject CreateRacer(string racerType)
    {
        GameObject racerPrefab = null;

        switch (racerType)
        {
            case "Type1":
                racerPrefab = type1RacerPrefab;
                break;
            case "Type2":
                racerPrefab = type2RacerPrefab;
                break;
            case "Type3":
                racerPrefab = type3RacerPrefab;
                break;
            case "Type4":
                racerPrefab = type4RacerPrefab;
                break;
            case "Type5":
                racerPrefab = type4RacerPrefab;
                break;
            default:
                Debug.LogError("Invalid racer type: " + racerType);
                break;
        }

        if (racerPrefab != null)
        {
            return Instantiate(racerPrefab);
        }

        return null;
    }
}
