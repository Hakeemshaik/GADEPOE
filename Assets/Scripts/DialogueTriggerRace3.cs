using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using System;
using UnityEngine;

public class DialogueTriggerRace3 : MonoBehaviour
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
            KnownAs.text = Reader.Instance.npc2.Peek();
            dialogue.text = Reader.Instance.speech2.Peek();
            KnownAs.text = Reader.Instance.npc2.Dequeue();
            dialogue.text = Reader.Instance.speech2.Dequeue();
        }
        catch (InvalidOperationException)
        {
            Debug.Log("Dialogue Finished");
            SceneManager.LoadScene(2);
        }




        if ( Reader.Instance.npc2.Peek() == "Jacque Die Boer") 
        {

            casperUI.SetActive(false);
            jaqueUI.SetActive(true);


        }
        else if (Reader.Instance.npc2.Peek() == "Casper")
        {

            casperUI.SetActive(true);
            jaqueUI.SetActive(false);

        }




    }

}
