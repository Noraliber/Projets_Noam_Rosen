using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl1Music : MonoBehaviour
{
    public AudioSource lvl1Music;

    void Awake()
    {   
        DontDestroyOnLoad(transform.gameObject);
        lvl1Music = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        if (!lvl1Music.isPlaying)
        {
            lvl1Music.Play();
        }
    }

    public void StopMusic()
    {
        lvl1Music.Stop();
    }
}
