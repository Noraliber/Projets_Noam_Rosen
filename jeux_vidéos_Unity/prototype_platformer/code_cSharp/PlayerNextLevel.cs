using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerNextLevel : MonoBehaviour
{   
    public bool isCollided;
    [SerializeField] public bool nextLevel;
    [SerializeField] public bool levelsMenu;

    [SerializeField] private GameObject noText; // lvl 1-4
    [SerializeField] private GameObject nonText; // lvl 1-4

    [SerializeField] private TransitionData loadReason;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "End Door")
        {   
            isCollided = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "End Door")
        {
            isCollided = false;
        }
    }

    void Update()
    {   
        if (isCollided == true)
        {
            if (Input.GetButtonDown("End Door"))
            {   
                string currentScene = SceneManager.GetActiveScene().name;
                char subLevel = currentScene[6];

                if (subLevel == '5')
                {
                    levelsMenu = true;
                    loadReason.loadReasonValue = "next level";  
                }
                else if (SceneManager.GetActiveScene().name == "Lvl 1-4")
                {
                    Lvl1_4();
                }
                else
                {
                    nextLevel = true;
                    loadReason.loadReasonValue = "next level";   
                }
            }
        }
    }

    void Lvl1_4()
    {
        if (gameObject.GetComponent<PlayerLvl1_4>().stage == 6)
        {
            nextLevel = true;
            loadReason.loadReasonValue = "next level";
        }
        else
        {
            if (Application.systemLanguage == SystemLanguage.English)
            {
                noText.SetActive(true);
                noText.GetComponent<AudioSource>().Play();
            }
            else if (Application.systemLanguage == SystemLanguage.French)
            {
                nonText.SetActive(true);
                nonText.GetComponent<AudioSource>().Play();
            }
        }
    }
}