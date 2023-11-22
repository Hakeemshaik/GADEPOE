using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class DialogueTriggerRace2 : MonoBehaviour
{

    [SerializeField] public TextMeshProUGUI KnownAs;
    [SerializeField] public TextMeshProUGUI dialogue;

    public GameObject casperUI;
    public GameObject jaqueUI;


    void Start()
    {

        //PortraitTrigger();
    }

    public void PortraitTrigger()
    {
         try
         {
             KnownAs.text = Reader.Instance.npc1.Peek();
             dialogue.text = Reader.Instance.speech1.Peek();
             KnownAs.text = Reader.Instance.npc1.Dequeue();
             dialogue.text = Reader.Instance.speech1.Dequeue();
         }
         catch (InvalidOperationException)
         {
             Debug.Log("Dialogue Finished");
             SceneManager.LoadScene(3);
         }
        

       

        if (Reader.Instance.npc1.Peek() == "Jacque die Boer")
        {

            casperUI.SetActive(false);
            jaqueUI.SetActive(true);


        }
        else if (Reader.Instance.npc1.Peek() == "Casper")
        {

            casperUI.SetActive(true);
            jaqueUI.SetActive(false);

        }




    }

}
