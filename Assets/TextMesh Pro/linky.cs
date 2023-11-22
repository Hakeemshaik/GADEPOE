using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


[System.Serializable] // Make my whole class Serializable
public class linky : MonoBehaviour
{
    public LinkedList<Transform> linkyPoints = new LinkedList<Transform> ();
    public GameObject[] LinkyArray;
   
    private void Start()
    {
      foreach (GameObject Waypoint in LinkyArray)
      {
           if (Waypoint != null)
           {
              linkyPoints.AddLast(Waypoint.transform);
           }
      }
      
    }
  
}