using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipDialogue : MonoBehaviour
{
    
    public void skip()
    {
        SceneManager.LoadScene(4);
    }
}
