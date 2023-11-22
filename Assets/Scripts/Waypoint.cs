using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Waypoint : MonoBehaviour
{
    public void AddNeighbor(Waypoint neighbor)
    {
        // Implement your logic to store and manage neighbors
    }

    public Waypoint GetRandomNeighbor()
    {
        // Implement your logic to get a random neighbor
        // For simplicity, you can return a random neighbor from the list
        Waypoint[] neighbors = GetComponents<Waypoint>();
        return neighbors[Random.Range(0, neighbors.Length)];
    }
}
