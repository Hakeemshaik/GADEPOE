using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Waypointgraph
{
    public List<WaypointNode> Nodes { get; }

    public Waypointgraph()
    {
        Nodes = new List<WaypointNode>();
    }

    public void AddWaypoint(string waypointName, Vector3 position)
    {
        WaypointNode newNode = new WaypointNode(waypointName, position);
        Nodes.Add(newNode);
    }

    public void ConnectWaypoints(WaypointNode waypoint1, WaypointNode waypoint2)
    {
        waypoint1.AddNeighbor(waypoint2);
        waypoint2.AddNeighbor(waypoint1);
    }

    public WaypointNode GetRandomNeighbor(WaypointNode waypoint)
    {
        if (waypoint.Neighbors.Count > 0)
        {
            int randomIndex = Random.Range(0, waypoint.Neighbors.Count);
            return waypoint.Neighbors[randomIndex];
        }
        else
        {
            return null;
        }
    }
}
