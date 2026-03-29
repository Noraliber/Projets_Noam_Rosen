using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicCheck : MonoBehaviour
{
    void Awake()
    {   
        string currentScene = SceneManager.GetActiveScene().name;
        char level = currentScene[4];

        if (SceneManager.GetActiveScene().name == "Main Menu" || SceneManager.GetActiveScene().name == "Levels Menu")
        {
            GameObject.FindGameObjectWithTag("Menu Music").GetComponent<MenuMusic>().PlayMusic();
        }
        else
        {
            GameObject.FindGameObjectWithTag("Menu Music").GetComponent<MenuMusic>().StopMusic();
        }

        if (level == '1')
        {
            GameObject.FindGameObjectWithTag("Lvl 1 Music").GetComponent<Lvl1Music>().PlayMusic();
        }
        else
        {
            GameObject.FindGameObjectWithTag("Lvl 1 Music").GetComponent<Lvl1Music>().StopMusic();
        }
    }
}