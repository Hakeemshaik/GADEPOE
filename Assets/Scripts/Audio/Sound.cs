using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public SfxNames Name;
    public AudioClip Clip;
    [Range(0, 1)] public float Volume = 1;
}