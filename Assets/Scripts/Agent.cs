using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Agent : MonoBehaviour // This class will have the agents keep track of the waypoints they have to get to
    {
        private linky waypointManager;
        private LinkedListNode<Transform> currentWaypoint;

        private void Start()
        {
            waypointManager = FindObjectOfType<linky>(); // Find the waypoint manager (linky) in the scene.
            if (waypointManager != null)
            {
                // Set the currentWaypoint to the first waypoint in the list.
                currentWaypoint = waypointManager.linkyPoints.First;
            }
        }
        private void Update()
        {
            if (currentWaypoint != null) // so if there are still waypoints remaining the racers will continue moving towards them at a constant speed
            {
                
                Vector3 moveDirection = (currentWaypoint.Value.position - transform.position).normalized;  // Move the agent towards the current waypoint.
                float moveSpeed = 2.0f; // agent moves at this speed
                transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
                // currentWaypoint = currentWaypoint.Next;
            // Check if the racer has reached the current waypoint.
                 float waypointProximity = 1f;
                if (Vector3.Distance(transform.position, currentWaypoint.Value.position) < waypointProximity)
                {
                    // Move to the next waypoint in the LinkedList.
                    currentWaypoint = currentWaypoint.Next;
                    Debug.Log(Vector3.Distance(transform.position, currentWaypoint.Value.position));
            
                if (currentWaypoint == null) // To see if there is no more waypoints in the scene
                {
                  Debug.Log("Racer reached the finish line!");
                }
               
            }
        }
        }
    }

