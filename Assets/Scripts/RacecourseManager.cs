using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class Racecourse : MonoBehaviour
{
    public Transform[] waypoints;
    private int currentWaypointIndex;

    void Start()
    {
        BuildRacecourse();
        StartCoroutine(MoveAgents());
    }

    void BuildRacecourse()
    {
        // Set the starting waypoint
        currentWaypointIndex = 0;
    }

    IEnumerator MoveAgents()
    {
        while (true)
        {
            // Move agents to the next waypoint
            foreach (var agent in FindObjectsOfType<NavMeshAgent>())
            {
                
                agent.updateRotation = false;
                agent.SetDestination(waypoints[currentWaypointIndex].position);
                

            }

            // Wait for agents to reach the waypoint
            yield return new WaitForSeconds(20f); // Adjust this based on your game speed and agent speed

            // Update the current waypoint index for the next iteration
            switch (currentWaypointIndex)
            {
                case 0: // A
                    currentWaypointIndex = 1; // Move to B next
                    break;
                case 1: // B
                    // Randomly choose between C and D
                    currentWaypointIndex = Random.Range(2, 4);
                    break;
                case 3: // D
                case 2: // C
                    currentWaypointIndex = 4; // Move to E next
                    break;
                case 4: // E
                    currentWaypointIndex = 5; // Move to F next
                    break;
                case 5: // F
                    // Randomly choose between G and H
                    currentWaypointIndex = Random.Range(6, 8);
                    break;
                case 7: // H
                case 6: // G
                    currentWaypointIndex = 8; // Move to I next
                    break;
                case 8: // I
                    currentWaypointIndex = 9; // Move to J next
                    break;
                case 9: // J
                    // Back to A to create a loop
                    currentWaypointIndex = 0;
                    break;
            }

            yield return null;
        }
    }
}

