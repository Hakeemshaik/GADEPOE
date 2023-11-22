using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reader : MonoBehaviour
{
    public static Reader Instance; //created a singleton to access the variables within this class
    public TextAsset jsonFile; 
    public Queue<string> npc; // Created 6 string queues 
    public Queue<string> speech; // The npc, npc1, npc2, queues store the 2 npc charcters 
    public Queue<string> npc1; // and speech, speech1, speech2 queues store the dialogue for the to npc charcters
    public Queue<string> speech1; // use npc & speech queue for the checkpont race dialogue etc
    public Queue<string> npc2;
    public Queue<string> speech2;
    private void Awake() // Singleton stating if there no existing instance named instance we make this current instance "this" or destroy it if there is already an exsiting instance
    {
        if (Instance == null)
            Instance = this;
        else Destroy(this);
    }
    void Start()
    {
        npc = new Queue<string>(); // Create an instance of these queues 
        speech = new Queue<string>();
        npc1 = new Queue<string>();
        speech1 = new Queue<string>();
        npc2 = new Queue<string>();
        speech2 = new Queue<string>();
        Characters npcCharactersInJson = JsonUtility.FromJson<Characters>(jsonFile.text);
        foreach (character npcCharacters in npcCharactersInJson.npcCharacters) 
        {
            Debug.Log("Found npc: " + " " + npcCharacters.npcName + "   " + npcCharacters.npcName1 + "  " + npcCharacters.npcName2 + " " + "Dialogue: " + npcCharacters.dialogue + "  " + npcCharacters.dialogue1 + "  " + npcCharacters.dialogue2 );
            npc.Enqueue(npcCharacters.npcName);  // We actaully store the content of our json file into these multiple queues
            speech.Enqueue(npcCharacters.dialogue); // npc1 & speech1 will contain the content for the first race etc
            npc1.Enqueue(npcCharacters.npcName1);
            speech1.Enqueue(npcCharacters.dialogue1);
            npc2.Enqueue(npcCharacters.npcName2);
            speech2.Enqueue(npcCharacters.dialogue2);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
