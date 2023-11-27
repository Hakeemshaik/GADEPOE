using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Needs to be put in every scene that plays sound.
public class SfxManager : MonoBehaviour
{
    public List<Sound> sounds;
    public AudioSource audioSource;
    public AudioSource loopingAudioSource;

    private HashMap<string, Sound> hashMap;
    [HideInInspector] public static SfxManager instance;

    public float CheerWaitTime = 1; // in seconds
    private bool cheerCanPlay = true;
    private WaitForSeconds coroutineCheerWait;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
        
        hashMap = new HashMap<string, Sound>();
        foreach (var sound in sounds)
        {
            hashMap.Add(sound.Name.ToString(), sound);
        }

        coroutineCheerWait = new WaitForSeconds(CheerWaitTime);
    }

    public void PlaySound(SfxNames soundName)
    {
        if (soundName == SfxNames.Cheer)
        {
            if (cheerCanPlay)
                StartCoroutine(nameof(CheerSoundWait));
            else
            {
                return;
            }
        }
        Sound sound = hashMap.GetValue(soundName.ToString());
        
        audioSource.PlayOneShot(sound.Clip, sound.Volume);
    }

    public void PlayLoopingSound(SfxNames soundName)
    {
        Sound sound = hashMap.GetValue(soundName.ToString());
        loopingAudioSource.loop = true;
        loopingAudioSource.clip = sound.Clip;
        loopingAudioSource.volume = sound.Volume;
        loopingAudioSource.Play();
    }

    // for playing 3D audio like the cheering
    public void PlaySound(SfxNames soundName, AudioSource externalAudioSource)
    {
        if (soundName == SfxNames.Cheer)
        {
            if (cheerCanPlay)
                StartCoroutine(nameof(CheerSoundWait));
            else
            {
                return;
            }
        }
        Sound sound = hashMap.GetValue(soundName.ToString());
        
        externalAudioSource.PlayOneShot(sound.Clip, sound.Volume);
    }

    private IEnumerator CheerSoundWait()
    {
        cheerCanPlay = false;
        yield return coroutineCheerWait;
        cheerCanPlay = true;
    }
}
