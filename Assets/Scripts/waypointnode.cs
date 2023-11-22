using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WaypointNode
{
    public string Name { get; private set; }
    public Vector3 Position { get; }
    public List<WaypointNode> Neighbors { get; }

    public WaypointNode(Vector3 position)
    {
        Position = position;
        Neighbors = new List<WaypointNode>();
    }

    public WaypointNode(string waypointName, Vector3 position)
    {
        Name = waypointName;
        Position = position;
        Neighbors = new List<WaypointNode>();
    }

    public void SetName(string name)
    {
        Name = name;
    }

    public void AddNeighbor(WaypointNode neighbor)
    {
        Neighbors.Add(neighbor);
    }
}

public class WaypointGraph
{
    public List<WaypointNode> Nodes { get; }

    public WaypointGraph()
    {
        Nodes = new List<WaypointNode>();
    }

    public void AddWaypoint(string waypointName, Vector3 position)
    {
        WaypointNode newNode = new WaypointNode(waypointName, position);
        Nodes.Add(newNode);
    }

    internal WaypointNode FindNode(string v)
    {
        throw new System.NotImplementedException();
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

