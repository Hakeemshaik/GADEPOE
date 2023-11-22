using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckpointRaceManager : MonoBehaviour
{
    public Text timerText;
    public Text winLoseText;

    private Stack<GameObject> checkpointStack = new Stack<GameObject>();
    private int timer = 15; // Initial timer value

    private void Start()
    {
        checkpointStack.Push(GameObject.Find("Checkpoint10"));
        checkpointStack.Push(GameObject.Find("Checkpoint9"));
        checkpointStack.Push(GameObject.Find("Checkpoint8"));
        checkpointStack.Push(GameObject.Find("Checkpoint7"));
        checkpointStack.Push(GameObject.Find("Checkpoint6"));
        checkpointStack.Push(GameObject.Find("Checkpoint5"));
        checkpointStack.Push(GameObject.Find("Checkpoint4"));
        checkpointStack.Push(GameObject.Find("Checkpoint3"));
        checkpointStack.Push(GameObject.Find("Checkpoint2"));
        checkpointStack.Push(GameObject.Find("Checkpoint1"));

        StartCoroutine(CountdownTimer());
    }

    private IEnumerator CountdownTimer()
    {
        while (timer > 0 && checkpointStack.Count > 0)
        {
            yield return new WaitForSeconds(1f);
            timer--;
            timerText.text = "Time: " + timer.ToString();

            // Check if the player has reached a checkpoint
            if (checkpointStack.Peek().GetComponent<CheckpointTrigger>().IsReached)
            {
                GameObject checkpoint = checkpointStack.Pop();
                Destroy(checkpoint); // Remove the checkpoint
                timer += 3; // Add some time when reaching a checkpoint 
            }
        }

        // Check if the player won or lost
        if (checkpointStack.Count == 0)
        {
            winLoseText.text = "You Win!";
        }
        else if (timer <= 0)
        {
            winLoseText.text = "You Lose!";
        }
    }
}

