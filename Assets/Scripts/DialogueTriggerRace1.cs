using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Pipes;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueTriggerRace1 : MonoBehaviour
{
  
    [SerializeField] private TextMeshProUGUI KnownAs;   /* This is a textmesh variable that will show the name of the Npc */ 
    [SerializeField] private TextMeshProUGUI dialogue;  /* This is a textmesh variable that will show the name of the Npc */

    public GameObject casperUI; // The casper and jacque raw images are stored as game object so we are able to manipulate which picture the player can see
    public GameObject jaqueUI;
   

    void Start()
    {
       
         //PortraitTrigger();
    }
    
    public void PortraitTrigger() // Method has all the code to execute the dialogue  
    {
        if ( Reader.Instance.npc.Peek() == "Jacque die Boer") // if the next npc in the queue is Jacque JacqueUI will activate and CasperUI will deactivate
        {

              casperUI.SetActive(false);
                      jaqueUI.SetActive(true);
              
                
        }
        else if (Reader.Instance.npc.Peek() == "Casper") // if the next npc within the queue is Casper CasperUI will activate and JacqueUI will deactivate
        {

               casperUI.SetActive(true);
                       jaqueUI.SetActive(false);
               
        }
        try // Implemented a try catch function to solve one of our occuring issues 
        {
            KnownAs.text = Reader.Instance.npc.Peek(); 
            dialogue.text = Reader.Instance.speech.Peek();
            KnownAs.text = Reader.Instance.npc.Dequeue();
            dialogue.text = Reader.Instance.speech.Dequeue();
        }
        catch(InvalidOperationException)
        {
            Debug.Log("Dialogue Finished");
            SceneManager.LoadScene(1);
        }
       

       
        
       
    }
    
}

