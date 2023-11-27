using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecAni : MonoBehaviour
{
    private Animator animator; // variable to access the animator component
    private float stateLimit; // variable for how long a spectator will be in an exact state
    private float nextStateLimit;
    private AudioSource cheerAudioSource;
    
    private void Start()
    {
        animator = GetComponent<Animator>(); // access the animater component 
        ChangeState(); // Start in a random state.
        cheerAudioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Time.time >= nextStateLimit) // time .time function is a numerical value equal to the number of seconds that have passed by since the application has started
        {
            ChangeState();
        }
    }

    private void ChangeState()
    {
        // Randomly select the next state and how long it will last.
        int randomState = Random.Range(0, 3); // Cheerful, Disgust, Surprised the 3 states the random function will choose from
        stateLimit = Random.Range(8f, 15f); // spectators will do certain state for 8-15 seconds.
        nextStateLimit = Time.time + stateLimit;

        // Trigger the corresponding animation state.
        switch (randomState)
        {
            case 0:
                animator.SetTrigger("cheerful");
                SfxManager.instance.PlaySound(SfxNames.Cheer, cheerAudioSource);
                break;
            case 1:
                animator.SetTrigger("disgust");
                break;
            case 2:
                animator.SetTrigger("surprised");
                break;
        }

        // Offset the animation start position with a random value.
        float randomOffset = Random.Range(8f, 10f);
        animator.Play("Base Layer.cheerful", 1 , randomOffset); // used to player the different states the "Cheerful" state is the primary layer 
    }
}




