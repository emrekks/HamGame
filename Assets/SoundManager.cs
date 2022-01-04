using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    
    public void Awake()
    {
        instance = this;
    }


    public AudioMixerSnapshot masterGroupMute;
    public AudioMixerSnapshot masterGroupOpen;

    public bool muted = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
