using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BUTTON : MonoBehaviour
{
    public string sceneToLoad; // Enter the name of the scene you want to load in the Inspector.

    public void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
