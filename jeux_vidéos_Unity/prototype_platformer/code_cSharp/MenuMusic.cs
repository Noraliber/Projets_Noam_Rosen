using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusic : MonoBehaviour
{   
    public AudioSource menuMusic;

    void Awake()
    {   
        DontDestroyOnLoad(transform.gameObject);
        menuMusic = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        if (!menuMusic.isPlaying)
        {
            menuMusic.Play();
        }
    }

    public void StopMusic()
    {
        menuMusic.Stop();
    }
}
